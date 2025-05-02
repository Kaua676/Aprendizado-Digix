using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sistema_Escolar.Models;
using Sistema_Escolar.DTO;
using Sistema_Escolar.DB;

namespace Sistema_Escolar.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CursoController : ControllerBase
    {
        private readonly AppDbContext _context;

        public CursoController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<CursoDTO>>> Get()
        {
            var curso = await _context.Cursos
                .Select(c => new CursoDTO
                {
                    Id = c.Id,
                    Descricao = c.Descricao
                })
                .ToListAsync();

            return Ok(curso);
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] CursoDTO cursoDTO)
        {
            var curso = new Curso
            {
                Descricao = cursoDTO.Descricao
            };

            _context.Cursos.Add(curso);
            await _context.SaveChangesAsync();

            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] CursoDTO cursoDTO)
        {
            var curso = await _context.Cursos.FindAsync(id);
            if (curso == null)
                return NotFound("Curso não encontrado!");

            curso.Descricao = cursoDTO.Descricao;

            _context.Cursos.Update(curso);
            await _context.SaveChangesAsync();

            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var curso = await _context.Cursos.FindAsync(id);
            if (curso == null)
                return NotFound("Curso não encontrado!");

            _context.Cursos.Remove(curso);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<CursoDTO>> Get(int id)
        {
            var curso = await _context.Cursos.FindAsync(id);
            if (curso == null)
            {
                return NotFound("Curso não encontrado!");
            }
            var cursoDTO = new CursoDTO
            {
                Id = curso.Id,
                Descricao = curso.Descricao
            };

            return Ok(cursoDTO);
        }
    }
}
