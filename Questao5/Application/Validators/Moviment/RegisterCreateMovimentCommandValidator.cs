using Questao5.Domain.Interfaces.Repositories;

namespace Questao5.Application.Validators.Moviment
{
    public class RegisterCreateMovimentCommandValidator : CreateMovimentCommandValidator
    {
        public RegisterCreateMovimentCommandValidator(IAccountRepository repository) : base(repository)
        {
            ValidateAccountId();
            ValidateValue();
            ValidateType();
        }
    }
}
