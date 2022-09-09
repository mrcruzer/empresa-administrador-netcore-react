using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using empresa_administrador_api.Data;
using empresa_administrador_api.Models;
using Swashbuckle.AspNetCore.Annotations;
using empresa_administrador_api.Dtos.API.Nationality;
using empresa_administrador_api.Features.Nationality.Queries.ListNationality;
using empresa_administrador_api.Features.Nationality.Queries.GetNationalityById;
using MediatR;

namespace empresa_administrador_api.Controllers
{
    [SwaggerTag("Mantenimiento de Nacionalidades")]
    [ApiController]
    public class NationalityController : BaseApiController
    {
        /*private readonly EmpresaDbContext _context;
        private readonly IMediator _mediator;

        public NationalityController(EmpresaDbContext context)
        {
            _context = context;
        }*/

        
        [HttpGet("List")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(NationalityResponse))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(NationalityResponse))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [Produces("application/json")]
        [SwaggerOperation(Summary="Listado de nacionalidades", Description = "Listado de nacionalidades")]
        /*public async Task<ActionResult<IEnumerable<Nationality>>> Get()
        {
            return await _context.Nationalities.Include(employee => employee.Employees).ToListAsync();
        }*/

        public async Task<IActionResult> Get()
        {
            try
            {
                //var response = await _context.Nationalities.Include(employee => employee.Employees).ToListAsync();
                var response = await Mediator.Send(new ListNationalityQuery());
                //var res();

                if (response == null || response.Count() == 0)
                    return NotFound();

                return Ok(response);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpGet("GetById/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(NationalityResponse))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [Produces("application/json")]
        [SwaggerOperation(
           Summary = "Nacionalidad por Id",
           Description = "Muestra los datos de la nacionalidad correspondiente al Id suministrado"
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

        /*public async Task<ActionResult<NationalityResponse> GetNationality(int id)
        {
            //var nationality = await _context.Nationalities.Include(employee => employee.Employees).FirstOrDefaultAsync(x => x.Id == id);
           // var nationalityDTO = new NationalityResponse() { Name = nationality.Name };

            if (nationalityDTO == null)
            {
                return NotFound();
            }

            return nationalityDTO;
        }*/



        /*[HttpGet("GetById/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(NationalityResponse))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [Produces("application/json")]
        [SwaggerOperation(
           Summary = "Nacionalidad por Id",
           Description = "Muestra los datos de la nacionalidad correspondiente al Id suministrado"
           )]*/
        // PUT: api/Nationality/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        /* [HttpPut("{id}")]
         //[Produces("application/json")]
         public async Task<IActionResult> PutNationality(int id, Nationality nationality)
         {
             if (id != nationality.Id)
             {
                 return BadRequest();
             }

             _context.Entry(nationality).State = EntityState.Modified;

             try
             {
                 await _context.SaveChangesAsync();
             }
             catch (DbUpdateConcurrencyException)
             {
                 if (!NationalityExists(id))
                 {
                     return NotFound();
                 }
                 else
                 {
                     throw;
                 }
             }

             return NoContent();
         }*/

        // POST: api/Nationality
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        /* [HttpPost]
         [Produces("application/json")]
         [SwaggerResponse(200)]
         public async Task<ActionResult<Nationality>> PostNationality(CreateNationality createNationalityDTO)
         {

             var nationality = new Nationality() { Name = createNationalityDTO.Name }; 
             _context.Nationalities.Add(nationality);
             await _context.SaveChangesAsync();

             return CreatedAtAction("GetNationality", new { id = nationality.Id }, createNationalityDTO);
         }

         // DELETE: api/Nationality/5
         [HttpDelete("{id}")]
         [Produces("application/json")]
         public async Task<IActionResult> DeleteNationality(int id)
         {
             var nationality = await _context.Nationalities.FindAsync(id);
             if (nationality == null)
             {
                 return NotFound();
             }

             _context.Nationalities.Remove(nationality);
             await _context.SaveChangesAsync();

             return NoContent();
         }

         private bool NationalityExists(int id)
         {
             return _context.Nationalities.Any(e => e.Id == id);
         }*/
    }
}
