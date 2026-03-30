using System;
using System.Collections.Generic;
using System.Text;

namespace FinancialManagement.Domain.Exceptions.User
{
    public class UserAgeNotValid : DomainException
    {
        public UserAgeNotValid(string? message) : base($"AgeUser {message} user not correct!") { }
    }
}
