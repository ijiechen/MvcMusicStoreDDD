using JcSoft.Framework.Domain.Validation;
using MvcMusicStore.Domain.Entities.Specifications.GenreSpecs;

namespace MvcMusicStore.Domain.Entities.Validations
{
    public class GenreIsValidValidation : Validation<Genre>
    {
        public GenreIsValidValidation()
        {
            base.AddRule(new ValidationRule<Genre>(new GenreNameIsRequiredSpec(), ValidationMessages.NameIsRequired));
            base.AddRule(new ValidationRule<Genre>(new GenreDescriptionIsRequiredSpec(), ValidationMessages.DescriptionIsRequired));
        }
    }
}
