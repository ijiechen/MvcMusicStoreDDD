using JcSoft.Framework.Domain.Services.Common;
using MvcMusicStore.Domain.Entities;
using MvcMusicStore.Domain.Interfaces.Repository;
using MvcMusicStore.Domain.Interfaces.Repository.ReadOnly;
using MvcMusicStore.Domain.Interfaces.Service;

namespace MvcMusicStore.Domain.Services
{
    public class OrderService : Service<Order>, IOrderService
    {
        public OrderService(IOrderRepository repository, IOrderReadOnlyRepository readOnlyRepository) 
            : base(repository, readOnlyRepository)
        {
        }
    }
}
