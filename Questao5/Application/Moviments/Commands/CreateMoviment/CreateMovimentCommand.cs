using Questao5.Application.Abstrations;
using Questao5.Domain.Enumerators;

namespace Questao5.Application.Moviments.Commands.CreateUser
{
    public class CreateMovimentCommand : ICommand<Guid>
    {
        protected Guid RequestId { get; set; } = Guid.NewGuid();
        public Guid AccountId { get; set; }
        public double Value { get; set; }
        public MovimentType Type { get; set; }
    }
}
