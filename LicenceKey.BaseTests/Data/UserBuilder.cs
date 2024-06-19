
using LicenceKey.Domain.Entities;

namespace LicenceKey.BaseTests.Data;

public class UserBuilder
{
    public User Build()
    {
        return new User()
        {
            Active = true,
            Username = "Luka",
            Password = "luka123",
            Email = "luka@gmail.com",
            Balance = 60,
            MoneySpend = 40
        };
    }
}