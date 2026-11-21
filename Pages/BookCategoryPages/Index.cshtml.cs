using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Filep_Mihai_Lab2.Models;

namespace Filep_Mihai_Lab2.Pages.BookCategoryPages;

public class IndexModel : PageModel
{
    private readonly Filep_Mihai_Lab2Context _context;

    public IndexModel(Filep_Mihai_Lab2Context context)
    {
        _context = context;
    }

    public IList<BookCategory> BookCategory { get; set; } = default!;

    public async Task OnGetAsync()
    {
        BookCategory = await _context.BookCategory.ToListAsync();
    }
}
