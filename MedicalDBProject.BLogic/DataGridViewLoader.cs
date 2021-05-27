using MedicalDBProject.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using static MedicalDBProject.Data.DataBaseCreator;
using MedicalDBProject.BLogic;

namespace MedicalDBProject.Forms
{
    public static class DataGridViewLoader
    {
        public static List<PatientForRussianTitles> LoadDbInDataGridView()
        {
            using (var db = new MedicalDBProject.Data.ApplicationContext())
            {
                var output = TableDataShaper.GetPatientTableForDataGrid(db);
                return output;
            }
        }

        public static List<DiagnosisForRussianTitles> LoadDiagnosisInDataGridView()
        {
            using (var db = new MedicalDBProject.Data.ApplicationContext())
            {
                var output = TableDataShaper.GetDiagnosesTableForDataGrid(db);
                return output;
            }
        }

        public static List<WardForRussianTitles> LoadWardsInDataGridView()
        {
            using (var db = new MedicalDBProject.Data.ApplicationContext())
            {
                var output = TableDataShaper.GetWardsTableForDataGrid(db);
                return output;
            }
        }

        public static List<PatientForRussianTitles> PutMatchedDataInDataGrid(IQueryable<Patient> match)
        {
            if (match.Any())
            {
                var searchingResults = TableDataShaper.GetStringForDataGrid(match);
                return searchingResults;
            }
            return null;
        }
    }
}
