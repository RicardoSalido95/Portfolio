using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Portfolio.Models;

[ApiController]
public class TesteController : ControllerBase
{
    private readonly AppDbContext _context;

    public TesteController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    [Route("api/[controller]/GetTesteTables")]
    public async Task<ActionResult<IEnumerable<TesteTable>>> GetTesteTables()
    {
        return await _context.TesteTable.ToListAsync();
    }

    [HttpGet]
    [Route("api/[controller]/AddTeste")]
    public async Task<ActionResult> AddTeste()
    {
        int t = 10;
        for (int i = 0; t > i; i++)
        {
            _context.Add(new TesteTable
            {
                Nome = $"Ricardo_{i}",
                Email = $"e-mail_{i}"
            });
        }

        _context.SaveChanges();
        return Ok("Informação inseriada com sucesso");
    }
}