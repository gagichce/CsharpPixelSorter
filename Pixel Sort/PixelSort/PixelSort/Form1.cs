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
            Sort thisSort = new Sort(pictureBoxPreview.Image);
            //0.27 is a good tolerance
            pictureBoxPreview.Image = thisSort.SortImage(0.17f);
        }

        private void saveFileDialogPreview_FileOk(object sender, CancelEventArgs e)
        {
            pictureBoxPreview.Image.Save(saveFileDialogPreview.FileName,System.Drawing.Imaging.ImageFormat.Png);
        }

        private void buttonPreviewSave_Click(object sender, EventArgs e)
        {
            saveFileDialogPreview.ShowDialog();
        }
    }
}
