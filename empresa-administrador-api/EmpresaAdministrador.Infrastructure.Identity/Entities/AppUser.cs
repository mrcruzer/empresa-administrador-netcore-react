using Microsoft.AspNetCore.Identity;

namespace EmpresaAdministrador.Infrastructure.Identity.Entities
{
    public class AppUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DNI { get; set; }
    }
}