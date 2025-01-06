using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using FitDash.Data;
using FitDash.Configurations.Entities;

namespace FitDash.Data
{
    public class FitDashContext(DbContextOptions<FitDashContext> options) : IdentityDbContext<FitDashUser>(options)
    {
    public DbSet<FitDash.Domain.User> Users { get; set; } = default!;
        public DbSet<FitDash.Domain.Workout> Workouts { get; set; } = default!;
        public DbSet<FitDash.Domain.Meal> Meals { get; set; } = default!;
        public DbSet<FitDash.Domain.ProgressTracker> ProgressTrackers { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Apply seed data configurations in correct order
            modelBuilder.ApplyConfiguration(new RoleSeed());       // Roles must be seeded first
            modelBuilder.ApplyConfiguration(new ClientSeed());     // Admin user must be seeded next
            modelBuilder.ApplyConfiguration(new UserRoleSeed());   // UserRole depends on Roles and Users
            modelBuilder.ApplyConfiguration(new UserSeed());       // Additional users (domain-specific)
            modelBuilder.ApplyConfiguration(new WorkoutSeed());    // Other domain entities
            modelBuilder.ApplyConfiguration(new MealSeed());
            modelBuilder.ApplyConfiguration(new ProgressTrackerSeed());
        }
    }
}