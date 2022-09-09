using EmpresaAdministrador.Core.Application.ViewModels.Nationality;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EmpresaAdministrador.Core.Application.Interfaces.Services
{
    public interface INationalityService : IGenericService<NationalityViewModel, SaveNationalityViewModel>
    {
        //Task<List<PropertyTypeViewModel>> GetAllViewModelWithInclude();
    }
}