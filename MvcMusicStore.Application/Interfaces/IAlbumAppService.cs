using System.Collections.Generic;
using JcSoft.Framework.Application.Interfaces.Common;
using MvcMusicStore.Domain.Entities;

namespace MvcMusicStore.Application.Interfaces
{
    public interface IAlbumAppService : IAppService<Album>
    {
        IEnumerable<Album> GetTopSellingAlbums(int count);
        
    }
}
