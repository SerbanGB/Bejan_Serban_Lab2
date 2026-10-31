using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Bejan_Serban_Lab2.Models;

namespace Bejan_Serban_Lab2.Pages.Books;

public class DetailsModel : PageModel
{
    private readonly Bejan_Serban_Lab2Context _context;
    public DetailsModel(Bejan_Serban_Lab2Context context)
    {
        _context = context;
    }

    public Book Book { get; set; } = default!;

    public async Task<IActionResult> OnGetAsync(int? id)
    {
        if (id is null)
        {
            return NotFound();
        }

        var book = await _context.Book
    .Include(b => b.Author)
    .Include(b => b.Publisher)
    .FirstOrDefaultAsync(m => m.ID == id);
        if (book is null)
        {
            return NotFound();
        }
        else
        {
            Book = book;
        }

        return Page();
    }
}
