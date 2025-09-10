using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class ExpendHeadController : ControllerBase
{
    private readonly AppDbContext _context;
    public ExpendHeadController(AppDbContext context) => _context = context;

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] ExpendHead head)
    {
        head.EntryDate = DateTime.Now;
        _context.ExpendHeads.Add(head);
        await _context.SaveChangesAsync();
        return Ok(head);
    }
}
