using System;
using FacebookWrapper.ObjectModel;

namespace FacebookWinFormsEngine
{
    public class FacebookUserCachingProxy
    {
        private readonly User r_FacebookUser;
        private FacebookObjectCollection<Post> m_LoggedInUserPosts;
        private FacebookObjectCollection<Group> m_LoggedInUserGroups;
        private FacebookObjectCollection<Page> m_LoggedInUserPages;
        private FacebookObjectCollection<Album> m_LoggedInUserAlbums;

        public FacebookUserCachingProxy(User i_FacebookUser)
        {
            r_FacebookUser = i_FacebookUser;
        }

        public FacebookObjectCollection<Post> Posts
        {
            get
            {
                return m_LoggedInUserPosts ?? (m_LoggedInUserPosts = r_FacebookUser.Posts);
            }
        }

        public FacebookObjectCollection<Album> Albums
        {
            get
            {
                return m_LoggedInUserAlbums ?? (m_LoggedInUserAlbums = r_FacebookUser.Albums);
            }
        }

        public FacebookObjectCollection<Page> Pages
        {
            get
            {
                return m_LoggedInUserPages ?? (m_LoggedInUserPages = r_FacebookUser.LikedPages);
            }
        }

        public FacebookObjectCollection<Group> Groups
        {
            get
            {
                return m_LoggedInUserGroups ?? (m_LoggedInUserGroups = r_FacebookUser.Groups);
            }
        }

        public string PictureSquareUrl
        {
            get
            {
                return r_FacebookUser.PictureSqaureURL;
            }
        }

        public string PictureNormalUrl
        {
            get
            {
                return r_FacebookUser.PictureNormalURL;
            }
        }

        public string FirstName
        {
            get
            {
                return r_FacebookUser.FirstName;
            }
        }

        public string Name
        {
            get
            {
                return r_FacebookUser.Name;
            }
        }

        public string Email
        {
            get
            {
                return r_FacebookUser.Email;
            }
        }

        public string Gender
        {
            get
            {
                return r_FacebookUser.Gender.ToString();
            }
        }

        public string Birthday
        {
            get
            {
                return r_FacebookUser.Birthday;
            }
        }

        public Status PostStatus(string i_StatusMessage)
        {
            return r_FacebookUser.PostStatus(i_StatusMessage);
        }
    }
}
