namespace SEJMS.Models
{
    public class StudentActivity
    {
        public int StudentActivityId { get; set; }

        public int StudentId { get; set; }

        public int ActivityId { get; set; }

        public Student? Student { get; set; }

        public Activity? Activity { get; set; }
    }
}