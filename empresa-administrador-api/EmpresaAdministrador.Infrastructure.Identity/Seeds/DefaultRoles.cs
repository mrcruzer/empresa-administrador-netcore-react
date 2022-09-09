using Microsoft.AspNetCore.Identity;
using EmpresaAdministrador.Core.Application.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaAdministrador.Infrastructure.Identity.Seeds
{
    public static class DefaultRoles
    {
        public static async Task SeedsAsync(RoleManager<IdentityRole> roleManager)
        {
            await roleManager.CreateAsync(new IdentityRole(Roles.Admin.ToString()));
      
        }
    }
}