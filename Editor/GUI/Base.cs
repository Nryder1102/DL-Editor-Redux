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
                    loadTheme(0);
                    break;
                }
            case "dark":
                {
                    lightToolStripMenuItem.Checked = false;
                    darkToolStripMenuItem.Checked = true;
                    blueToolStripMenuItem.Checked = false;
                    redToolStripMenuItem.Checked = false;
                    yellowToolStripMenuItem.Checked = false;
                    loadTheme(1);
                    break;
                }
            case "blue":
                {
                    lightToolStripMenuItem.Checked = false;
                    darkToolStripMenuItem.Checked = false;
                    blueToolStripMenuItem.Checked = true;
                    redToolStripMenuItem.Checked = false;
                    yellowToolStripMenuItem.Checked = false;
                    loadTheme(2);
                    break;
                }
            case "red":
                {
                    lightToolStripMenuItem.Checked = false;
                    darkToolStripMenuItem.Checked = false;
                    blueToolStripMenuItem.Checked = false;
                    redToolStripMenuItem.Checked = true;
                    yellowToolStripMenuItem.Checked = false;
                    loadTheme(3);
                    break;
                }
            case "yellow":
                {
                    lightToolStripMenuItem.Checked = false;
                    darkToolStripMenuItem.Checked = false;
                    blueToolStripMenuItem.Checked = false;
                    redToolStripMenuItem.Checked = false;
                    yellowToolStripMenuItem.Checked = true;
                    loadTheme(4);
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
            saveTo(sender, e);
        }

        //I'll figure out undo and redo someday, maybe
    }

    //Function to save changes to the master asset bundle, somehow
    private void saveTo(object sender, EventArgs e)
    {
        System.Windows.Forms.MessageBox.Show("Are you sure you want to save?");
    }

    //Function to try and grab the needed files from the master asset bundle, somehow
    private void loadFrom(object sender, EventArgs e)
    {

        charaButton.Enabled = true;
        dragonButton.Enabled = true;
        talismanButton.Enabled = true;

        createLists();

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

    //Function to generate the button lists from the master asset
    private void createLists()
    {
        for (int i = 0; i < 10; i++)
        {
            NoFocusCueButton temp = new NoFocusCueButton();
            temp.Name = i.ToString();
            temp.Text = "Button #" + i;
            temp.Size = new Size(200, 30);
            temp.FlatStyle = FlatStyle.Flat;
            temp.Dock = DockStyle.Top;
            characterButtons.Add(temp);
        }

        for(int i = characterButtons.Count; i != 0; i--) { listContainer.Controls.Add(characterButtons[i]); }
    }


    //Function that governs all drop down lists, based on the object that calls it
    private void activateDropDown(object sender, EventArgs e)
    {
        if (sender == settingsButton)
        {
            settingsMenuStrip.Show(settingsButton, new Point(0, settingsButton.Height));
        }
    }

    //Function to record a change to the application's theme
    private void changeTheme(object sender, EventArgs e)
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
                    loadTheme(0);
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
                    loadTheme(1);
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
                    loadTheme(2);
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
                    loadTheme(3);
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
                    loadTheme(4);
                    break;
                }
        }

        Properties.Settings.Default.Save();

    }

    //This is almost certainly unnecessary, but too bad
    private void loadTheme(int i)
    {
        setTheme(Themes[i][ThemeColor.Primary], Themes[i][ThemeColor.Secondary], Themes[i][ThemeColor.Tertiary], Themes[i][ThemeColor.Accents], Themes[i][ThemeColor.Buttons], Themes[i][ThemeColor.Text]);
    }

    //Function to change the application's theme
    //Gonna be a mess cause I've gotta manually set every item's style
    //I'm sure there's a better way to do this, but for now? It's what works
    private void setTheme(Color primaryColor, Color secondaryColor, Color tertiaryColor, Color accentColor, Color buttonColor, Color textColor)
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

    //Override dropdown menu colors
    private class MenuRenderer : ToolStripProfessionalRenderer
    {
        public MenuRenderer() : base(new MenuColors()) { }
    }

    private class MenuColors : ProfessionalColorTable
    {

        int currentTheme;

        public MenuColors()
        {
            switch (Properties.Settings.Default.Theme)
            {
                case "light":
                    {
                        currentTheme = 0;
                        break;
                    }
                case "dark":
                    {
                        currentTheme = 1;
                        break;
                    }
                case "blue":
                    {
                        currentTheme = 2;
                        break;
                    }
                case "red":
                    {
                        currentTheme = 3;
                        break;
                    }
                case "yellow":
                    {
                        currentTheme = 4;
                        break;
                    }
            }
        }


        public override Color MenuItemSelected
        {
            get { return ControlPaint.Light(Themes[currentTheme][ThemeColor.Buttons]); }
        }
        public override Color MenuItemSelectedGradientBegin
        {
            get { return ControlPaint.Light(Themes[currentTheme][ThemeColor.Buttons]); }
        }
        public override Color MenuItemSelectedGradientEnd
        {
            get { return ControlPaint.Light(Themes[currentTheme][ThemeColor.Buttons]); }
        }
        public override Color MenuItemBorder
        {
            get { return Color.Transparent; }
        }

    }

}


