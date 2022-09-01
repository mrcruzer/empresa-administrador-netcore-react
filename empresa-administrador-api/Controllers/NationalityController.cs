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

namespace empresa_administrador_api.Controllers
{
    [Route("api/[controller]")]
    [SwaggerTag("Mantenimiento de Nacionalidades")]
    [ApiController]
    public class NationalityController : ControllerBase
    {
        private readonly EmpresaDbContext _context;

        public NationalityController(EmpresaDbContext context)
        {
            _context = context;
        }

        
        [HttpGet]
        [Produces("application/json")]
        [SwaggerOperation(Summary="Listado de nacionalidades", Description = "Listar todas las nacionalidades")]
        public async Task<ActionResult<IEnumerable<Nationality>>> GetNationalities()
        {
            return await _context.Nationalities.ToListAsync();
        }

        // GET: api/Nationality/5
        [HttpGet("{id}")]
        [Produces("application/json")]
        public async Task<ActionResult<Nationality>> GetNationality(int id)
        {
            var nationality = await _context.Nationalities.FindAsync(id);

            if (nationality == null)
            {
                return NotFound();
            }

            return nationality;
        }

        // PUT: api/Nationality/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        [Produces("application/json")]
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
        }

        // POST: api/Nationality
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        [Produces("application/json")]
        public async Task<ActionResult<Nationality>> PostNationality(Nationality nationality)
        {
            _context.Nationalities.Add(nationality);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetNationality", new { id = nationality.Id }, nationality);
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
        }
    }
}
