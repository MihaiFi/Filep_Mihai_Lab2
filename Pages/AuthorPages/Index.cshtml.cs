using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Filep_Mihai_Lab2.Models;

namespace Filep_Mihai_Lab2.Pages.AuthorPages;

public class IndexModel : PageModel
{
    private readonly Filep_Mihai_Lab2Context _context;

    public IndexModel(Filep_Mihai_Lab2Context context)
    {
        _context = context;
    }

    public IList<Author> Author { get; set; } = default!;

    public async Task OnGetAsync()
    {
        Author = await _context.Author.ToListAsync();
    }
}
