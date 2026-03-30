using FinancialManagement.Domain.Exceptions.User;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace FinancialManagement.Domain.ObjectValue
{
    public sealed record AgeUser
    {
        public int Age { get; set; }

        public AgeUser(int age)
        {
            if (age < 18 || age > 25)
            {
                throw new UserAgeNotValid(age.ToString());
            }

            Age = age;
        }
    }
}
