// Controllers/DisciplinaController.cs
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sistema_Escolar.DB;
using Sistema_Escolar.DTO;
using Sistema_Escolar.Models;

[ApiController]
[Route("api/[controller]")]
public class DisciplinaController : ControllerBase
{
    private readonly AppDbContext _context;
    public DisciplinaController(AppDbContext ctx) => _context = ctx;

    [HttpGet]
    public async Task<ActionResult<IEnumerable<DisciplinaDTO>>> Get()
    {
        var lista = await _context.Disciplinas
            .Include(d => d.Curso)
            .Select(d => new DisciplinaDTO
            {
                Id = d.Id,
                Descricao = d.Descricao,
                Curso = d.Curso.Descricao
            })
            .ToListAsync();
        return Ok(lista);
    }

    [HttpPost]
    public async Task<ActionResult<DisciplinaDTO>> Post([FromBody] DisciplinaDTO dto)
    {
        var curso = await _context.Cursos.FirstOrDefaultAsync(c => c.Descricao == dto.Curso)
            ?? return BadRequest("Curso não encontrado")
        var d = new Disciplina { Descricao = dto.Descricao, CursoId = curso.Id };
        _context.Disciplinas.Add(d);
        await _context.SaveChangesAsync();
        dto.Id = d.Id;
        return CreatedAtAction(nameof(GetById), new { id = d.Id }, dto);
    }

    [HttpPut("{id}")]
    public async Task<ActionResult> Put(int id, [FromBody] DisciplinaDTO dto)
    {
        var disc = await _context.Disciplinas.FindAsync(id)
            ?? return NotFound("Disciplina não encontrada");
        var curso = await _context.Cursos.FirstOrDefaultAsync(c => c.Descricao == dto.Curso)
            ?? return BadRequest("Curso não encontrado");
        disc.Descricao = dto.Descricao;
        disc.CursoId = curso.Id;
        await _context.SaveChangesAsync();
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult> Delete(int id)
    {
        var disc = await _context.Disciplinas.FindAsync(id)
            ?? return NotFound("Disciplina não encontrada");
        _context.Disciplinas.Remove(disc);
        await _context.SaveChangesAsync();
        return NoContent();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<DisciplinaDTO>> GetById(int id)
    {
        var d = await _context.Disciplinas
            .Include(x => x.Curso)
            .FirstOrDefaultAsync(x => x.Id == id)
            ?? return NotFound("Disciplina não encontrada");
        return Ok(new DisciplinaDTO
        {
            Id = d.Id,
            Descricao = d.Descricao,
            Curso = d.Curso.Descricao
        });
    }
}
