using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using HaiAdmin.Models;

namespace HaiAdmin.Pages.FileMeta
{
    public class IndexModel : PageModel
    {
        private readonly HaiDbContext _context;

        public IndexModel(HaiDbContext context)
        {
            _context = context;
        }

        public IList<FileMetaInfo> FileMetas { get;set; }

        public async Task OnGetAsync()
        {
            FileMetas = await _context.FileMetas.ToListAsync();
        }
    }
}
