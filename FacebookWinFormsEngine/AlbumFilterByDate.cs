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
        public bool FilterAlbum(Album i_AlbumToCheck, int i_YearCreated)
        {
            bool wasAddedSuccessfully = false;

            if(i_AlbumToCheck.CreatedTime != null)
            {
                wasAddedSuccessfully = i_AlbumToCheck.CreatedTime.Value.Year == i_YearCreated;
            }

            return wasAddedSuccessfully;
        }
    }
}
