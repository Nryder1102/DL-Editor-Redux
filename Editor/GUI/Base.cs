using Editor.GUI;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Editor;

public partial class Base : Form
{

    public List<NoFocusCueButton> characterButtons = new List<NoFocusCueButton>();
    public List<NoFocusCueButton> dragonButtons = new List<NoFocusCueButton>();
    public List<NoFocusCueButton> talismanButtons = new List<NoFocusCueButton>();

    //Not gonna lie, I just stole the idea for this from Warframe
    //It works 
    public enum ThemeColor
    {
        Primary,
        Secondary,
        Tertiary,
        Accents,
        Buttons,
        Text
    }

    //Make a list of color dictionaries, so I can just use an index to grab the needed theme slot
    public static List<Dictionary<ThemeColor, Color>> Themes = new List<Dictionary<ThemeColor, Color>>();
    Dictionary<ThemeColor, Color> Light = new Dictionary<ThemeColor, Color>();
    Dictionary<ThemeColor, Color> Dark = new Dictionary<ThemeColor, Color>();
    Dictionary<ThemeColor, Color> Blue = new Dictionary<ThemeColor, Color>();
    Dictionary<ThemeColor, Color> Red = new Dictionary<ThemeColor, Color>();
    Dictionary<ThemeColor, Color> Yellow = new Dictionary<ThemeColor, Color>();

    public Base()
    {
        InitializeComponent();

        //Create the various themes
        Light = new Dictionary<ThemeColor, Color>() {
        { ThemeColor.Primary, Color.FromArgb(255,247,221) },
        { ThemeColor.Secondary, Color.GhostWhite },
        { ThemeColor.Tertiary, Color.White },
        { ThemeColor.Accents, Color.Black },
        { ThemeColor.Buttons, Color.FloralWhite  },
        { ThemeColor.Text, Color.Black }
        };
        Dark = new Dictionary<ThemeColor, Color>() {
        { ThemeColor.Primary, Color.FromArgb(64,64,64) },
        { ThemeColor.Secondary, Color.DimGray },
        { ThemeColor.Tertiary, Color.FromArgb(35,35,35) },
        { ThemeColor.Accents, Color.White },
        { ThemeColor.Buttons, Color.Gray },
        { ThemeColor.Text, Color.White }
        };
        Blue = new Dictionary<ThemeColor, Color>() {
        { ThemeColor.Primary, Color.FromArgb(2,17,66) },
        { ThemeColor.Secondary, Color.FromArgb(30,52,121) },
        { ThemeColor.Tertiary, Color.FromArgb(21,42,107) },
        { ThemeColor.Accents, Color.Black },
        { ThemeColor.Buttons, Color.FromArgb(0,22,107) },
        { ThemeColor.Text, Color.White }
        };
        Red = new Dictionary<ThemeColor, Color>() {
        { ThemeColor.Primary, Color.Red },
        { ThemeColor.Secondary, Color.Blue },
        { ThemeColor.Tertiary, Color.Yellow },
        { ThemeColor.Accents, Color.Green },
        { ThemeColor.Buttons, Color.Purple },
        { ThemeColor.Text, Color.Black }
        };
        Yellow = new Dictionary<ThemeColor, Color>() {
        { ThemeColor.Primary, Color.DarkSeaGreen },
        { ThemeColor.Secondary, Color.AliceBlue },
        { ThemeColor.Tertiary, Color.Honeydew },
        { ThemeColor.Accents, Color.ForestGreen },
        { ThemeColor.Buttons, Color.Turquoise },
        { ThemeColor.Text, Color.Black }
        };

        //Add 'em to the list
        Themes.Add(Light);
        Themes.Add(Dark);
        Themes.Add(Blue);
        Themes.Add(Red);
        Themes.Add(Yellow);

        //Change the theme on load to last chosen theme
        switch (Properties.Settings.Default.Theme)
        {
            case "light":
                {
                    lightToolStripMenuItem.Checked = true;
                    darkToolStripMenuItem.Checked = false;
                    blueToolStripMenuItem.Checked = false;
                    redToolStripMenuItem.Checked = false;
                    yellowToolStripMenuItem.Checked = false;
                    LoadTheme(0);
                    break;
                }
            case "dark":
                {
                    lightToolStripMenuItem.Checked = false;
                    darkToolStripMenuItem.Checked = true;
                    blueToolStripMenuItem.Checked = false;
                    redToolStripMenuItem.Checked = false;
                    yellowToolStripMenuItem.Checked = false;
                    LoadTheme(1);
                    break;
                }
            case "blue":
                {
                    lightToolStripMenuItem.Checked = false;
                    darkToolStripMenuItem.Checked = false;
                    blueToolStripMenuItem.Checked = true;
                    redToolStripMenuItem.Checked = false;
                    yellowToolStripMenuItem.Checked = false;
                    LoadTheme(2);
                    break;
                }
            case "red":
                {
                    lightToolStripMenuItem.Checked = false;
                    darkToolStripMenuItem.Checked = false;
                    blueToolStripMenuItem.Checked = false;
                    redToolStripMenuItem.Checked = true;
                    yellowToolStripMenuItem.Checked = false;
                    LoadTheme(3);
                    break;
                }
            case "yellow":
                {
                    lightToolStripMenuItem.Checked = false;
                    darkToolStripMenuItem.Checked = false;
                    blueToolStripMenuItem.Checked = false;
                    redToolStripMenuItem.Checked = false;
                    yellowToolStripMenuItem.Checked = true;
                    LoadTheme(4);
                    break;
                }
        }

        //Disable the big buttons until something is loaded
        charaButton.Enabled = false;
        dragonButton.Enabled = false;
        talismanButton.Enabled = false;

        //Give the dropdown menus new renderers
        settingsMenuStrip.Renderer = new MenuRenderer();
        changeThemeMenuStrip.Renderer = new MenuRenderer();

    }

