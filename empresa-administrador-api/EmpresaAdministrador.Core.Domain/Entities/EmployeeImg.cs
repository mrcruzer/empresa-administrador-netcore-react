using EmpresaAdministrador.Core.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaAdministrador.Core.Domain.Entities
{
    public class EmployeeImg : AuditableBaseEntity
    {

        public int EmployeeId   { get; set; }
        public string ImgUrl { get; set; }

        // navigation

        public Employee Employee { get; set; }
    }
}
