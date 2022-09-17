using System;
using System.Threading;
using System.Windows.Forms;
using Facebook;
using FacebookWinFormsEngine;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures.SubForms
{
    public partial class FormPages : Form
    {
        private readonly FacebookUserManager r_FacebookUserManager;

        public FormPages()
        {
            InitializeComponent();
            r_FacebookUserManager = FacebookUserManager.Instance;
            this.HandleCreated += FormPages_HandleCreated;
        }

        private void FormPages_HandleCreated(object sender, EventArgs e)
        {
            new Thread(fetchPages).Start();
        }

        private void listBoxPagesList_SelectedValueChanged(object i_Sender, EventArgs i_E)
        {
            if (listBoxPagesList.Items.Count != 0)
            {
                labelCoverPhoto.Visible = true;
            }
        }

        private void buttonFetchPages_Click(object i_Sender, EventArgs i_E)
        {
            if(IsHandleCreated)
            {
                new Thread(fetchPages).Start();
            }
        }

        private void fetchPages()
        {
            FacebookObjectCollection<Page> allPages = r_FacebookUserManager.LoggedInUser.Pages;

            if (!listBoxPagesList.InvokeRequired)
            {
                pageBindingSource.DataSource = allPages;
            }
            else
            {
                listBoxPagesList.Invoke(new Action(() => pageBindingSource.DataSource = allPages));
            }
        }

        private void FormPages_Load(object i_Sender, EventArgs i_E)
        {
            UIThemeColor.LoadTheme(panelPages);
        }
    }
}
