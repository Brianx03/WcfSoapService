using System.Data.Entity;

public class MyDbContext : DbContext
{
    public DbSet<User> Users { get; set; }

    public MyDbContext() : base("name=MyDbContext")
    {
    }
}