using System.Collections.Generic;
using JcSoft.Framework.Domain.Interfaces.Validation;
using JcSoft.Framework.Domain.Validation;
using MvcMusicStore.Domain.Entities.Validations;

namespace MvcMusicStore.Domain.Entities
{
    public class Artist : ISelfValidation
    {
        public int ArtistId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Album> Albums { get; set; }

        public ValidationResult ValidationResult { get; private set; }

        public bool IsValid
        {
            get
            {
                var fiscal = new ArtistIsValidValidation();
                ValidationResult = fiscal.Valid(this);
                return ValidationResult.IsValid;
            }
        }
    }
}