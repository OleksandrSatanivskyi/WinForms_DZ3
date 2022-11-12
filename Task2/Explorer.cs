using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.CheckedListBox;

namespace WinForms_DZ3.Task2
{
    public partial class Explorer : Form
    {
        private string Path => tbAddressLine.Text;
        public Explorer()
        {
            InitializeComponent();
            DriveInfo[] drives = DriveInfo.GetDrives();
            DiskTree.Items.AddRange(DriveInfo.GetDrives().Select(d => d.Name).ToArray());
        }

        private void Explorer_Load(object sender, EventArgs e)
        {

        }

        private void DiskTree_DoubleClick(object sender, EventArgs e)
        {
            FolderContents.Items.AddRange(Directory.GetDirectories(DiskTree.SelectedItem.ToString()));
        }
    }
}
