using empresa_administrador_api.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace empresa_administrador_api.Data
{
    public class EmpresaDbContext : DbContext
    {
        public EmpresaDbContext(DbContextOptions<EmpresaDbContext> options)
            : base(options)
        { }

        public DbSet<Employee> Empleados { get; set; }

        public DbSet<Education> Educations { get; set; }

        public DbSet<EmploymentStatus> EmploymentStatus { get; set; }

        public DbSet<JobCategory> JobCategories { get; set; }

        public DbSet<JobTitle> jobTitles { get; set; }

        public DbSet<Language> Languages { get; set; }

        public DbSet<License> Licenses { get; set; }

        public DbSet<Nationality> Nationalities { get; set; }

        public DbSet<Skill> Skills { get; set; }

        public DbSet<PayGrade> PayGrades { get; set; }
    }
}
