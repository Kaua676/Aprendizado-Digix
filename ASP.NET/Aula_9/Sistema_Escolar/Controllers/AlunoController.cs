// Controllers/AlunoController.cs
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sistema_Escolar.DB;
using Sistema_Escolar.DTO;
using Sistema_Escolar.Models;

[ApiController]
[Route("api/[controller]")]
public class AlunoController : ControllerBase
{
    private readonly AppDbContext _context;
    public AlunoController(AppDbContext ctx) => _context = ctx;

    [HttpGet]
    public async Task<ActionResult<IEnumerable<AlunoDTO>>> Get()
    {
        var lista = await _context.Alunos
            .Include(a => a.Curso)
            .Select(a => new AlunoDTO
            {
                Id = a.Id,
                Nome = a.Nome,
                Curso = a.Curso.Descricao
            })
            .ToListAsync();
        return Ok(lista);
    }

    [HttpPost]
    public async Task<ActionResult<AlunoDTO>> Post([FromBody] AlunoDTO dto)
    {
        var curso = await _context.Cursos.FirstOrDefaultAsync(c => c.Descricao == dto.Curso)
            ?? return BadRequest("Curso não encontrado");
        var aluno = new Aluno { Nome = dto.Nome, CursoId = curso.Id };
        _context.Alunos.Add(aluno);
        await _context.SaveChangesAsync();

        dto.Id = aluno.Id;
        return CreatedAtAction(nameof(Get), new { id = aluno.Id }, dto);
    }

    [HttpPut("{id}")]
    public async Task<ActionResult> Put(int id, [FromBody] AlunoDTO dto)
    {
        var aluno = await _context.Alunos.FindAsync(id)
            ?? return NotFound("Aluno não encontrado");
        var curso = await _context.Cursos.FirstOrDefaultAsync(c => c.Descricao == dto.Curso)
            ?? return BadRequest("Curso não encontrado");
        aluno.Nome = dto.Nome;
        aluno.CursoId = curso.Id;
        await _context.SaveChangesAsync();
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult> Delete(int id)
    {
        var aluno = await _context.Alunos.FindAsync(id)
            ?? return NotFound("Aluno não encontrado");
        _context.Alunos.Remove(aluno);
        await _context.SaveChangesAsync();
        return NoContent();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<AlunoDTO>> Get(int id)
    {
        var a = await _context.Alunos
            .Include(x => x.Curso)
            .FirstOrDefaultAsync(x => x.Id == id)
            ?? return NotFound("Aluno não encontrado");
        return Ok(new AlunoDTO { Id = a.Id, Nome = a.Nome, Curso = a.Curso.Descricao });
    }
}
