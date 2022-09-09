using empresa_administrador_api.Data;
using empresa_administrador_api.Interfaces.Repositories;
using empresa_administrador_api.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace empresa_administrador_api.Repositories
{
    public class GenericRepository<Entity> : IGenericRepository<Entity> where Entity : class
    {
        protected readonly EmpresaDbContext _context;
        private readonly DbSet<Entity> _entitiySet;

        public GenericRepository(EmpresaDbContext context)
        {
            _context = context;
            _entitiySet = context.Set<Entity>();
        }

        /*public async Task<T> GetAsync(Expression<Func<T, bool>> expression, CancellationToken cancellationToken = default)
          => await _entitiySet.FirstOrDefaultAsync(expression);*/
    }
}