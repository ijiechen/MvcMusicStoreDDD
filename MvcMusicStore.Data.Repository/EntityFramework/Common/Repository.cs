using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using JcSoft.Framework.Data.Context;
using JcSoft.Framework.Data.Context.Interfaces;
using JcSoft.Framework.Data.Repository.EntityFramework.Common;
using JcSoft.Framework.Domain.Interfaces.Repository.Common;
using Microsoft.Practices.ServiceLocation;
using MvcMusicStore.Data.Context;

namespace MvcMusicStore.Data.Repository.EntityFramework.Common
{
    public class Repository<TEntity> :BaseRepository<MusicStoreContext,TEntity>, IRepository<TEntity>, IDisposable
        where TEntity : class
    {



    }
}
