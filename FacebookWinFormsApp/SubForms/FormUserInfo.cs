using System;
using System.Windows.Forms;
using FacebookWinFormsEngine;

namespace BasicFacebookFeatures.SubForms
{
    public partial class FormUserInfo : Form
    {
        private readonly FacebookUserManager r_FacebookUserManager;

        public FormUserInfo()
        {
            InitializeComponent();
            r_FacebookUserManager = FacebookUserManager.Instance;
            this.HandleCreated += FormUserInfo_HandleCreated;
        }

        private void FormUserInfo_HandleCreated(object sender, EventArgs e)
        {
            fetchAndDisplayUserInfo();
        }

        private void fetchAndDisplayUserInfo()
        {
            labelUserInfoWelcome.Text += r_FacebookUserManager.LoggedInUser.FirstName + "!";
            labelUserInfoName.Text += r_FacebookUserManager.LoggedInUser.Name;
            labelUserInfoEmail.Text += r_FacebookUserManager.LoggedInUser.Email;
            labelUserInfoGender.Text += r_FacebookUserManager.LoggedInUser.Gender;
            labelUserBirthDate.Text += r_FacebookUserManager.LoggedInUser.Birthday;
            pictureBoxUserInfoProfilePicture.Visible = true;
            pictureBoxUserInfoProfilePicture.LoadAsync(r_FacebookUserManager.LoggedInUser.PictureNormalUrl);
        }

        private void FormUserInfo_Load(object i_Sender, EventArgs i_E)
        {
            UIThemeColor.LoadTheme(panelUserInfo);
        }
    }
}
