using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FEH.Components;

<<<<<<< HEAD
namespace Forms.Data
=======
namespace FEH.Data
>>>>>>> origin/JLosing
{
    public class FEHContext : DbContext
    {
        public FEHContext (DbContextOptions<FEHContext> options)
            : base(options)
        {
        }

<<<<<<< HEAD
        public DbSet<FEH.Components.Dogs> Dogs { get; set; } = default!;
=======
        public DbSet<FEH.Components.Forms> Forms { get; set; } = default!;
>>>>>>> origin/JLosing
    }
}