    private void Base_Load(object sender, EventArgs e)
    {
        this.KeyPreview = true;
    }

    //Enables keybinds
    private void Base_KeyDown(object sender, KeyEventArgs e)
    {
        //Ctrl + S for save
        if (e.Control && e.KeyCode == Keys.S)
        {
            SaveTo(sender, e);
        }

        //I'll figure out undo and redo someday, maybe
    }

    //Function to save changes to the master asset bundle, somehow
    private void SaveTo(object sender, EventArgs e)
    {
        System.Windows.Forms.MessageBox.Show("Are you sure you want to save?");
    }

    //Function to try and grab the needed files from the master asset bundle, somehow
    private void LoadFrom(object sender, EventArgs e)
    {

        charaButton.Enabled = true;
        dragonButton.Enabled = true;
        talismanButton.Enabled = true;

        CreateLists();

    }

    //Function that governs which list will be displayed on selection
    private void ChooseList(object sender, EventArgs e)
    {
        if (sender != mainListButton)
        {
            charaButton.Visible = false;
            dragonButton.Visible = false;
            talismanButton.Visible = false;
            mainListButton.Enabled = true;
            listContainer.Visible = true;
            if (sender == charaButton)
            {
                for (int i = characterButtons.Count - 1; i >= 0; i--)
                {
                    characterControl.Visible = true;
                    listContainer.Controls.Add(characterButtons[i]);
                }
            }
        }
        else
        {
            charaButton.Visible = true;
            characterControl.Visible = false;
            dragonButton.Visible = true;
            talismanButton.Visible = true;
            mainListButton.Enabled = false;
            listContainer.Visible = false;
            listContainer.Controls.Clear();
        }
    }

    //Function to generate the button lists from the master asset
    private void CreateLists()
    {
        int basex = listContainer.Location.X;
        int basey = 0;

        for (int i = 0; i < 30; i++)
        {
            NoFocusCueButton temp = new NoFocusCueButton();
            temp.Name = i.ToString();
            temp.Text = "Button #" + i;
            temp.Size = new Size(180, 30);
            temp.Left = basex;
            temp.Top = basey;
            temp.BackColor = Themes[GetTheme()][ThemeColor.Buttons];
            temp.ForeColor = Themes[GetTheme()][ThemeColor.Text];
            basey += 35;
            characterButtons.Add(temp);
        }

    }


    //Function that governs all drop down lists, based on the object that calls it
    private void ActivateDropDown(object sender, EventArgs e)
    {
        if (sender == settingsButton)
        {
            settingsMenuStrip.Show(settingsButton, new Point(0, settingsButton.Height));
        }
    }

    private static int GetTheme()
    {
        switch (Properties.Settings.Default.Theme)
        {
            case "light":
                {
                    return 0;
                }
            case "dark":
                {
                    return 1;
                }
            case "blue":
                {
                    return 2;
                }
            case "red":
                {
                    return 3;
                }
            case "yellow":
                {
                    return 4;
                }
            case null:
                {
                    return -1;
                }
        }

        return -1;

    }

