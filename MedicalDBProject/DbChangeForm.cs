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
    public partial class DbChangeForm : Form
    {
        public DbChangeForm()
        {
            InitializeComponent();
            this.MaximizeBox = false;

            dataGridViewDbChange.DataSource = DataGridViewLoader.LoadDbInDataGridView().ToList();
            
            // Устанавливаем значение по умолчанию для ComboBox
            comboBoxSortDbChange.SelectedIndex = 0;
            comboBoxModifyDbChange.SelectedIndex = 0;
        }

        private void DbChangeSortButton_Click(object sender, EventArgs e)
        {
            var output = SortImplementation.ImplementSorting();
            
            switch (comboBoxSortDbChange.Text)
            {
                case "По имени":
                    dataGridViewDbChange.DataSource = output.OrderBy(p => p.ФИО).ToList();
                    break;
                case "По году рождения":
                    dataGridViewDbChange.DataSource = output.OrderBy(p => p.Год_рождения).ToList();
                    break;
                case "По телефону":
                    dataGridViewDbChange.DataSource = output.OrderBy(p => p.Телефон).ToList();
                    break;
                case "По группе крови":
                    dataGridViewDbChange.DataSource = output.OrderBy(p => p.Группа_крови).ToList();
                    break;
                case "По диагнозу":
                    dataGridViewDbChange.DataSource = output.OrderBy(p => p.Диагноз).ToList();
                    break;
                case "По палате":
                    dataGridViewDbChange.DataSource = output.OrderBy(p => p.Палата).ToList();
                    break;
            }
        }

        private void DbChangeSearchButton_Click(object sender, EventArgs e)
        {
            var searchText = textBoxDbChangeSearch.Text;

            if (!String.IsNullOrEmpty(searchText))
            {
                var output = SearchImplementation.ImplementSearching(searchText);

                if (output != null)
                {
                    dataGridViewDbChange.DataSource = output.ToList();
                }
                else
                {
                    MessageBox.Show("Нет совпадений", "Поиск завершен", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else MessageBox.Show("Пустой поисковый запрос", "Ошибка: Пустое поле", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }

        private void DbChangeClearButton_Click(object sender, EventArgs e)
        {
            dataGridViewDbChange.DataSource = DataGridViewLoader.LoadDbInDataGridView().ToList();
            textBoxDbChangeSearch.Text = "";
        }

        private void DbChangeModifyButton_Click(object sender, EventArgs e)
        {
            if (comboBoxModifyDbChange.Text == "Пациенты и их данные")
            {
                ChangeDbPatientsForm changeDbPatientsForm = new ChangeDbPatientsForm();
                changeDbPatientsForm.Show();
            }
            else if (comboBoxModifyDbChange.Text == "Диагнозы")
            {
                ChangeDbDiagnosisForm changeDbDiagnosisForm = new ChangeDbDiagnosisForm();
                changeDbDiagnosisForm.Show();
            }
            else if (comboBoxModifyDbChange.Text == "Палаты")
            {
                ChangeDbWardsForm changeDbWardsForm = new ChangeDbWardsForm();
                changeDbWardsForm.Show();
            }
        }
    }
}
