namespace SEJMS.Models
{
    public class Job
    {
        public int JobId { get; set; }

        public int EmployerId { get; set; }

        public string JobTitle { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public string Requirements { get; set; } = string.Empty;

        public string Location { get; set; } = string.Empty;

        public string EmploymentType { get; set; } = string.Empty;

        public DateTime PostedDate { get; set; }

        public Employer? Employer { get; set; }

        public ICollection<JobSkill> RequiredSkills { get; set; }
            = new List<JobSkill>();
    }
}