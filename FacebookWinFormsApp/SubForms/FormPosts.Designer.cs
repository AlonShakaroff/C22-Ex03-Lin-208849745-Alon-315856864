namespace BasicFacebookFeatures.SubForms
{
    public partial class FormPosts
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBoxPostsList = new System.Windows.Forms.ListBox();
            this.buttonFetchPosts = new System.Windows.Forms.Button();
            this.panelPosts = new System.Windows.Forms.Panel();
            this.buttonFilter = new System.Windows.Forms.Button();
            this.textBoxFilterByKeyword = new System.Windows.Forms.TextBox();
            this.labelFilter = new System.Windows.Forms.Label();
            this.labelCoverPhoto = new System.Windows.Forms.Label();
            this.listBoxCommentsList = new System.Windows.Forms.ListBox();
            this.textBoxStatus = new System.Windows.Forms.TextBox();
            this.pictureBoxPostPhotoDisplay = new System.Windows.Forms.PictureBox();
            this.buttonPostNewStatus = new System.Windows.Forms.Button();
            this.panelPosts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPostPhotoDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxPostsList
            // 
            this.listBoxPostsList.FormattingEnabled = true;
            this.listBoxPostsList.ItemHeight = 25;
            this.listBoxPostsList.Location = new System.Drawing.Point(106, 95);
            this.listBoxPostsList.Name = "listBoxPostsList";
            this.listBoxPostsList.Size = new System.Drawing.Size(506, 204);
            this.listBoxPostsList.TabIndex = 3;
            this.listBoxPostsList.SelectedValueChanged += new System.EventHandler(this.listBoxEventsList_SelectedValueChanged);
            // 
            // buttonFetchPosts
            // 
            this.buttonFetchPosts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFetchPosts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFetchPosts.Location = new System.Drawing.Point(106, 573);
            this.buttonFetchPosts.Name = "buttonFetchPosts";
            this.buttonFetchPosts.Size = new System.Drawing.Size(204, 80);
            this.buttonFetchPosts.TabIndex = 0;
            this.buttonFetchPosts.Text = "Fetch posts";
            this.buttonFetchPosts.UseVisualStyleBackColor = true;
            this.buttonFetchPosts.Click += new System.EventHandler(this.buttonFetchPosts_Click);
            // 
            // panelPosts
            // 
            this.panelPosts.Controls.Add(this.buttonFilter);
            this.panelPosts.Controls.Add(this.textBoxFilterByKeyword);
            this.panelPosts.Controls.Add(this.labelFilter);
            this.panelPosts.Controls.Add(this.labelCoverPhoto);
            this.panelPosts.Controls.Add(this.listBoxCommentsList);
            this.panelPosts.Controls.Add(this.textBoxStatus);
            this.panelPosts.Controls.Add(this.pictureBoxPostPhotoDisplay);
            this.panelPosts.Controls.Add(this.buttonPostNewStatus);
            this.panelPosts.Controls.Add(this.listBoxPostsList);
            this.panelPosts.Controls.Add(this.buttonFetchPosts);
            this.panelPosts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPosts.Location = new System.Drawing.Point(0, 0);
            this.panelPosts.Name = "panelPosts";
            this.panelPosts.Size = new System.Drawing.Size(1478, 931);
            this.panelPosts.TabIndex = 1;
            // 
            // buttonFilter
            // 
            this.buttonFilter.Location = new System.Drawing.Point(632, 175);
            this.buttonFilter.Name = "buttonFilter";
            this.buttonFilter.Size = new System.Drawing.Size(230, 63);
            this.buttonFilter.TabIndex = 17;
            this.buttonFilter.Text = "Filter";
            this.buttonFilter.UseVisualStyleBackColor = true;
            this.buttonFilter.Click += new System.EventHandler(this.buttonFilter_Click);
            // 
            // textBoxFilterByKeyword
            // 
            this.textBoxFilterByKeyword.Location = new System.Drawing.Point(632, 129);
            this.textBoxFilterByKeyword.Name = "textBoxFilterByKeyword";
            this.textBoxFilterByKeyword.Size = new System.Drawing.Size(229, 31);
            this.textBoxFilterByKeyword.TabIndex = 16;
            // 
            // labelFilter
            // 
            this.labelFilter.AutoSize = true;
            this.labelFilter.Location = new System.Drawing.Point(626, 95);
            this.labelFilter.Name = "labelFilter";
            this.labelFilter.Size = new System.Drawing.Size(175, 25);
            this.labelFilter.TabIndex = 15;
            this.labelFilter.Text = "Filter by keyword";
            // 
            // labelCoverPhoto
            // 
            this.labelCoverPhoto.AutoSize = true;
            this.labelCoverPhoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCoverPhoto.Location = new System.Drawing.Point(872, 23);
            this.labelCoverPhoto.Name = "labelCoverPhoto";
            this.labelCoverPhoto.Size = new System.Drawing.Size(207, 39);
            this.labelCoverPhoto.TabIndex = 14;
            this.labelCoverPhoto.Text = "Post\'s photo";
            this.labelCoverPhoto.Visible = false;
            // 
            // listBoxCommentsList
            // 
            this.listBoxCommentsList.FormattingEnabled = true;
            this.listBoxCommentsList.ItemHeight = 25;
            this.listBoxCommentsList.Location = new System.Drawing.Point(106, 345);
            this.listBoxCommentsList.Name = "listBoxCommentsList";
            this.listBoxCommentsList.Size = new System.Drawing.Size(506, 204);
            this.listBoxCommentsList.TabIndex = 8;
            // 
            // textBoxStatus
            // 
            this.textBoxStatus.Location = new System.Drawing.Point(106, 677);
            this.textBoxStatus.Multiline = true;
            this.textBoxStatus.Name = "textBoxStatus";
            this.textBoxStatus.Size = new System.Drawing.Size(528, 101);
            this.textBoxStatus.TabIndex = 7;
            this.textBoxStatus.TextChanged += new System.EventHandler(this.textBoxStatus_TextChanged);
            // 
            // pictureBoxPostPhotoDisplay
            // 
            this.pictureBoxPostPhotoDisplay.Location = new System.Drawing.Point(876, 95);
            this.pictureBoxPostPhotoDisplay.Name = "pictureBoxPostPhotoDisplay";
            this.pictureBoxPostPhotoDisplay.Size = new System.Drawing.Size(138, 143);
            this.pictureBoxPostPhotoDisplay.TabIndex = 6;
            this.pictureBoxPostPhotoDisplay.TabStop = false;
            // 
            // buttonPostNewStatus
            // 
            this.buttonPostNewStatus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPostNewStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPostNewStatus.Location = new System.Drawing.Point(656, 722);
            this.buttonPostNewStatus.Name = "buttonPostNewStatus";
            this.buttonPostNewStatus.Size = new System.Drawing.Size(204, 55);
            this.buttonPostNewStatus.TabIndex = 5;
            this.buttonPostNewStatus.Text = "Post a new status";
            this.buttonPostNewStatus.UseVisualStyleBackColor = true;
            this.buttonPostNewStatus.Click += new System.EventHandler(this.buttonAddNewPost_Click);
            // 
            // FormPosts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1478, 931);
            this.Controls.Add(this.panelPosts);
            this.MaximumSize = new System.Drawing.Size(1504, 1002);
            this.MinimumSize = new System.Drawing.Size(1504, 1002);
            this.Name = "FormPosts";
            this.Text = "Posts";
            this.Load += new System.EventHandler(this.FormPosts_Load);
            this.panelPosts.ResumeLayout(false);
            this.panelPosts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPostPhotoDisplay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxPostsList;
        private System.Windows.Forms.Button buttonFetchPosts;
        private System.Windows.Forms.Panel panelPosts;
        private System.Windows.Forms.Button buttonPostNewStatus;
        private System.Windows.Forms.PictureBox pictureBoxPostPhotoDisplay;
        private System.Windows.Forms.ListBox listBoxCommentsList;
        private System.Windows.Forms.TextBox textBoxStatus;
        private System.Windows.Forms.Label labelCoverPhoto;
        private System.Windows.Forms.Button buttonFilter;
        private System.Windows.Forms.TextBox textBoxFilterByKeyword;
        private System.Windows.Forms.Label labelFilter;
    }
}