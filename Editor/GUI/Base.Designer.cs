using Editor.GUI;

namespace Editor;

partial class Base
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();
        bottomPanel = new Panel();
        separator6 = new Panel();
        topPanel = new Panel();
        separator5 = new Panel();
        settingsPanel = new Panel();
        settingsButton = new NoFocusCueButton();
        loadPanel = new Panel();
        loadButton = new NoFocusCueButton();
        savePanel = new Panel();
        saveButton = new NoFocusCueButton();
        sidePanel = new Panel();
        mainListButton = new NoFocusCueButton();
        listPanel = new Panel();
        listContainer = new Panel();
        charaButton = new NoFocusCueButton();
        dragonButton = new NoFocusCueButton();
        talismanButton = new NoFocusCueButton();
        detailPanel = new Panel();
        characterControl = new TabControl();
        characterBasicTab = new TabPage();
        characterStatsTab = new TabPage();
        characterSkillsTab = new TabPage();
        characterMiscTab = new TabPage();
        changeThemeMenuStrip = new ContextMenuStrip(components);
        darkToolStripMenuItem = new ToolStripMenuItem();
        lightToolStripMenuItem = new ToolStripMenuItem();
        blueToolStripMenuItem = new ToolStripMenuItem();
        redToolStripMenuItem = new ToolStripMenuItem();
        yellowToolStripMenuItem = new ToolStripMenuItem();
        changeThemeToolStripMenuItem = new ToolStripMenuItem();
        separator1 = new Panel();
        separator2 = new Panel();
        separator3 = new Panel();
        separator4 = new Panel();
        separator7 = new Panel();
        settingsMenuStrip = new ContextMenuStrip(components);
        bottomPanel.SuspendLayout();
        topPanel.SuspendLayout();
        settingsPanel.SuspendLayout();
        loadPanel.SuspendLayout();
        savePanel.SuspendLayout();
        sidePanel.SuspendLayout();
        listPanel.SuspendLayout();
        detailPanel.SuspendLayout();
        characterControl.SuspendLayout();
        changeThemeMenuStrip.SuspendLayout();
        settingsMenuStrip.SuspendLayout();
        SuspendLayout();
        // 
        // bottomPanel
        // 
        bottomPanel.Controls.Add(separator6);
        bottomPanel.Dock = DockStyle.Bottom;
        bottomPanel.Location = new Point(1, 497);
        bottomPanel.Margin = new Padding(3, 4, 3, 4);
        bottomPanel.Name = "bottomPanel";
        bottomPanel.Size = new Size(1041, 33);
        bottomPanel.TabIndex = 0;
        // 
        // separator6
        // 
        separator6.Dock = DockStyle.Right;
        separator6.Location = new Point(1040, 0);
        separator6.Name = "separator6";
        separator6.Size = new Size(1, 33);
        separator6.TabIndex = 0;
        // 
        // topPanel
        // 
        topPanel.Controls.Add(separator5);
        topPanel.Controls.Add(settingsPanel);
        topPanel.Controls.Add(loadPanel);
        topPanel.Controls.Add(savePanel);
        topPanel.Dock = DockStyle.Top;
        topPanel.Location = new Point(1, 0);
        topPanel.Margin = new Padding(3, 4, 3, 4);
        topPanel.Name = "topPanel";
        topPanel.Size = new Size(1041, 33);
        topPanel.TabIndex = 1;
        // 
        // separator5
        // 
        separator5.Dock = DockStyle.Right;
        separator5.Location = new Point(1040, 0);
        separator5.Name = "separator5";
        separator5.Size = new Size(1, 33);
        separator5.TabIndex = 3;
        // 
        // settingsPanel
        // 
        settingsPanel.Controls.Add(settingsButton);
        settingsPanel.Dock = DockStyle.Left;
        settingsPanel.Location = new Point(138, 0);
        settingsPanel.Margin = new Padding(3, 4, 3, 4);
        settingsPanel.Name = "settingsPanel";
        settingsPanel.Padding = new Padding(6, 0, 0, 0);
        settingsPanel.Size = new Size(90, 33);
        settingsPanel.TabIndex = 2;
        // 
        // settingsButton
        // 
        settingsButton.BackColor = Color.MediumSlateBlue;
        settingsButton.Dock = DockStyle.Fill;
        settingsButton.FlatStyle = FlatStyle.Flat;
        settingsButton.ForeColor = Color.White;
        settingsButton.Location = new Point(6, 0);
        settingsButton.Margin = new Padding(3, 4, 3, 4);
        settingsButton.Name = "settingsButton";
        settingsButton.Size = new Size(84, 33);
        settingsButton.TabIndex = 0;
        settingsButton.Text = "Settings";
        settingsButton.UseVisualStyleBackColor = true;
        settingsButton.Click += ActivateDropDown;
        // 
        // loadPanel
        // 
        loadPanel.Controls.Add(loadButton);
        loadPanel.Dock = DockStyle.Left;
        loadPanel.Location = new Point(69, 0);
        loadPanel.Margin = new Padding(3, 4, 3, 4);
        loadPanel.Name = "loadPanel";
        loadPanel.Padding = new Padding(6, 0, 0, 0);
        loadPanel.Size = new Size(69, 33);
        loadPanel.TabIndex = 1;
        // 
        // loadButton
        // 
        loadButton.BackColor = Color.MediumSlateBlue;
        loadButton.Dock = DockStyle.Fill;
        loadButton.FlatStyle = FlatStyle.Flat;
        loadButton.ForeColor = Color.White;
        loadButton.Location = new Point(6, 0);
        loadButton.Margin = new Padding(3, 4, 3, 4);
        loadButton.Name = "loadButton";
        loadButton.Size = new Size(63, 33);
        loadButton.TabIndex = 0;
        loadButton.Text = "Load";
        loadButton.UseVisualStyleBackColor = true;
        loadButton.Click += LoadFrom;
        // 
        // savePanel
        // 
        savePanel.Controls.Add(saveButton);
        savePanel.Dock = DockStyle.Left;
        savePanel.Location = new Point(0, 0);
        savePanel.Margin = new Padding(3, 4, 3, 4);
        savePanel.Name = "savePanel";
        savePanel.Size = new Size(69, 33);
        savePanel.TabIndex = 0;
        // 
        // saveButton
        // 
        saveButton.BackColor = Color.MediumSlateBlue;
        saveButton.Dock = DockStyle.Fill;
        saveButton.FlatStyle = FlatStyle.Flat;
        saveButton.ForeColor = Color.White;
        saveButton.Location = new Point(0, 0);
        saveButton.Margin = new Padding(3, 4, 3, 4);
        saveButton.Name = "saveButton";
        saveButton.Size = new Size(69, 33);
        saveButton.TabIndex = 0;
        saveButton.Text = "Save";
        saveButton.UseVisualStyleBackColor = true;
        saveButton.Click += SaveTo;
        // 
        // sidePanel
        // 
        sidePanel.BackColor = Color.Gray;
        sidePanel.Controls.Add(mainListButton);
        sidePanel.Controls.Add(listPanel);
        sidePanel.Dock = DockStyle.Left;
        sidePanel.Location = new Point(1, 34);
        sidePanel.Margin = new Padding(3, 4, 3, 4);
        sidePanel.Name = "sidePanel";
        sidePanel.Size = new Size(228, 462);
        sidePanel.TabIndex = 2;
        // 
        // mainListButton
        // 
        mainListButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        mainListButton.BackColor = Color.MediumSlateBlue;
        mainListButton.Enabled = false;
        mainListButton.FlatStyle = FlatStyle.Flat;
        mainListButton.ForeColor = Color.White;
        mainListButton.Location = new Point(5, 426);
        mainListButton.Margin = new Padding(3, 4, 3, 4);
        mainListButton.Name = "mainListButton";
        mainListButton.Size = new Size(217, 32);
        mainListButton.TabIndex = 1;
        mainListButton.Text = "Back to Menu";
        mainListButton.UseVisualStyleBackColor = true;
        mainListButton.Click += ChooseList;
        // 
        // listPanel
        // 
        listPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        listPanel.AutoSize = true;
        listPanel.BackColor = Color.LightGray;
        listPanel.Controls.Add(listContainer);
        listPanel.Controls.Add(charaButton);
        listPanel.Controls.Add(dragonButton);
        listPanel.Controls.Add(talismanButton);
        listPanel.Location = new Point(0, 0);
        listPanel.Margin = new Padding(3, 4, 3, 4);
        listPanel.MinimumSize = new Size(230, 0);
        listPanel.Name = "listPanel";
        listPanel.Size = new Size(232, 424);
        listPanel.TabIndex = 0;
        // 
        // listContainer
        // 
        listContainer.AutoScroll = true;
        listContainer.Location = new Point(5, 8);
        listContainer.Name = "listContainer";
        listContainer.Size = new Size(217, 411);
        listContainer.TabIndex = 0;
        listContainer.Visible = false;
        // 
        // charaButton
        // 
        charaButton.BackColor = Color.MediumSlateBlue;
        charaButton.FlatStyle = FlatStyle.Flat;
        charaButton.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
        charaButton.ForeColor = Color.White;
        charaButton.Location = new Point(5, 8);
        charaButton.Margin = new Padding(3, 4, 3, 4);
        charaButton.Name = "charaButton";
        charaButton.Size = new Size(217, 57);
        charaButton.TabIndex = 0;
        charaButton.Text = "Characters";
        charaButton.UseVisualStyleBackColor = true;
        charaButton.Click += ChooseList;
        // 
        // dragonButton
        // 
        dragonButton.BackColor = Color.MediumSlateBlue;
        dragonButton.FlatStyle = FlatStyle.Flat;
        dragonButton.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
        dragonButton.ForeColor = Color.White;
        dragonButton.Location = new Point(5, 72);
        dragonButton.Margin = new Padding(3, 4, 3, 4);
        dragonButton.Name = "dragonButton";
        dragonButton.Size = new Size(217, 57);
        dragonButton.TabIndex = 1;
        dragonButton.Text = "Dragons";
        dragonButton.UseVisualStyleBackColor = true;
        dragonButton.Click += ChooseList;
        // 
        // talismanButton
        // 
        talismanButton.BackColor = Color.MediumSlateBlue;
        talismanButton.FlatStyle = FlatStyle.Flat;
        talismanButton.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
        talismanButton.ForeColor = Color.White;
        talismanButton.Location = new Point(5, 137);
        talismanButton.Margin = new Padding(3, 4, 3, 4);
        talismanButton.Name = "talismanButton";
        talismanButton.Size = new Size(217, 57);
        talismanButton.TabIndex = 2;
        talismanButton.Text = "Wyrmprints";
        talismanButton.UseVisualStyleBackColor = true;
        talismanButton.Click += ChooseList;
        // 
        // detailPanel
        // 
        detailPanel.BackColor = Color.DarkGray;
        detailPanel.Controls.Add(characterControl);
        detailPanel.Dock = DockStyle.Fill;
        detailPanel.Location = new Point(1, 0);
        detailPanel.Margin = new Padding(3, 4, 3, 4);
        detailPanel.Name = "detailPanel";
        detailPanel.Size = new Size(1041, 530);
        detailPanel.TabIndex = 3;
        // 
        // characterControl
        // 
        characterControl.Controls.Add(characterBasicTab);
        characterControl.Controls.Add(characterStatsTab);
        characterControl.Controls.Add(characterSkillsTab);
        characterControl.Controls.Add(characterMiscTab);
        characterControl.Location = new Point(228, 33);
        characterControl.Name = "characterControl";
        characterControl.SelectedIndex = 0;
        characterControl.Size = new Size(813, 464);
        characterControl.TabIndex = 0;
        // 
        // characterBasicTab
        // 
        characterBasicTab.Location = new Point(4, 29);
        characterBasicTab.Name = "characterBasicTab";
        characterBasicTab.Padding = new Padding(3);
        characterBasicTab.Size = new Size(805, 431);
        characterBasicTab.TabIndex = 0;
        characterBasicTab.Text = "Basic Info";
        characterBasicTab.UseVisualStyleBackColor = true;
        // 
        // characterStatsTab
        // 
        characterStatsTab.Location = new Point(4, 29);
        characterStatsTab.Name = "characterStatsTab";
        characterStatsTab.Padding = new Padding(3);
        characterStatsTab.Size = new Size(805, 431);
        characterStatsTab.TabIndex = 1;
        characterStatsTab.Text = "Stats";
        characterStatsTab.UseVisualStyleBackColor = true;
        // 
        // characterSkillsTab
        // 
        characterSkillsTab.Location = new Point(4, 29);
        characterSkillsTab.Name = "characterSkillsTab";
        characterSkillsTab.Size = new Size(805, 431);
        characterSkillsTab.TabIndex = 2;
        characterSkillsTab.Text = "Skills & Abilities";
        characterSkillsTab.UseVisualStyleBackColor = true;
        // 
        // characterMiscTab
        // 
        characterMiscTab.Location = new Point(4, 29);
        characterMiscTab.Name = "characterMiscTab";
        characterMiscTab.Size = new Size(805, 431);
        characterMiscTab.TabIndex = 3;
        characterMiscTab.Text = "Misc.";
        characterMiscTab.UseVisualStyleBackColor = true;
        // 
        // changeThemeMenuStrip
        // 
        changeThemeMenuStrip.ImageScalingSize = new Size(20, 20);
        changeThemeMenuStrip.Items.AddRange(new ToolStripItem[] { darkToolStripMenuItem, lightToolStripMenuItem, blueToolStripMenuItem, redToolStripMenuItem, yellowToolStripMenuItem });
        changeThemeMenuStrip.Name = "changeThemeMenuStrip";
        changeThemeMenuStrip.OwnerItem = changeThemeToolStripMenuItem;
        changeThemeMenuStrip.Size = new Size(122, 134);
        // 
        // darkToolStripMenuItem
        // 
        darkToolStripMenuItem.Checked = true;
        darkToolStripMenuItem.CheckState = CheckState.Checked;
        darkToolStripMenuItem.Name = "darkToolStripMenuItem";
        darkToolStripMenuItem.Size = new Size(121, 26);
        darkToolStripMenuItem.Text = "Dark";
        darkToolStripMenuItem.Click += ChangeTheme;
        // 
        // lightToolStripMenuItem
        // 
        lightToolStripMenuItem.Name = "lightToolStripMenuItem";
        lightToolStripMenuItem.Size = new Size(121, 26);
        lightToolStripMenuItem.Text = "Light";
        lightToolStripMenuItem.Click += ChangeTheme;
        // 
        // blueToolStripMenuItem
        // 
        blueToolStripMenuItem.Name = "blueToolStripMenuItem";
        blueToolStripMenuItem.Size = new Size(121, 26);
        blueToolStripMenuItem.Text = "Blue";
        blueToolStripMenuItem.Click += ChangeTheme;
        // 
        // redToolStripMenuItem
        // 
        redToolStripMenuItem.Name = "redToolStripMenuItem";
        redToolStripMenuItem.Size = new Size(121, 26);
        redToolStripMenuItem.Text = "Red";
        redToolStripMenuItem.Click += ChangeTheme;
        // 
        // yellowToolStripMenuItem
        // 
        yellowToolStripMenuItem.Name = "yellowToolStripMenuItem";
        yellowToolStripMenuItem.Size = new Size(121, 26);
        yellowToolStripMenuItem.Text = "Yellow";
        yellowToolStripMenuItem.Click += ChangeTheme;
        // 
        // changeThemeToolStripMenuItem
        // 
        changeThemeToolStripMenuItem.DropDown = changeThemeMenuStrip;
        changeThemeToolStripMenuItem.Name = "changeThemeToolStripMenuItem";
        changeThemeToolStripMenuItem.Size = new Size(177, 24);
        changeThemeToolStripMenuItem.Text = "Change Theme";
        // 
        // separator1
        // 
        separator1.Dock = DockStyle.Left;
        separator1.Location = new Point(229, 34);
        separator1.Name = "separator1";
        separator1.Size = new Size(1, 462);
        separator1.TabIndex = 5;
        // 
        // separator2
        // 
        separator2.Dock = DockStyle.Top;
        separator2.Location = new Point(1, 33);
        separator2.Name = "separator2";
        separator2.Size = new Size(1041, 1);
        separator2.TabIndex = 6;
        // 
        // separator3
        // 
        separator3.Dock = DockStyle.Bottom;
        separator3.Location = new Point(1, 496);
        separator3.Name = "separator3";
        separator3.Size = new Size(1041, 1);
        separator3.TabIndex = 7;
        // 
        // separator4
        // 
        separator4.Dock = DockStyle.Right;
        separator4.Location = new Point(1041, 34);
        separator4.Name = "separator4";
        separator4.Size = new Size(1, 462);
        separator4.TabIndex = 8;
        // 
        // separator7
        // 
        separator7.Dock = DockStyle.Left;
        separator7.Location = new Point(0, 0);
        separator7.Name = "separator7";
        separator7.Size = new Size(1, 530);
        separator7.TabIndex = 9;
        // 
        // settingsMenuStrip
        // 
        settingsMenuStrip.ImageScalingSize = new Size(20, 20);
        settingsMenuStrip.Items.AddRange(new ToolStripItem[] { changeThemeToolStripMenuItem });
        settingsMenuStrip.Name = "settingsMenuStrip";
        settingsMenuStrip.Size = new Size(178, 28);
        // 
        // Base
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(64, 64, 64);
        ClientSize = new Size(1042, 530);
        Controls.Add(separator4);
        Controls.Add(separator1);
        Controls.Add(sidePanel);
        Controls.Add(separator3);
        Controls.Add(bottomPanel);
        Controls.Add(separator2);
        Controls.Add(topPanel);
        Controls.Add(detailPanel);
        Controls.Add(separator7);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        Name = "Base";
        Text = "Dragalia Lost Data Editor";
        Load += Base_Load;
        KeyDown += Base_KeyDown;
        bottomPanel.ResumeLayout(false);
        topPanel.ResumeLayout(false);
        settingsPanel.ResumeLayout(false);
        loadPanel.ResumeLayout(false);
        savePanel.ResumeLayout(false);
        sidePanel.ResumeLayout(false);
        sidePanel.PerformLayout();
        listPanel.ResumeLayout(false);
        detailPanel.ResumeLayout(false);
        characterControl.ResumeLayout(false);
        changeThemeMenuStrip.ResumeLayout(false);
        settingsMenuStrip.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

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
            currentTheme = GetTheme();
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

    private Panel bottomPanel;
    private Panel topPanel;
    private Panel sidePanel;
    private Panel listPanel;
    private Panel detailPanel;
    private Panel savePanel;
    private Panel loadPanel;
    private Panel settingsPanel;
    private ContextMenuStrip changeThemeMenuStrip;
    private ToolStripMenuItem darkToolStripMenuItem;
    private ToolStripMenuItem lightToolStripMenuItem;
    private NoFocusCueButton mainListButton;
    private NoFocusCueButton charaButton;
    private NoFocusCueButton talismanButton;
    private NoFocusCueButton dragonButton;
    private NoFocusCueButton saveButton;
    private NoFocusCueButton loadButton;
    private Panel separator1;
    private Panel separator2;
    private Panel separator3;
    private Panel separator4;
    private Panel separator5;
    private Panel separator6;
    private Panel separator7;
    private ToolStripMenuItem changeThemeToolStripMenuItem;
    private ContextMenuStrip settingsMenuStrip;
    private ToolStripMenuItem blueToolStripMenuItem;
    private ToolStripMenuItem redToolStripMenuItem;
    private ToolStripMenuItem yellowToolStripMenuItem;
    private Panel listContainer;
    public NoFocusCueButton settingsButton;
    private TabControl characterControl;
    private TabPage characterBasicTab;
    private TabPage characterStatsTab;
    private TabPage characterSkillsTab;
    private TabPage characterMiscTab;
}
