using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Endpoints.Models; // Importa o modelo da entidade Maquina
using Endpoints.database; // Importa o contexto do banco de dados

using Microsoft.EntityFrameworkCore; // Importa funcionalidades do Entity Framework Core
using Microsoft.AspNetCore.Mvc; // Importa funcionalidades do ASP.NET Core MVC

namespace Endpoints.Controller
{
    [ApiController] // Define que essa classe é um controlador de API
    [Route("[controller]")] // Define a rota base do controlador (exemplo: /Maquina)
    public class MaquinaController : ControllerBase
    {
        private readonly AppDbContext _context; // Representa a conexão com o banco de dados

        public MaquinaController(AppDbContext context) // Construtor que recebe o contexto do banco de dados
        {
            _context = context; // Inicializa o contexto para ser usado nos métodos
        }

        [HttpGet] // Define um endpoint para requisições GET
        public async Task<IEnumerable<Maquina>> Get() // Retorna uma lista de todas as máquinas
        {
            return await _context.Maquinas.ToListAsync(); // Busca todas as máquinas no banco de dados
        }

        [HttpPost] // Define um endpoint para requisições POST
        public async Task<ActionResult<Maquina>> Post([FromBody] Maquina maquina)
        {
            _context.Maquinas.Add(maquina); // Adiciona a nova máquina ao banco de dados
            await _context.SaveChangesAsync(); // Salva a alteração no banco
            return maquina; // Retorna o objeto cadastrado
        }

        [HttpPut("{id}")] // Define um endpoint para requisições PUT, esperando um ID na URL
        public async Task<ActionResult<Maquina>> Put(int id, [FromBody] Maquina maquina)
        {
            var existente = await _context.Maquinas.FindAsync(id); // Busca a máquina pelo ID
            if (existente == null) return NotFound(); // Retorna erro 404 se não encontrar

            existente.Tipo = maquina.Tipo; // Atualiza o campo necessário
            await _context.SaveChangesAsync(); // Salva as alterações no banco
            return existente; // Retorna o objeto atualizado
        }

        [HttpDelete("{id}")] // Define um endpoint para requisições DELETE, esperando um ID na URL
        public async Task<ActionResult> Delete(int id)
        {
            var existente = await _context.Maquinas.FindAsync(id); // Busca a máquina pelo ID
            if (existente == null) return NotFound(); // Retorna erro 404 se não encontrar

            _context.Maquinas.Remove(existente); // Remove a máquina do banco de dados
            await _context.SaveChangesAsync(); // Salva as alterações
            return NoContent(); // Retorna um status 204 (sem conteúdo)
        }
    }
}
