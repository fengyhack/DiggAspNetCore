using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using HaiAdmin.Models;

namespace HaiAdmin.Pages.Model
{
    public class IndexModel : PageModel
    {
        private readonly HaiDbContext _context;

        public IndexModel(HaiDbContext context)
        {
            _context = context;
        }

        public IList<ModelInfo> ProductModels { get;set; }

        public async Task OnGetAsync()
        {
            ProductModels = await _context.ProductModels.ToListAsync();
        }
    }
}
