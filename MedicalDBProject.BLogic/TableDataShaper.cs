using MedicalDBProject.BLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static MedicalDBProject.Data.DataBaseCreator;

namespace MedicalDBProject.Forms
{
    class TableDataShaper
    {
        internal static List<PatientForRussianTitles> GetStringForDataGrid(IQueryable<Patient> match)
        {
            return match.Select(match => new PatientForRussianTitles
            {
                ФИО = match.FullName,
                Год_рождения = match.YearOfBirth,
                Телефон = match.PhoneNumber,
                Группа_крови = match.BloodGroup.Group,
                Диагноз = match.Diagnosis.Name,
                Палата = match.Ward.Number
            }).ToList();
        }

        internal static List<PatientForRussianTitles> GetPatientTableForDataGrid(MedicalDBProject.Data.ApplicationContext db)
        {
            return db.Patients.Select(patient => new PatientForRussianTitles
            {
                ФИО = patient.FullName,
                Год_рождения = patient.YearOfBirth,
                Телефон = patient.PhoneNumber,
                Группа_крови = patient.BloodGroup.Group,
                Диагноз = patient.Diagnosis.Name,
                Палата = patient.Ward.Number
            }).ToList();
        }

        internal static List<WardForRussianTitles> GetWardsTableForDataGrid(MedicalDBProject.Data.ApplicationContext db)
        {
            return db.ClinicWard.Select(ward => new WardForRussianTitles
            {
                Порядковый_номер = ward.Id,
                Номер_палаты = ward.Number
            }).ToList();
        }

        internal static List<DiagnosisForRussianTitles> GetDiagnosesTableForDataGrid(MedicalDBProject.Data.ApplicationContext db)
        {
            return db.Diagnoses.Select(d => new DiagnosisForRussianTitles
            {
                Порядковый_номер = d.Id,
                Наименование = d.Name,
                Код_МКБ = d.Code
            }).ToList();
        }
    }
}
