using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BasicFacebookFeatures.SubForms;

namespace BasicFacebookFeatures
{
    public static class SubFormFactory
    {
        public enum eSubFormType
        {
            FormAlbums,
            FormCollage,
            FormGroups,
            FormPages,
            FormPosts,
            FormUserInfo
        }

        public static Form CreateSubForm(eSubFormType i_SubFormType)
        {
            Form createdSubForm = null;

            switch (i_SubFormType)
            {
                case eSubFormType.FormAlbums:
                    createdSubForm = new FormAlbums();
                    break;
                case eSubFormType.FormCollage:
                    createdSubForm = new FormCollage();
                    break;
                case eSubFormType.FormGroups:
                    createdSubForm = new FormGroups();
                    break;
                case eSubFormType.FormPages:
                    createdSubForm = new FormPages();
                    break;
                case eSubFormType.FormPosts:
                    createdSubForm = new FormPosts();
                    break;
                case eSubFormType.FormUserInfo:
                    createdSubForm = new FormUserInfo();
                    break;
            }

            return createdSubForm;
        }
    }
}
