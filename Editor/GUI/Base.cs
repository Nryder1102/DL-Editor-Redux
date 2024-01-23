using Editor.GUI;
using System.Windows.Forms;

namespace Editor;

public partial class Base : Form
{

    public List<Button> characterButtons = new List<Button>();
    public List<Button> dragonButtons = new List<Button>();
    public List<Button> talismanButtons = new List<Button>();

    enum ThemeColor
    {
        Primary,
        Secondary,
        Tertiary,
        Accents,
        Buttons,
        Text
    }

    Dictionary<ThemeColor, Color> Light = new Dictionary<ThemeColor, Color>();
    Dictionary<ThemeColor, Color> Nature = new Dictionary<ThemeColor, Color>();
    Dictionary<ThemeColor, Color> Dark = new Dictionary<ThemeColor, Color>();

    public Base()
    {
        InitializeComponent();

        // Add dictionaries here
        Light = new Dictionary<ThemeColor, Color>() {
        { ThemeColor.Primary, Color.WhiteSmoke },
        { ThemeColor.Secondary, Color.Silver },
        { ThemeColor.Tertiary, Color.White },
        { ThemeColor.Accents, Color.Black },
        { ThemeColor.Buttons, Color.FloralWhite  },
        { ThemeColor.Text, Color.Black }
        };
        Nature = new Dictionary<ThemeColor, Color>() {
        { ThemeColor.Primary, Color.DarkSeaGreen },
        { ThemeColor.Secondary, Color.AliceBlue },
        { ThemeColor.Tertiary, Color.Honeydew },
        { ThemeColor.Accents, Color.ForestGreen },
        { ThemeColor.Buttons, Color.Turquoise },
        { ThemeColor.Text, Color.Black }
        };
        Dark = new Dictionary<ThemeColor, Color>() {
        { ThemeColor.Primary, Color.FromArgb(64,64,64) },
        { ThemeColor.Secondary, Color.DimGray },
        { ThemeColor.Tertiary, Color.Black },
        { ThemeColor.Accents, Color.White },
        { ThemeColor.Buttons, Color.LightGray },
        { ThemeColor.Text, Color.White }
        };

        Properties.Settings.Default.Theme = "nature";

        Console.WriteLine(Properties.Settings.Default.Theme);

        switch (Properties.Settings.Default.Theme)
        {
            case "dark":
                {
                    darkToolStripMenuItem.Checked = true;
                    lightToolStripMenuItem.Checked = false;
                    loadTheme(Dark[ThemeColor.Primary], Dark[ThemeColor.Secondary], Dark[ThemeColor.Tertiary], Dark[ThemeColor.Accents], Dark[ThemeColor.Buttons], Dark[ThemeColor.Text]);
                    break;
                }
            case "light":
                {
                    lightToolStripMenuItem.Checked = true;
                    darkToolStripMenuItem.Checked = false;
                    loadTheme(Light[ThemeColor.Primary], Light[ThemeColor.Secondary], Light[ThemeColor.Tertiary], Light[ThemeColor.Accents], Light[ThemeColor.Buttons], Light[ThemeColor.Text]);
                    break;
                }
            case "nature":
                {
                    lightToolStripMenuItem.Checked = true;
                    darkToolStripMenuItem.Checked = false;
                    loadTheme(Nature[ThemeColor.Primary], Nature[ThemeColor.Secondary], Nature[ThemeColor.Tertiary], Nature[ThemeColor.Accents], Nature[ThemeColor.Buttons], Nature[ThemeColor.Text]);
                    break;
                }
        }



        if (Properties.Settings.Default.MasterPath == "" && Properties.Settings.Default.FolderPath == "")
        {
            SetupBox box = new SetupBox();
            box.ShowDialog();
        }

        charaButton.Enabled = false;
        dragonButton.Enabled = false;
        talismanButton.Enabled = false;


        if (File.Exists(Properties.Settings.Default.FolderPath + "CharaData.json"))
        {
            charaButton.Enabled = true;
        }
    }

    private void Base_Load(object sender, EventArgs e)
    {

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
        //Save to the various files in the folder
        if (sender == saveToFolderMenuItem)
        {

        }
        //Save to the master asset
        else
        {

        }
    }

    //Function to either load data from the master bundle, or from a folder containing a valid CharaData, DragonData, TalismanData, and TextLabel set of files
    private void loadFrom(object sender, EventArgs e)
    {
        //Load from the various files in the folder
        if (sender == loadFromFolderMenuItem)
        {

        }
        //Load from the master asset
        else
        {

        }

        charaButton.Enabled = true;
        dragonButton.Enabled = true;
        talismanButton.Enabled = true;

    }

    //Function to record a change to the application's theme
    private void changeTheme(object sender, EventArgs e)
    {
        if (sender == darkToolStripMenuItem)
        {
            Properties.Settings.Default.Theme = "dark";
            darkToolStripMenuItem.Checked = true;
            lightToolStripMenuItem.Checked = false;
            loadTheme(Dark[ThemeColor.Primary], Dark[ThemeColor.Secondary], Dark[ThemeColor.Tertiary], Dark[ThemeColor.Accents], Dark[ThemeColor.Buttons], Dark[ThemeColor.Text]);
        }
        else
        {
            Properties.Settings.Default.Theme = "light";
            darkToolStripMenuItem.Checked = false;
            lightToolStripMenuItem.Checked = true;
            loadTheme(Light[ThemeColor.Primary], Light[ThemeColor.Secondary], Light[ThemeColor.Tertiary], Light[ThemeColor.Accents], Light[ThemeColor.Buttons], Light[ThemeColor.Text]);
        }

        Properties.Settings.Default.Save();

    }

    //Function to change the application's theme
    private void loadTheme(Color primaryColor, Color secondaryColor, Color tertiaryColor, Color accentColor, Color buttonColor, Color textColor)
    {
        bottomPanel.BackColor = primaryColor;
        topPanel.BackColor = primaryColor;
        settingsPanel.BackColor = primaryColor;
        settingsButton.BackColor = buttonColor;
        loadPanel.BackColor = primaryColor;
        loadButton.BackColor = buttonColor;
        savePanel.BackColor = primaryColor;
        saveButton.BackColor = buttonColor;
        sidePanel.BackColor = secondaryColor;
        mainListButton.BackColor = buttonColor;
        listPanel.BackColor = secondaryColor;
        talismanButton.BackColor = buttonColor;
        dragonButton.BackColor = buttonColor;
        charaButton.BackColor = buttonColor;
        detailPanel.BackColor = tertiaryColor;
        saveToFolderMenuItem.BackColor = buttonColor;
        saveToMasterMenuItem.BackColor = buttonColor;
        loadFromFolderMenuItem.BackColor = buttonColor;
        loadFromMasterMenuItem.BackColor = buttonColor;
        changePathToolStripMenuItem.BackColor = buttonColor;
        editPathToFolderToolStripMenuItem.BackColor = buttonColor;
        editPathToMasterToolStripMenuItem.BackColor = buttonColor;
        changeThemeToolStripMenuItem.BackColor = buttonColor;
        darkToolStripMenuItem.BackColor = buttonColor;
        lightToolStripMenuItem.BackColor = buttonColor;
        separator1.BackColor = accentColor;
        separator2.BackColor = accentColor;
        separator3.BackColor = accentColor;
        separator4.BackColor = accentColor;
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

    //Function to generate the button lists from a folder of relevant files
    private void createListsFolder()
    {


    }

    //Function to generate the button lists from the master asset
    private void createListsAsset()
    {

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
}


