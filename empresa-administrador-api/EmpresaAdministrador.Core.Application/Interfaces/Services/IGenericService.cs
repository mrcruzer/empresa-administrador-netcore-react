/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaAdministrador.Core.Application.Interfaces.Services
{
    public interface IGenericService<ViewModel, SaveViewModel>
        where ViewModel : class
        where SaveViewModel : class
    {
        Task<SaveViewModel> Add(SaveViewModel vm);
        Task Delete(int id);
        Task<List<ViewModel>> GetAllViewModel();
        Task<SaveViewModel> GetByIdSaveViewModel(int id);
        //Task<ViewModel> GetByIdViewModel(int id);
        Task Update(SaveViewModel saveViewModel, int id);
    }
}*/
