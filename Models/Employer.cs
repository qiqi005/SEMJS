namespace SEJMS.Models
{
    public class Employer
    {
        public int EmployerId { get; set; }

        public int UserId { get; set; }

        public string CompanyName { get; set; } = string.Empty;

        public string CompanyDescription { get; set; } = string.Empty;

        public string Industry { get; set; } = string.Empty;

        public string ContactNumber { get; set; } = string.Empty;

        public string CompanyEmail { get; set; } = string.Empty;

        public string? Website { get; set; }
        public string? Country { get; set; }
        public string? Region { get; set; }
        public string? City { get; set; }
        public string? Address { get; set; }
        public string? PostalCode { get; set; }
        public string? Services { get; set; }
        public string? Tagline { get; set; }
        public User? User { get; set; }
    }
}