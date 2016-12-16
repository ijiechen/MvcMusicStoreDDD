using JcSoft.Framework.Domain.Interfaces.Service.Common;
using MvcMusicStore.Domain.Entities;

namespace MvcMusicStore.Domain.Interfaces.Service
{
    public interface IGenreService : IService<Genre>
    {
        Genre GetWithAlbums(string genre);
    }
}