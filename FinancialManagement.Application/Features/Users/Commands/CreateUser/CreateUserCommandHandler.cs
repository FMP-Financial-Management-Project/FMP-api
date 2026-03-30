using FinancialManagement.Application.Abstractions.Messaging;
using FinancialManagement.Domain.Factories;
using FinancialManagement.Domain.Interfaces;

namespace FinancialManagement.Application.Features.Users.Commands.CreateUser
{
    public class CreateUserCommandHandler(IUserRepository repoUser) : ICommandHandler<CreateUserCommand, Guid>
    {
        public async Task<Guid> Handle(CreateUserCommand req, CancellationToken cancellationToken)
        {
            var user = UsersFactory.Create(req.Age, req.Role, req.Name);
            
            await repoUser.AddAsync(user);

            await repoUser.CommitAsync();

            return user.Id;
        }
    }
}
