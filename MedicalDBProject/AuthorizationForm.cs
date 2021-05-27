using MedicalDBProject.Data;
using MedicalDBProject.Forms;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MedicalDBProject
{
    public partial class AuthorizationForm : Form
    {
        public AuthorizationForm()
        {
            InitializeComponent();

            var dataBaseCreator = new Data.DataBaseCreator();
            dataBaseCreator.CreateDataBase();

            this.MaximizeBox = false;
        }

        private void OpenDbViewButton_Click(object sender, EventArgs e)
        {
            var dbViewForm = new DbViewForm();
            dbViewForm.Show();
        }

        private void OpenDbChangeButton_Click(object sender, EventArgs e)
        {
            var enteredLogin = DataHasher.GetHashMd5(textBoxLogin.Text);
            var enteredPassword = DataHasher.GetHashMd5(textBoxPassword.Text);

            if (!String.IsNullOrEmpty(textBoxLogin.Text) &&
                !String.IsNullOrEmpty(textBoxPassword.Text))
            {
                using (var db = new MedicalDBProject.Data.ApplicationContext())
                {
                    var matchedEmployee = db.Employee.FirstOrDefault(e => e.Login == enteredLogin && e.Password == enteredPassword);

                    if (matchedEmployee != null)
                    {
                        DbChangeForm dbChangeForm = new DbChangeForm();
                        dbChangeForm.Show();
                    }
                    else
                    {
                        MessageBox.Show("Неправильный логин или пароль. Повторите попытку," +
                                                "либо зарегистрируйте нового сотрудника", "Доступ закрыт",
                                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else MessageBox.Show("Поля должны быть заполнены", "Ошибка: Пустые поля", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }

        private void labelEmployeeReg_Click(object sender, EventArgs e)
        {
            EmployeeRegForm employeeRegForm = new EmployeeRegForm();
            employeeRegForm.Show();
        }

        private void labelPrivacyPolicy_Click(object sender, EventArgs e)
        {
            PrivacyPolicyForm privacyPolicyForm = new PrivacyPolicyForm();
            privacyPolicyForm.Show();
        }
    }
}
