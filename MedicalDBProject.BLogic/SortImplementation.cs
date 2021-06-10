using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace MedicalDBProject.Forms
{
    public static class SortImplementation
    {
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
