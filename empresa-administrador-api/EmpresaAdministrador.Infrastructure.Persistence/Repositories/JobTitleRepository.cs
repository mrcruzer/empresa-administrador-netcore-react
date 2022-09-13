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
    public class JobTitleRepository : GenericRepository<JobTitle>, IJobTitleRepository
    {
        private readonly EmpresaContext _dbContext;
        public JobTitleRepository(EmpresaContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
