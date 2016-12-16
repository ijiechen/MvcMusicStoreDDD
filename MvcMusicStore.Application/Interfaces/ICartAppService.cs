using System.Collections.Generic;
using JcSoft.Framework.Application.Interfaces.Common;
using JcSoft.Framework.Domain.Validation;
using MvcMusicStore.Domain.Entities;

namespace MvcMusicStore.Application.Interfaces
{
    public interface ICartAppService : IAppService<Cart>
    {
        ValidationResult Remove(IEnumerable<Cart> carts);
        ValidationResult Update(IEnumerable<Cart> carts);
    }
}
