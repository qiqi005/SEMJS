namespace SEJMS.Models
{
    public class Activity
    {
        public int ActivityId { get; set; }

        public string ActivityName { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public DateTime ActivityDate { get; set; }

        public string Location { get; set; } = string.Empty;
    }
}