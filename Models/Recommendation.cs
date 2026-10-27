namespace SEJMS.Models
{
    public class Recommendation
    {
        public int RecommendationId { get; set; }

        public int StudentId { get; set; }

        public int JobId { get; set; }

        public double MatchingScore { get; set; }

        public string Reason { get; set; } = string.Empty;

        public DateTime RecommendationDate { get; set; }

        public Student? Student { get; set; }

        public Job? Job { get; set; }
    }
}
