using JcSoft.Framework.Data.Context;
using JcSoft.Framework.Data.Context.Interfaces;
using MvcMusicStore.Data.Context;
using Ninject.Modules;

namespace MvcMusicStore.CrossCutting.InversionOfControl.Modules
{
    public class InfrastructureNinjectModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IDbContext>().To<MusicStoreContext>();
            Bind(typeof (IContextManager<>)).To(typeof (ContextManager<>));
            Bind(typeof(IUnitOfWork<>)).To((typeof(UnitOfWork<>)));
        }
    }
}
