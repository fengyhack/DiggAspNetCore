using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using HaiAdmin.Models;

namespace HaiAdmin.Pages.Instrument
{
    public class DeleteModel : PageModel
    {
        private readonly HaiDbContext _context;

        public DeleteModel(HaiDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public InstrumentInfo Instrument { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Instrument = await _context.Instruments.FirstOrDefaultAsync(m => m.Id == id);

            if (Instrument == null)
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

            Instrument = await _context.Instruments.FindAsync(id);

            if (Instrument != null)
            {
                _context.Instruments.Remove(Instrument);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("Index");
        }
    }
}
