using JcSoft.Framework.Domain.Services.Common;
using MvcMusicStore.Domain.Entities;
using MvcMusicStore.Domain.Interfaces.Repository;
using MvcMusicStore.Domain.Interfaces.Repository.ReadOnly;
using MvcMusicStore.Domain.Interfaces.Service;

namespace MvcMusicStore.Domain.Services
{
    public class AlbumService : Service<Album>, IAlbumService
    {
        public AlbumService(IAlbumRepository repository, IAlbumReadOnlyRepository readOnlyRepository) 
            : base(repository, readOnlyRepository)
        {
        }
    }
}
