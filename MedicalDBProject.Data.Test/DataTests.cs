using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace MedicalDBProject.Data.Test
{
    [TestClass]
    public class DataTests
    {
        [TestMethod]
        public void CreatedPatientsCount()
        {
            DataBaseCreator dataBaseCreator = new DataBaseCreator();
            dataBaseCreator.CreateDataBase();
            
            using (var db = new MedicalDBProject.Data.ApplicationContext())
            {
                var expectedPatientsCount = 31;
                var actualPatientsCount = db.Patients.Count();

                Assert.AreEqual(expectedPatientsCount, actualPatientsCount);
            }
        }
        [TestMethod]
        public void CreatedBloogGroupsCount()
        {
            DataBaseCreator dataBaseCreator = new DataBaseCreator();
            dataBaseCreator.CreateDataBase();

            using (var db = new MedicalDBProject.Data.ApplicationContext())
            {
                var expectedBloogGroupsCount = 9;
                var actualBloogGroupsCount = db.BloodGroups.Count();

                Assert.AreEqual(expectedBloogGroupsCount, actualBloogGroupsCount);
            }
        }
        [TestMethod]
        public void CreatedDiagnosesCount()
        {
            DataBaseCreator dataBaseCreator = new DataBaseCreator();
            dataBaseCreator.CreateDataBase();

            using (var db = new MedicalDBProject.Data.ApplicationContext())
            {
                var expectedDiagnosesCount = 19;
                var actualDiagnosesCount = db.Diagnoses.Count();

                Assert.AreEqual(expectedDiagnosesCount, actualDiagnosesCount);
            }
        }
        [TestMethod]
        public void CreatedWardsCount()
        {
            DataBaseCreator dataBaseCreator = new DataBaseCreator();
            dataBaseCreator.CreateDataBase();

            using (var db = new MedicalDBProject.Data.ApplicationContext())
            {
                var expectedWardsCount = 11;
                var actualWardsCount = db.ClinicWard.Count();

                Assert.AreEqual(expectedWardsCount, actualWardsCount);
            }
        }
    }
}
