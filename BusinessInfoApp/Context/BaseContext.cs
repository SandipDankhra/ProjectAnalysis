namespace BusinessInfoApp.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class BaseContext : DbContext
    {
        public BaseContext() : base("name=DbBaseContext")
        {
        }

        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<ProjectDetail> ProjectDetails { get; set; }
        public virtual DbSet<Project> Projects { get; set; }
        public virtual DbSet<vProjectDetailRecord> vProjectDetailRecords { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.EmployeeType)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.Status)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.Projects)
                .WithRequired(e => e.Employee)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ProjectDetail>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<ProjectDetail>()
                .Property(e => e.ProjectType)
                .IsUnicode(false);

            modelBuilder.Entity<ProjectDetail>()
                .Property(e => e.ProjectDuration)
                .IsUnicode(false);

            modelBuilder.Entity<Project>()
                .Property(e => e.ProjectName)
                .IsUnicode(false);

            modelBuilder.Entity<Project>()
                .HasMany(e => e.ProjectDetails)
                .WithRequired(e => e.Project)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ProjectDetail>()
                .MapToStoredProcedures();

            modelBuilder.Entity<vProjectDetailRecord>()
               .Property(e => e.ProjectName)
               .IsUnicode(false);

            modelBuilder.Entity<vProjectDetailRecord>()
                .Property(e => e.ProjectType)
                .IsUnicode(false);

            modelBuilder.Entity<vProjectDetailRecord>()
                .Property(e => e.ProjectDuration)
                .IsUnicode(false);

            modelBuilder.Entity<vProjectDetailRecord>()
                .Property(e => e.Name)
                .IsUnicode(false);
        }
    }
}
