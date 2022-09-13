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
    public class JobCategoryRepository : GenericRepository<JobCategory>, IJobCategoryRepository
    {
        private readonly EmpresaContext _dbContext;

        public JobCategoryRepository(EmpresaContext dbContext ) : base(dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
