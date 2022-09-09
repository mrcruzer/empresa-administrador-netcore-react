using MediatR;
using Swashbuckle.AspNetCore.Annotations;
using System.ComponentModel.DataAnnotations;

namespace EmpresaAdministrador.Core.Application.Features.Nationality.Commands.CreateNationality
{
    public class CreateNationalityCommand : IRequest<bool>
    {
        [Required]
        [SwaggerParameter(Description = "Nombre de la nacionalidad")]
        public string Name { get; set; }
    }
}