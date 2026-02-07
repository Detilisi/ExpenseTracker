using ExpenseTracker.Domain.Enums;

namespace ExpenseTracker.Domain.Entities;

public class CategoryEntity
{
    public required int Id { get; set; }
    
    public required string Name { get; set; } = "";
    public string? Description { get; set; } = null;
    
    public required ECategoryScope Scope { get; set; }
}