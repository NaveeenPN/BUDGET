using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using BUDGET.Data;
using BUDGET.User;

namespace BUDGET.Pages
{
    public class CreateModel : PageModel
    {
        private readonly BUDGET.Data.BUDGETContext _context;

        public CreateModel(BUDGET.Data.BUDGETContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Income Income { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Income.Add(Income);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
