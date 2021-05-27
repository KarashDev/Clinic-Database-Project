using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static MedicalDBProject.Data.DataBaseCreator;


namespace MedicalDBProject.Forms
{
    public static class SearchImplementation
    {
        public static List<PatientForRussianTitles> ImplementSearching(string searchText)
        {
            using (var db = new MedicalDBProject.Data.ApplicationContext())
            {
                List<PatientForRussianTitles> output = null;

                var namesMatch = db.Patients.Where(p => p.FullName.Contains(searchText));
                if (namesMatch.Any())
                {
                    output = DataGridViewLoader.PutMatchedDataInDataGrid(namesMatch);
                }

                var yearOfBirthMatch = db.Patients.Where(p => p.YearOfBirth.ToString().Contains(searchText));
                if (yearOfBirthMatch.Any())
                {
                    output = DataGridViewLoader.PutMatchedDataInDataGrid(yearOfBirthMatch);
                }

                var phoneNumberMatch = db.Patients.Where(p => p.PhoneNumber.ToString().Contains(searchText));
                if (phoneNumberMatch.Any())
                {
                    output = DataGridViewLoader.PutMatchedDataInDataGrid(phoneNumberMatch);
                }
                
                var bloodGroupMatch = db.Patients.Where(p => p.BloodGroup.Group.Contains(searchText));
                if (bloodGroupMatch.Any())
                {
                    output = DataGridViewLoader.PutMatchedDataInDataGrid(bloodGroupMatch);
                }

                var diagnosisMatch = db.Patients.Where(p => p.Diagnosis.Name.Contains(searchText));
                if (diagnosisMatch.Any())
                {
                    output = DataGridViewLoader.PutMatchedDataInDataGrid(diagnosisMatch);
                }

                var wardMatch = db.Patients.Where(p => p.Ward.Number.ToString().Contains(searchText));
                if (wardMatch.Any())
                {
                    output = DataGridViewLoader.PutMatchedDataInDataGrid(wardMatch);
                }

                 return output;
            }
        }
    }
}
