using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Filep_Mihai_Lab2.Models;

namespace Filep_Mihai_Lab2.Pages.BookCategoryPages;

public class DetailsModel : PageModel
{
    private readonly Filep_Mihai_Lab2Context _context;
    public DetailsModel(Filep_Mihai_Lab2Context context)
    {
        _context = context;
    }

    public BookCategory BookCategory { get; set; } = default!;

    public async Task<IActionResult> OnGetAsync(int? id)
    {
        if (id is null)
        {
            return NotFound();
        }

        var bookcategory = await _context.BookCategory.FirstOrDefaultAsync(m => m.ID == id);
        if (bookcategory is null)
        {
            return NotFound();
        }
        else
        {
            BookCategory = bookcategory;
        }

        return Page();
    }
}
