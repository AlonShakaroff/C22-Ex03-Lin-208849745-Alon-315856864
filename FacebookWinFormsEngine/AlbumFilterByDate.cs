using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace FacebookWinFormsEngine
{
    public class AlbumFilterByDate : IAlbumFilter
    {
        public bool FilterAlbum(Album i_AlbumToCheck)
        {
            bool wasAddedSuccessfully = false;
            if(i_AlbumToCheck.CreatedTime != null)
            {
                wasAddedSuccessfully = i_AlbumToCheck.CreatedTime.Value.Year > (DateTime.Now.Year - 2);
            }

            return wasAddedSuccessfully;
        }
    }
}
