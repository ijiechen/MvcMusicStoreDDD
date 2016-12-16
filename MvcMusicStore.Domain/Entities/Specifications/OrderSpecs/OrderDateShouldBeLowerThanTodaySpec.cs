using System;
using JcSoft.Framework.Domain.Interfaces.Specification;

namespace MvcMusicStore.Domain.Entities.Specifications.OrderSpecs
{
    public class OrderDateShouldBeLowerThanTodaySpec : ISpecification<Order>
    {
        public bool IsSatisfiedBy(Order order)
        {
            return order.OrderDate.Date <= DateTime.Today;
        }
    }
}
