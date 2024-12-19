﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FEH.Components;

namespace FEH.Data
{
    public class FEHContext : DbContext
    {
        public FEHContext (DbContextOptions<FEHContext> options)
            : base(options)
        {
        }

        public DbSet<FEH.Components.Forms> Forms { get; set; } = default!;
        public DbSet<FEH.Components.Dogs> Dogs { get; set; } = default!;
    }
}
