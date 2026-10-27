using System.ComponentModel.DataAnnotations;

namespace SEJMS.Models;

public class ProfileItem
{
    public int ProfileItemId { get; set; }

    public int UserId { get; set; }

    [MaxLength(20)]
    public string Kind { get; set; } = "Project";

    [MaxLength(150)]
    public string Title { get; set; } = "";

    [MaxLength(150)]
    public string? Organization { get; set; }

    [MaxLength(150)]
    public string? Position { get; set; }

    [MaxLength(4000)]
    public string? Description { get; set; }

    [MaxLength(2000)]
    public string? Url { get; set; }

    [MaxLength(300)]
    public string? Skills { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public bool IsCurrent { get; set; }

    [MaxLength(255)]
    public string? AttachmentName { get; set; }

    [MaxLength(100)]
    public string? StoredFileName { get; set; }

    public User? User { get; set; }
}