using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using FacebookWinFormsEngine;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures.SubForms
{
    public partial class FormAlbums : Form
    {
        private readonly FacebookUserManager r_FacebookUserManager;

        public FormAlbums()
        {
            InitializeComponent();
            r_FacebookUserManager = FacebookUserManager.Instance;
            this.HandleCreated += FormAlbums_HandleCreated;
        }

        private void FormAlbums_HandleCreated(object sender, EventArgs e)
        {
            new Thread(fetchAlbums).Start();
        }

        private void buttonFetchAlbums_Click(object i_Sender, EventArgs i_E)
        {
            if(IsHandleCreated)
            {
                new Thread(fetchAlbums).Start();
            }
        }

        private void fetchAlbums()
        {
            listBoxAlbumsList.Invoke(new Action(() => listBoxAlbumsList.Items.Clear()));
            foreach (Album userAlbum in r_FacebookUserManager.LoggedInUser.Albums)
            {
                listBoxAlbumsList.Invoke(new Action(() => listBoxAlbumsList.Items.Add(userAlbum)));
            }

            if (listBoxAlbumsList.Items.Count == 0)
            {
                listBoxAlbumsList.Invoke(new Action(() => listBoxAlbumsList.Items.Add("No Albums to fetch")));
            }
        }

        private void listBoxAlbumsList_SelectedValueChanged(object i_Sender, EventArgs i_E)
        {
            DateTime? dateTime;
            DateTime createdTime;

            if (listBoxAlbumsList.Items.Count != 0)
            {
                labelCoverPhoto.Visible = true;
                pictureBoxAlbumsCoverPhoto.LoadAsync((listBoxAlbumsList.SelectedItem as Album)?.PictureAlbumURL);
                labelDateCreated.Visible = true;
                dateTime = (listBoxAlbumsList.SelectedItem as Album)?.CreatedTime;
                if(dateTime != null)
                {
                    createdTime = (DateTime)dateTime;
                    textBoxDateCreated.Text = createdTime.ToString("d");
                }
            }
        }

        private void FormAlbums_Load(object i_Sender, EventArgs i_E)
        {
            UIThemeColor.LoadTheme(panelAlbums);
        }

        private void buttonSortAlbums_Click(object i_Sender, EventArgs i_E)
        {
            List<Album> sortedAlbumsList;

            if (listBoxAlbumsList.Items.Count != 0)
            {
                if (radioButtonSortByDate.Checked)
                {
                    sortedAlbumsList = listBoxAlbumsList.Items.Cast<Album>()
                        .OrderByDescending(i_Album => i_Album.CreatedTime).ToList();
                    listBoxAlbumsList.Items.Clear();
                    foreach (Album album in sortedAlbumsList)
                    {
                        listBoxAlbumsList.Items.Add(album);
                    }
                }
                else if (radioButtonSortByAmountOfPhotos.Created)
                {
                    sortedAlbumsList = listBoxAlbumsList.Items.Cast<Album>()
                        .OrderByDescending(i_Album => i_Album.Photos.Count).ToList();
                    listBoxAlbumsList.Items.Clear();
                    foreach (Album album in sortedAlbumsList)
                    {
                        listBoxAlbumsList.Items.Add(album);
                    }
                }
            }
        }
    }
}
