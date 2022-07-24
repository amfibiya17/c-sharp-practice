using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CloudCustomers.API.Models;

namespace CloudCustomers.UnitTests.Fixtures
{
  public class UsersFixture
  {
    public static List<User> GetTestUsers() => new() {
      new User {
        Name = "Slava1",
        Email = "slava1@yates.com",
        Address = new Address
        {
          Street = "Waterloo1",
          City = "London1",
          PostCode = "SW1"
        },
      },
      new User {
        Name = "Slava2",
        Email = "slava2@yates.com",
        Address = new Address
        {
          Street = "Waterloo2",
          City = "London2",
          PostCode = "SW2"
        },
      },
      new User {
        Name = "Slava3",
        Email = "slava3@yates.com",
        Address = new Address
        {
          Street = "Waterloo3",
          City = "London3",
          PostCode = "SW3"
        },
      },
      };
  }
}
