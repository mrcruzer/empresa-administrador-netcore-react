using Microsoft.AspNetCore.Identity;
using EmpresaAdministrador.Core.Application.Interfaces.Services;
using EmpresaAdministrador.Core.Application.ViewModels.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaAdministrador.Infrastructure.Identity.Services
{
    public class RoleService : IRoleService
    {
        private readonly RoleManager<IdentityRole> _roleManager;

        public RoleService(RoleManager<IdentityRole> roleManager)
        {
            _roleManager = roleManager;
        }

        public List<RoleViewModel> GetAllRoles()
        {
            List<IdentityRole> roles = _roleManager.Roles.ToList();
            List<RoleViewModel> viewModelList = roles.Select(role => new RoleViewModel
            {
                Id = role.Id,
                Name = role.Name
            }).ToList();

            return viewModelList;
        }
    }
}
