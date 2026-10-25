using Baiasu_David_Lab2.Models;
using Microsoft.EntityFrameworkCore;

public class Baiasu_David_Lab2Context(DbContextOptions<Baiasu_David_Lab2Context> options) : DbContext(options)
{
    public DbSet<Book> Book { get; set; } = default!;
    public DbSet<Publisher> Publisher { get; set; } = default!;
    public DbSet<Author> Author { get; set; } = default!;

}
