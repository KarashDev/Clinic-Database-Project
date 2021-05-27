using MedicalDBProject.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using static MedicalDBProject.AuthorizationForm;

namespace MedicalDBProject
{
    public partial class EmployeeRegForm : Form
    {
        public EmployeeRegForm()
        {
            InitializeComponent();
            acceptRegButton.Enabled = false;
            this.MaximizeBox = false;
        }

        private void acceptRegButton_Click(object sender, EventArgs e)
        {
            using (var db = new MedicalDBProject.Data.ApplicationContext())
            {
                if (!String.IsNullOrEmpty(textBoxNewLogin.Text)
                    && !String.IsNullOrEmpty(textBoxNewPassword.Text))
                {
                    // Введена доп. проверка, нет ли уже в базе такого логина и пароля
                    if (!db.Employee.Any(e => e.Login == DataHasher.GetHashMd5(textBoxNewLogin.Text) &&
                    e.Password == DataHasher.GetHashMd5(textBoxNewPassword.Text)))
                    {
                        var newEmployee = new DataBaseCreator.EmployeeData
                        {
                            Login = DataHasher.GetHashMd5(textBoxNewLogin.Text),
                            Password = DataHasher.GetHashMd5(textBoxNewPassword.Text)
                        };

                        db.Employee.Add(newEmployee);
                        db.SaveChanges();

                        MessageBox.Show("Новый сотрудник зарегистрирован", "Регистрация завершена", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                        textBoxNewLogin.Clear();
                        textBoxNewPassword.Clear();
                    }    
                    else MessageBox.Show("Сотрудник с указанными данными" +
                        " уже зарегистрирован в базе", "Ошибка регистрации", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else MessageBox.Show("Поля должны быть заполнены", "Ошибка: Пустые поля", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }
        }

        private void checkBoxPrivacyPolicy_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBoxPrivacyPolicy.Checked)
                acceptRegButton.Enabled = false;
            else acceptRegButton.Enabled = true;
        }

        private void labelPrivacyPolicy_Click(object sender, EventArgs e)
        {
            PrivacyPolicyForm privacyPolicyForm = new PrivacyPolicyForm();
            privacyPolicyForm.Show();
        }
    }
}
