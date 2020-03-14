using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using HaiAdmin.Models;

namespace HaiAdmin.Pages.Script
{
    public class UpdateModel : PageModel
    {
        private readonly HaiDbContext _context;

        public UpdateModel(HaiDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public ScriptInfo Script { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Script = await _context.Scripts.FirstOrDefaultAsync(m => m.Id == id);

            if (Script == null)
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

            _context.Attach(Script).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ScriptExists(Script.Id))
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

        private bool ScriptExists(int id)
        {
            return _context.Scripts.Any(e => e.Id == id);
        }
    }
}
