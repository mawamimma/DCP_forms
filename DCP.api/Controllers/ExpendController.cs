using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[ApiController]
[Route("api/[controller]")]
public class ExpendController : ControllerBase
{
    private readonly AppDbContext _context;
    public ExpendController(AppDbContext context) => _context = context;

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] Expend expend)
    {
        expend.EntryDate = DateTime.Now;
        _context.Expends.Add(expend);
        await _context.SaveChangesAsync();
        return Ok(expend);
    }

    [HttpGet("sub-codes")]
    public async Task<IActionResult> GetExpSubCodes()
    {
        var codes = await _context.ExpSubs
            .Select(x => x.ExpSubCode)
            .ToListAsync();
        return Ok(codes);
    }
}
