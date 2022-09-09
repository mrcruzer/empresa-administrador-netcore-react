using EmpresaAdministradorApi.Core.Application.ViewModels.Nationality;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EmpresaAdministradorApi.Core.Application.Interfaces.Services
{
    public interface INationalityService : IGenericService<NationalityViewModel, SaveNationalityViewModel>
    {
        //Task<List<PropertyTypeViewModel>> GetAllViewModelWithInclude();
    }
}