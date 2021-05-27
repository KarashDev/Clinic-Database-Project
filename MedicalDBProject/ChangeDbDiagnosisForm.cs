using MedicalDBProject.Data;
using MedicalDBProject.Forms;
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
    public partial class ChangeDbDiagnosisForm : Form
    {
        public ChangeDbDiagnosisForm()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            
            dataGridViewChangeDiagnosis.DataSource = DataGridViewLoader.LoadDiagnosisInDataGridView().ToList();

            // Реализация автоматической перезагрузки окна с выведенной базой (DbChangeForm), 
            // сразу после закрытия окна, изменяющего данные этой базы. Реализовано, 
            // чтобы пользоваетелю не нужно было вручную перезагружать окно с данными базы,
            // чтобы увидеть обновленную таблицу.
            this.FormClosed += new FormClosedEventHandler(ChangeDbDiagnosisForm_FormClosed);

            void ChangeDbDiagnosisForm_FormClosed(object sender, FormClosedEventArgs e)
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
        }

        private void buttonAddDiagnosis_Click(object sender, EventArgs e)
        {
            var newDiagnosisName = textBoxDSNameToAdd.Text;
            var newDiagnosisCode = textBoxDSNameToAdd.Text;

            if (!String.IsNullOrEmpty(newDiagnosisName) &&
                !String.IsNullOrEmpty(newDiagnosisCode))
            {
                using (var db = new MedicalDBProject.Data.ApplicationContext())
                {
                    if (!db.Diagnoses.Any(d => d.Name == newDiagnosisName || d.Code == newDiagnosisCode))
                    {
                        // Сразу вносится реализация смены местами двух строк через временную третью строку.
                        // Необходимо, так как пустая строка в базе всегда должна быть самой последней в списке,
                        // для этого необходимо менять ее местами с новой добавленной пользователем строкой.
                        db.Diagnoses.Add (new DataBaseCreator.Diagnosis
                        {
                            Name = newDiagnosisName,
                            Code = newDiagnosisCode
                        });

                        // Создание временной третьей строки
                        db.Diagnoses.Add (new DataBaseCreator.Diagnosis
                        {
                            Name = "",
                            Code = ""
                        });
                        
                        db.SaveChanges();

                        var x = db.Diagnoses.FirstOrDefault(d => d.Name == "" && d.Code == "");
                        var y = db.Diagnoses.FirstOrDefault(d => d.Name == newDiagnosisName && d.Code == newDiagnosisCode);
                        var z = db.Diagnoses.FirstOrDefault(d => d.Name == "" && d.Code == "" && d.Id != x.Id);

                        z.Name = y.Name;
                        z.Code = y.Code;
                        
                        y.Name = x.Name;
                        y.Code = x.Code;
                        
                        x.Name = z.Name;
                        x.Code = z.Code;
                        db.Remove(z);
                        db.SaveChanges();

                        MessageBox.Show("Диагноз успешно добавлен в список", "Операция завершена", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        textBoxDSNameToAdd.Clear();
                        textBoxDSNameToAdd.Clear();

                        // Сразу же выводятся обновленные данные в DataGridView
                        dataGridViewChangeDiagnosis.DataSource = DataGridViewLoader.LoadDiagnosisInDataGridView().ToList();
                    }
                    else MessageBox.Show("Вы ввели данные уже существующего в базе диагноза", "Ошибка: неверный ввод",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else MessageBox.Show("Поля должны быть заполнены", "Ошибка: Пустые поля", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
        }

        private void buttonDeleteDiagnosis_Click(object sender, EventArgs e)
        {
            var diagnosisToDeleteName = textBoxDSNameToDelete.Text;

            if (!String.IsNullOrEmpty(diagnosisToDeleteName))
            {
                using (var db = new MedicalDBProject.Data.ApplicationContext())
                {
                    if (db.Diagnoses.Any(d => d.Name == diagnosisToDeleteName))
                    {
                        var diagnosisToRemove = db.Diagnoses.FirstOrDefault(d => d.Name == diagnosisToDeleteName);

                        db.Diagnoses.Remove(diagnosisToRemove);
                        db.SaveChanges();

                        MessageBox.Show("Диагноз успешно удален", "Операция завершена", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        textBoxDSNameToDelete.Clear();

                        // Сразу же выводятся обновленные данные в DataGridView
                        dataGridViewChangeDiagnosis.DataSource = DataGridViewLoader.LoadDiagnosisInDataGridView().ToList();
                    }
                    else MessageBox.Show("ОШИБКА: такого диагноза нет в списке. Проверьте введенные данные", "Ошибка ввода", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                }
            }
            else MessageBox.Show("Поле не заполнено", "Ошибка: Пустое поле", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
    }
}
