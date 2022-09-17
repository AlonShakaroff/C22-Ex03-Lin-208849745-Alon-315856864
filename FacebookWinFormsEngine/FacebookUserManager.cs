using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace FacebookWinFormsEngine
{
    public sealed class FacebookUserManager
    {
        private static readonly object sr_CreationLockContext = new object();
        private static FacebookUserManager s_Instance = null;
        private LoginResult m_LoginResult;

        private FacebookUserManager() 
        {
        }

        public static FacebookUserManager Instance
        {
            get
            {
                if(s_Instance == null)
                {
                    lock(sr_CreationLockContext)
                    {
                        if(s_Instance == null)
                        {
                            s_Instance = new FacebookUserManager();
                        }
                    }
                }

                return s_Instance;
            }
        }

        public FacebookUserCachingProxy LoggedInUser { get; private set; } = null;

        public bool Login()
        {
            m_LoginResult = FacebookService.Login(
                "768643954263924",
                "email",
                "public_profile",
                "user_age_range",
                "user_birthday",
                "user_events",
                "user_friends",
                "user_gender",
                "user_hometown",
                "user_likes",
                "user_link",
                "user_location",
                "user_photos",
                "user_posts",
                "user_videos",
                "groups_access_member_info",
                "publish_to_groups",
                "pages_manage_posts",
                "pages_read_user_content");
            LoggedInUser = !string.IsNullOrEmpty(m_LoginResult.AccessToken) ? new FacebookUserCachingProxy(m_LoginResult.LoggedInUser) : null;

            return LoggedInUser != null;
        }

        public void Logout()
        {
            FacebookService.Logout();
        }

        public Status PostStatus(string i_StatusMessage)
        {
            Status postedStatus = LoggedInUser != null
                                      ? LoggedInUser.PostStatus(i_StatusMessage)
                                      : throw new Exception("No user is logged in");

            return postedStatus;
        }

        public List<Post> FilterPostsByKeyword(string i_Keyword)
        {
            List<Post> filteredPosts = new List<Post>();

            if (LoggedInUser.Posts != null)
            {
                foreach (Post userPost in LoggedInUser.Posts)
                {
                    if ((userPost.Message != null && userPost.Message.Contains(i_Keyword)) ||
                       (userPost.Description != null && userPost.Description.Contains(i_Keyword)) ||
                       (userPost.Caption != null && userPost.Caption.Contains(i_Keyword)) ||
                       i_Keyword == string.Empty)
                    {
                        filteredPosts.Add(userPost);
                    }
                }
            }

            return filteredPosts;
        }
    }
}
