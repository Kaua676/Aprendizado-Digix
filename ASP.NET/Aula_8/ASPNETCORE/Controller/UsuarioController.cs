using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ASPNETCORE.Models;
using ASPNETCORE.database;

namespace ASPNETCORE.Controller
{
    [ApiController]
    [Route("[controller]")] // /Usuario
    public class UsuarioController : ControllerBase
    {
        private readonly AppDbContext _context;

        public UsuarioController(AppDbContext context)
        {
            _context = context;
        }

        // 1) GET ALL: /Usuario
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Usuario>>> GetAll()
        {
            return await _context.Usuarios.ToListAsync();
        }

        // 2) GET BY ID: /Usuario/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Usuario>> GetById(int id)
        {
            var usuario = await _context.Usuarios.FindAsync(id);
            if (usuario == null)
                return NotFound();

            return usuario;
        }

        // 3) POST: /Usuario
        [HttpPost]
        public async Task<ActionResult<Usuario>> Post([FromBody] Usuario usuario)
        {
            _context.Usuarios.Add(usuario);
            await _context.SaveChangesAsync();
            return usuario;
        }

        // 4) PUT: /Usuario/5
        [HttpPut("{id}")]
        public async Task<ActionResult<Usuario>> Put(int id, [FromBody] Usuario usuario)
        {
            var existente = await _context.Usuarios.FindAsync(id);
            if (existente == null)
                return NotFound();

            existente.Nome = usuario.Nome;
            existente.Senha = usuario.Senha;
            existente.Ramal = usuario.Ramal;
            existente.Especialidade = usuario.Especialidade;

            _context.Usuarios.Update(existente);
            await _context.SaveChangesAsync();
            return existente;
        }

        // 5) DELETE: /Usuario/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var existente = await _context.Usuarios.FindAsync(id);
            if (existente == null)
                return NotFound();

            _context.Usuarios.Remove(existente);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
