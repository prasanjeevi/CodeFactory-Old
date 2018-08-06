using System;

namespace Common.Core.Models
{
  public class Account
  {
    public int Id { get; set; }
    public DateTime BalanceOn { get; set; }
    public decimal Balance { get; set; }
  }
}