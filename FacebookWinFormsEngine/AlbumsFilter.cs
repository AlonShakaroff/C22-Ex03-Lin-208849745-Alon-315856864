using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace FacebookWinFormsEngine
{
    public class AlbumsFilter : IEnumerable<Album>
    {
        private readonly List<Album> r_FilteredAlbumsList;
        private readonly FacebookUserManager r_FacebookUserManager;
        private IAlbumFilter m_AlbumFilter;

        public AlbumsFilter()
        {
            r_FilteredAlbumsList = new List<Album>();
            r_FacebookUserManager = FacebookUserManager.Instance;
        }

        public IEnumerator<Album> GetEnumerator()
        {
            return r_FilteredAlbumsList.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public IAlbumFilter AlbumFilter
        {
            set => m_AlbumFilter = value;
        }

        public void FilterAlbumList(int i_FilterParamater)
        {
            if(m_AlbumFilter != null && r_FacebookUserManager.LoggedInUser != null)
            {
                r_FilteredAlbumsList.Clear();
                foreach(Album currentAlbum in r_FacebookUserManager.LoggedInUser.Albums)
                {
                    if(m_AlbumFilter.FilterAlbum(currentAlbum, i_FilterParamater))
                    {
                        r_FilteredAlbumsList.Add(currentAlbum);
                    }
                }
            }
        }
    }
}
