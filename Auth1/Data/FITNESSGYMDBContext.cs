using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FITNESSGYM.Models;
using System.Reflection.Emit;
using FITNESSGYM.Data.Seeding;

namespace FITNESSGYM.Data
{
    public class FITNESSGYMDBContext : DbContext
    {
        public FITNESSGYMDBContext(DbContextOptions<FITNESSGYMDBContext> options)
            : base(options)
        {

        }

        //Seeding Database
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            AppDBContextSeed.Seed(modelBuilder);
            base.OnModelCreating(modelBuilder);

        }

        public DbSet<Exercise> Exercise { get; set; } = default!;
        public DbSet<TrainingProgram> TrainingProgram { get; set; } = default!;
        public DbSet<IndividualProgram> IndividualProgram { get; set; } = default!;

        public DbSet<Goal> Goal { get; set; } = default!;
        public DbSet<Location> Location { get; set; } = default!;
        public DbSet<Formula> Formula { get; set; } = default!;
        public DbSet<Coach> Coach { get; set; } = default!;
        public DbSet<Speciality> Speciality { get; set; } = default!;
        public DbSet<Machine> Machine { get; set; } = default!;
        public DbSet<Session> Session { get; set; } = default!;
        public DbSet<Client> Client { get; set; } = default!;
        public DbSet<Subscription> Subscription { get; set; } = default!;
        public DbSet<Reservation> Reservation { get; set; } = default!;
        public DbSet<Product> Product { get; set; } = default!;

    }
}