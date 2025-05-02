using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Sistema_Escolar.Models;
using Sistema_Escolar.DTO;
using Sistema_Escolar.DB;

namespace Sistema_Escolar.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AlunoController : ControllerBase
    {
        private readonly AppDbContext _context;

        public AlunoController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<AlunoDTO>>> Get()
        {
            var alunos = await _context.Alunos
                .Include(a => a.Curso)
                .Select(a => new AlunoDTO
                {
                    Id = a.Id,
                    Nome = a.Nome,
                    Curso = a.Curso.Descricao
                })
                .ToListAsync();

            return Ok(alunos);
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] AlunoDTO alunoDTO)
        {
            var curso = await _context.Cursos.FirstOrDefaultAsync(c => c.Descricao == alunoDTO.Curso);
            if (curso == null) return BadRequest("Curso não encontrado");

            var aluno = new Aluno
            {
                Nome = alunoDTO.Nome,
                CursoId = curso.Id
            };

            _context.Alunos.Add(aluno);
            await _context.SaveChangesAsync();

            return Ok(new { mensagem = "Aluno cadastrado com sucesso!" });
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] AlunoDTO alunoDTO)
        {
            var aluno = await _context.Alunos.FindAsync(id);
            if (aluno == null)
                return NotFound("Aluno não encontrado!");

            var curso = await _context.Cursos.FirstOrDefaultAsync(c => c.Descricao == alunoDTO.Curso);
            if (curso == null)
                return BadRequest("Curso não encontrado!");

            aluno.Nome = alunoDTO.Nome;
            aluno.CursoId = curso.Id;

            await _context.SaveChangesAsync();

            return Ok(new { mensagem = "Aluno atualizado com sucesso!" });
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var aluno = await _context.Alunos.FindAsync(id);
            if (aluno == null)
                return NotFound("Aluno não encontrado!");

            _context.Alunos.Remove(aluno);
            await _context.SaveChangesAsync();

            return Ok(new { mensagem = "Aluno removido com sucesso!" });
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<AlunoDTO>> Get(int id)
        {
            var aluno = await _context.Alunos
                .Include(a => a.Curso)
                .FirstOrDefaultAsync(a => a.Id == id);
            if (aluno == null)
            {
                return NotFound("Aluno não encontrado!");
            }
            var alunoDTO = new AlunoDTO
            {
                Id = aluno.Id,
                Nome = aluno.Nome,
                Curso = aluno.Curso.Descricao
            };

            return Ok(alunoDTO);
        }
    }
}