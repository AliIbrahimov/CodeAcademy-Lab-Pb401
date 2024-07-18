using EFCorePractise.Entities;
using Microsoft.EntityFrameworkCore;

namespace EFCorePractise.Context;

internal class BlogDbContext: DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=(LocalDb)\\MSSQLLocalDB;Database=BlogDb;Trusted_Connection=true");
    }
    public DbSet<Post> Posts { get; set; }
    public DbSet<Comment> Comments { get; set; }
}
