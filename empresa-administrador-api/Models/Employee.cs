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
        public string Direccion { get; set; }

        public int Edad { get; set; }


        public long Nomina { get; set; }

        [Column(TypeName = "VARCHAR(50)")]
        public string TipoNomina { get; set; }


        public long Telefono { get; set; }

        [Column(TypeName = "VARCHAR(100)")]
        public string Email { get; set; }

        [Column(TypeName = "VARCHAR(100)")]
        public string Posicion { get; set; }
    }
}
