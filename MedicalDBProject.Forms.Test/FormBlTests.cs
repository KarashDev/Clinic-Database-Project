using MedicalDBProject.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace MedicalDBProject.Forms.Test
{
    // Тесты для логики работы интерфейсов реализованы в переписанном виде. Тесты реализованы 
    // только для выборочных нескольких методов, полного покрытия тестами  нет, так
    // как они не требуются для данного проекта.
    [TestClass]
    public class FormBlTests
    {
        // Тест точной реализации логики ввода логина/пароля и проверки наличия их захэшированных
        // копий в базе данных (за исключением проверки пустых полей). 
        // Используется в AuthorizationForm.OpenDbChangeButton_Click()
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
                        output = "Доступ разрешен, логин и пароль верны";
                        return output;
                    }
                    else
                    {
                        output = "Доступ запрещен, неверные данные";
                        return output;
                    }
                }
            }

            var expectedResult1 = "Доступ разрешен, логин и пароль верны";
            var actualResult1 = TestHashFunction("Emivanova", "Calisto");
            Assert.AreEqual(expectedResult1, actualResult1); //Пройдено


            //var expectedResult2 = "Доступ разрешен, логин и пароль верны";
            //var actualResult2 = TestHashFunction("Emivanova", "Calistoo");
            //Assert.AreEqual(expectedResult2, actualResult2); //Не пройдено
        }

        // Тест упрощенной реализации логики изменения данных пациента в базе данных.
        // (исключено изменение палат. диагнозов и групп крови, исключена проверка пустых полей).
        // Используется в ChangeDbPatientsForm.buttonChangePatiient_Click()
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

                    // Проверяем, есть ли такой пациент, или сразу возвращаем false
                    if (selectedPatient != null)
                    {
                        selectedPatient.FullName = newPatientName;
                        selectedPatient.YearOfBirth = Convert.ToInt32(newPatientYearBirth);
                        selectedPatient.PhoneNumber = Convert.ToInt64(newPatientPhone);

                        db.SaveChanges();
                    }
                    else return false;

                    // Проверяем, действительно ли у выбранного пациента изменились данные
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
            var isDbPatientChanged2 = IsPatientChanged("Липов Ю.А.", "1989", "79652767310", "Dima", "1992", "75002253532");

            //Assert.AreEqual(false, isDbPatientChanged1); //Пройдено: такого пациента вообще нет в базе

            Assert.AreEqual(true, isDbPatientChanged2); //Пройдено: такой пациент найден, и его удалось изменить
        }

       
        // Тест упрощенной реализации логики добавления нового пациента в базу данных.
        // (исключено добавление палат. диагнозов и групп крови, исключена проверка пустых полей).
        // Используется в ChangeDbPatientsForm.buttonChangePatiient_Click()
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

            Assert.AreEqual(true, isDbPatientCreated); //Пройдено: такой пациент найден, значит он был добавлен
        }


        // Тест упрощенной реализации логики удаления пациента из базы данных.
        // Используется в ChangeDbPatientsForm.buttonChangePatiient_Click()
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

                    // Проверяем, есть ли такой пациент, или сразу возвращаем false
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
            
            var isDbPatientRemoved = IsPatientRemoved("Новикова В.А.", "1972", "79137672682");

            Assert.AreEqual(true, isDbPatientRemoved); //Пройдено: такой пациент найден, удален, и более не найден
        }
    }
}



