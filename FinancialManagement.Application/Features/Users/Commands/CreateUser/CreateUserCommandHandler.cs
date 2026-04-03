using FinancialManagement.Domain.Interfaces;
using FinancialManagement.Application.Abstractions.Messaging;
using User = FinancialManagement.Domain.Entities.Users;

namespace FinancialManagement.Application.Features.Users.Commands.CreateUser
{
    public class CreateUserCommandHandler(IUserRepository repoUser) : ICommandHandler<CreateUserCommand, Guid>
    {
        public async Task<Guid> Handle(CreateUserCommand req, CancellationToken cancellationToken)
        {
            var user = User.Create(req.Age, req.Role, req.Name);

            await repoUser.AddAsync(user);

            await repoUser.CommitAsync();

            return user.Id;
        }
    }
}
