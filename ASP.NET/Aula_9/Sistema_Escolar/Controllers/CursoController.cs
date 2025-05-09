// Controllers/CursoController.cs
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sistema_Escolar.DB;
using Sistema_Escolar.DTO;
using Sistema_Escolar.Models;

[ApiController]
[Route("api/[controller]")]
public class CursoController : ControllerBase
{
    private readonly AppDbContext _context;
    public CursoController(AppDbContext ctx) => _context = ctx;

    [HttpGet]
    public async Task<ActionResult<IEnumerable<CursoDTO>>> Get()
    {
        var lista = await _context.Cursos
            .Select(c => new CursoDTO { Id = c.Id, Descricao = c.Descricao })
            .ToListAsync();
        return Ok(lista);
    }

    [HttpPost]
    public async Task<ActionResult<CursoDTO>> Post([FromBody] CursoDTO dto)
    {
        var curso = new Curso { Descricao = dto.Descricao };
        _context.Cursos.Add(curso);
        await _context.SaveChangesAsync();
        dto.Id = curso.Id;
        return CreatedAtAction(nameof(Get), new { id = curso.Id }, dto);
    }

    [HttpPut("{id}")]
    public async Task<ActionResult> Put(int id, [FromBody] CursoDTO dto)
    {
        var curso = await _context.Cursos.FindAsync(id)
            ?? return NotFound("Curso não encontrado");
        curso.Descricao = dto.Descricao;
        await _context.SaveChangesAsync();
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult> Delete(int id)
    {
        var curso = await _context.Cursos.FindAsync(id)
            ?? return NotFound("Curso não encontrado");
        _context.Cursos.Remove(curso);
        await _context.SaveChangesAsync();
        return NoContent();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<CursoDTO>> Get(int id)
    {
        var c = await _context.Cursos.FindAsync(id)
            ?? return NotFound("Curso não encontrado");
        return Ok(new CursoDTO { Id = c.Id, Descricao = c.Descricao });
    }
}
