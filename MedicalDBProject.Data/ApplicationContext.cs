using Microsoft.EntityFrameworkCore;
using System;
using static MedicalDBProject.Data.DataBaseCreator;

namespace MedicalDBProject.Data
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Patient> Patients { get; set; }
        public DbSet<BloodGroup> BloodGroups { get; set; }
        public DbSet<Diagnosis> Diagnoses { get; set; }
        public DbSet<ClinicWard> ClinicWard { get; set; }

        public DbSet<EmployeeData> Employee { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=MedicalDB;Trusted_Connection=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Необходимо отключить встроенное каскадное удаление, иначе при удалении палат и  
            // диагнозов будут удаляться и пациенты, а это недопустимо.
            modelBuilder.Entity<Patient>()
           .HasOne(p => p.Ward)
           .WithMany(w => w.Patients)
           .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<Patient>()
           .HasOne(p => p.Diagnosis)
           .WithMany(d => d.Patients)
           .OnDelete(DeleteBehavior.SetNull);
        }
    }
}
