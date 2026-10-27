using System.ComponentModel.DataAnnotations;

namespace SEJMS.Models
{
    public class ApplicationMessage
    {
        public int ApplicationMessageId { get; set; }

        public int ApplicationId { get; set; }

        public int SenderUserId { get; set; }

        [MaxLength(20)]
        public string SenderRole { get; set; } = "";

        [MaxLength(3000)]
        public string Text { get; set; } = "";

        public DateTime SentAtUtc { get; set; }
        public DateTime? ReadAtUtc { get; set; }

        [MaxLength(255)]
        public string? AttachmentName { get; set; }

        [MaxLength(100)]
        public string? StoredFileName { get; set; }

        public Application? Application { get; set; }
    }
}