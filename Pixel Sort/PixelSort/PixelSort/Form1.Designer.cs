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
            this.toleranceUpDown = new System.Windows.Forms.NumericUpDown();
            this.toleranceLbl = new System.Windows.Forms.Label();
            this.dynamicUpdatingCheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButtonAverage1 = new System.Windows.Forms.RadioButton();
            this.radioButtonAverage2 = new System.Windows.Forms.RadioButton();
            this.radioButtonBlock = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toleranceUpDown)).BeginInit();
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
            // toleranceUpDown
            // 
            this.toleranceUpDown.Location = new System.Drawing.Point(870, 138);
            this.toleranceUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.toleranceUpDown.Name = "toleranceUpDown";
            this.toleranceUpDown.Size = new System.Drawing.Size(46, 20);
            this.toleranceUpDown.TabIndex = 4;
            this.toleranceUpDown.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.toleranceUpDown.Click += new System.EventHandler(this.toleranceUpDown_Click);
            // 
            // toleranceLbl
            // 
            this.toleranceLbl.AutoSize = true;
            this.toleranceLbl.Location = new System.Drawing.Point(846, 122);
            this.toleranceLbl.Name = "toleranceLbl";
            this.toleranceLbl.Size = new System.Drawing.Size(94, 13);
            this.toleranceLbl.TabIndex = 5;
            this.toleranceLbl.Text = "Tolerance: (1-100)";
            // 
            // dynamicUpdatingCheckBox
            // 
            this.dynamicUpdatingCheckBox.AutoSize = true;
            this.dynamicUpdatingCheckBox.Checked = true;
            this.dynamicUpdatingCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.dynamicUpdatingCheckBox.Location = new System.Drawing.Point(861, 164);
            this.dynamicUpdatingCheckBox.Name = "dynamicUpdatingCheckBox";
            this.dynamicUpdatingCheckBox.Size = new System.Drawing.Size(67, 17);
            this.dynamicUpdatingCheckBox.TabIndex = 6;
            this.dynamicUpdatingCheckBox.Text = "Dynamic";
            this.dynamicUpdatingCheckBox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(846, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Method:";
            // 
            // radioButtonAverage1
            // 
            this.radioButtonAverage1.AutoSize = true;
            this.radioButtonAverage1.Checked = true;
            this.radioButtonAverage1.Location = new System.Drawing.Point(855, 200);
            this.radioButtonAverage1.Name = "radioButtonAverage1";
            this.radioButtonAverage1.Size = new System.Drawing.Size(74, 17);
            this.radioButtonAverage1.TabIndex = 8;
            this.radioButtonAverage1.TabStop = true;
            this.radioButtonAverage1.Text = "Average 1";
            this.radioButtonAverage1.UseVisualStyleBackColor = true;
            this.radioButtonAverage1.CheckedChanged += new System.EventHandler(this.radioButtonAverage1_CheckedChanged);
            // 
            // radioButtonAverage2
            // 
            this.radioButtonAverage2.AutoSize = true;
            this.radioButtonAverage2.Location = new System.Drawing.Point(855, 224);
            this.radioButtonAverage2.Name = "radioButtonAverage2";
            this.radioButtonAverage2.Size = new System.Drawing.Size(74, 17);
            this.radioButtonAverage2.TabIndex = 9;
            this.radioButtonAverage2.Text = "Average 2";
            this.radioButtonAverage2.UseVisualStyleBackColor = true;
            this.radioButtonAverage2.CheckedChanged += new System.EventHandler(this.radioButtonAverage2_CheckedChanged);
            // 
            // radioButtonBlock
            // 
            this.radioButtonBlock.AutoSize = true;
            this.radioButtonBlock.Location = new System.Drawing.Point(855, 247);
            this.radioButtonBlock.Name = "radioButtonBlock";
            this.radioButtonBlock.Size = new System.Drawing.Size(82, 17);
            this.radioButtonBlock.TabIndex = 10;
            this.radioButtonBlock.Text = "Block Swap";
            this.radioButtonBlock.UseVisualStyleBackColor = true;
            this.radioButtonBlock.CheckedChanged += new System.EventHandler(this.radioButtonBlock_CheckedChanged);
            // 
            // mainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 551);
            this.Controls.Add(this.radioButtonBlock);
            this.Controls.Add(this.radioButtonAverage2);
            this.Controls.Add(this.radioButtonAverage1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dynamicUpdatingCheckBox);
            this.Controls.Add(this.toleranceLbl);
            this.Controls.Add(this.toleranceUpDown);
            this.Controls.Add(this.buttonPreviewSave);
            this.Controls.Add(this.buttonPreview);
            this.Controls.Add(this.buttonBrowse);
            this.Controls.Add(this.pictureBoxPreview);
            this.Name = "mainPage";
            this.Text = "Pixel Sorter";
            this.Load += new System.EventHandler(this.mainPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toleranceUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxPreview;
        private System.Windows.Forms.OpenFileDialog openFileDialogPreview;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.Button buttonPreview;
        private System.Windows.Forms.SaveFileDialog saveFileDialogPreview;
        private System.Windows.Forms.Button buttonPreviewSave;
        private System.Windows.Forms.NumericUpDown toleranceUpDown;
        private System.Windows.Forms.Label toleranceLbl;
        private System.Windows.Forms.CheckBox dynamicUpdatingCheckBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButtonAverage1;
        private System.Windows.Forms.RadioButton radioButtonAverage2;
        private System.Windows.Forms.RadioButton radioButtonBlock;
    }
}

