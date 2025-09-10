using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class UsersController : ControllerBase
{
    private readonly AppDbContext _context;
    public UsersController(AppDbContext context) => _context = context;

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] User user)
    {
        user.EntryDate = DateTime.Now;
        _context.Users.Add(user);
        await _context.SaveChangesAsync();
        return Ok(user);
    }
}
