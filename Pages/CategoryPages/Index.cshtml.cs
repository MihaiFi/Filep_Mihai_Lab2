using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Filep_Mihai_Lab2.Models;
using Filep_Mihai_Lab2;

namespace Filep_Mihai_Lab2.Pages.CategoryPages;

public class IndexModel : PageModel
{
    private readonly Filep_Mihai_Lab2Context _context;

    public IndexModel(Filep_Mihai_Lab2Context context)
    {
        _context = context;
    }

    public IList<Category> Category { get; set; } = default!;

    public async Task OnGetAsync()
    {
        Category = await _context.Category.ToListAsync();
    }
}
