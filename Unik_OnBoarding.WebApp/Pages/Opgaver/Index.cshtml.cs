using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Unik_OnBoarding.Domain.Model;
using Unik_OnBoarding.Persistance.DbContext;

namespace Unik_OnBoarding.WebApp.Pages.Opgaver;

public class IndexModel : PageModel
{
    private readonly AppDbContext _context;

    public IndexModel(AppDbContext context)
    {
        _context = context;
    }

    public IList<OpgaverEntity> OpgaverEntity { get; set; } = default!;

    public async Task OnGetAsync()
    {
        if (_context.Opgaver != null) OpgaverEntity = await _context.Opgaver.ToListAsync();
    }
}