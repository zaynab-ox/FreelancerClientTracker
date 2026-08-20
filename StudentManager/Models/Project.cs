using System.ComponentModel.DataAnnotations;

namespace FreelancerClientTracker.Models;

public class Project
{
    [Key]
    public int Id { get; set; }
    [Required]
    public string Title { get; set; } = string.Empty;
    public int ClientId { get; set; }
    public string Status { get; set; } = "Pending"; // Pending, Done
    public DateTime Deadline { get; set; } = DateTime.Now;
}