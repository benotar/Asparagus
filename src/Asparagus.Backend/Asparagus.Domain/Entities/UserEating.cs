namespace Asparagus.Domain.Entities;

public class UserEating 
{
    public long Id { get; set; }
    
    public long UserId { get; set; }
    
    public User User { get; set; }
    
    public int Count { get; set; }

    public DateTime EatingDate { get; set; }
}