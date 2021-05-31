using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace MedicalDBProject.Data
{
    public class DataBaseCreator
    {
        [Table("Сотрудники")]
        public class EmployeeData
        {
            public int Id { get; set; }

            [MinLength(10)]
            public string Login { get; set; }

            [MinLength(10)]
            public string Password { get; set; }
        }

        [Table("Пациенты")]
        public class Patient
        {
            public int Id { get; set; }

            [Column("ФИО"), Required]
            public string FullName { get; set; }

            [Column("Год рождения"), Required, MaxLength(4)]
            public int YearOfBirth { get; set; }

            [Column("Телефон"), Required, MaxLength(15)]
            public long PhoneNumber { get; set; }

            // Группа_крови к Пациенту: один ко многим
            [Column("Группа крови"), MaxLength(20)]
            public BloodGroup? BloodGroup { get; set; }

            // Диагноз к Пациенту: один ко многим
            [Column("Диагноз")]
            public Diagnosis? Diagnosis { get; set; }

            // Палата к Пациенту: один ко многим
            [Column("Палата"), MaxLength(4)]
            public ClinicWard? Ward { get; set; }
        }

        [Table("Группы крови")]
        public class BloodGroup
        {
            public int? Id { get; set; }

            [Column("Группа"), Required, DefaultValue("*Не указано*")]
            public string? Group { get; set; }

            // Группа_крови к Пациенту: один ко многим 
            public List<Patient> Patients { get; set; } = new List<Patient>();
        }

        [Table("Диагнозы")]
        public class Diagnosis
        {
            public int? Id { get; set; }

            [Column("Наименование"), Required, DefaultValue("*Не указано*")]
            public string? Name { get; set; }

            [Column("Код"), MaxLength(10), DefaultValue("*Не указано*")]
            public string? Code { get; set; }

            // Диагноз к Пациенту: один ко многим
            public List<Patient> Patients { get; set; } = new List<Patient>();
        }

        [Table("Палаты")]
        public class ClinicWard
        {
            public int? Id { get; set; }

            [Column("Номер"), Required, DefaultValue("*Не указано*")]
            public int? Number { get; set; }

            // Палата к Пациенту: один ко многим
            public List<Patient> Patients { get; set; } = new List<Patient>();
        }


        public void CreateDataBase()
        {
            using (ApplicationContext dataBase = new ApplicationContext())
            {
                // База данных пересоздается при каждом запуске программы
                dataBase.Database.EnsureDeleted();
                dataBase.Database.EnsureCreated();


                //Создание таблицы с группами крови

                BloodGroup group1 = new BloodGroup { Group = "0(I) RH+" };
                BloodGroup group2 = new BloodGroup { Group = "0(I) RH-" };
                BloodGroup group3 = new BloodGroup { Group = "A(II) RH+" };
                BloodGroup group4 = new BloodGroup { Group = "A(II) RH-" };
                BloodGroup group5 = new BloodGroup { Group = "B(III) RH+" };
                BloodGroup group6 = new BloodGroup { Group = "B(III) RH-" };
                BloodGroup group7 = new BloodGroup { Group = "AB(IV) RH+" };
                BloodGroup group8 = new BloodGroup { Group = "AB(IV) RH-" };
                BloodGroup group9 = new BloodGroup { Group = "" };

                dataBase.AddRange(group1, group2, group3, group4, group5, group6, group7, group8, group9);


                //Создание таблицы с диагнозами

                Diagnosis ds1 = new Diagnosis { Name = "Атопический дерматит", Code = "L20" };
                Diagnosis ds2 = new Diagnosis { Name = "Ларингит", Code = "J04" };
                Diagnosis ds3 = new Diagnosis { Name = "Брадикардия", Code = "R00.1" };
                Diagnosis ds4 = new Diagnosis { Name = "Невралгия", Code = "M79.2" };
                Diagnosis ds5 = new Diagnosis { Name = "Острый гастрит", Code = "K29.0" };
                Diagnosis ds6 = new Diagnosis { Name = "Ожог 2 степени", Code = "L55.1" };
                Diagnosis ds7 = new Diagnosis { Name = "Грипп", Code = "J10" };
                Diagnosis ds8 = new Diagnosis { Name = "Пневмония", Code = "J13" };
                Diagnosis ds9 = new Diagnosis { Name = "Гепатит C", Code = "B18.2" };
                Diagnosis ds10 = new Diagnosis { Name = "Бедренная грыжа", Code = "K41" };
                Diagnosis ds11 = new Diagnosis { Name = "Острый энцефалит", Code = "G04.0" };
                Diagnosis ds12 = new Diagnosis { Name = "Абсцесс печени", Code = "K75.0" };
                Diagnosis ds13 = new Diagnosis { Name = "Тиреотоксикоз", Code = "E05" };
                Diagnosis ds14 = new Diagnosis { Name = "Мочекаменная болезнь", Code = "N20" };
                Diagnosis ds15 = new Diagnosis { Name = "Вазомоторный ринит", Code = "J30.0" };
                Diagnosis ds16 = new Diagnosis { Name = "Коклюш", Code = "A36" };
                Diagnosis ds17 = new Diagnosis { Name = "Туберкулез", Code = "A15" };
                Diagnosis ds18 = new Diagnosis { Name = "Стенокардия", Code = "I20" };
                

                dataBase.AddRange(ds1, ds2, ds3, ds4, ds5, ds6, ds7, ds8, ds9,
                     ds10, ds11, ds12, ds13, ds14, ds15, ds16, ds17, ds18);
                
                dataBase.SaveChanges();

                //Создание пустого диагноза. Требуется для того, чтобы combobox мог вывести одно пустое значение
                Diagnosis dsEmpty = new Diagnosis { Name = "", Code = "" };
                dataBase.Diagnoses.Add(dsEmpty);

                //Создание таблицы с палатами

                ClinicWard CreateWard(int number)
                {
                    return new ClinicWard { Number = number };
                }
                var ward1 = CreateWard(101);
                var ward2 = CreateWard(116);
                var ward3 = CreateWard(205);
                var ward4 = CreateWard(167);
                var ward5 = CreateWard(122);
                var ward6 = CreateWard(220);
                var ward7 = CreateWard(165);
                var ward8 = CreateWard(105);
                var ward9 = CreateWard(163);
                var ward10 = CreateWard(199);

                dataBase.AddRange(ward1, ward2, ward3, ward4, ward5, ward6, ward7, ward8, ward9, ward10);

                dataBase.SaveChanges();

                //Создание пустой палаты. Требуется для того, чтобы combobox мог вывести одно пустое значение
                var wardEmpty = CreateWard(default);
                dataBase.ClinicWard.Add(wardEmpty);

                
                
                //Создание таблицы с пациентами и их данными
                static Patient CreatePatient(string fullName, int yearOfBirth, long phoneNumber,
                    BloodGroup bloodGroup, Diagnosis diagnosis, ClinicWard ward)
                {
                    return new Patient
                    {
                        FullName = fullName,
                        YearOfBirth = yearOfBirth,
                        PhoneNumber = phoneNumber,
                        BloodGroup = bloodGroup,
                        Diagnosis = diagnosis,
                        Ward = ward
                    };
                }

                var patient1 = CreatePatient("Ивашкин Ю.С.", 1973, 79051442521, group1, ds1, ward1);
                var patient2 = CreatePatient("Липов Ю.А.", 1989, 79652767310, group3, ds13, ward7);
                var patient3 = CreatePatient("Илонтьев Г.А.", 1956, 79737972953, group4, ds2, ward2);
                var patient4 = CreatePatient("Голованова У.А.", 1925, 79811318637, group7, ds4, ward8);
                var patient5 = CreatePatient("Акимов Д.Р.", 1994, 77019381234, group1, ds10, ward9);
                var patient6 = CreatePatient("Федотов Д.К.", 2001, 79732511037, group2, ds11, ward6);
                var patient7 = CreatePatient("Новикова В.А.", 1972, 79137672682, group3, ds16, ward7);
                var patient8 = CreatePatient("Ефремов В.И.", 2000, 77221100098, group6, ds8, ward1);
                var patient9 = CreatePatient("Гуляева У.И.", 1978, 79506396939, group4, ds15, ward5);
                var patient10 = CreatePatient("Тихонова М.Д.", 1967, 79500294383, group8, ds3, ward9);
                var patient11 = CreatePatient("Наумов С.Н.", 1988, 79084240256, group4, ds15, ward1);
                var patient12 = CreatePatient("Козлов А.Е.", 1985, 79284240256, group6, ds18, ward3);
                var patient13 = CreatePatient("Нестерова А.Е.", 1992, 79197172481, group8, ds17, ward6);
                var patient14 = CreatePatient("Семенов И.П.", 1973, 79356495891, group2, ds5, ward10);
                var patient15 = CreatePatient("Ульянова В.А.", 2001, 79997172481, group7, ds15, ward9);
                var patient16 = CreatePatient("Павловский Р.Л.", 1949, 79358495891, group6, ds12, ward6);
                var patient17 = CreatePatient("Васильева С.А.", 1977, 79997172481, group5, ds1, ward2);
                var patient18 = CreatePatient("Борисов К.Н.", 1988, 79807171546, group3, ds8, ward5);
                var patient19 = CreatePatient("Богданова А.Д.", 1991, 79130065276, group5, ds3, ward4);
                var patient20 = CreatePatient("Романов А.К.", 1973, 79478831627, group2, ds2, ward8);
                var patient21 = CreatePatient("Воронин Ф.Г.", 1966, 79817171546, group7, ds9, ward9);
                var patient22 = CreatePatient("Яковлев И.А.", 1999, 79134065276, group8, ds17, ward1);
                var patient23 = CreatePatient("Нестерова В.Д.", 1972, 79478831627, group1, ds5, ward2);
                var patient24 = CreatePatient("Морозова С.Ю.", 1961, 79667171546, group2, ds9, ward3);
                var patient25 = CreatePatient("Котов Н.К.", 1969, 79131265276, group3, ds11, ward7);
                var patient26 = CreatePatient("Климов Д.В.", 1992, 79478831627, group5, ds2, ward9);
                var patient27 = CreatePatient("Лукьянова С.А.", 2000, 79877171546, group6, ds6, ward4);
                var patient28 = CreatePatient("Панфилов Б.Ф.", 1997, 79137065276, group1, ds4, ward7);
                var patient29 = CreatePatient("Григорьев Я.Ф.", 1950, 79478831627, group4, ds3, ward2);
                var patient30 = CreatePatient("Попова А.М.", 1994, 79178832328, group7, ds1, ward1);
                var patient31 = CreatePatient("Попов C.C.", 1984, 79573212328, group7, ds8, ward6);


                dataBase.AddRange(patient1, patient2, patient3, patient4, patient5, patient6,
                    patient7, patient8, patient9, patient10, patient11, patient12, patient13,
                    patient14, patient15, patient16, patient17, patient18, patient19, patient20,
                    patient21, patient22, patient23, patient24, patient25, patient26, patient27,
                    patient28, patient29, patient30, patient31);


                //Создание таблицы с логинами и паролями сотрудников

                static EmployeeData CreateEmployee(string login, string password)
                {
                    return new EmployeeData { Login = DataHasher.GetHashMd5(login), Password = DataHasher.GetHashMd5(password) };
                }

                var employee1 = CreateEmployee("Emivanova", "Calisto");
                var employee2 = CreateEmployee("Avmarkina", "Milostart135");
                var employee3 = CreateEmployee("Aspanfilov", "Romesta_rbon");
                var employee4 = CreateEmployee("Vamoiseev", "Rubik13356");
                var employee5 = CreateEmployee("Dekulikov", "Johnson_13151617");
                var employee6 = CreateEmployee("Kdmironov", "HarryPotter");

                dataBase.AddRange(employee1, employee2, employee3, employee4, employee5, employee6);

                dataBase.SaveChanges();
            }
        }
    }
}
