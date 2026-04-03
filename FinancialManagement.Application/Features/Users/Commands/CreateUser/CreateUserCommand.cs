using FinancialManagement.Application.Abstractions.Messaging;
using FinancialManagement.Domain.Enums;

namespace FinancialManagement.Application.Features.Users.Commands.CreateUser
{
    public record CreateUserCommand(
        Guid Id,
        int Age, 
        UserRole Role,
        string Name) : ICommand<Guid>;
}
