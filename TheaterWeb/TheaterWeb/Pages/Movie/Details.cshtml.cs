using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TheaterWeb.Models;

namespace TheaterWeb.Pages.Movie
{
    public class DetailsModel : PageModel
    {
        private readonly OceanDbContext _context;

        public DetailsModel(OceanDbContext context)
        {
            _context = context;
        }

        public MovieInfo Movie { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Movie = await _context.Movies.FirstOrDefaultAsync(m => m.Id == id);

            if (Movie == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
