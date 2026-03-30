using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace FinancialManagement.Infrastructure.Persistence.Connection
{
    public interface IDbConnectionFactory
    {
        IDbConnection Create();
    }
}
