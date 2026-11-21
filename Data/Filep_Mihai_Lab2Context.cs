using Microsoft.EntityFrameworkCore;

namespace Filep_Mihai_Lab2;

public class Filep_Mihai_Lab2Context(DbContextOptions<Filep_Mihai_Lab2Context> options) : DbContext(options)
{
    public DbSet<Filep_Mihai_Lab2.Models.Book> Book { get; set; } = default!;
    public DbSet<Filep_Mihai_Lab2.Models.Publisher> Publisher { get; set; } = default!;
    public DbSet<Filep_Mihai_Lab2.Models.Author> Author { get; set; } = default!;
    public DbSet<Filep_Mihai_Lab2.Models.Category> Category { get; set; } = default!;
    public DbSet<Filep_Mihai_Lab2.Models.BookCategory> BookCategory { get; set; } = default!;
}
