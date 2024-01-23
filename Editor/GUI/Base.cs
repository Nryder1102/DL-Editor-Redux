using Editor.GUI;
using System.Windows.Forms;

namespace Editor;

public partial class Base : Form
{

    public Base()
    {
        InitializeComponent();
    }

    private void Base_Load(object sender, EventArgs e)
    {
        loadTheme(Properties.Settings.Default.Theme);
        if (Properties.Settings.Default.MasterPath == "" && Properties.Settings.Default.FolderPath == "")
        {
            SetupBox box1 = new SetupBox();
            box1.ShowDialog();
        }
    }

    private void editPath(object sender, EventArgs e)
    {
        if (sender == editPathToFolderToolStripMenuItem)
        {

        }
    }

    //Function to either save changes to the master bundle, or a folder with various dumped files
    private void saveTo(object sender, EventArgs e)
    {

    }

    //Function to either load data from the master bundle, or from a folder containing a valid CharaData, DragonData, TalismanData, and TextLabel set of files
    private void loadFrom(object sender, EventArgs e)
    {

    }

    //Function to record a change to the application's theme
    private void changeTheme(object sender, EventArgs e)
    {
        if (sender == darkToolStripMenuItem)
        {
            Properties.Settings.Default.Theme = "dark";
            loadTheme("dark");
        }
        else
        {
            Properties.Settings.Default.Theme = "light";
            loadTheme("light");
        }

        Properties.Settings.Default.Save();

    }

    //Function to change the application's theme
    private void loadTheme(string theme)
    {
        if (theme == "dark")
        {
            lightToolStripMenuItem.Checked = false;
            darkToolStripMenuItem.Checked = true;
        }
        else
        {
            lightToolStripMenuItem.Checked = true;
            darkToolStripMenuItem.Checked = false;
        }
    }

    //Function that governs which list will be displayed on selection
    private void chooseList(object sender, EventArgs e)
    {
        if (sender != mainListButton)
        {
            charaButton.Visible = false;
            dragonButton.Visible = false;
            talismanButton.Visible = false;
            mainListButton.Enabled = true;
        }
        else
        {
            charaButton.Visible = true;
            dragonButton.Visible = true;
            talismanButton.Visible = true;
            mainListButton.Enabled = false;
        }
    }

    //Function that governs all drop down lists, based on the object that calls it
    private void activateDropDown(object sender, EventArgs e)
    {
        if (sender == saveButton)
        {
            saveMenuStrip.Show(saveButton, new Point(0, saveButton.Height));
        }
        else if (sender == loadButton)
        {
            loadMenuStrip.Show(loadButton, new Point(0, loadButton.Height));
        }
        else if (sender == settingsButton)
        {
            settingsMenuStrip.Show(settingsButton, new Point(0, settingsButton.Height));
        }
    }

    private void setupPanel_Paint(object sender, PaintEventArgs e)
    {
    }
}
