using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FEH.Components;

namespace FEH.Data
{
    public class JackContext : DbContext
    {
        public JackContext (DbContextOptions<JackContext> options)
            : base(options)
        {
        }

        public DbSet<FEH.Components.Dogs> Dogs { get; set; } = default!;
    }
}
