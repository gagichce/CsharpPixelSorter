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

        RadioButtonStatus mySortMethod = new RadioButtonStatus();

        private enum RadioButtonStatus
        {
            none,
            Average1,
            Average2,
            Block
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

        private void updateImage()
        {
            Sort thisSort = new Sort(Image.FromFile(openFileDialogPreview.FileName));
            switch (mySortMethod)
            {
                case RadioButtonStatus.Average1:
                    pictureBoxPreview.Image = thisSort.SortImage((float)toleranceUpDown.Value / 100f);
                    break;
                case RadioButtonStatus.Average2:
                    pictureBoxPreview.Image = thisSort.SortImage2((float)toleranceUpDown.Value / 100f);
                    break;
                case RadioButtonStatus.Block:
                    pictureBoxPreview.Image = thisSort.SortImageBlock((float)toleranceUpDown.Value / 100f);
                    break;
            }
        }

        private void saveFileDialogPreview_FileOk(object sender, CancelEventArgs e)
        {
            pictureBoxPreview.Image.Save(saveFileDialogPreview.FileName, System.Drawing.Imaging.ImageFormat.Png);
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

        private void radioButtonAverage1_CheckedChanged(object sender, EventArgs e)
        {
            mySortMethod = RadioButtonStatus.Average1;
        }

        private void radioButtonAverage2_CheckedChanged(object sender, EventArgs e)
        {
            mySortMethod = RadioButtonStatus.Average2;
        }

        private void radioButtonBlock_CheckedChanged(object sender, EventArgs e)
        {
            mySortMethod = RadioButtonStatus.Block;
        }
    }
}
