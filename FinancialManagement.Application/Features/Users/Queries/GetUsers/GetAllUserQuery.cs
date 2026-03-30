using FinancialManagement.Application.Abstractions.Messaging;
using FinancialManagement.Application.Features.Users.DTOs;

namespace FinancialManagement.Application.Features.Users.Queries.GetUsers
{
    public sealed record GetAllUserQuery : IQuery<List<UserDto>>;
}
