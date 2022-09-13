using EmpresaAdministrador.Core.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EmpresaAdministrador.Core.Domain.Entities
{
    public class Nationality : AuditableBaseEntity
    {

        //[Required]
        [MaxLength(50)]
        public string Name { get; set; }
        public ICollection<Employee> Employees { get; set; }

    }
}
