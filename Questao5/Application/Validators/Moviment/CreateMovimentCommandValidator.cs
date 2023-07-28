using FluentValidation;
using Questao5.Application.Moviments.Commands.CreateUser;
using Questao5.Application.Validators.Base;
using Questao5.Domain.Interfaces.Repositories;
namespace Questao5.Application.Validators.Moviment
{

    public class CreateMovimentCommandValidator : BaseValidator<CreateMovimentCommand>
    {
        private readonly IAccountRepository _repository;

        public CreateMovimentCommandValidator(IAccountRepository repository)
        {
            _repository = repository;
        }

        protected void ValidateAccountId()
        {
            RuleFor(x => x.AccountId)
                .NotEmpty()
                .Must(AccountExist).WithMessage("INVALID_ACCOUNT")
                .Must(ActiveAccount).WithMessage("INACTIVE_ACCOUNT");
        }

        protected void ValidateValue()
        {
            RuleFor(x => x.Value)
                .GreaterThan(0).WithMessage("INVALID_VALUE");
        }


        protected void ValidateType()
        {
            RuleFor(x => x.Type)
                .IsInEnum().WithMessage("INVALID_TYPE");
        }


        private bool AccountExist(Guid accountId)
        {
            var result = _repository.GetByIdAsync(accountId).Result;

            return result != null;

        }

        private bool ActiveAccount(Guid accountId)
        {
            var result = _repository.GetActiveAccountById(accountId).Result;

            return result != null;

        }



    }
}
