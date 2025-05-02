using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sistema_Escolar.DTO;
using Sistema_Escolar.Models;
using Sistema_Escolar.Services;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;

namespace Sistema_Escolar.Controllers
{
    [ApiController]
    [Route("api/controller")]
    public class LoginController : ControllerBase
    {
        [HttpPost]
        public IActionResult Login([FromBody] LoginDTO LoginDTO)
        {
            if (string.IsNullOrWhiteSpace(LoginDTO.Nome) || string.IsNullOrWhiteSpace(LoginDTO.Senha))
            {
                return BadRequest("Usuarios e senha são obrigatórios");
            }

            var usuarios = new List<Usuario>
            {
                new Usuario { Nome = "admin", Senha = "admin", Cargo = "Administrador" },
                new Usuario { Nome = "Kauã", Senha = "123", Cargo = "Funcionário" }
            };

            var usuario = usuarios.FirstOrDefault(u => u.Nome == LoginDTO.Nome && u.Senha == LoginDTO.Senha);

            if (usuario == null)
            {
                return Unauthorized(new { mensagem = "Usuário ou Senha incorreto." });
            }

            var token = TokenService.GenerateToken(usuario);
            return Ok(new { token });

        }
    }
}