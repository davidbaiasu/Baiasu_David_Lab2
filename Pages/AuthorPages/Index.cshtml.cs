using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Baiasu_David_Lab2.Models;

namespace Baiasu_David_Lab2.Pages.AuthorPages;

public class IndexModel : PageModel
{
    private readonly Baiasu_David_Lab2Context _context;

    public IndexModel(Baiasu_David_Lab2Context context)
    {
        _context = context;
    }

    public IList<Author> Author { get; set; } = default!;

    public async Task OnGetAsync()
    {
        Author = await _context.Author.ToListAsync();
    }
}
