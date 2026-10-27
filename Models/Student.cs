namespace SEJMS.Models
{
    public class Student
    {
        public int StudentId { get; set; }

        public int UserId { get; set; }

        public string StudentName { get; set; } = string.Empty;

        public string StudentNumber { get; set; } = string.Empty;

        public string Course { get; set; } = string.Empty;

        public string University { get; set; } = string.Empty;

        public string PhoneNumber { get; set; } = string.Empty;

        public string? Headline { get; set; }
        public string? About { get; set; }
        public string? Country { get; set; }
        public string? Region { get; set; }
        public string? City { get; set; }
        public string? PreferredLocations { get; set; }
        public string? PreferredWorkTypes { get; set; }
        public string? PreferredWorkModes { get; set; }
        public string? Website { get; set; }
        public string? LinkedIn { get; set; }
        public string? GitHub { get; set; }
        public User? User { get; set; }
    }
}