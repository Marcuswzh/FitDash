namespace FitDash.Domain
{
    public class User : BaseDomainModel
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }
        public float? Height { get; set; }
        public float? Weight { get; set; }
        public string ActivityLevel { get; set; }
    }
}
