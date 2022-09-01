using empresa_administrador_api.Models.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace empresa_administrador_api.Models
{
    public class Employee : AuditableBaseEntity
    {

        [Column(TypeName = "VARCHAR(100)")]
        public string Name { get; set; }

        [Column(TypeName = "VARCHAR(100)")]
        public string LastName { get; set; }

        [Column(TypeName = "VARCHAR(100)")]
        public string Address { get; set; }

        [Column(TypeName = "VARCHAR(100)")]
        public string City { get; set; }

        [Column(TypeName = "VARCHAR(100)")]
        public string Province { get; set; }

        [Column(TypeName = "VARCHAR(100)")]
        public string Country { get; set; }


        [Column(TypeName = "VARCHAR(25)")]
        public string Gender { get; set; }

        public long Telephone { get; set; }

        [Column(TypeName = "VARCHAR(100)")]
        public string Email { get; set; }


        // Relations
        public Nationality Nationality { get; set; }

        /*public JobTitle JobTitle { get; set; }

        public JobCategory JobCategory { get; set; }*/

    }
}
