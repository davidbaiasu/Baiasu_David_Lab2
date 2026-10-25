using Microsoft.EntityFrameworkCore;

public class Baiasu_David_Lab2Context(DbContextOptions<Baiasu_David_Lab2Context> options) : DbContext(options)
{
    public DbSet<Baiasu_David_Lab2.Models.Book> Book { get; set; } = default!;
    public DbSet<Baiasu_David_Lab2.Models.Publisher> Publisher { get; set; } = default!;
}
