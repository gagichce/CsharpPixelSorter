namespace PixelSort
{
    partial class mainPage
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
            this.pictureBoxPreview = new System.Windows.Forms.PictureBox();
            this.openFileDialogPreview = new System.Windows.Forms.OpenFileDialog();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.buttonPreview = new System.Windows.Forms.Button();
            this.saveFileDialogPreview = new System.Windows.Forms.SaveFileDialog();
            this.buttonPreviewSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxPreview
            // 
            this.pictureBoxPreview.Location = new System.Drawing.Point(13, 13);
            this.pictureBoxPreview.Name = "pictureBoxPreview";
            this.pictureBoxPreview.Size = new System.Drawing.Size(827, 504);
            this.pictureBoxPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPreview.TabIndex = 0;
            this.pictureBoxPreview.TabStop = false;
            // 
            // openFileDialogPreview
            // 
            this.openFileDialogPreview.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialogPreview_FileOk);
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Location = new System.Drawing.Point(858, 13);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(75, 23);
            this.buttonBrowse.TabIndex = 1;
            this.buttonBrowse.Text = "Browse..";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // buttonPreview
            // 
            this.buttonPreview.Location = new System.Drawing.Point(858, 42);
            this.buttonPreview.Name = "buttonPreview";
            this.buttonPreview.Size = new System.Drawing.Size(75, 23);
            this.buttonPreview.TabIndex = 2;
            this.buttonPreview.Text = "Preview";
            this.buttonPreview.UseVisualStyleBackColor = true;
            this.buttonPreview.Click += new System.EventHandler(this.buttonPreview_Click);
            // 
            // saveFileDialogPreview
            // 
            this.saveFileDialogPreview.CreatePrompt = true;
            this.saveFileDialogPreview.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialogPreview_FileOk);
            // 
            // buttonPreviewSave
            // 
            this.buttonPreviewSave.Location = new System.Drawing.Point(858, 72);
            this.buttonPreviewSave.Name = "buttonPreviewSave";
            this.buttonPreviewSave.Size = new System.Drawing.Size(75, 23);
            this.buttonPreviewSave.TabIndex = 3;
            this.buttonPreviewSave.Text = "Save";
            this.buttonPreviewSave.UseVisualStyleBackColor = true;
            this.buttonPreviewSave.Click += new System.EventHandler(this.buttonPreviewSave_Click);
            // 
            // mainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 551);
            this.Controls.Add(this.buttonPreviewSave);
            this.Controls.Add(this.buttonPreview);
            this.Controls.Add(this.buttonBrowse);
            this.Controls.Add(this.pictureBoxPreview);
            this.Name = "mainPage";
            this.Text = "Pixel Sorter - NVC Software";
            this.Load += new System.EventHandler(this.mainPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxPreview;
        private System.Windows.Forms.OpenFileDialog openFileDialogPreview;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.Button buttonPreview;
        private System.Windows.Forms.SaveFileDialog saveFileDialogPreview;
        private System.Windows.Forms.Button buttonPreviewSave;
    }
}

