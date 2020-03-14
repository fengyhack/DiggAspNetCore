using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using HaiAdmin.Models;

namespace HaiAdmin.Pages.Template
{
    public class DeleteModel : PageModel
    {
        private readonly HaiDbContext _context;

        public DeleteModel(HaiDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public TemplateInfo Template { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Template = await _context.Templates.FirstOrDefaultAsync(m => m.Id == id);

            if (Template == null)
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

            Template = await _context.Templates.FindAsync(id);

            if (Template != null)
            {
                _context.Templates.Remove(Template);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("Index");
        }
    }
}
