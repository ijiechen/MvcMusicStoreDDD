using JcSoft.Framework.Domain.Validation;
using MvcMusicStore.Domain.Entities.Specifications.CartSpecs;

namespace MvcMusicStore.Domain.Entities.Validations
{
    public class CartIsValidValidation : Validation<Cart>
    {
        public CartIsValidValidation()
        {
            base.AddRule(new ValidationRule<Cart>(new CartCountShouldBeGreaterThanZeroSpec(), ValidationMessages.NameIsRequired));
        }
    }
}
