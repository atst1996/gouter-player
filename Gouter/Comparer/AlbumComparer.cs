﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gouter
{
    internal class AlbumComparer : IComparer<AlbumInfo>, IComparer<AlbumPlaylist>
    {
        public static readonly AlbumComparer Instance = new AlbumComparer();

        private static readonly IComparer<string> _albumNameComparer = AlbumManager.AlbumNameComparer;

        public int Compare(AlbumInfo x, AlbumInfo y)
        {
            return _albumNameComparer.Compare(x.Key, y.Key);
        }

        public int Compare(AlbumPlaylist x, AlbumPlaylist y)
        {
            return _albumNameComparer.Compare(x.Album.Key, y.Album.Key);
        }
    }
}
