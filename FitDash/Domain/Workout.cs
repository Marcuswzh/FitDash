namespace FitDash.Domain
{
    public class Workout : BaseDomainModel
    {
        public int UserID { get; set; } // Foreign Key
        public string WorkoutName { get; set; }

        public int Duration { get; set; } // Minutes

        public float? CaloriesBurned { get; set; }

        public DateTime WorkoutDate { get; set; }

        // Navigation property
        public User User { get; set; }
    }
}
