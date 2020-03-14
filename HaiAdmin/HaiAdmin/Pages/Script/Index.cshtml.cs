using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using HaiAdmin.Models;

namespace HaiAdmin.Pages.Script
{
    public class IndexModel : PageModel
    {
        private readonly HaiDbContext _context;

        public IndexModel(HaiDbContext context)
        {
            _context = context;
        }

        public IList<ScriptInfo> Scripts { get;set; }

        public async Task OnGetAsync()
        {
            Scripts = await _context.Scripts.ToListAsync();
        }
    }
}
