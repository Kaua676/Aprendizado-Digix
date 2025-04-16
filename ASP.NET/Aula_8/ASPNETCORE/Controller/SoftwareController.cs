using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ASPNETCORE.Models;
using ASPNETCORE.database;

namespace ASPNETCORE.Controller
{
    [ApiController]
    [Route("[controller]")] // /Software
    public class SoftwareController : ControllerBase
    {
        private readonly AppDbContext _context;

        public SoftwareController(AppDbContext context)
        {
            _context = context;
        }

        // 1) GET ALL - /Software
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Software>>> GetAll()
        {
            // Se quiser trazer a máquina relacionada:
            // return await _context.Softwares
            //    .Include(s => s.Maquina)
            //    .ToListAsync();

            return await _context.Softwares.ToListAsync();
        }

        // 2) GET BY ID - /Software/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Software>> GetById(int id)
        {
            // Incluindo a navegação de Maquina:
            var software = await _context.Softwares
                .Include(s => s.Maquina)
                .FirstOrDefaultAsync(s => s.SoftwareId == id);

            if (software == null)
                return NotFound();

            return software;
        }

        // 3) POST - /Software
        [HttpPost]
        public async Task<ActionResult<Software>> Post([FromBody] Software software)
        {
            _context.Softwares.Add(software);
            await _context.SaveChangesAsync();
            return software;
        }

        // 4) PUT - /Software/5
        [HttpPut("{id}")]
        public async Task<ActionResult<Software>> Put(int id, [FromBody] Software software)
        {
            var existente = await _context.Softwares.FindAsync(id);
            if (existente == null)
                return NotFound();

            existente.Produto = software.Produto;
            existente.HardDisk = software.HardDisk;
            existente.MemoriaRam = software.MemoriaRam;
            existente.MaquinaId = software.MaquinaId;

            _context.Softwares.Update(existente);
            await _context.SaveChangesAsync();
            return existente;
        }

        // 5) DELETE - /Software/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var existente = await _context.Softwares.FindAsync(id);
            if (existente == null)
                return NotFound();

            _context.Softwares.Remove(existente);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
