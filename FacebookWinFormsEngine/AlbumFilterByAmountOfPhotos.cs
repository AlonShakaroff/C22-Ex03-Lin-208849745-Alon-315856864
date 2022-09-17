using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace FacebookWinFormsEngine
{
    public class AlbumFilterByAmountOfPhotos : IAlbumFilter
    {
        public bool FilterAlbum(Album i_AlbumToCheck)
        {
            return i_AlbumToCheck.Count < 2;
        }
    }
}
