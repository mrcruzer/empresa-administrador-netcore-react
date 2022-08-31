using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace empresa_administrador_api.Models
{
    public class EmploymentStatus
    {
        [Key]
        public int Id { get; set; }

        [Column(TypeName = "VARCHAR(100)")]
        public string Name { get; set; }

        public ICollection<Employee> Employees { get; set; }



    }
}
