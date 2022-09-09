using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EmpresaAdministradorApi.Core.Domain
{
    public abstract class AuditableBaseEntity
    {
        public int Id { get; set; }
        public DateTime Created { get; set; }
    }
}
