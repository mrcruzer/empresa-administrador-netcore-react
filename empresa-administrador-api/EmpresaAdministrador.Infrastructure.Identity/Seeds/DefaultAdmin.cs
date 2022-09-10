using Microsoft.AspNetCore.Identity;
using EmpresaAdministrador.Core.Application.Enums;
using EmpresaAdministrador.Infrastructure.Identity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaAdministrador.Infrastructure.Identity.Seeds
{
    public static class DefaultAdmin
    {
        public static async Task SeedsAsync(UserManager<AppUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            AppUser defaultUser = new AppUser
            {
                FirstName = "Admin",
                LastName = "User",
                UserName = "AdminUser",
                Email = "adminuser@email.com",
                DNI = null,
                EmailConfirmed = true,
                PhoneNumberConfirmed = true
            };

            if (userManager.Users.All(user => user.Id != defaultUser.Id))
            {
                AppUser user = await userManager.FindByEmailAsync(defaultUser.Email);

                if (user == null)
                {
                    await userManager.CreateAsync(defaultUser, "certificado14");
                    await userManager.AddToRoleAsync(defaultUser, Roles.Admin.ToString());
                }
            }
        }
    }
}