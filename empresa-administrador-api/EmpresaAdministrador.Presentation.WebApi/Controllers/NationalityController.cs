using EmpresaAdministrador.Core.Application.Dtos.API.Nationality;
using EmpresaAdministrador.Core.Application.Features.Nationality.Commands.CreateNationality;
using EmpresaAdministrador.Core.Application.Features.Nationality.Commands.DeleteNationality;
using EmpresaAdministrador.Core.Application.Features.Nationality.Commands.UpdateNationality;
using EmpresaAdministrador.Core.Application.Features.Nationality.Queries.GetNationalityById;
using EmpresaAdministrador.Core.Application.Features.Nationality.Queries.ListNationality;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstateApp.Presentation.WebApi.Controllers;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Net.Mime;
using System.Threading.Tasks;

namespace EmpresaAdministrador.Presentation.WebApi.Controllers
{
    //[ApiVersion("1.0")]
    
    [SwaggerTag("Mantenimiento de Tipos de Propiedades")]
    public class NationalityController : BaseApiController
    {
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /*//[Authorize(Roles = "Admin")]
         [HttpPost("Create")]
         [Consumes(MediaTypeNames.Application.Json)]
         [ProducesResponseType(StatusCodes.Status204NoContent)]
         [ProducesResponseType(StatusCodes.Status400BadRequest)]
         [ProducesResponseType(StatusCodes.Status500InternalServerError)]
         [SwaggerOperation(
             Summary = "Crear Nacionalidad de empleado",
             Description = "Crea nacionalidad de empleado"
             )]
         public async Task<IActionResult> Post([FromBody] CreateNationalityCommand request)
         {
             try
             {
                 if (!ModelState.IsValid)
                     return BadRequest();

                 var wasCreated = await Mediator.Send(request);

                 if (wasCreated)
                     return NoContent();

                 return StatusCode(StatusCodes.Status500InternalServerError, "Ha ocurrido un error creando la nacionalidad");
             }
             catch (Exception ex)
             {
                 return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
             }
         }*/

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /*//[Authorize(Roles = "Admin")]
        [HttpPut("Update")]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(NationalityResponse))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [SwaggerOperation(
            Summary = "Editar Nacionalidad de empleado",
            Description = "Edita Nacionalidad de empleado segun los datos suministrados en formato JSON y modifica el registro correspondiente al Id"
            )]
        public async Task<IActionResult> Put([FromBody] UpdateNationalityCommand request)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest();

                var response = await Mediator.Send(request);

                if (response == null)
                    return NotFound();

                return Ok(response);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }*/

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        [HttpGet("List")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(NationalityResponse))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [SwaggerOperation(
            Summary = "Listar Nacionalidades de empleados",
            Description = "Lista todas las nacionalidades guardados en la base de datos"
            )]
        public async Task<IActionResult> Get()
        {
            try
            {
                var response = await Mediator.Send(new ListNationalityQuery());

                if (response == null || response.Count == 0)
                    return NotFound();

                return Ok(response);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        [HttpGet("GetById/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(NationalityResponse))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [SwaggerOperation(
            Summary = "Nacionalidades de empleados por Id",
            Description = "Muestra los datos de Nacionalidades de empleados correspondiente al Id suministrado"
            )]
        public async Task<IActionResult> Get([FromRoute] int id)
        {
            try
            {
                var response = await Mediator.Send(new GetNationalityByIdQuery
                {
                    Id = id
                });

                if (response == null)
                    return NotFound();

                return Ok(response);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /*//[Authorize(Roles = "Admin")]
        [HttpDelete("Delete/{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [SwaggerOperation(
            Summary = "Eliminar Nacionalidad de empleado",
            Description = "Eliminar Nacionalidad de empleado correspondiente al Id suministrado"
            )]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            try
            {
                var response = await Mediator.Send(new DeleteNationalityCommand
                {
                    Id = id
                });

                if (response)
                    return NoContent();

                return NotFound($"No existe la Nacionalidad con el Id '{id}'");
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }*/
    }
}
