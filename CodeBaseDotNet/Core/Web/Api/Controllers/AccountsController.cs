using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Common.Core.Models;
using Common.Data;

namespace Api.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class AccountsController : ControllerBase
  {
    static List<Account> accounts = new List<Account>()
    {
      new Account(){ Id = 1, Balance = 28_494.95M, BalanceOn = DateTime.Now }, //3.65
      new Account(){ Id = 2, Balance = 6_454.11M, BalanceOn = DateTime.Now } //0.05
    };

    // GET api/accounts
    [HttpGet]
    public ActionResult<IEnumerable<Account>> Get()
    {
      //IEnumerable<Account> accounts = null;
      using(var db = new AccountDbContext())
      {
        return db.Accounts.ToList();
      }
      //return accounts;
    }

    // GET api/accounts/1
    [HttpGet("{id}")]
    public ActionResult<Account> Get(int id)
    {
      using(var db = new AccountDbContext())
      {
        return db.Accounts.Where(a => a.Id == id).SingleOrDefault();
      }
      //return accounts.Where(a => a.Id == id).SingleOrDefault();
    }

    // GET api/accounts/balance
    [HttpGet]
    [Route("balance")]
    public ActionResult<decimal> GetBalance()
    {
      using(var db = new AccountDbContext())
      {
        return db.Accounts.Sum(a => a.Balance);
      }
      //return accounts.Sum(a => a.Balance);
    }

    // POST api/accounts
    [HttpPost]
    public void Post([FromBody] Account account)
    {
      using(var db = new AccountDbContext())
      {
        db.Accounts.Add(account);
        db.SaveChanges();
      }
    }

    // PUT api/values/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] Account account)
    {
      using(var db = new AccountDbContext())
      {
        db.Accounts.(account);
        db.SaveChanges();
      }
    }

    // DELETE api/values/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
    }
  }
}
