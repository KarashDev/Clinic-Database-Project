using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Windows.Forms;

namespace MedicalDBProject.Forms
{
    public static class SortImplementation
    {
        // Класс не вынесен в отдельную библиотеку бизнес-логики, поскольку реализации этих методов слишком 
        // конкретны, чтобы переносить их в другой проект. Нельзя ставить в зависимость "конкретное от конкретного" 
        //internal static void ImplementSorting(ComboBox comboBox, DataGridView dataGridView)
        //{
        //    using (var db = new MedicalDBProject.Data.ApplicationContext())
        //    {
        //        var output = TableDataShaper.GetTableForDataGrid(db);

        //        switch (comboBox.Text)
        //        {
        //            case "По имени":
        //                dataGridView.DataSource = output.OrderBy(p => p.ФИО).ToList();
        //                break;
        //            case "По году рождения":
        //                dataGridView.DataSource = output.OrderBy(p => p.Год_рождения).ToList();
        //                break;
        //            case "По телефону":
        //                dataGridView.DataSource = output.OrderBy(p => p.Телефон).ToList();
        //                break;
        //            case "По группе крови":
        //                dataGridView.DataSource = output.OrderBy(p => p.Группа_крови).ToList();
        //                break;
        //            case "По диагнозу":
        //                dataGridView.DataSource = output.OrderBy(p => p.Диагноз).ToList();
        //                break;
        //            case "По палате":
        //                dataGridView.DataSource = output.OrderBy(p => p.Палата).ToList();
        //                break;
        //        }
        //    }
        //}
        public static List<PatientForRussianTitles> ImplementSorting()
        {
            using (var db = new MedicalDBProject.Data.ApplicationContext())
            {
                var output = TableDataShaper.GetPatientTableForDataGrid(db);
                return output;
            }
        }
    }
}
