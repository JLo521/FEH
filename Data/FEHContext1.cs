using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FEH;

namespace FEH.Data
{
    public class FEHContext1 : DbContext
    {
        public FEHContext1 (DbContextOptions<FEHContext1> options)
            : base(options)
        {
        }

        public DbSet<FEH.User> User { get; set; } = default!;
    }
}
