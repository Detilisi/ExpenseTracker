using Microsoft.AspNetCore.Identity;

namespace ExpenseTracker.Domain.Entities;

public class UserEntity : IdentityUser<int>
{
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
}