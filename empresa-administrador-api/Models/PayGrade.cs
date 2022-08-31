using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace empresa_administrador_api.Models
{
    public class PayGrade
    {
        [Key]
        public int Id { get; set; }

        [Column(TypeName = "VARCHAR(50)")]
        public string Name { get; set; }

        public int Currency { get; set; }

        public ICollection<Employee> Employees { get; set; }


    }
}
