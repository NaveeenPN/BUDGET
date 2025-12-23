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
    public class DeleteModel : PageModel
    {
        private readonly BUDGET.Data.BUDGETContext _context;

        public DeleteModel(BUDGET.Data.BUDGETContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var income = await _context.Income.FindAsync(id);
            if (income != null)
            {
                Income = income;
                _context.Income.Remove(Income);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
