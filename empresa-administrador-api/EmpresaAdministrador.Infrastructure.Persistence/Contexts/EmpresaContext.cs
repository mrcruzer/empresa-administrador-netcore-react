
using EmpresaAdministrador.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmpresaAdministrador.Infrastructure.Persistence.Contexts
{
    public class EmpresaContext : DbContext
    {
        public EmpresaContext(DbContextOptions<EmpresaContext> options)
            : base(options)
        { }

        public DbSet<Employee> Employees { get; set; }

       // public DbSet<Education> Educations { get; set; }

        public DbSet<EmploymentStatus> EmploymentStatus { get; set; }

        public DbSet<JobCategory> JobCategories { get; set; }

        public DbSet<JobTitle> JobTitles { get; set; }

        //public DbSet<Language> Languages { get; set; }

        //public DbSet<License> Licenses { get; set; }

        public DbSet<Nationality> Nationalities { get; set; }

        //public DbSet<Skill> Skills { get; set; }

        //public DbSet<PayGrade> PayGrades { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region tables
            modelBuilder.Entity<Employee>().ToTable("Employees");
            modelBuilder.Entity<Nationality>().ToTable("Nationalities");
            modelBuilder.Entity<JobTitle>().ToTable("JobTitles");
            modelBuilder.Entity<JobCategory>().ToTable("JobCategories");
            modelBuilder.Entity<EmploymentStatus>().ToTable("EmploymentStatus");
            #endregion

            #region keys
            modelBuilder.Entity<Employee>().HasKey(employee => employee.Id);
            modelBuilder.Entity<Nationality>().HasKey(nationality => nationality.Id);
            modelBuilder.Entity<JobTitle>().HasKey(jobtitle => jobtitle.Id);
            modelBuilder.Entity<JobCategory>().HasKey(jobcategory => jobcategory.Id);
            modelBuilder.Entity<EmploymentStatus>().HasKey(empstatus => empstatus.Id);
            #endregion

            #region properties

            #region Employee
            modelBuilder.Entity<Employee>().Property(employee => employee.Name).IsRequired();
            modelBuilder.Entity<Employee>().Property(employee => employee.LastName).IsRequired();
            #endregion

            #region Nationality
            modelBuilder.Entity<Nationality>().Property(nationality => nationality.Name).IsRequired();
                #endregion

                #region JobTitle
                modelBuilder.Entity<JobTitle>().Property(jobtitle => jobtitle.Name).IsRequired();
                modelBuilder.Entity<JobTitle>().Property(jobtitle => jobtitle.Description).IsRequired();
                #endregion

                #region JobCategory
                modelBuilder.Entity<JobCategory>().Property(jobcategory => jobcategory.Name).IsRequired();
                #endregion

                #region EmploymentStatus
                modelBuilder.Entity<EmploymentStatus>().Property(empstatus => empstatus.Name).IsRequired();
                #endregion

            #endregion

            #region relations

            // Nationality (m-1)
            modelBuilder.Entity<Nationality>()
                .HasMany<Employee>(nationality => nationality.Employees)
                .WithOne(employee => employee.Nationality)
                .HasForeignKey(employee => employee.NationalityId);

            // Job Title (m-1)
            modelBuilder.Entity<JobTitle>()
                .HasMany<Employee>(jobtitle => jobtitle.Employees)
                .WithOne(employee => employee.JobTitle)
                .HasForeignKey(employee => employee.JobTitleId);

            // Job Category (m-1)
            modelBuilder.Entity<JobCategory>()
                .HasMany<Employee>(jobcategory => jobcategory.Employees)
                .WithOne(employee => employee.JobCategory)
                .HasForeignKey(employee => employee.JobCategoryId);

            // Employment Status (m-1)
            modelBuilder.Entity<EmploymentStatus>()
                .HasMany<Employee>(empstatus => empstatus.Employees)
                .WithOne(employee => employee.EmploymentStatus)
                .HasForeignKey(employee => employee.EmploymentStatusId);

            #endregion

        }
    }
}
