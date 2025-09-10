using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<User> Users { get; set; }
    public DbSet<ExpendHead> ExpendHeads { get; set; }
    public DbSet<ExpSub> ExpSubs { get; set; }
    public DbSet<Expend> Expends { get; set; }
}
