namespace FitDash.Domain
{
    public class ProgressTracker : BaseDomainModel
    {
        public int UserID { get; set; } // Foreign Key

        public DateTime DateRecorded { get; set; }

        public float Weight { get; set; }

        public float? BMI { get; set; }
        public float? BodyFatPercentage { get; set; }

        // Navigation property
        public User User { get; set; }
    }
}
