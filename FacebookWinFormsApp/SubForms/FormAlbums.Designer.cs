namespace BasicFacebookFeatures.SubForms
{
    public partial class FormAlbums
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
            this.panelAlbums = new System.Windows.Forms.Panel();
            this.labelIntParameter = new System.Windows.Forms.Label();
            this.textBoxDateCreated = new System.Windows.Forms.TextBox();
            this.labelDateCreated = new System.Windows.Forms.Label();
            this.buttonFilterAlbums = new System.Windows.Forms.Button();
            this.groupBoxSortingButtons = new System.Windows.Forms.GroupBox();
            this.radioButtonNone = new System.Windows.Forms.RadioButton();
            this.radioButtonFilterByMinAmountOfPhotos = new System.Windows.Forms.RadioButton();
            this.radioButtonFilterByYearCreated = new System.Windows.Forms.RadioButton();
            this.labelCoverPhoto = new System.Windows.Forms.Label();
            this.listBoxAlbumsList = new System.Windows.Forms.ListBox();
            this.pictureBoxAlbumsCoverPhoto = new System.Windows.Forms.PictureBox();
            this.buttonFetchAlbums = new System.Windows.Forms.Button();
            this.numericUpDownParameter = new System.Windows.Forms.NumericUpDown();
            this.panelAlbums.SuspendLayout();
            this.groupBoxSortingButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlbumsCoverPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownParameter)).BeginInit();
            this.SuspendLayout();
            // 
            // panelAlbums
            // 
            this.panelAlbums.Controls.Add(this.numericUpDownParameter);
            this.panelAlbums.Controls.Add(this.labelIntParameter);
            this.panelAlbums.Controls.Add(this.textBoxDateCreated);
            this.panelAlbums.Controls.Add(this.labelDateCreated);
            this.panelAlbums.Controls.Add(this.buttonFilterAlbums);
            this.panelAlbums.Controls.Add(this.groupBoxSortingButtons);
            this.panelAlbums.Controls.Add(this.labelCoverPhoto);
            this.panelAlbums.Controls.Add(this.listBoxAlbumsList);
            this.panelAlbums.Controls.Add(this.pictureBoxAlbumsCoverPhoto);
            this.panelAlbums.Controls.Add(this.buttonFetchAlbums);
            this.panelAlbums.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAlbums.Location = new System.Drawing.Point(0, 0);
            this.panelAlbums.Margin = new System.Windows.Forms.Padding(2);
            this.panelAlbums.Name = "panelAlbums";
            this.panelAlbums.Size = new System.Drawing.Size(988, 611);
            this.panelAlbums.TabIndex = 0;
            // 
            // labelIntParameter
            // 
            this.labelIntParameter.AutoSize = true;
            this.labelIntParameter.Location = new System.Drawing.Point(547, 96);
            this.labelIntParameter.Name = "labelIntParameter";
            this.labelIntParameter.Size = new System.Drawing.Size(108, 17);
            this.labelIntParameter.TabIndex = 11;
            this.labelIntParameter.Text = "Filter parameter";
            // 
            // textBoxDateCreated
            // 
            this.textBoxDateCreated.Location = new System.Drawing.Point(639, 420);
            this.textBoxDateCreated.Name = "textBoxDateCreated";
            this.textBoxDateCreated.ReadOnly = true;
            this.textBoxDateCreated.Size = new System.Drawing.Size(100, 22);
            this.textBoxDateCreated.TabIndex = 9;
            // 
            // labelDateCreated
            // 
            this.labelDateCreated.AutoSize = true;
            this.labelDateCreated.Location = new System.Drawing.Point(532, 420);
            this.labelDateCreated.Name = "labelDateCreated";
            this.labelDateCreated.Size = new System.Drawing.Size(90, 17);
            this.labelDateCreated.TabIndex = 7;
            this.labelDateCreated.Text = "Date created";
            // 
            // buttonFilterAlbums
            // 
            this.buttonFilterAlbums.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFilterAlbums.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFilterAlbums.Location = new System.Drawing.Point(381, 223);
            this.buttonFilterAlbums.Margin = new System.Windows.Forms.Padding(2);
            this.buttonFilterAlbums.Name = "buttonFilterAlbums";
            this.buttonFilterAlbums.Size = new System.Drawing.Size(150, 51);
            this.buttonFilterAlbums.TabIndex = 6;
            this.buttonFilterAlbums.Text = "Filter albums";
            this.buttonFilterAlbums.UseVisualStyleBackColor = true;
            this.buttonFilterAlbums.Click += new System.EventHandler(this.buttonFilterAlbums_Click);
            // 
            // groupBoxSortingButtons
            // 
            this.groupBoxSortingButtons.Controls.Add(this.radioButtonNone);
            this.groupBoxSortingButtons.Controls.Add(this.radioButtonFilterByMinAmountOfPhotos);
            this.groupBoxSortingButtons.Controls.Add(this.radioButtonFilterByYearCreated);
            this.groupBoxSortingButtons.Location = new System.Drawing.Point(381, 95);
            this.groupBoxSortingButtons.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxSortingButtons.Name = "groupBoxSortingButtons";
            this.groupBoxSortingButtons.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxSortingButtons.Size = new System.Drawing.Size(159, 110);
            this.groupBoxSortingButtons.TabIndex = 5;
            this.groupBoxSortingButtons.TabStop = false;
            this.groupBoxSortingButtons.Text = "Filter albums by";
            // 
            // radioButtonNone
            // 
            this.radioButtonNone.AutoSize = true;
            this.radioButtonNone.Checked = true;
            this.radioButtonNone.Location = new System.Drawing.Point(4, 74);
            this.radioButtonNone.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonNone.Name = "radioButtonNone";
            this.radioButtonNone.Size = new System.Drawing.Size(63, 21);
            this.radioButtonNone.TabIndex = 3;
            this.radioButtonNone.TabStop = true;
            this.radioButtonNone.Text = "None";
            this.radioButtonNone.UseVisualStyleBackColor = true;
            // 
            // radioButtonFilterByMinAmountOfPhotos
            // 
            this.radioButtonFilterByMinAmountOfPhotos.AutoSize = true;
            this.radioButtonFilterByMinAmountOfPhotos.Location = new System.Drawing.Point(5, 49);
            this.radioButtonFilterByMinAmountOfPhotos.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonFilterByMinAmountOfPhotos.Name = "radioButtonFilterByMinAmountOfPhotos";
            this.radioButtonFilterByMinAmountOfPhotos.Size = new System.Drawing.Size(160, 21);
            this.radioButtonFilterByMinAmountOfPhotos.TabIndex = 1;
            this.radioButtonFilterByMinAmountOfPhotos.Text = "Amount of photos >=";
            this.radioButtonFilterByMinAmountOfPhotos.UseVisualStyleBackColor = true;
            // 
            // radioButtonFilterByYearCreated
            // 
            this.radioButtonFilterByYearCreated.AutoSize = true;
            this.radioButtonFilterByYearCreated.Location = new System.Drawing.Point(5, 27);
            this.radioButtonFilterByYearCreated.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonFilterByYearCreated.Name = "radioButtonFilterByYearCreated";
            this.radioButtonFilterByYearCreated.Size = new System.Drawing.Size(123, 21);
            this.radioButtonFilterByYearCreated.TabIndex = 0;
            this.radioButtonFilterByYearCreated.Text = "Year created =";
            this.radioButtonFilterByYearCreated.UseVisualStyleBackColor = true;
            // 
            // labelCoverPhoto
            // 
            this.labelCoverPhoto.AutoSize = true;
            this.labelCoverPhoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCoverPhoto.Location = new System.Drawing.Point(655, 52);
            this.labelCoverPhoto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCoverPhoto.Name = "labelCoverPhoto";
            this.labelCoverPhoto.Size = new System.Drawing.Size(209, 26);
            this.labelCoverPhoto.TabIndex = 4;
            this.labelCoverPhoto.Text = "Album\'s cover photo";
            this.labelCoverPhoto.Visible = false;
            // 
            // listBoxAlbumsList
            // 
            this.listBoxAlbumsList.FormattingEnabled = true;
            this.listBoxAlbumsList.ItemHeight = 16;
            this.listBoxAlbumsList.Location = new System.Drawing.Point(35, 95);
            this.listBoxAlbumsList.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxAlbumsList.Name = "listBoxAlbumsList";
            this.listBoxAlbumsList.Size = new System.Drawing.Size(339, 292);
            this.listBoxAlbumsList.TabIndex = 3;
            this.listBoxAlbumsList.SelectedValueChanged += new System.EventHandler(this.listBoxAlbumsList_SelectedValueChanged);
            // 
            // pictureBoxAlbumsCoverPhoto
            // 
            this.pictureBoxAlbumsCoverPhoto.Location = new System.Drawing.Point(660, 96);
            this.pictureBoxAlbumsCoverPhoto.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxAlbumsCoverPhoto.Name = "pictureBoxAlbumsCoverPhoto";
            this.pictureBoxAlbumsCoverPhoto.Size = new System.Drawing.Size(204, 178);
            this.pictureBoxAlbumsCoverPhoto.TabIndex = 2;
            this.pictureBoxAlbumsCoverPhoto.TabStop = false;
            // 
            // buttonFetchAlbums
            // 
            this.buttonFetchAlbums.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFetchAlbums.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFetchAlbums.Location = new System.Drawing.Point(35, 420);
            this.buttonFetchAlbums.Margin = new System.Windows.Forms.Padding(2);
            this.buttonFetchAlbums.Name = "buttonFetchAlbums";
            this.buttonFetchAlbums.Size = new System.Drawing.Size(136, 51);
            this.buttonFetchAlbums.TabIndex = 0;
            this.buttonFetchAlbums.Text = "Fetch albums";
            this.buttonFetchAlbums.UseVisualStyleBackColor = true;
            this.buttonFetchAlbums.Click += new System.EventHandler(this.buttonFetchAlbums_Click);
            // 
            // numericUpDownParameter
            // 
            this.numericUpDownParameter.Location = new System.Drawing.Point(550, 122);
            this.numericUpDownParameter.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownParameter.Name = "numericUpDownParameter";
            this.numericUpDownParameter.Size = new System.Drawing.Size(105, 22);
            this.numericUpDownParameter.TabIndex = 12;
            // 
            // FormAlbums
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 611);
            this.Controls.Add(this.panelAlbums);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(1006, 658);
            this.MinimumSize = new System.Drawing.Size(1006, 658);
            this.Name = "FormAlbums";
            this.Text = "Albums";
            this.Load += new System.EventHandler(this.FormAlbums_Load);
            this.panelAlbums.ResumeLayout(false);
            this.panelAlbums.PerformLayout();
            this.groupBoxSortingButtons.ResumeLayout(false);
            this.groupBoxSortingButtons.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlbumsCoverPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownParameter)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelAlbums;
        private System.Windows.Forms.PictureBox pictureBoxAlbumsCoverPhoto;
        private System.Windows.Forms.Button buttonFetchAlbums;
        private System.Windows.Forms.ListBox listBoxAlbumsList;
        private System.Windows.Forms.Label labelCoverPhoto;
        private System.Windows.Forms.Button buttonFilterAlbums;
        private System.Windows.Forms.GroupBox groupBoxSortingButtons;
        private System.Windows.Forms.RadioButton radioButtonFilterByMinAmountOfPhotos;
        private System.Windows.Forms.RadioButton radioButtonFilterByYearCreated;
        private System.Windows.Forms.TextBox textBoxDateCreated;
        private System.Windows.Forms.Label labelDateCreated;
        private System.Windows.Forms.RadioButton radioButtonNone;
        private System.Windows.Forms.Label labelIntParameter;
        private System.Windows.Forms.NumericUpDown numericUpDownParameter;
    }
}