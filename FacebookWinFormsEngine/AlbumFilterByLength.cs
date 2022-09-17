using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace FacebookWinFormsEngine
{
    public class AlbumFilterByLength : IAlbumFilter
    {
        public bool FilterAlbum(Album i_AlbumToCheck)
        {
            bool wasAddedSuccessfully = false;

            if(!string.IsNullOrEmpty(i_AlbumToCheck.Message))
            {
                wasAddedSuccessfully = i_AlbumToCheck.Message.Length < 50;
            }

            return wasAddedSuccessfully;
        }
    }
}
