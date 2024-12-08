using FitDash.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FitDash.Configurations.Entities
{
    public class WorkoutSeed : IEntityTypeConfiguration<Workout>
    {
        public void Configure(EntityTypeBuilder<Workout> builder)
        {
            builder.HasData(
                new Workout
                {
                    Id = 1,
                    UserID = 1,
                    WorkoutName = "Cardio",
                    Duration = 30,
                    CaloriesBurned = 300,
                    WorkoutDate = DateTime.UtcNow,
                    DateCreated = DateTime.UtcNow,
                    DateUpdated = DateTime.UtcNow
                },
                new Workout
                {
                    Id = 2,
                    UserID = 2,
                    WorkoutName = "Strength Training",
                    Duration = 45,
                    CaloriesBurned = 400,
                    WorkoutDate = DateTime.UtcNow,
                    DateCreated = DateTime.UtcNow,
                    DateUpdated = DateTime.UtcNow
                }
            ); ;
        }
    }
}
