using DomainModel;
using System;
using System.IdentityModel.Selectors;
using System.IdentityModel.Tokens;

namespace Service.Autentification
{
    //Costume validator
    public class Validator : UserNamePasswordValidator
    {

        public override void Validate(string userName, string password)
        {
            if (AccountModel.Login(userName, password))
            {
                Console.WriteLine("User {0} connected", userName);
                return;
            }

            throw new SecurityTokenException("Account's invalid");
        }
    }
}
