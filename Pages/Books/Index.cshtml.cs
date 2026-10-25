using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Bejan_Serban_Lab2.Models;

namespace Bejan_Serban_Lab2.Pages.Books;

public class IndexModel : PageModel
{
    private readonly Bejan_Serban_Lab2Context _context;

    public IndexModel(Bejan_Serban_Lab2Context context)
    {
        _context = context;
    }

    public IList<Book> Book { get; set; } = default!;

    public async Task OnGetAsync()
    {
        Book = await _context.Book
            .Include(b => b.Publisher)
            .ToListAsync(); 
    }
}
