using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using TheaterWeb.Models;

namespace TheaterWeb
{
    public class IndexModel : PageModel
    {
        public bool DbExists { get; set; }

        private readonly ILogger<IndexModel> _logger;
        private readonly OceanDbContext _context;

        public IndexModel(OceanDbContext context,ILogger<IndexModel> logger)
        {
            _context = context;
            _logger = logger;
            DbExists = _context.CanConnect;
        }

        public void OnGet()
        {
            //
        }

        public async Task<IActionResult> OnPost()
        {
            await _context.Database.MigrateAsync();
            DbExists = true;
            return Page();
        }
    }
}
