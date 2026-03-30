using FinancialManagement.Domain.Enums;
using FinancialManagement.Domain.Exceptions;
using FinancialManagement.Domain.ObjectValue;

namespace FinancialManagement.Domain.Entities
{
    public class Users : BaseEntity, IAggregateRoot
    {
        public Users() { }
        public Users(AgeUser age, UserRole role, string name)
        {
            if(string.IsNullOrEmpty(name))
            {
                throw new DomainException("Name cannot be null or empty.");
            }

            Age = age;
            Role = role;
            Name = name;
        }

        public AgeUser Age { get; set; }
        public UserRole Role { get; set; }
        public string Name { get; set; } = null!;
    }
}
