using System.ComponentModel.DataAnnotations;

namespace FreelancerClientTracker.Models;

public class Client
{
    [Key]
    public int Id { get; set; }
    [Required]
    public string Name { get; set; } = string.Empty;
    public string? Email { get; set; }
    public string? Phone { get; set; }
    public string? Notes { get; set; }
}