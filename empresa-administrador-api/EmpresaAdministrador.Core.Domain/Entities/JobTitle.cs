using EmpresaAdministrador.Core.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EmpresaAdministrador.Core.Domain.Entities
{
    public class JobTitle : AuditableBaseEntity
    {
      
      //  [MaxLength(50)]
        public string Name { get; set; }

       // [MaxLength(100)]
        public string Description { get; set; }

        public ICollection<Employee> Employees { get; set; }


    }
}
