using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace FacebookWinFormsEngine
{
    public class AlbumFilterByMinNumberOfLikes : IAlbumFilter
    {
        public bool FilterAlbum(Album i_AlbumToCheck, int i_MinNumberOfLikes)
        {
            return i_AlbumToCheck.LikedBy.Count < i_MinNumberOfLikes;
        }
    }
}
