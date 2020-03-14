using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using HaiAdmin.Models;

namespace HaiAdmin.Pages.Config
{
    public class DeleteModel : PageModel
    {
        private readonly HaiDbContext _context;

        public DeleteModel(HaiDbContext context)
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Config = await _context.Configs.FindAsync(id);

            if (Config != null)
            {
                _context.Configs.Remove(Config);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("Index");
        }
    }
}
