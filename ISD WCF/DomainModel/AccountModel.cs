using System;
using System.Collections.Generic;
using System.Linq;

namespace DomainModel
{
    public static class AccountModel
    {
        private static List<Account> _listAccounts = new List<Account>();

        static AccountModel()
        {
            _listAccounts.Add(new Account { User = "admin", Password = "admin" });
            _listAccounts.Add(new Account { User = "acc1", Password = "123" });
            _listAccounts.Add(new Account { User = "acc2", Password = "123" });
            _listAccounts.Add(new Account { User = "acc3", Password = "123" });
            _listAccounts.Add(new Account { User = "acc4", Password = "123" });
        }

        public static Boolean Login(String user, String pass)
        {
            return _listAccounts.Count(acc => acc.User.Equals(user) && acc.Password.Equals(pass)) > 0;
        }
    }
}
