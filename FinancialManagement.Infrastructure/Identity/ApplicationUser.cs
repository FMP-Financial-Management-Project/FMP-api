using Microsoft.AspNetCore.Identity;

namespace FinancialManagement.Infrastructure.Identity
{
    public class ApplicationUser : IdentityUser<Guid>
    {
        public string FullName { get; set; } = string.Empty;
    }
}
