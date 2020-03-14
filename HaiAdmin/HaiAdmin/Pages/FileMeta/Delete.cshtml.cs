using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using HaiAdmin.Models;

namespace HaiAdmin.Pages.FileMeta
{
    public class DeleteModel : PageModel
    {
        private readonly HaiDbContext _context;

        public DeleteModel(HaiDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public FileMetaInfo FileMeta { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            FileMeta = await _context.FileMetas.FirstOrDefaultAsync(m => m.Id == id);

            if (FileMeta == null)
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

            FileMeta = await _context.FileMetas.FindAsync(id);

            if (FileMeta != null)
            {
                _context.FileMetas.Remove(FileMeta);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("Index");
        }
    }
}
