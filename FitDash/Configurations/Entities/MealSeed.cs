using FitDash.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FitDash.Configurations.Entities
{
    public class MealSeed : IEntityTypeConfiguration<Meal>
    {
        public void Configure(EntityTypeBuilder<Meal> builder)
        {
            builder.HasData(
                new Meal
                {
                    Id = 1,
                    UserID = 1,
                    MealName = "Breakfast",
                    Calories = 400,
                    Proteins = 25,
                    Fats = 10,
                    Carbs = 50,
                    MealDate = DateTime.UtcNow,
                    DateCreated = DateTime.UtcNow,
                    DateUpdated = DateTime.UtcNow,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Meal
                {
                    Id = 2,
                    UserID = 2,
                    MealName = "Lunch",
                    Calories = 600,
                    Proteins = 40,
                    Fats = 15,
                    Carbs = 70,
                    MealDate = DateTime.UtcNow,
                    DateCreated = DateTime.UtcNow,
                    DateUpdated = DateTime.UtcNow,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                }
            );
        }
    }
}
