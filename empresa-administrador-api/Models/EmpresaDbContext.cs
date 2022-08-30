using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace empresa_administrador_api.Models
{
    public class EmpresaDbContext : DbContext
    {
        public EmpresaDbContext(DbContextOptions<EmpresaDbContext> options)
            : base(options)
        { }

        public DbSet<Empleado> Empleados { get; set; }
    }
}
