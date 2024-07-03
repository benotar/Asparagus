namespace Asparagus.Domain.Entities;

public class User
{
    public long Id { get; set; }

    public string Name { get; set; }
    
    public string Email { get; set; }
    
    public DateTime CreationDate { get; set; }

    public DateTime EditDate { get; set; }

    public ICollection<UserEating> UserEatings { get; set; } = new List<UserEating>();
}