using ExpenseTracker.Domain.Enums;

namespace ExpenseTracker.Domain.Entities;

public class AccountEntity
{
    public required int Id { get; set; }
    public required int CategoryId { get; set; }
    
    public required string Name { get; set; }
    public string? Description { get; set; } = null;

    public required decimal Balance { get; set; }
    
    public required EAccountType AccountType { get; set; }
    public required EAccountBalanceType BalanceType { get; set; }
}