namespace BasicFacebookFeatures.SubForms
{
    public partial class FormPages
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label likesCountLabel;
            System.Windows.Forms.Label uRLLabel;
            System.Windows.Forms.Label phoneLabel;
            this.panelPages = new System.Windows.Forms.Panel();
            this.phoneLabel1 = new System.Windows.Forms.Label();
            this.pageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uRLLinkLabel = new System.Windows.Forms.LinkLabel();
            this.likesCountLabel1 = new System.Windows.Forms.Label();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.imageLargePictureBox = new System.Windows.Forms.PictureBox();
            this.labelCoverPhoto = new System.Windows.Forms.Label();
            this.listBoxPagesList = new System.Windows.Forms.ListBox();
            this.buttonFetchPages = new System.Windows.Forms.Button();
            descriptionLabel = new System.Windows.Forms.Label();
            likesCountLabel = new System.Windows.Forms.Label();
            uRLLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            this.panelPages.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageLargePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(641, 505);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(126, 25);
            descriptionLabel.TabIndex = 7;
            descriptionLabel.Text = "Description:";
            // 
            // likesCountLabel
            // 
            likesCountLabel.AutoSize = true;
            likesCountLabel.Location = new System.Drawing.Point(641, 671);
            likesCountLabel.Name = "likesCountLabel";
            likesCountLabel.Size = new System.Drawing.Size(132, 25);
            likesCountLabel.TabIndex = 10;
            likesCountLabel.Text = "Likes Count:";
            // 
            // uRLLabel
            // 
            uRLLabel.AutoSize = true;
            uRLLabel.Location = new System.Drawing.Point(641, 716);
            uRLLabel.Name = "uRLLabel";
            uRLLabel.Size = new System.Drawing.Size(60, 25);
            uRLLabel.TabIndex = 11;
            uRLLabel.Text = "URL:";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new System.Drawing.Point(641, 627);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(80, 25);
            phoneLabel.TabIndex = 12;
            phoneLabel.Text = "Phone:";
            // 
            // panelPages
            // 
            this.panelPages.Controls.Add(phoneLabel);
            this.panelPages.Controls.Add(this.phoneLabel1);
            this.panelPages.Controls.Add(uRLLabel);
            this.panelPages.Controls.Add(this.uRLLinkLabel);
            this.panelPages.Controls.Add(likesCountLabel);
            this.panelPages.Controls.Add(this.likesCountLabel1);
            this.panelPages.Controls.Add(descriptionLabel);
            this.panelPages.Controls.Add(this.descriptionTextBox);
            this.panelPages.Controls.Add(this.imageLargePictureBox);
            this.panelPages.Controls.Add(this.labelCoverPhoto);
            this.panelPages.Controls.Add(this.listBoxPagesList);
            this.panelPages.Controls.Add(this.buttonFetchPages);
            this.panelPages.Cursor = System.Windows.Forms.Cursors.Default;
            this.panelPages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPages.Location = new System.Drawing.Point(0, 0);
            this.panelPages.Name = "panelPages";
            this.panelPages.Size = new System.Drawing.Size(1481, 945);
            this.panelPages.TabIndex = 2;
            // 
            // phoneLabel1
            // 
            this.phoneLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pageBindingSource, "Phone", true));
            this.phoneLabel1.Location = new System.Drawing.Point(779, 627);
            this.phoneLabel1.Name = "phoneLabel1";
            this.phoneLabel1.Size = new System.Drawing.Size(279, 23);
            this.phoneLabel1.TabIndex = 13;
            this.phoneLabel1.Text = "labelPhone";
            // 
            // pageBindingSource
            // 
            this.pageBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Page);
            // 
            // uRLLinkLabel
            // 
            this.uRLLinkLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pageBindingSource, "URL", true));
            this.uRLLinkLabel.Location = new System.Drawing.Point(779, 716);
            this.uRLLinkLabel.Name = "uRLLinkLabel";
            this.uRLLinkLabel.Size = new System.Drawing.Size(279, 23);
            this.uRLLinkLabel.TabIndex = 12;
            this.uRLLinkLabel.TabStop = true;
            this.uRLLinkLabel.Text = "Click here to go to page";
            // 
            // likesCountLabel1
            // 
            this.likesCountLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pageBindingSource, "LikesCount", true));
            this.likesCountLabel1.Location = new System.Drawing.Point(779, 673);
            this.likesCountLabel1.Name = "likesCountLabel1";
            this.likesCountLabel1.Size = new System.Drawing.Size(100, 23);
            this.likesCountLabel1.TabIndex = 11;
            this.likesCountLabel1.Text = "labelLikesCount";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pageBindingSource, "Description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(784, 502);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(358, 106);
            this.descriptionTextBox.TabIndex = 8;
            // 
            // imageLargePictureBox
            // 
            this.imageLargePictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.pageBindingSource, "ImageLarge", true));
            this.imageLargePictureBox.Location = new System.Drawing.Point(646, 154);
            this.imageLargePictureBox.Name = "imageLargePictureBox";
            this.imageLargePictureBox.Size = new System.Drawing.Size(496, 330);
            this.imageLargePictureBox.TabIndex = 10;
            this.imageLargePictureBox.TabStop = false;
            // 
            // labelCoverPhoto
            // 
            this.labelCoverPhoto.AutoSize = true;
            this.labelCoverPhoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCoverPhoto.Location = new System.Drawing.Point(639, 91);
            this.labelCoverPhoto.Name = "labelCoverPhoto";
            this.labelCoverPhoto.Size = new System.Drawing.Size(207, 39);
            this.labelCoverPhoto.TabIndex = 5;
            this.labelCoverPhoto.Text = "Page details";
            this.labelCoverPhoto.Visible = false;
            // 
            // listBoxPagesList
            // 
            this.listBoxPagesList.DataSource = this.pageBindingSource;
            this.listBoxPagesList.DisplayMember = "Name";
            this.listBoxPagesList.FormattingEnabled = true;
            this.listBoxPagesList.ItemHeight = 25;
            this.listBoxPagesList.Location = new System.Drawing.Point(107, 154);
            this.listBoxPagesList.Name = "listBoxPagesList";
            this.listBoxPagesList.Size = new System.Drawing.Size(507, 454);
            this.listBoxPagesList.TabIndex = 3;
            this.listBoxPagesList.SelectedValueChanged += new System.EventHandler(this.listBoxPagesList_SelectedValueChanged);
            // 
            // buttonFetchPages
            // 
            this.buttonFetchPages.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFetchPages.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFetchPages.Location = new System.Drawing.Point(107, 661);
            this.buttonFetchPages.Name = "buttonFetchPages";
            this.buttonFetchPages.Size = new System.Drawing.Size(204, 80);
            this.buttonFetchPages.TabIndex = 0;
            this.buttonFetchPages.Text = "Fetch pages";
            this.buttonFetchPages.UseVisualStyleBackColor = true;
            this.buttonFetchPages.Click += new System.EventHandler(this.buttonFetchPages_Click);
            // 
            // FormPages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1481, 945);
            this.Controls.Add(this.panelPages);
            this.MaximumSize = new System.Drawing.Size(1507, 1016);
            this.MinimumSize = new System.Drawing.Size(1507, 1016);
            this.Name = "FormPages";
            this.Text = "Pages";
            this.Load += new System.EventHandler(this.FormPages_Load);
            this.panelPages.ResumeLayout(false);
            this.panelPages.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pageBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageLargePictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPages;
        private System.Windows.Forms.ListBox listBoxPagesList;
        private System.Windows.Forms.Button buttonFetchPages;
        private System.Windows.Forms.Label labelCoverPhoto;
        private System.Windows.Forms.BindingSource pageBindingSource;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.PictureBox imageLargePictureBox;
        private System.Windows.Forms.Label likesCountLabel1;
        private System.Windows.Forms.LinkLabel uRLLinkLabel;
        private System.Windows.Forms.Label phoneLabel1;
    }
}