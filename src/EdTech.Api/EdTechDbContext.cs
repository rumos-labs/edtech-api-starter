using Microsoft.EntityFrameworkCore;

namespace EdTech.Api;

public class EdTechDbContext : DbContext
{
    public EdTechDbContext(DbContextOptions<EdTechDbContext> options) : base(options) { }

    // TODO: Add DbSet properties here
}
