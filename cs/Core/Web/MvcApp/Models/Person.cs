using System;

namespace MvcApp.Models
{
  public class Person
  {
    private Person()
    {
    }
    public Person(string name)
    {
        Name = name;
    }
    public Guid Id { get; private set; } = Guid.NewGuid();
    public string Name { get; set; }
  }
}