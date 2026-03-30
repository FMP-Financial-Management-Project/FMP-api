namespace FinancialManagement.Domain
{
    public abstract class BaseEntity : IEntity
    {
        public Guid Id { get; set;  }
    }
}
