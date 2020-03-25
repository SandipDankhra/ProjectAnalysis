using HospitalStoreApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalStoreApp.Context
{
    public abstract class BaseContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("data source=S\\SQLEXPRESS;initial catalog=HospitalDepartmentDb;Integrated Security=True;MultipleActiveResultSets=True;App=EntityFramework");
        }

        public DbSet<Doctors> Doctors { get; set; }
        public DbSet<Departments> Departments { get; set; }
        public DbSet<Patients> Patients{ get; set; }
        public DbSet<PatientDrugsDeatils> PatientDrugsDeatils{ get; set; }
    }
}
