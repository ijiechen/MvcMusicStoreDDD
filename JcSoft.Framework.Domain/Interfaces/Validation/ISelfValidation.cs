using JcSoft.Framework.Domain.Validation;

namespace JcSoft.Framework.Domain.Interfaces.Validation
{
    public interface ISelfValidation
    {
        ValidationResult ValidationResult { get; }
        bool IsValid { get; }
    }
}