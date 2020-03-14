using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using HaiAdmin.Models;

namespace HaiAdmin.Pages
{
    public class IndexModel : PageModel
    {
        public bool DatabaseExists { get; set; }

        private readonly HaiDbContext _context;
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(HaiDbContext context,ILogger<IndexModel> logger)
        {
            _context = context;
            _logger = logger;
            DatabaseExists = _context.CanConnect;
        }

        public void OnGet()
        {
            //
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!DatabaseExists)
            {
                await _context.Database.MigrateAsync();
                DatabaseExists = true;
            }

            return Page();
        }
    }
}
