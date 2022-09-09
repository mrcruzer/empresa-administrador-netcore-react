
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

        public DbSet<Education> Educations { get; set; }

        public DbSet<EmploymentStatus> EmploymentStatus { get; set; }

        public DbSet<JobCategory> JobCategories { get; set; }

        public DbSet<JobTitle> JobTitles { get; set; }

        public DbSet<Language> Languages { get; set; }

        public DbSet<License> Licenses { get; set; }

        public DbSet<Nationality> Nationalities { get; set; }

        public DbSet<Skill> Skills { get; set; }

        public DbSet<PayGrade> PayGrades { get; set; }
    }
}
