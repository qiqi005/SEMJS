namespace SEJMS.Models
{
    public class Resume
    {
        public int ResumeId { get; set; }

        public int StudentId { get; set; }

        public string FileName { get; set; } = string.Empty;

        public string FilePath { get; set; } = string.Empty;

        public DateTime UploadedDate { get; set; }

        public Student? Student { get; set; }
    }
}