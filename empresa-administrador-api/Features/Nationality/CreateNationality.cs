using System.ComponentModel.DataAnnotations;

namespace empresa_administrador_api.DTO.Nationality
{
    public class CreateNationalityDTO
    {
        [Required]
        public string Name { get; set; }
    }
}
