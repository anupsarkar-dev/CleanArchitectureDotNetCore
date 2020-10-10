using CleanArchitecture.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Domain.Inferfaces
{
    public interface IUserAccountRepository
    {
        IEnumerable<UserAccount> GetUserAccounts();

        bool DeleteUser(string uid);
         

    }
}
