using ExpenseTracker.Domain.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ExpenseTracker.Infrastructure.Persistence;

public class ApplicationDataContext :  IdentityDbContext<UserEntity>
{
    public DbSet<UserEntity> UserEntities { get; set; }
    public DbSet<CategoryEntity> CategoriesEntities { get; set; }  
    
    public DbSet<AccountEntity> AccountEntities { get; set; }
    public DbSet<TransactionEntity> TransactionEntities { get; set; }
}