using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PixelSort
{
    public partial class mainPage : Form
    {
        private string imagePath = "";
        public mainPage()
        {
            InitializeComponent();
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            openFileDialogPreview.ShowDialog();
        }

        private void mainPage_Load(object sender, EventArgs e)
        {
            openFileDialogPreview.InitialDirectory = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyPictures);
            saveFileDialogPreview.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            
        }

        private void openFileDialogPreview_FileOk(object sender, CancelEventArgs e)
        {
            pictureBoxPreview.ImageLocation = openFileDialogPreview.FileName;
        }

        private void buttonPreview_Click(object sender, EventArgs e)
        {
            updateImage();
        }

        private void updateImage() {
            Sort thisSort = new Sort(Image.FromFile(openFileDialogPreview.FileName));
            pictureBoxPreview.Image = thisSort.SortImage((float)toleranceUpDown.Value / 100f);
        }

        private void saveFileDialogPreview_FileOk(object sender, CancelEventArgs e)
        {
            pictureBoxPreview.Image.Save(saveFileDialogPreview.FileName,System.Drawing.Imaging.ImageFormat.Png);
        }

        private void buttonPreviewSave_Click(object sender, EventArgs e)
        {
            saveFileDialogPreview.ShowDialog();
        }

        private void toleranceUpDown_Click(object sender, EventArgs e)
        {
            if (dynamicUpdatingCheckBox.Checked && pictureBoxPreview.Image != null)
            {
                updateImage();
            }
        }
    }
}
