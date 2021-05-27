using MedicalDBProject.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace MedicalDBProject.Forms.Test
{
    // ����� ��� ������ ������ ����������� ����������� � ������������ ����. ����� ����������� 
    // ������ ��� ���������� ���������� �������, ������� �������� �������  ���, ���
    // ��� ��� �� ��������� ��� ������� �������.
    [TestClass]
    public class FormBlTests
    {
        // ���� ������ ���������� ������ ����� ������/������ � �������� ������� �� ��������������
        // ����� � ���� ������ (�� ����������� �������� ������ �����). 
        // ������������ � AuthorizationForm.OpenDbChangeButton_Click()
        [TestMethod]
        public void LoginPasswordHashedCheckInDb()
        {
            string TestHashFunction(string nonHashedLogin, string nonHashedPassword)
            {
                string output;

                DataBaseCreator dataBaseCreator = new DataBaseCreator();
                dataBaseCreator.CreateDataBase();

                var hashedLogin = DataHasher.GetHashMd5(nonHashedLogin);
                var hashedPassword = DataHasher.GetHashMd5(nonHashedPassword);

                using (var db = new MedicalDBProject.Data.ApplicationContext())
                {
                    var matchedEmployee = db.Employee.FirstOrDefault(e => e.Login == hashedLogin && e.Password == hashedPassword);

                    if (matchedEmployee != null)
                    {
                        output = "������ ��������, ����� � ������ �����";
                        return output;
                    }
                    else
                    {
                        output = "������ ��������, �������� ������";
                        return output;
                    }
                }
            }

            var expectedResult1 = "������ ��������, ����� � ������ �����";
            var actualResult1 = TestHashFunction("Emivanova", "Calisto");
            Assert.AreEqual(expectedResult1, actualResult1); //��������


            //var expectedResult2 = "������ ��������, ����� � ������ �����";
            //var actualResult2 = TestHashFunction("Emivanova", "Calistoo");
            //Assert.AreEqual(expectedResult2, actualResult2); //�� ��������
        }

        // ���� ���������� ���������� ������ ��������� ������ �������� � ���� ������.
        // (��������� ��������� �����. ��������� � ����� �����, ��������� �������� ������ �����).
        // ������������ � ChangeDbPatientsForm.buttonChangePatiient_Click()
        [TestMethod]
        public void ChangePatientDataInDb()
        {
            bool IsPatientChanged(string oldPatientName, string oldPatientYearBirth, string oldPatientPhone,
                string newPatientName, string newPatientYearBirth, string newPatientPhone)
            {

                using (var db = new MedicalDBProject.Data.ApplicationContext())
                {
                    var selectedPatient = db.Patients.FirstOrDefault(p =>
                            p.FullName == oldPatientName &&
                            p.YearOfBirth == Convert.ToInt64(oldPatientYearBirth) &&
                            p.PhoneNumber == Convert.ToInt64(oldPatientPhone));

                    // ���������, ���� �� ����� �������, ��� ����� ���������� false
                    if (selectedPatient != null)
                    {
                        selectedPatient.FullName = newPatientName;
                        selectedPatient.YearOfBirth = Convert.ToInt32(newPatientYearBirth);
                        selectedPatient.PhoneNumber = Convert.ToInt64(newPatientPhone);

                        db.SaveChanges();
                    }
                    else return false;

                    // ���������, ������������� �� � ���������� �������� ���������� ������
                    if (db.Patients.Any(p => p.FullName == newPatientName &&
                    p.YearOfBirth == Convert.ToInt32(newPatientYearBirth) &&
                    p.PhoneNumber == Convert.ToInt64(newPatientPhone)))
                    {
                        return true;
                    }
                    else return false;
                }
            }

            var isDbPatientChanged1 = IsPatientChanged("Ivan", "1994", "75068443012", "Dima", "1992", "7500225353");
            var isDbPatientChanged2 = IsPatientChanged("����� �.�.", "1989", "79652767310", "Dima", "1992", "75002253532");

            //Assert.AreEqual(false, isDbPatientChanged1); //��������: ������ �������� ������ ��� � ����

            Assert.AreEqual(true, isDbPatientChanged2); //��������: ����� ������� ������, � ��� ������� ��������
        }

       
        // ���� ���������� ���������� ������ ���������� ������ �������� � ���� ������.
        // (��������� ���������� �����. ��������� � ����� �����, ��������� �������� ������ �����).
        // ������������ � ChangeDbPatientsForm.buttonChangePatiient_Click()
        [TestMethod]
        public void AddPatientInDb()
        {
            bool IsPatientCreated(string newPatientName, string newPatientYearBirth, string newPatientPhone)
            {
                using (var db = new MedicalDBProject.Data.ApplicationContext())
                {
                    db.Patients.Add(new DataBaseCreator.Patient
                    {
                        FullName = newPatientName,
                        YearOfBirth = Convert.ToInt32(newPatientYearBirth),
                        PhoneNumber = Convert.ToInt64(newPatientPhone),
                    });
                    db.SaveChanges();

                    if (db.Patients.Any(p => p.FullName == newPatientName &&
                    p.YearOfBirth == Convert.ToInt32(newPatientYearBirth) &&
                    p.PhoneNumber == Convert.ToInt64(newPatientPhone)))
                    {
                        return true;
                    }
                    else return false;
                }
            }

            var isDbPatientCreated = IsPatientCreated("Ivan", "1994", "75068443012");

            Assert.AreEqual(true, isDbPatientCreated); //��������: ����� ������� ������, ������ �� ��� ��������
        }


        // ���� ���������� ���������� ������ �������� �������� �� ���� ������.
        // ������������ � ChangeDbPatientsForm.buttonChangePatiient_Click()
        [TestMethod]
        public void RemovePatientFromDb()
        {
            bool IsPatientRemoved(string patientName, string patientYearBirth, string patientPhone)
            {
                using (var db = new MedicalDBProject.Data.ApplicationContext())
                {
                    var selectedPatient = db.Patients.FirstOrDefault(p =>
                            p.FullName == patientName &&
                            p.YearOfBirth == Convert.ToInt64(patientYearBirth) &&
                            p.PhoneNumber == Convert.ToInt64(patientPhone));

                    // ���������, ���� �� ����� �������, ��� ����� ���������� false
                    if (selectedPatient != null)
                    {
                        db.Remove(selectedPatient);

                        db.SaveChanges();
                    }
                    else return false;


                    if (!db.Patients.Any(p => p.FullName == patientName &&
                    p.YearOfBirth == Convert.ToInt32(patientYearBirth) &&
                    p.PhoneNumber == Convert.ToInt64(patientPhone)))
                    {
                        return true;
                    }
                    else return false;
                }
            }
            
            var isDbPatientRemoved = IsPatientRemoved("�������� �.�.", "1972", "79137672682");

            Assert.AreEqual(true, isDbPatientRemoved); //��������: ����� ������� ������, ������, � ����� �� ������
        }
    }
}



