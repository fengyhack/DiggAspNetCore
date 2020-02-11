using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TheaterWeb.Models;

namespace TheaterWeb
{
    public class DetailsModel : PageModel
    {
        private readonly TheaterWeb.Models.OceanContext _context;

        public DetailsModel(TheaterWeb.Models.OceanContext context)
        {
            _context = context;
        }

        public Movies Movies { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Movies = await _context.Movies.FirstOrDefaultAsync(m => m.Id == id);

            if (Movies == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
