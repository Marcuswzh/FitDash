using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FitDash.Domain;

namespace FitDash.Data
{
    public class FitDashContext : DbContext
    {
        public FitDashContext (DbContextOptions<FitDashContext> options)
            : base(options)
        {
        }

        public DbSet<FitDash.Domain.User> User { get; set; } = default!;
        public DbSet<FitDash.Domain.Workout> Workout { get; set; } = default!;
        public DbSet<FitDash.Domain.Meal> Meal { get; set; } = default!;
        public DbSet<FitDash.Domain.ProgressTracker> ProgressTracker { get; set; } = default!;
    }
}
