using MedicalDBProject.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MedicalDBProject
{
    public partial class ChangeDbPatientsForm : Form
    {

        public ChangeDbPatientsForm()
        {
            InitializeComponent();
            this.MaximizeBox = false;

            // Реализация автоматической перезагрузки окна с выведенной базой (DbChangeForm), 
            // сразу после закрытия окна, изменяющего данные этой базы. Реализовано, 
            // чтобы пользоваетелю не нужно было вручную перезагружать окно с данными базы,
            // чтобы увидеть обновленную таблицу.
            this.FormClosed += new FormClosedEventHandler(ChangeDbPatientsForm_FormClosed);

            void ChangeDbPatientsForm_FormClosed(object sender, FormClosedEventArgs e)
            {
                DbChangeForm newDbChangeForm = new DbChangeForm();

                FormCollection openForms = Application.OpenForms;
                foreach (Form selectedForm in openForms)
                {
                    if (selectedForm.Name == "DbChangeForm")
                    {
                        this.Dispose();
                        selectedForm.Dispose();
                        newDbChangeForm.Show();

                        break;
                    }
                }
            }

            // При открытии окна, все combobox должны быть сразу заполнены подгруженными названиями. 
            using (var db = new MedicalDBProject.Data.ApplicationContext())
            {
                // Вынес создание в отдельный метод, чтобы не дублировать этот код. 
                void FillComboBoxes(ComboBox comboBoxBlood, ComboBox comboBoxDiagnosis, ComboBox comboBoxWard)
                {
                    // При создании/изменении данных о пациенте, не обязательно указывать его палату, группу крови
                    // или диагноз. Поскольку выбор этих значений идет в combobox, обязательно оставить одну строку
                    // в combobox пустой, чтобы можно было выбрать значение "не существует". Однако, при загрузке 
                    // в combobox данных из БД, невозможно потом вручную добавить в combobox новое значение,
                    // отсюда возникла проблема невозможности создания пустой строки. Решилась проблема путем
                    // изменения самого источника данных путем добавления в него одной сущности с пустыми значениями.
                    var dbBloodGroups = db.BloodGroups.OrderBy(b => b.Group).ToList();
                    comboBoxBlood.DataSource = dbBloodGroups;
                    comboBoxBlood.ValueMember = "Id";
                    comboBoxBlood.DisplayMember = "Group";
                    comboBoxBlood.SelectedItem = -1;


                    var dbDiagnoses = db.Diagnoses.OrderBy(b => b.Name).ToList();
                    comboBoxDiagnosis.DataSource = dbDiagnoses;
                    comboBoxDiagnosis.ValueMember = "Id";
                    comboBoxDiagnosis.DisplayMember = "Code";
                    comboBoxDiagnosis.SelectedItem = -1;

                    // У сущности, отвечающей за палаты, свойство "номер"(Number) является значимым типом, поэтому невозможно
                    // указать пустое значение. Вопрос решается оператором условного null.
                    var dbWards = db.ClinicWard.OrderBy(w => w.Number).ToList();
                    comboBoxWard.DataSource = dbWards;
                    comboBoxWard.ValueMember = "Id";
                    comboBoxWard.DisplayMember = "Number";
                    comboBoxWard.SelectedItem = -1;
                }

                FillComboBoxes(comboBoxAddBloodGroup, comboBoxAddDiagnosis, comboBoxAddWard);

                FillComboBoxes(comboBoxChangeBloodGroup, comboBoxChangeDiagnosis, comboBoxChangeWard);
            }
        }

        private void buttonAddPatiient_Click(object sender, EventArgs e)
        {
            var patientName = textBoxAddName.Text;
            var patientYearBirth = textBoxAddYearBirth.Text;
            var patientPhone = textBoxAddPhone.Text;

            var patientBloodGroup = comboBoxAddBloodGroup;
            var patientDiagnosis = comboBoxAddDiagnosis;
            var patientWard = comboBoxAddWard;

            if (!String.IsNullOrEmpty(patientName) &&
                 !String.IsNullOrEmpty(patientYearBirth) &&
                 !String.IsNullOrEmpty(patientPhone))
            {
                using (var db = new MedicalDBProject.Data.ApplicationContext())
                {
                    try
                    {
                        if (!db.Patients.Any(p => p.FullName == patientName &&
                   p.YearOfBirth == Convert.ToInt64(patientYearBirth) &&
                   p.PhoneNumber == Convert.ToInt64(patientPhone)))
                        {
                            // "Палата" (Ward) является значимым типом, его значение по умолчанию "0", однако, если
                            // пользователь выбрал "0" в combobox, в таблице на месте этого значения должно
                            // быть пустое место, а не "0". Я решил эту проблему отказом от внесения чего-либо в поле Ward,
                            // в случае, если пользователем было выбрано значение "0" в combobox.
                            if (Convert.ToInt32(patientWard.Text) != 0)
                            {
                                db.Patients.Add(new DataBaseCreator.Patient
                                {
                                    FullName = patientName,
                                    YearOfBirth = Convert.ToInt32(patientYearBirth),
                                    PhoneNumber = Convert.ToInt32(patientPhone),

                                    BloodGroup = db.BloodGroups.FirstOrDefault(b => b.Group == patientBloodGroup.Text),
                                    Diagnosis = db.Diagnoses.FirstOrDefault(d => d.Code == patientDiagnosis.Text),
                                    Ward = db.ClinicWard.FirstOrDefault(w => w.Number == Convert.ToInt32(patientWard.Text))
                                });
                            }
                            else
                            {
                                db.Patients.Add(new DataBaseCreator.Patient
                                {
                                    FullName = patientName,
                                    YearOfBirth = Convert.ToInt32(patientYearBirth),
                                    PhoneNumber = Convert.ToInt32(patientPhone),

                                    BloodGroup = db.BloodGroups.FirstOrDefault(b => b.Group == patientBloodGroup.Text),
                                    Diagnosis = db.Diagnoses.FirstOrDefault(d => d.Code == patientDiagnosis.Text),
                                });
                            }

                            db.SaveChanges();

                            MessageBox.Show("Новый пациент успешно добавлен в базу", "Операция завершена", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                        }
                        else MessageBox.Show("В базе уже имеется пациент с указанными данными", "Ошибка: неверный ввод",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Неверный формат ввода. Поля \"Год рождения\" и \"Номер телефона\"принимают " +
                            "только числа","Ошибка: неверный ввод", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else MessageBox.Show("Обязательные поля должны быть заполнены", "Ошибка: Пустые поля", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
        }

        private void buttonChangePatiient_Click(object sender, EventArgs e)
        {
            var searchPatientName = textBoxCnangeNameSearch.Text;
            var searchPatientYearBirth = textBoxCnangeYearBirthSearch.Text;
            var searchPatientPhone = textBoxCnangePhoneSearch.Text;

            var newPatientName = textBoxCnangeNameNew.Text;
            var newPatientYearBirth = textBoxCnangeYearBirthNew.Text;
            var newPatientPhone = textBoxCnangePhoneNew.Text;
            var newPatientBloodGroup = comboBoxChangeBloodGroup;
            var newPatientDiagnosis = comboBoxChangeDiagnosis;
            var newPatientWard = comboBoxChangeWard;


            if (!String.IsNullOrEmpty(searchPatientName) &&
                 !String.IsNullOrEmpty(searchPatientYearBirth) &&
                 !String.IsNullOrEmpty(searchPatientPhone) &&
                 !String.IsNullOrEmpty(newPatientName) &&
                 !String.IsNullOrEmpty(newPatientYearBirth) &&
                 !String.IsNullOrEmpty(newPatientPhone))
            {
                using (var db = new MedicalDBProject.Data.ApplicationContext())
                {
                    try
                    {
                        var selectedPatient = db.Patients.FirstOrDefault(p =>
                            p.FullName == searchPatientName &&
                            p.YearOfBirth == Convert.ToInt64(searchPatientYearBirth) &&
                            p.PhoneNumber == Convert.ToInt64(searchPatientPhone));

                        if (selectedPatient != null)
                        {
                            selectedPatient.FullName = newPatientName;
                            selectedPatient.YearOfBirth = Convert.ToInt32(newPatientYearBirth);
                            selectedPatient.PhoneNumber = Convert.ToInt64(newPatientPhone);
                            selectedPatient.BloodGroup = db.BloodGroups.FirstOrDefault(b => b.Group == newPatientBloodGroup.Text);
                            selectedPatient.Diagnosis = db.Diagnoses.FirstOrDefault(d => d.Code == newPatientDiagnosis.Text);
                            selectedPatient.Ward = db.ClinicWard.FirstOrDefault(w => w.Number == Convert.ToInt64(newPatientWard.Text));

                            if (Convert.ToInt64(newPatientWard.Text) == 0)
                            {
                                if (!String.IsNullOrEmpty(selectedPatient.Ward.Number.ToString()))
                                {
                                    db.Remove(selectedPatient.Ward);
                                }
                            }

                            db.SaveChanges();

                            MessageBox.Show("Данные пациента успешно изменены", "Операция завершена", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                        }
                        else MessageBox.Show("В базе отсутствует пациент с указанными данными. Проверьте правильность вводенных данных",
                            "Ошибка: неверный ввод", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Неверный формат ввода. Поля \"Год рождения\" и \"Номер телефона\"принимают " +
                                                    "только числа", "Ошибка: неверный ввод", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else MessageBox.Show("Обязательные поля должны быть заполнены", "Ошибка: Пустые поля", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
        }

        private void buttonDeletePatient_Click(object sender, EventArgs e)
        {
            var patientName = textBoxDeleteName.Text;
            var patientYearBirth = textBoxDeleteYearBirth.Text;
            var patientPhone = textBoxDeletePhone.Text;

            if (!String.IsNullOrEmpty(patientName) &&
                 !String.IsNullOrEmpty(patientYearBirth) &&
                 !String.IsNullOrEmpty(patientPhone))
            {
                using (var db = new MedicalDBProject.Data.ApplicationContext())
                {
                    try
                    {
                        var selectedPatient = db.Patients.FirstOrDefault(p =>
                           p.FullName == patientName &&
                           p.YearOfBirth == Convert.ToInt64(patientYearBirth) &&
                           p.PhoneNumber == Convert.ToInt64(patientPhone));

                        if (selectedPatient != null)
                        {
                            db.Patients.Remove(selectedPatient);

                            db.SaveChanges();

                            MessageBox.Show($"Пациент {selectedPatient.FullName} успешно удален из базы", "Операция завершена", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                            textBoxDeleteName.Clear();
                            textBoxDeleteYearBirth.Clear();
                            textBoxDeletePhone.Clear();
                        }
                        else MessageBox.Show("В базе отсутствует пациент с указанными данными. Проверьте правильность вводенных данных",
                            "Ошибка: неверный ввод", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Неверный формат ввода. Поля \"Год рождения\" и \"Телефон\"принимают " +
                                                   "только числа", "Ошибка: неверный ввод", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else MessageBox.Show("Обязательные поля должны быть заполнены", "Ошибка: Пустые поля", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
        }

        
    }
}
