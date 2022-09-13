using System.Collections.Generic;
using System.Threading.Tasks;
//using EmpresaAdministrador.Infrastructure.Persistence.Contexts;

namespace EmpresaAdministrador.Core.Application.Interfaces.Repositories
{
    public interface IGenericRepository<Entity> where Entity : class
    {

        //protected EmpresaContext RepositoryContext { get; set; }

        Task<Entity> AddAsync(Entity t);
        Task DeleteAsync(Entity t);
        Task<List<Entity>> GetAllAsync();
        

        //Task<List<Entity>> GetAllWithIncludes(List<string> props);
        Task<Entity> GetByIdAsync(int id);
        //Task<Entity> GetByIdWithIncludes(int id, List<string> props, List<string> colls);
        Task UpdateAsync(Entity t, int id);
    }
}