    //Function to record a change to the application's theme
    private void ChangeTheme(object sender, EventArgs e)
    {
        //Switch and save the theme
        switch ((sender as ToolStripMenuItem).Text)
        {
            case "Light":
                {
                    lightToolStripMenuItem.Checked = true;
                    darkToolStripMenuItem.Checked = false;
                    blueToolStripMenuItem.Checked = false;
                    redToolStripMenuItem.Checked = false;
                    yellowToolStripMenuItem.Checked = false;
                    Properties.Settings.Default.Theme = "light";
                    LoadTheme(0);
                    break;
                }
            case "Dark":
                {
                    lightToolStripMenuItem.Checked = false;
                    darkToolStripMenuItem.Checked = true;
                    blueToolStripMenuItem.Checked = false;
                    redToolStripMenuItem.Checked = false;
                    yellowToolStripMenuItem.Checked = false;
                    Properties.Settings.Default.Theme = "dark";
                    LoadTheme(1);
                    break;
                }
            case "Blue":
                {
                    lightToolStripMenuItem.Checked = false;
                    darkToolStripMenuItem.Checked = false;
                    blueToolStripMenuItem.Checked = true;
                    redToolStripMenuItem.Checked = false;
                    yellowToolStripMenuItem.Checked = false;
                    Properties.Settings.Default.Theme = "blue";
                    LoadTheme(2);
                    break;
                }
            case "Red":
                {
                    lightToolStripMenuItem.Checked = false;
                    darkToolStripMenuItem.Checked = false;
                    blueToolStripMenuItem.Checked = false;
                    redToolStripMenuItem.Checked = true;
                    yellowToolStripMenuItem.Checked = false;
                    Properties.Settings.Default.Theme = "red";
                    LoadTheme(3);
                    break;
                }
            case "Yellow":
                {
                    lightToolStripMenuItem.Checked = false;
                    darkToolStripMenuItem.Checked = false;
                    blueToolStripMenuItem.Checked = false;
                    redToolStripMenuItem.Checked = false;
                    yellowToolStripMenuItem.Checked = true;
                    Properties.Settings.Default.Theme = "yellow";
                    LoadTheme(4);
                    break;
                }
        }

        Properties.Settings.Default.Save();

    }

    //This is almost certainly unnecessary, but too bad
    private void LoadTheme(int i)
    {
        SetTheme(Themes[i][ThemeColor.Primary], Themes[i][ThemeColor.Secondary], Themes[i][ThemeColor.Tertiary], Themes[i][ThemeColor.Accents], Themes[i][ThemeColor.Buttons], Themes[i][ThemeColor.Text]);
    }

    //Function to change the application's theme
    //Gonna be a mess cause I've gotta manually set every item's style
    //I'm sure there's a better way to do this, but for now? It's what works
    private void SetTheme(Color primaryColor, Color secondaryColor, Color tertiaryColor, Color accentColor, Color buttonColor, Color textColor)
    {
        bottomPanel.BackColor = primaryColor;
        topPanel.BackColor = primaryColor;
        settingsPanel.BackColor = primaryColor;
        settingsButton.BackColor = buttonColor;
        settingsButton.ForeColor = textColor;
        loadPanel.BackColor = primaryColor;
        loadButton.BackColor = buttonColor;
        loadButton.ForeColor = textColor;
        savePanel.BackColor = primaryColor;
        saveButton.BackColor = buttonColor;
        saveButton.ForeColor = textColor;
        sidePanel.BackColor = secondaryColor;
        mainListButton.BackColor = buttonColor;
        mainListButton.ForeColor = textColor;
        listPanel.BackColor = secondaryColor;
        talismanButton.BackColor = buttonColor;
        talismanButton.ForeColor = textColor;
        dragonButton.BackColor = buttonColor;
        dragonButton.ForeColor = textColor;
        charaButton.BackColor = buttonColor;
        charaButton.ForeColor = textColor;
        detailPanel.BackColor = tertiaryColor;
        characterBasicTab.BackColor = tertiaryColor;
        characterStatsTab.BackColor = tertiaryColor;
        characterSkillsTab.BackColor = tertiaryColor;
        characterMiscTab.BackColor = tertiaryColor;
        changeThemeToolStripMenuItem.BackColor = buttonColor;
        changeThemeToolStripMenuItem.ForeColor = textColor;
        darkToolStripMenuItem.BackColor = buttonColor;
        darkToolStripMenuItem.ForeColor = textColor;
        lightToolStripMenuItem.BackColor = buttonColor;
        lightToolStripMenuItem.ForeColor = textColor;
        blueToolStripMenuItem.BackColor = buttonColor;
        blueToolStripMenuItem.ForeColor = textColor;
        redToolStripMenuItem.BackColor = buttonColor;
        redToolStripMenuItem.ForeColor = textColor;
        yellowToolStripMenuItem.BackColor = buttonColor;
        yellowToolStripMenuItem.ForeColor = textColor;
        separator1.BackColor = accentColor;
        separator2.BackColor = accentColor;
        separator3.BackColor = accentColor;
        separator4.BackColor = accentColor;
        separator5.BackColor = accentColor;
        separator6.BackColor = accentColor;
        separator7.BackColor = accentColor;

        for (int i = 0; i < characterButtons.Count; i++)
        {
            characterButtons[i].BackColor = buttonColor;
            characterButtons[i].ForeColor = textColor;
        }

        settingsMenuStrip.Renderer = new MenuRenderer();
        changeThemeMenuStrip.Renderer = new MenuRenderer();

        Refresh();

    }



}


