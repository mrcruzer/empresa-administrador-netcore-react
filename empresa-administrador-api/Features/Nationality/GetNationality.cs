using empresa_administrador_api.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace empresa_administrador_api.DTO.Nationality
{
    public class NationalityDTO
    {
        [Required]
        public string Name { get; set; }

        public ICollection<Employee> Employees { get; set; }
    }
}
