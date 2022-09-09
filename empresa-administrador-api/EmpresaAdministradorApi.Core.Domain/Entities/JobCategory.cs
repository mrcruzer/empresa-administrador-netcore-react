using EmpresaAdministradorApi.Core.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EmpresaAdministradorApi.Core.Domain.Entities
{
    public class JobCategory : AuditableBaseEntity
    {

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        public ICollection<Employee> Employees { get; set; }


    }
}
