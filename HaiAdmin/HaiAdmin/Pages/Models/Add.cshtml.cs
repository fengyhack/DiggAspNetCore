using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HaiAdmin.Models;

namespace HaiAdmin.Pages.Model
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
        public ModelInfo ProductModel { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.ProductModels.Add(ProductModel);
            await _context.SaveChangesAsync();

            return RedirectToPage("Index");
        }
    }
}
