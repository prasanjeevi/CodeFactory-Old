using Microsoft.EntityFrameworkCore;
using Common.Core.Models;

namespace Common.Data
{
  public class AccountDbContext : DbContext
  {
    public DbSet<Account> Accounts { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseSqlite("Data Source=account.db");
    }
  }
}