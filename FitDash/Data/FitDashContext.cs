using Microsoft.EntityFrameworkCore;
using FitDash.Domain;
using FitDash.Configurations.Entities;

namespace FitDash.Data
{
    public class FitDashContext : DbContext
    {
        public FitDashContext(DbContextOptions<FitDashContext> options)
            : base(options)
        {
        }

        public DbSet<FitDash.Domain.User> Users { get; set; } = default!;   // Changed to 'Users'
        public DbSet<FitDash.Domain.Workout> Workouts { get; set; } = default!;
        public DbSet<FitDash.Domain.Meal> Meals { get; set; } = default!;
        public DbSet<FitDash.Domain.ProgressTracker> ProgressTrackers { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Apply seed data configurations
            modelBuilder.ApplyConfiguration(new UserSeed());
            modelBuilder.ApplyConfiguration(new WorkoutSeed());
            modelBuilder.ApplyConfiguration(new MealSeed());
            modelBuilder.ApplyConfiguration(new ProgressTrackerSeed());

            // Optional: Set custom table names if needed
            modelBuilder.Entity<User>().ToTable("User");  // Customizing table name
        }
    }
}
