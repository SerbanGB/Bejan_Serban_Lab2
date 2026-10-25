using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Bejan_Serban_Lab2.Models;

namespace Bejan_Serban_Lab2.Pages.CategoryPages;

public class IndexModel : PageModel
{
    private readonly Bejan_Serban_Lab2Context _context;

    public IndexModel(Bejan_Serban_Lab2Context context)
    {
        _context = context;
    }

    public IList<Category> Category { get; set; } = default!;

    public async Task OnGetAsync()
    {
        Category = await _context.Category.ToListAsync();
    }
}
