using Microsoft.EntityFrameworkCore;

public class Bejan_Serban_Lab2Context(DbContextOptions<Bejan_Serban_Lab2Context> options) : DbContext(options)
{
    public DbSet<Bejan_Serban_Lab2.Models.Book> Book { get; set; } = default!;
    public DbSet<Bejan_Serban_Lab2.Models.Publisher> Publisher { get; set; } = default!;
}
