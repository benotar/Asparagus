using Asparagus.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Asparagus.Application.Interfaces;

public interface IAsparagusDbContext
{
    DbSet<User> Users { get; set; }
    DbSet<UserEating> UsersEatings { get; set; }

}