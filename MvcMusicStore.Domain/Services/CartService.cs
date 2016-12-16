using JcSoft.Framework.Domain.Services.Common;
using MvcMusicStore.Domain.Entities;
using MvcMusicStore.Domain.Interfaces.Repository;
using MvcMusicStore.Domain.Interfaces.Repository.ReadOnly;
using MvcMusicStore.Domain.Interfaces.Service;

namespace MvcMusicStore.Domain.Services
{
    public class CartService : Service<Cart>, ICartService
    {
        public CartService(ICartRepository repository, ICartReadOnlyRepository readOnlyRepository) 
            : base(repository, readOnlyRepository)
        {
        }
    }
}
