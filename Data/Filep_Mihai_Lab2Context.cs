using Microsoft.EntityFrameworkCore;

public class Filep_Mihai_Lab2Context(DbContextOptions<Filep_Mihai_Lab2Context> options) : DbContext(options)
{
    public DbSet<Filep_Mihai_Lab2.Models.Book> Book { get; set; } = default!;
    public DbSet<Filep_Mihai_Lab2.Models.Publisher> Publisher { get; set; } = default!;
    public DbSet<Filep_Mihai_Lab2.Models.Author> Author { get; set; } = default!;
}
