using FitDash.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FitDash.Configurations.Entities
{
    public class UserSeed : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasData(
                new User
                {
                    Id = 1,
                    Name = "John Doe",
                    Email = "johndoe@example.com",
                    Password = "P@ssword1", // Hash this in a real application
                    DateOfBirth = new DateTime(1990, 5, 15),
                    Gender = "Male",
                    Height = 175,
                    Weight = 70,
                    ActivityLevel = "Active",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now
                },
                new User
                {
                    Id = 2,
                    Name = "Jane Doe",
                    Email = "janedoe@example.com",
                    Password = "P@ssword1", // Hash this in a real application
                    DateOfBirth = new DateTime(1990, 5, 15),
                    Gender = "Male",
                    Height = 175,
                    Weight = 70,
                    ActivityLevel = "Active",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now
                }
                );
        }
    }
}
