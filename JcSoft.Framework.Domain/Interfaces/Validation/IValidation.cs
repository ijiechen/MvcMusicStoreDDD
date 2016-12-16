using JcSoft.Framework.Domain.Validation;

namespace JcSoft.Framework.Domain.Interfaces.Validation
{
    public interface IValidation<in TEntity>
    {
        ValidationResult Valid(TEntity entity);
    }
}