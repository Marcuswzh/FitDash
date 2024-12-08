using FitDash.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FitDash.Configurations.Entities
{
    public class ProgressTrackerSeed : IEntityTypeConfiguration<ProgressTracker>
    {
        public void Configure(EntityTypeBuilder<ProgressTracker> builder)
        {
            builder.HasData(
                new ProgressTracker
                {
                    Id = 1,
                    UserID = 1,  // Ensure a User with ID 1 exists
                    DateRecorded = DateTime.UtcNow,
                    Weight = 70,
                    BMI = 24.5f,
                    BodyFatPercentage = 20
                },
                new ProgressTracker
                {
                    Id = 2,
                    UserID = 2,  // Ensure a User with ID 2 exists
                    DateRecorded = DateTime.UtcNow,
                    Weight = 60,
                    BMI = 22.0f,
                    BodyFatPercentage = 18
                }
            );

        }
    }
}
