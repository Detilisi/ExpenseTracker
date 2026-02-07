using ExpenseTracker.Domain.Enums;

namespace ExpenseTracker.Domain.Entities;

public class TransactionEntity
{
    public required int Id { get; set; }
    
    public required int AccountId { get; set; }
    public required int CategoryId { get; set; }
    
    public required decimal Amount { get; set; }
    public string? Description { get; set; } = null;
    
    public required DateTime Date { get; set; }
    public required ETransactionType TransactionType { get; set; }
}