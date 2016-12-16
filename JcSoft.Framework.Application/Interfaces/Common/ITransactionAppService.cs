using JcSoft.Framework.Data.Context.Interfaces;

namespace JcSoft.Framework.Application.Interfaces.Common
{
    public interface ITransactionAppService<TContext>
        where TContext : IDbContext, new()
    {
        void BeginTransaction();
        void Commit();
    }
}
