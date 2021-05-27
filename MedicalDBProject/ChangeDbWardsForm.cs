using MedicalDBProject.Data;
using MedicalDBProject.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;


namespace MedicalDBProject
{
    public partial class ChangeDbWardsForm : Form
    {
        public ChangeDbWardsForm()
        {
            InitializeComponent();
            this.MaximizeBox = false;

            dataGridViewChangeWards.DataSource = DataGridViewLoader.LoadWardsInDataGridView().ToList();

            // Реализация автоматической перезагрузки окна с выведенной базой (DbChangeForm), 
            // сразу после закрытия окна, изменяющего данные этой базы. Реализовано, 
            // чтобы пользоваетелю не нужно было вручную перезагружать окно с данными базы,
            // чтобы увидеть обновленную таблицу.
            this.FormClosed += new FormClosedEventHandler(ChangeDbWardsForm_FormClosed);

            void ChangeDbWardsForm_FormClosed(object sender, FormClosedEventArgs e)
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

        private void buttonAddWard_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBoxWardToAdd.Text))
            {
                using (var db = new MedicalDBProject.Data.ApplicationContext())
                {
                    try
                    {
                        if (!db.ClinicWard.Any(w => w.Number == Convert.ToInt32(textBoxWardToAdd.Text)))
                        {
                            // Сразу вносится реализация смены местами двух строк через временную третью строку.
                            // Необходимо, так как пустая строка в базе всегда должна быть самой последней в списке,
                            // для этого необходимо менять ее местами с новой добавленной пользователем строкой.
                            db.ClinicWard.Add(new DataBaseCreator.ClinicWard
                            {
                                Number = Convert.ToInt32(textBoxWardToAdd.Text)
                            });

                            // Создание временной третьей строки
                            db.ClinicWard.Add(new DataBaseCreator.ClinicWard
                            {
                                Number = 0
                            });
                            db.SaveChanges();

                            var x = db.ClinicWard.FirstOrDefault(d => d.Number == 0);
                            var y = db.ClinicWard.FirstOrDefault(d => d.Number == Convert.ToInt32(textBoxWardToAdd.Text));
                            var z = db.ClinicWard.FirstOrDefault(d => d.Number == 0 && d.Id != x.Id);
                            z.Number = y.Number;
                            y.Number = x.Number;
                            x.Number = z.Number;
                            db.Remove(z);
                            db.SaveChanges();

                            MessageBox.Show("Палата успешно добавлена в базу", "Операция завершена", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                            textBoxWardToAdd.Clear();

                            // Сразу же выводятся обновленные данные в DataGridView
                            dataGridViewChangeWards.DataSource = DataGridViewLoader.LoadWardsInDataGridView().ToList();

                        }
                        else MessageBox.Show("Палата с указанным номером уже есть в базе", "Ошибка: неверный ввод",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Неверный формат ввода. Поле \"Добавить палату\" принимает только числа",
                            "Ошибка: неверный ввод",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else MessageBox.Show("Поле не заполнено", "Ошибка: Пустое поле", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }

        private void buttonDeleteWard_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBoxWardToDelete.Text))
            {
                using (var db = new MedicalDBProject.Data.ApplicationContext())
                {
                    try
                    {
                        var wardToRemove = db.ClinicWard.FirstOrDefault(w => w.Number == Convert.ToInt32(textBoxWardToDelete.Text));

                        // Сразу же проверяется, не вводит ли пользователь номер НЕ существующей палаты
                        if (wardToRemove != null)
                        {
                            db.ClinicWard.Remove(wardToRemove);

                            db.SaveChanges();

                            MessageBox.Show("Палата успешно удалена из базы", "Операция завершена", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                            textBoxWardToDelete.Clear();

                            // Сразу же выводятся обновленные данные в DataGridView
                            dataGridViewChangeWards.DataSource = DataGridViewLoader.LoadWardsInDataGridView().ToList();
                        }
                        else MessageBox.Show("Палаты с указанным номером нет в базе", "Ошибка: неверный ввод",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Неверный формат ввода. Поле \"Удалить палату\" принимает только числа",
                            "Ошибка: неверный ввод",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else MessageBox.Show("Поле не заполнено", "Ошибка: Пустое поле", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
    }
}
