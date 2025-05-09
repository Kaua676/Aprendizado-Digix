// Controllers/DisciplinaAlunoCursoController.cs
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sistema_Escolar.DB;
using Sistema_Escolar.DTO;
using Sistema_Escolar.Models;

[ApiController]
[Route("api/[controller]")]
public class DisciplinaAlunoCursoController : ControllerBase
{
    private readonly AppDbContext _context;
    public DisciplinaAlunoCursoController(AppDbContext ctx) => _context = ctx;

    [HttpGet]
    public async Task<ActionResult<IEnumerable<DisciplinaAlunoCursoDTO>>> Get()
    {
        var lista = await _context.DisciplinaAlunoCursos
            .Include(d => d.Aluno)
            .Include(d => d.Curso)
            .Include(d => d.Disciplina)
            .Select(d => new DisciplinaAlunoCursoDTO
            {
                Id = d.AlunoId + d.CursoId + d.DisciplinaId,
                AlunoId = d.AlunoId,
                AlunoNome = d.Aluno.Nome,
                CursoId = d.CursoId,
                CursoDescricao = d.Curso.Descricao,
                DisciplinaId = d.DisciplinaId,
                DisciplinaDescricao = d.Disciplina.Descricao
            })
            .ToListAsync();
        return Ok(lista);
    }

    [HttpPost]
    public async Task<ActionResult<DisciplinaAlunoCursoDTO>> Post([FromBody] CreateDisciplinaAlunoCursoDTO input)
    {
        var a = await _context.Alunos.FindAsync(input.AlunoId)
            ?? return BadRequest("Aluno não encontrado");
        var c = await _context.Cursos.FindAsync(input.CursoId)
            ?? return BadRequest("Curso não encontrado");
        var d = await _context.Disciplinas.FindAsync(input.DisciplinaId)
            ?? return BadRequest("Disciplina não encontrada");

        var ent = new DisciplinaAlunoCurso
        {
            AlunoId = input.AlunoId,
            CursoId = input.CursoId,
            DisciplinaId = input.DisciplinaId
        };
        _context.DisciplinaAlunoCursos.Add(ent);
        await _context.SaveChangesAsync();

        var dto = new DisciplinaAlunoCursoDTO
        {
            Id = ent.AlunoId + ent.CursoId + ent.DisciplinaId,
            AlunoId = ent.AlunoId,
            AlunoNome = a.Nome,
            CursoId = ent.CursoId,
            CursoDescricao = c.Descricao,
            DisciplinaId = ent.DisciplinaId,
            DisciplinaDescricao = d.Descricao
        };
        return CreatedAtAction(nameof(GetById), new { id = dto.Id }, dto);
    }

    [HttpPut("{id}")]
    public async Task<ActionResult> Put(int id, [FromBody] CreateDisciplinaAlunoCursoDTO input)
    {
        var ent = await _context.DisciplinaAlunoCursos.FindAsync(id)
            ?? return NotFound();
        if (!await _context.Alunos.AnyAsync(x => x.Id == input.AlunoId))
            return BadRequest("Aluno não encontrado");
        if (!await _context.Cursos.AnyAsync(x => x.Id == input.CursoId))
            return BadRequest("Curso não encontrado");
        if (!await _context.Disciplinas.AnyAsync(x => x.Id == input.DisciplinaId))
            return BadRequest("Disciplina não encontrada");

        ent.AlunoId = input.AlunoId;
        ent.CursoId = input.CursoId;
        ent.DisciplinaId = input.DisciplinaId;
        await _context.SaveChangesAsync();
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult> Delete(int id)
    {
        var ent = await _context.DisciplinaAlunoCursos.FindAsync(id)
            ?? return NotFound();
        _context.DisciplinaAlunoCursos.Remove(ent);
        await _context.SaveChangesAsync();
        return NoContent();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<DisciplinaAlunoCursoDTO>> GetById(int id)
    {
        var d = await _context.DisciplinaAlunoCursos
            .Include(x => x.Aluno)
            .Include(x => x.Curso)
            .Include(x => x.Disciplina)
            .FirstOrDefaultAsync(x => x.AlunoId + x.CursoId + x.DisciplinaId == id)
            ?? return NotFound("Relação não encontrada");

        return Ok(new DisciplinaAlunoCursoDTO
        {
            Id = id,
            AlunoId = d.AlunoId,
            AlunoNome = d.Aluno.Nome,
            CursoId = d.CursoId,
            CursoDescricao = d.Curso.Descricao,
            DisciplinaId = d.DisciplinaId,
            DisciplinaDescricao = d.Disciplina.Descricao
        });
    }
}
