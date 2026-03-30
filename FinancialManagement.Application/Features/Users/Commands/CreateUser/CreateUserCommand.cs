using FinancialManagement.Application.Abstractions.Messaging;
using FinancialManagement.Domain.Enums;

namespace FinancialManagement.Application.Features.Users.Commands.CreateUser
{
    public record CreateUserCommand(
        int Age, 
        UserRole Role,
        string Name) : ICommand<Guid>;
}
