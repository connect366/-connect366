using PostService.Entities;
using Microsoft.EntityFrameworkCore;

namespace PostService.Data;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Post> Posts { get; set; }

}
