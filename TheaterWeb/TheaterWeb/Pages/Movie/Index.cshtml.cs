using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TheaterWeb.Models;

namespace TheaterWeb.Pages.Movie
{
    public class IndexModel : PageModel
    {
        private readonly OceanDbContext _context;

        public IndexModel(OceanDbContext context)
        {
            _context = context;
        }

        public IList<MovieInfo> Movies { get;set; }

        public async Task OnGetAsync()
        {
            Movies = await _context.Movies.ToListAsync();
        }
    }
}
