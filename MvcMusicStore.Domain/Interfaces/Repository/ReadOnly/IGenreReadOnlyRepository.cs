﻿using JcSoft.Framework.Domain.Interfaces.Repository.Common;
using MvcMusicStore.Domain.Entities;

namespace MvcMusicStore.Domain.Interfaces.Repository.ReadOnly
{
    public interface IGenreReadOnlyRepository : IReadOnlyRepository<Genre>
    {
        Genre GetWithAlbums(string genreName);
    }
}