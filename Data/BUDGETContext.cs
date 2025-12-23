using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BUDGET.User;

namespace BUDGET.Data
{
    public class BUDGETContext : DbContext
    {
        public BUDGETContext (DbContextOptions<BUDGETContext> options)
            : base(options)
        {
        }

        public DbSet<BUDGET.User.Income> Income { get; set; } = default!;
    }
}
