using MediatR;

namespace Questao5.Application.Abstrations
{
    public interface ICommand<out TResponse> : IRequest<TResponse>
    {
    }
}