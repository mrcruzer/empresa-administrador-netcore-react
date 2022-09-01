using empresa_administrador_api.Models.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace empresa_administrador_api.Models
{
    public class SubUnit : AuditableBaseEntity
    {

        [Column(TypeName = "VARCHAR(50)")]
        public string Name { get; set; }

        [Column(TypeName = "VARCHAR(100)")]
        public string Description { get; set; }

        public ICollection<Employee> Employees { get; set; }


    }
}
