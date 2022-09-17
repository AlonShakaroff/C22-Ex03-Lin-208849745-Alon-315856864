using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using BasicFacebookFeatures.SubForms;
using FacebookWrapper;
using FacebookWinFormsEngine;

namespace BasicFacebookFeatures
{
    public partial class FacebookForm : Form
    {
        private const bool k_IsEnableOptions = true;
        private readonly FacebookUserManager r_FacebookUserManager;
        private readonly Random r_Random;
        private readonly FormAlbums r_FormAlbums;
        private readonly FormCollage r_FormCollage;
        private readonly FormGroups r_FormGroups;
        private readonly FormPages r_FormPages;
        private readonly FormPosts r_FormPosts;
        private readonly FormUserInfo r_FormUserInfo;
        private Form m_ActiveForm;
        private Button m_CurrentSelectedButton;
        private int m_RandomColorIndex;

        public FacebookForm()
        {
            InitializeComponent();
            FacebookService.s_CollectionLimit = 100;
            r_Random = new Random();
            r_FacebookUserManager = FacebookUserManager.Instance;
            r_FormAlbums = (FormAlbums)SubFormFactory.CreateSubForm(SubFormFactory.eSubFormType.FormAlbums);
            r_FormCollage = (FormCollage)SubFormFactory.CreateSubForm(SubFormFactory.eSubFormType.FormCollage);
            r_FormGroups = (FormGroups)SubFormFactory.CreateSubForm(SubFormFactory.eSubFormType.FormGroups);
            r_FormPages = (FormPages)SubFormFactory.CreateSubForm(SubFormFactory.eSubFormType.FormPages);
            r_FormPosts = (FormPosts)SubFormFactory.CreateSubForm(SubFormFactory.eSubFormType.FormPosts);
            r_FormUserInfo = (FormUserInfo)SubFormFactory.CreateSubForm(SubFormFactory.eSubFormType.FormUserInfo);
        }

        private Color selectThemeColor()
        {
            string color;
            int index = r_Random.Next(UIThemeColor.MenuColorsList.Count);
            
            while (m_RandomColorIndex == index)
            {
                index = r_Random.Next(UIThemeColor.MenuColorsList.Count);
            }

            m_RandomColorIndex = index;
            color = UIThemeColor.MenuColorsList[index];

            return ColorTranslator.FromHtml(color);
        }

        private void selectButton(object i_ButtonSender)
        {
            Color color;

            if (i_ButtonSender != null && m_CurrentSelectedButton != (Button)i_ButtonSender)
            {
                deselectButton();
                color = selectThemeColor();
                m_CurrentSelectedButton = (Button)i_ButtonSender;
                m_CurrentSelectedButton.BackColor = color;
                m_CurrentSelectedButton.ForeColor = Color.White;
                m_CurrentSelectedButton.Font = new System.Drawing.Font(
                    "Microsoft Sans Serif",
                    12.5F,
                    FontStyle.Regular,
                    GraphicsUnit.Point,
                    0);
                panelTitleBar.BackColor = color;
                panelLogo.BackColor = UIThemeColor.ChangeColorBrightness(color, -0.3);
                UIThemeColor.PrimaryColor = color;
                UIThemeColor.SecondaryColor = UIThemeColor.ChangeColorBrightness(color, -0.3);
            }
        }

        private void deselectButton()
        {
            foreach(Control previousButton in panelMenu.Controls)
            {
                if(previousButton.GetType() == typeof(Button))
                {
                    previousButton.BackColor = Color.FromArgb(51, 51, 76);
                    previousButton.ForeColor = Color.Gainsboro;
                    previousButton.Font = new System.Drawing.Font(
                        "Microsoft Sans Serif",
                        10F,
                        FontStyle.Regular,
                        GraphicsUnit.Point,
                        0);
                }
            }
        }

        private void buttonLogin_Click(object i_Sender, EventArgs i_E)
        {
            if(r_FacebookUserManager.Login())
            {
                buttonLogin.Enabled = false;
                setEnableApplicationOptions(k_IsEnableOptions);
                setLoginEnable(!k_IsEnableOptions);
                fetchUserInformation();
            }
            else
            {
                MessageBox.Show("Error occurred while trying to login ");
            }
        }

        private void fetchUserInformation()
        {
            pictureBoxCircleProfilePicture.LoadAsync(r_FacebookUserManager.LoggedInUser.PictureSquareUrl);
            labelProfileName.Text = r_FacebookUserManager.LoggedInUser.FirstName;
        }

        private void setEnableApplicationOptions(bool i_IsEnable)
        {
            buttonUserInfo.Enabled = i_IsEnable;
            buttonAlbums.Enabled = i_IsEnable;
            buttonGroups.Enabled = i_IsEnable;
            buttonPages.Enabled = i_IsEnable;
            buttonPosts.Enabled = i_IsEnable;
            buttonCollage.Enabled = i_IsEnable;
            buttonLogout.Enabled = i_IsEnable;
            pictureBoxCircleProfilePicture.Visible = i_IsEnable;
            labelProfileName.Visible = i_IsEnable;
        }

        private void setLoginEnable(bool i_IsEnable)
        {
            buttonLogout.Enabled = !i_IsEnable;
            buttonLogin.Enabled = i_IsEnable;
        }

        private void buttonLogout_Click(object i_Sender, EventArgs i_E)
        {
            r_FacebookUserManager.Logout();
            Close();
        }

        private void openChildForm(Form i_ChildForm, object i_Sender)
        {
            selectButton(i_Sender);
            m_ActiveForm = i_ChildForm;
            m_ActiveForm.TopLevel = false;
            m_ActiveForm.FormBorderStyle = FormBorderStyle.None;
            m_ActiveForm.Dock = DockStyle.Fill;
            panelDesktopPanel.Controls.Add(i_ChildForm);
            panelDesktopPanel.Tag = i_ChildForm;
            m_ActiveForm.BringToFront();
            m_ActiveForm.Show();
            labelTitleBar.Text = i_ChildForm.Text;
        }

        private void buttonUserInfo_Click(object i_Sender, EventArgs i_E)
        {
            openChildForm(r_FormUserInfo, i_Sender);
        }

        private void buttonAlbums_Click(object i_Sender, EventArgs i_E)
        {
            openChildForm(r_FormAlbums, i_Sender);
        }

        private void buttonGroups_Click(object i_Sender, EventArgs i_E)
        {
            openChildForm(r_FormGroups, i_Sender);
        }

        private void buttonPages_Click(object i_Sender, EventArgs i_E)
        {
            openChildForm(r_FormPages, i_Sender);
        }

        private void buttonCollage_Click(object i_Sender, EventArgs i_E)
        {
            openChildForm(r_FormCollage, i_Sender);
        }

        private void buttonPosts_Click(object i_Sender, EventArgs i_E)
        {
            openChildForm(r_FormPosts, i_Sender);
        }
    }
}
