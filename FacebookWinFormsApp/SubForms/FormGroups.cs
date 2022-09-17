using System;
using System.Threading;
using System.Windows.Forms;
using FacebookWinFormsEngine;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures.SubForms
{
    public partial class FormGroups : Form
    {
        private readonly FacebookUserManager r_FacebookUserManager;

        public FormGroups()
        {
            InitializeComponent();
            r_FacebookUserManager = FacebookUserManager.Instance;
            this.HandleCreated += FormGroups_HandleCreated;
        }

        private void FormGroups_HandleCreated(object sender, EventArgs e)
        {
            new Thread(fetchGroups).Start();
        }

        private void buttonFetchGroups_Click(object i_Sender, EventArgs i_E)
        {
            if(IsHandleCreated)
            {
                new Thread(fetchGroups).Start();
            }
        }

        private void listBoxGroupsList_SelectedValueChanged(object i_Sender, EventArgs i_E)
        {
            if (listBoxGroupsList.Items.Count != 0)
            {
                labelCoverPhoto.Visible = true;
                pictureBoxGroupsCoverPhoto.LoadAsync((listBoxGroupsList.SelectedItem as Group)?.PictureLargeURL);
            }
        }

        private void fetchGroups()
        {
            listBoxGroupsList.Invoke(new Action(() => listBoxGroupsList.Items.Clear()));
            foreach (Group userGroup in r_FacebookUserManager.LoggedInUser.Groups)
            {
                listBoxGroupsList.Invoke(new Action(() => listBoxGroupsList.Items.Add(userGroup)));
            }

            if (listBoxGroupsList.Items.Count == 0)
            {
                listBoxGroupsList.Invoke(new Action(() => listBoxGroupsList.Items.Add("No Groups to fetch")));
            }
        }

        private void FormGroups_Load(object i_Sender, EventArgs i_E)
        {
            UIThemeColor.LoadTheme(panelGroups);
        }
    }
}
