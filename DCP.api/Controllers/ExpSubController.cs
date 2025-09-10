using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[ApiController]
[Route("api/[controller]")]
public class ExpSubController : ControllerBase
{
    private readonly AppDbContext _context;
    public ExpSubController(AppDbContext context) => _context = context;

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] ExpSub sub)
    {
        sub.EntryDate = DateTime.Now;
        _context.ExpSubs.Add(sub);
        await _context.SaveChangesAsync();
        return Ok(sub);
    }

    [HttpGet("exp-codes")]
    public async Task<IActionResult> GetExpCodes()
    {
        var codes = await _context.ExpendHeads
            .Select(x => x.ExpCode)
            .ToListAsync();
        return Ok(codes);
    }
}
