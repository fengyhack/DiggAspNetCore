using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using HaiAdmin.Models;

namespace HaiAdmin.Pages.Report
{
    public class DeleteModel : PageModel
    {
        private readonly HaiDbContext _context;

        public DeleteModel(HaiDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public ReportInfo Report { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Report = await _context.Reports.FirstOrDefaultAsync(m => m.Id == id);

            if (Report == null)
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

            Report= await _context.Reports.FindAsync(id);

            if (Report != null)
            {
                _context.Reports.Remove(Report);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("Index");
        }
    }
}
