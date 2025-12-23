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
    public class DetailsModel : PageModel
    {
        private readonly BUDGET.Data.BUDGETContext _context;

        public DetailsModel(BUDGET.Data.BUDGETContext context)
        {
            _context = context;
        }

        public Income Income { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var income = await _context.Income.FirstOrDefaultAsync(m => m.ID == id);

            if (income is not null)
            {
                Income = income;

                return Page();
            }

            return NotFound();
        }
    }
}
