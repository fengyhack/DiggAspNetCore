using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HaiAdmin.Models;

namespace HaiAdmin.Pages.Script
{
    public class AddModel : PageModel
    {
        private readonly HaiDbContext _context;

        public AddModel(HaiDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public ScriptInfo Script { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Scripts.Add(Script);
            await _context.SaveChangesAsync();

            return RedirectToPage("Index");
        }
    }
}
