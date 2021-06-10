using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static MedicalDBProject.AuthorizationForm;

namespace MedicalDBProject.Forms
{
    public partial class DbViewForm : Form
    {
        public DbViewForm()
        {
            InitializeComponent();
            this.MaximizeBox = false;

            dataGridViewDbView.DataSource = DataGridViewLoader.LoadDbInDataGridView().ToList();

            // Устанавливаем значение по умолчанию для ComboBox
            comboBoxSortDbView.SelectedIndex = 0;
        }

        private void DbViewSortButton_Click(object sender, EventArgs e)
        {
            var outputRows = SortImplementation.ImplementSorting();
            switch (comboBoxSortDbView.Text)
            {
                case "По имени":
                    dataGridViewDbView.DataSource = outputRows.OrderBy(p => p.ФИО).ToList();
                    break;
                case "По году рождения":
                    dataGridViewDbView.DataSource = outputRows.OrderBy(p => p.Год_рождения).ToList();
                    break;
                case "По телефону":
                    dataGridViewDbView.DataSource = outputRows.OrderBy(p => p.Телефон).ToList();
                    break;
                case "По группе крови":
                    dataGridViewDbView.DataSource = outputRows.OrderBy(p => p.Группа_крови).ToList();
                    break;
                case "По диагнозу":
                    dataGridViewDbView.DataSource = outputRows.OrderBy(p => p.Диагноз).ToList();
                    break;
                case "По палате":
                    dataGridViewDbView.DataSource = outputRows.OrderBy(p => p.Палата).ToList();
                    break;
            }
        }

        private void DbViewSearchButton_Click(object sender, EventArgs e)
        {
            var searchText = textBoxDbViewSearch.Text;

            if (!String.IsNullOrEmpty(searchText))
            {
                var outputRows = SearchImplementation.ImplementSearching(searchText);

                if (outputRows != null)
                {
                    dataGridViewDbView.DataSource = outputRows.ToList();
                }
                else
                {
                    MessageBox.Show("Нет совпадений", "Поиск завершен", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else MessageBox.Show("Пустой поисковый запрос", "Ошибка: Пустое поле", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }

        private void DbViewClearButton_Click(object sender, EventArgs e)
        {
            // Очистка результатов поиска: заново выгружаем БД в DataGridView
            dataGridViewDbView.DataSource = DataGridViewLoader.LoadDbInDataGridView().ToList();
            textBoxDbViewSearch.Text = "";
        }
    }
}

