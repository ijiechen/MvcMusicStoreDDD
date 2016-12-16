using JcSoft.Framework.Domain.Validation;
using MvcMusicStore.Domain.Entities.Specifications.ArtistSpecs;

namespace MvcMusicStore.Domain.Entities.Validations
{
    public class ArtistIsValidValidation : Validation<Artist>
    {
        public ArtistIsValidValidation()
        {
            base.AddRule(new ValidationRule<Artist>(new ArtistNameIsRequiredSpec(), ValidationMessages.NameIsRequired));
        }
    }
}
