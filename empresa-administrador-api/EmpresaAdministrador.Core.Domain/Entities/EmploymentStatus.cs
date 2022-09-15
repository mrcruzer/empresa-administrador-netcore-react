using EmpresaAdministrador.Core.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EmpresaAdministrador.Core.Domain.Entities
{
    public class EmploymentStatus : AuditableBaseEntity
    {

        public string Name { get; set; }

        public ICollection<Employee> Employees { get; set; }



    }
}
