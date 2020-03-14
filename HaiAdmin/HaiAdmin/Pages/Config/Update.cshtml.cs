using System.Threading.Tasks;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using HaiAdmin.Models;

namespace HaiAdmin.Pages.Config
{
    public class UpdateModel : PageModel
    {
        private readonly HaiDbContext _context;

        public UpdateModel(HaiDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public ConfigInfo Config { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Config = await _context.Configs.FirstOrDefaultAsync(m => m.Id == id);

            if (Config == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Config).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ConfigExists(Config.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("Index");
        }

        private bool ConfigExists(int id)
        {
            return _context.Configs.Any(e => e.Id == id);
        }
    }
}
