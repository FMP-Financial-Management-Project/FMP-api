using MediatR;

namespace FinancialManagement.Application.Abstractions.Messaging
{
    public interface IQuery<out TReponse> : IRequest<TReponse>;
}
