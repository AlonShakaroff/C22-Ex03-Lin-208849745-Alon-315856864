using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace FacebookWinFormsEngine
{
    public class AlbumFilterByMinAmountOfPhotos : IAlbumFilter
    {
        public bool FilterAlbum(Album i_AlbumToCheck, int i_MinAmountOfPhotos)
        {
            return i_AlbumToCheck.Count < i_MinAmountOfPhotos;
        }
    }
}
