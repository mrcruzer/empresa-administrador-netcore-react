﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaAdministradorApi.Core.Application.Interfaces.Services
{
    public interface IRoleService
    {
        List<RoleViewModel> GetAllRoles();
    }
}