using Microsoft.AspNetCore.Identity;

namespace ExpenseTracker.Domain.Entities;

public class UserEntity : IdentityUser
{
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
}