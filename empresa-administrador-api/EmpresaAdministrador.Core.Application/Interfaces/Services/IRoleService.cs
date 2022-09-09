using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaAdministrador.Core.Application.Interfaces.Services
{
    public interface IRoleService
    {
        List<RoleViewModel> GetAllRoles();
    }
}
