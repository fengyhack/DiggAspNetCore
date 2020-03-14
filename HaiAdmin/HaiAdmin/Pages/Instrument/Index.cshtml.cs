using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using HaiAdmin.Models;

namespace HaiAdmin.Pages.Instrument
{
    public class IndexModel : PageModel
    {
        private readonly HaiDbContext _context;

        public IndexModel(HaiDbContext context)
        {
            _context = context;
        }

        public IList<InstrumentInfo> Instruments { get;set; }

        public async Task OnGetAsync()
        {
            Instruments = await _context.Instruments.ToListAsync();
        }
    }
}
