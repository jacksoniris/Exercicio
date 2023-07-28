using MediatR;

namespace Questao5.Application.Abstrations
{
    public interface IQuery<out TResponse> : IRequest<TResponse>
    {
    }
}