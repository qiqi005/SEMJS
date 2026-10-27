namespace SEJMS.Models
{
    public class Application
    {
        public int ApplicationId { get; set; }

        public int StudentId { get; set; }

        public int JobId { get; set; }

        public DateTime ApplicationDate { get; set; }

        public string Status { get; set; } = "Pending";

        public Student? Student { get; set; }

        public Job? Job { get; set; }

        public ICollection<ApplicationMessage> Messages { get; set; }
            = new List<ApplicationMessage>();
    }
}