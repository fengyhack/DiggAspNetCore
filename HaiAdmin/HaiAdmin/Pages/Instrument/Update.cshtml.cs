using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using HaiAdmin.Models;

namespace HaiAdmin.Pages.Instrument
{
    public class UpdateModel : PageModel
    {
        private readonly HaiDbContext _context;

        public UpdateModel(HaiDbContext context)
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

            Instrument= await _context.Instruments.FirstOrDefaultAsync(m => m.Id == id);

            if (Instrument == null)
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

            _context.Attach(Instrument).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!InstrumentExists(Instrument.Id))
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

        private bool InstrumentExists(int id)
        {
            return _context.Instruments.Any(e => e.Id == id);
        }
    }
}
