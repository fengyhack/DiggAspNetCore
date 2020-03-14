using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using HaiAdmin.Models;

namespace HaiAdmin.Pages.User
{
    public class IndexModel : PageModel
    {
        private readonly HaiDbContext _context;

        public IndexModel(HaiDbContext context)
        {
            _context = context;
        }

        public IList<UserInfo> Users { get;set; }

        public async Task OnGetAsync()
        {
            Users = await _context.Users.ToListAsync();
        }
    }
}
