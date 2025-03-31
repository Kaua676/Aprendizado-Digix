using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Correcao_Exercicio.Models;
using Correcao_Exercicio.database;

namespace Correcao_Exercicio.Controller
{
    [ApiController]
    [Route("[controller]")] // /Maquina
    public class MaquinaController : ControllerBase
    {
        private readonly AppDbContext _context;

        public MaquinaController(AppDbContext context)
        {
            _context = context;
        }

        // 1) GET ALL - /Maquina
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Maquina>>> GetAll()
        {
            // Se quiser trazer também os dados do Usuário, use:
            // return await _context.Maquinas
            //    .Include(m => m.Usuario)
            //    .ToListAsync();

            return await _context.Maquinas.ToListAsync();
        }

        // 2) GET BY ID - /Maquina/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Maquina>> GetById(int id)
        {
            // Se quiser incluir o Usuário relacionado:
            // var maquina = await _context.Maquinas
            //    .Include(m => m.Usuario)
            //    .FirstOrDefaultAsync(m => m.MaquinaId == id);

            var maquina = await _context.Maquinas.FindAsync(id);
            if (maquina == null)
                return NotFound();

            return maquina;
        }

        // 3) POST - /Maquina
        [HttpPost]
        public async Task<ActionResult<Maquina>> Post([FromBody] Maquina maquina)
        {
            _context.Maquinas.Add(maquina);
            await _context.SaveChangesAsync();
            return maquina;
        }

        // 4) PUT - /Maquina/5
        [HttpPut("{id}")]
        public async Task<ActionResult<Maquina>> Put(int id, [FromBody] Maquina maquina)
        {
            var existente = await _context.Maquinas.FindAsync(id);
            if (existente == null)
                return NotFound();

            // Atualiza todos os campos relevantes:
            existente.Tipo = maquina.Tipo;
            existente.Velocidade = maquina.Velocidade;
            existente.HardDisk = maquina.HardDisk;
            existente.PlacaRede = maquina.PlacaRede;
            existente.MemoriaRam = maquina.MemoriaRam;
            existente.Id_Usuario = maquina.Id_Usuario;

            // Salva
            await _context.SaveChangesAsync();
            return existente;
        }

        // 5) DELETE - /Maquina/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var existente = await _context.Maquinas.FindAsync(id);
            if (existente == null)
                return NotFound();

            _context.Maquinas.Remove(existente);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
