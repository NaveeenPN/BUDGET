using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BUDGET.Data;
using BUDGET.User;

namespace BUDGET.Pages
{
    public class IndexModel : PageModel
    {
        private readonly BUDGET.Data.BUDGETContext _context;

        public IndexModel(BUDGET.Data.BUDGETContext context)
        {
            _context = context;
        }

        public IList<Income> Income { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Income = await _context.Income.ToListAsync();
        }
    }
}
