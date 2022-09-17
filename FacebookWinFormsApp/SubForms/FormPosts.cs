using System;
using System.Threading;
using System.Windows.Forms;
using FacebookWinFormsEngine;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures.SubForms
{
    public partial class FormPosts : Form
    {
        private readonly FacebookUserManager r_FacebookUserManager;

        public FormPosts()
        {
            r_FacebookUserManager = FacebookUserManager.Instance;
            InitializeComponent();
            this.HandleCreated += FormPosts_HandleCreated;
        }

        private void FormPosts_HandleCreated(object sender, EventArgs e)
        {
            new Thread(fetchPosts).Start();
        }

        private void buttonFetchPosts_Click(object i_Sender, EventArgs i_E)
        {
            if(IsHandleCreated)
            {
                new Thread(fetchPosts).Start();
            }
        }

        private void fetchPosts()
        {
            listBoxPostsList.Invoke(new Action(() => listBoxPostsList.Items.Clear()));
            foreach(Post userPost in r_FacebookUserManager.LoggedInUser.Posts)
            {
                listBoxPostsList.Invoke(new Action(() => listBoxPostsList.Items.Add(userPost)));
            }

            if(listBoxPostsList.Items.Count == 0)
            {
                listBoxPostsList.Invoke(new Action(() => listBoxPostsList.Items.Add("No posts to fetch")));
            }
        }

        private void listBoxEventsList_SelectedValueChanged(object i_Sender, EventArgs i_E)
        {
            pictureBoxPostPhotoDisplay.Visible = false;
            listBoxCommentsList.Items.Clear();
            if (listBoxPostsList.Items.Count != 0)
            {
                if(((Post)listBoxPostsList.SelectedItem).Type.Equals(Post.eType.photo))
                {
                    pictureBoxPostPhotoDisplay.Visible = true;
                    labelCoverPhoto.Visible = true;
                    pictureBoxPostPhotoDisplay.LoadAsync(((Post)listBoxPostsList.SelectedItem)?.PictureURL);
                }

                if(((Post)listBoxPostsList.SelectedItem)?.Comments.Count != 0)
                {
                    foreach(Comment comment in ((Post)listBoxPostsList.SelectedItem).Comments)
                    {
                        listBoxCommentsList.Items.Add(comment.Message);
                    }
                }
                else
                {
                    listBoxCommentsList.Items.Add("No comments on this post.");
                }
            }
        }

        private void buttonAddNewPost_Click(object i_Sender, EventArgs i_E)
        {
            try
            {
                Status postedStatus = r_FacebookUserManager.PostStatus(textBoxStatus.Text);
                MessageBox.Show("Status Posted! ID: " + postedStatus.Id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void textBoxStatus_TextChanged(object i_Sender, EventArgs i_E)
        {
            buttonPostNewStatus.Enabled = !textBoxStatus.Text.Equals(string.Empty);
        }

        private void FormPosts_Load(object i_Sender, EventArgs i_E)
        {
            UIThemeColor.LoadTheme(panelPosts);
        }

        private void buttonFilter_Click(object i_Sender, EventArgs i_E)
        {
            string filterKeyword = textBoxFilterByKeyword.Text;

            listBoxPostsList.Items.Clear();
            foreach (Post post in r_FacebookUserManager.FilterPostsByKeyword(filterKeyword))
            {
                listBoxPostsList.Items.Add(post);
            }
        }
    }
}