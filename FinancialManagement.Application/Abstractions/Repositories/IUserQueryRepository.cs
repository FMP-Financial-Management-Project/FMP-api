using FinancialManagement.Application.Features.Users.DTOs;
using FinancialManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinancialManagement.Application.Abstractions.Repositories
{
    public interface IUserQueryRepository
    {
        Task<List<UserDto>> GetAllUserAsync(CancellationToken cancellationToken = default);
    }
}
