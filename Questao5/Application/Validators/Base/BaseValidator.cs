using FluentValidation;
using FluentValidation.Results;
using Questao5.Domain.Entities.Base;

namespace Questao5.Application.Validators.Base
{
    public class BaseValidator<TEntity> : AbstractValidator<TEntity> where TEntity : class
    {

        public virtual ValidationResult IsValid(TEntity entity, TEntity oldEntity = null)
        {
            var context = new ValidationContext<TEntity>(entity);
            context.RootContextData.Add("oldEntity", oldEntity);
            return Validate(context);
        }

        protected TEntity OldEntity(IValidationContext context) => (TEntity)context.RootContextData["oldEntity"];
    }
}
