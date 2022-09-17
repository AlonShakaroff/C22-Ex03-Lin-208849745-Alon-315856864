using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using FacebookWinFormsEngine;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures.SubForms
{
    public partial class FormCollage : Form
    {
        private readonly FacebookUserManager r_FacebookUserManager;

        public FormCollage()
        {
            InitializeComponent();
            r_FacebookUserManager = FacebookUserManager.Instance;
            this.HandleCreated += FormCollage_HandleCreated;
        }

        private void FormCollage_HandleCreated(object sender, EventArgs e)
        {
            new Thread(fetchAllPhotos).Start();
        }

        private void buttonFetchPhotos_Click(object i_Sender, EventArgs i_E)
        {
            if(IsHandleCreated)
            {
                new Thread(fetchAllPhotos).Start();
            }
        }

        private void fetchAllPhotos()
        {
            listBoxPhotosList.Invoke(new Action(() => listBoxPhotosList.Items.Clear()));
            foreach (Album userAlbum in r_FacebookUserManager.LoggedInUser.Albums)
            {
                foreach (Photo userPhoto in userAlbum.Photos)
                {
                    listBoxPhotosList.Invoke(new Action(() => listBoxPhotosList.Items.Add(userPhoto)));
                }
            }

            if (listBoxPhotosList.Items.Count == 0)
            {
                listBoxPhotosList.Invoke(new Action(() => listBoxPhotosList.Items.Add("No photos to fetch.")));
            }
        }

        private void buttonMakeCollage_Click(object i_Sender, EventArgs i_E)
        {
            int pictureIndex = 0;
            int selectedPhotosCount = 0;
            List<Photo> photosToCollage = new List<Photo>();
            PictureBox currentPictureBox;

            clearPreviousCollage();
            if(listBoxPhotosList.SelectedItems.Count <= 4)
            {
                foreach(Photo currentSelectedPhoto in listBoxPhotosList.SelectedItems)
                {
                    photosToCollage.Add(currentSelectedPhoto);
                    selectedPhotosCount = photosToCollage.Count;
                }

                foreach(Control currentControl in panelCollageContainer.Controls)
                {
                    if(pictureIndex < selectedPhotosCount && currentControl.GetType() == typeof(PictureBox))
                    {
                        currentPictureBox = (PictureBox)currentControl;
                        currentPictureBox.Visible = true;
                        currentPictureBox.LoadAsync(photosToCollage.ElementAt(pictureIndex)?.PictureNormalURL);
                        pictureIndex++;
                    }
                }
            }
            else
            {
                MessageBox.Show("You have selected more than 4 photos");
            }
        }

        private void clearPreviousCollage()
        {
            PictureBox currentPictureBox;

            foreach (Control currentControl in panelCollageContainer.Controls)
            {
                if(currentControl.GetType() == typeof(PictureBox))
                {
                    currentPictureBox = (PictureBox)currentControl;
                    currentPictureBox.Image = null;
                }
            }
        }

        private void listBoxPhotosList_SelectedValueChanged(object i_Sender, EventArgs i_E)
        {
            labelCurrentSelectedPhoto.Visible = true;
            pictureBoxSample.LoadAsync((listBoxPhotosList.SelectedItem as Photo)?.PictureNormalURL);
        }

        private void FormCollage_Load(object i_Sender, EventArgs i_E)
        {
            UIThemeColor.LoadTheme(panelCollage);
        }
    }
}
