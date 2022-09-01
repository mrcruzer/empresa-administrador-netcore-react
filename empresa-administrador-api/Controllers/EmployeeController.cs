﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using empresa_administrador_api.Models;
using empresa_administrador_api.Models.Common;
using empresa_administrador_api.Data;
using Swashbuckle.AspNetCore.Annotations;

namespace empresa_administrador_api.Controllers
{
    [Route("api/[controller]")]
    [SwaggerTag("Mantenimiento de Empleados")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly EmpresaDbContext _context;

        public EmployeeController(EmpresaDbContext context)
        {
            _context = context;
        }

       // Obtener Empleados
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Employee>>> GetEmpleados()
        {
            return await _context.Employees.ToListAsync();
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<Employee>> GetEmpleado(int id)
        {
            var empleado = await _context.Employees.FindAsync(id);

            if (empleado == null)
            {
                return NotFound();
            }

            return empleado;
        }

        // PUT: api/Empleado/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEmpleado(int id, Employee empleado)
        {
            if (id != empleado.Id)
            {
                return BadRequest();
            }

            _context.Entry(empleado).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EmpleadoExists(id))
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

       
        [HttpPost]
        public async Task<ActionResult<Employee>> PostEmpleado(Employee empleado)
        {
            _context.Employees.Add(empleado);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEmpleado", new { id = empleado.Id }, empleado);
        }

        
        [HttpDelete("{id}")]
        public async Task<ActionResult<Employee>> DeleteEmpleado(int id)
        {
            var empleado = await _context.Employees.FindAsync(id);
            if (empleado == null)
            {
                return NotFound();
            }

            _context.Employees.Remove(empleado);
            await _context.SaveChangesAsync();

            return empleado;
        }

        private bool EmpleadoExists(int id)
        {
            return _context.Employees.Any(e => e.Id == id);
        }
    }
}