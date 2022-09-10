﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using EmpresaAdministrador.Core.Application.Dtos.Account;
using EmpresaAdministrador.Core.Application.Interfaces.Services;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Net.Mime;
using System.Threading.Tasks;


namespace RealEstateApp.Presentation.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [SwaggerTag("Autenticar usuarios y crear nuevos Usuarios")]
    public class UserController : ControllerBase
    {
        private readonly IAccountService _accountService;

        public UserController(IAccountService accountService)
        {
            _accountService = accountService;
        }

        [HttpPost("Login")]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(LoginResponse))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [SwaggerOperation(
            Summary = "Inicia sesion",
            Description = "Inicia sesion con los datos suministrados y devuelve los datos del usuario que ha iniciado junto con su JWT"
            )]
        public async Task<IActionResult> Login([FromBody] LoginRequest request)
        {
            return Ok(await _accountService.LoginAsync(request));
        }

        

        [Authorize(Roles = "Admin")]
        [HttpPost("RegisterAdmin")]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [SwaggerOperation(
            Summary = "Crea un nuevo Admin",
            Description = "Crea un nuevo usuario con el rol de Admin con los datos suministrados"
            )]
        public async Task<IActionResult> RegisterAdminAsync([FromBody] RegisterRequest request)
        {
            try
            {
                var user = await _accountService.RegisterAdminUserAsync(request);
                if (user == null)
                {
                    return StatusCode(StatusCodes.Status500InternalServerError);
                }
                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
    }
}
