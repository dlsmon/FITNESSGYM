using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FITNESSGYM.Models;

namespace FITNESSGYM.Data
{
    public class FITNESSGYMDBContext : DbContext
    {
        public FITNESSGYMDBContext (DbContextOptions<FITNESSGYMDBContext> options)
            : base(options)
        {
        }

        public DbSet<FITNESSGYM.Models.TrainingProgram> TrainingProgram { get; set; } = default!;
        public DbSet<FITNESSGYM.Models.Session> Session { get; set; } = default!;
        public DbSet<FITNESSGYM.Models.Reservation> Reservation { get; set; } = default!;

    }
}
