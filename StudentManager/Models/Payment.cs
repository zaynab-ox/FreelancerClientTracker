using System.ComponentModel.DataAnnotations;

namespace FreelancerClientTracker.Models;

public class Payment
{
    [Key]
    public int Id { get; set; }
    public int ProjectId { get; set; }
    public decimal Amount { get; set; }
    public string Status { get; set; } = "Unpaid"; // Unpaid, Paid
}