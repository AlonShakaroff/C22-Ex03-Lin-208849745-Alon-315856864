using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace FacebookWinFormsEngine
{
    public interface IAlbumFilter
    {
        bool FilterAlbum(Album i_AlbumToCheck, int i_FilterByParameter);
    }
}
