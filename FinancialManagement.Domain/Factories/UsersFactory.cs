using FinancialManagement.Domain.Entities;
using FinancialManagement.Domain.Enums;
using FinancialManagement.Domain.ObjectValue;

namespace FinancialManagement.Domain.Factories
{
    public static class UsersFactory
    {
        public static Users Create(int age, UserRole role, string name)
        {
            var paraAge = new AgeUser(age);

            var user = new Users(paraAge, role, name);

            return user;
        }
    }
}
