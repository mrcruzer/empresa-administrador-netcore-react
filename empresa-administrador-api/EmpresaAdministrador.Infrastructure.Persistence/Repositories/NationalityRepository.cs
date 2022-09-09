using Microsoft.EntityFrameworkCore;
using EmpresaAdministrador.Core.Application.Interfaces.Repositories;
using EmpresaAdministrador.Core.Domain.Entities;
using EmpresaAdministrador.Infrastructure.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaAdministrador.Infrastructure.Persistence.Repositories
{
    public class NationalityRepository : GenericRepository<Nationality>, INationalityRepository
    {
        private readonly EmpresaContext _dbContext;

        public NationalityRepository(EmpresaContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
