using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaAdministrador.Core.Application.Dtos.Account
{
    public class LoginRequest
    {
        public string UserOrEmail { get; set; }
        public string Password { get; set; }
    }
}
