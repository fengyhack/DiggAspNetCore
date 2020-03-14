using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using HaiAdmin.Models;

namespace HaiAdmin.Pages.FileMeta
{
    public class UpdateModel : PageModel
    {
        private readonly HaiDbContext _context;

        public UpdateModel(HaiDbContext context)
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
        
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(FileMeta).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FileMetaExists(FileMeta.Id))
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

        private bool FileMetaExists(int id)
        {
            return _context.FileMetas.Any(e => e.Id == id);
        }
    }
}
