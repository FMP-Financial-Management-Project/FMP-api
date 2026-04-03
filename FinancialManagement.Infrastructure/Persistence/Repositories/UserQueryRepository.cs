using FinancialManagement.Application.Abstractions.Repositories;
using FinancialManagement.Application.Features.Users.DTOs;
using SqlKata.Execution;

namespace FinancialManagement.Infrastructure.Persistence.Repositories
{
    internal class UserQueryRepository : IUserQueryRepository
    {
        private readonly QueryFactory _queryFactory;

        public UserQueryRepository(QueryFactory queryFactory)
        {
            _queryFactory = queryFactory;
        }

        public async Task<List<UserDto>> GetAllUserAsync(CancellationToken cancellationToken = default)
        {
            var query = _queryFactory.Query("Users")
                                    .Select("Id", "Age_Age as Value", "Role", "Name");

            var user = await query.GetAsync<UserDto>(cancellationToken: cancellationToken);

            return user.ToList();
        }
    }
}
