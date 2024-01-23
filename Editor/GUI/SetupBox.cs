using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Editor.GUI
{
    public partial class SetupBox : Form
    {
        public SetupBox()
        {
            InitializeComponent();
        }

        private void setDefaultPath(object sender, EventArgs e)
        {
            if (sender == loadFromFolder)
            {
                Properties.Settings.Default.DefaultSaveType = "folder";
                folderBrowser.ShowDialog();
                Properties.Settings.Default.FolderPath = folderBrowser.SelectedPath;
            }
            else
            {
                Properties.Settings.Default.DefaultSaveType = "asset";
                fileBrowser.ShowDialog();
            }
        }
    }
}
