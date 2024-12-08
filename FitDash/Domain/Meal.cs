namespace FitDash.Domain
{
    public class Meal : BaseDomainModel
    {
        public int UserID { get; set; } // Foreign Key
        public string MealName { get; set; }
        public float Calories { get; set; }
        public float? Proteins { get; set; }
        public float? Fats { get; set; }
        public float? Carbs { get; set; }
        public DateTime MealDate { get; set; }

        // Navigation property
        public User User { get; set; }
    }
}
