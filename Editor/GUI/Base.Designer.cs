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
        topPanel = new Panel();
        separator5 = new Panel();
        settingsPanel = new Panel();
        settingsButton = new NoFocusCueButton();
        loadPanel = new Panel();
        loadButton = new NoFocusCueButton();
        savePanel = new Panel();
        saveButton = new NoFocusCueButton();
        separator6 = new Panel();
        sidePanel = new Panel();
        mainListButton = new NoFocusCueButton();
        listPanel = new Panel();
        talismanButton = new NoFocusCueButton();
        dragonButton = new NoFocusCueButton();
        charaButton = new NoFocusCueButton();
        detailPanel = new Panel();
        saveMenuStrip = new ContextMenuStrip(components);
        saveToFolderMenuItem = new ToolStripMenuItem();
        saveToMasterMenuItem = new ToolStripMenuItem();
        loadMenuStrip = new ContextMenuStrip(components);
        loadFromFolderMenuItem = new ToolStripMenuItem();
        loadFromMasterMenuItem = new ToolStripMenuItem();
        settingsMenuStrip = new ContextMenuStrip(components);
        changePathToolStripMenuItem = new ToolStripMenuItem();
        changePathMenuStrip = new ContextMenuStrip(components);
        editPathToFolderToolStripMenuItem = new ToolStripMenuItem();
        editPathToMasterToolStripMenuItem = new ToolStripMenuItem();
        changeThemeToolStripMenuItem = new ToolStripMenuItem();
        changeThemeMenuStrip = new ContextMenuStrip(components);
        darkToolStripMenuItem = new ToolStripMenuItem();
        lightToolStripMenuItem = new ToolStripMenuItem();
        separator1 = new Panel();
        separator2 = new Panel();
        separator3 = new Panel();
        separator4 = new Panel();
        separator7 = new Panel();
        separator8 = new Panel();
        separator9 = new Panel();
        bottomPanel.SuspendLayout();
        topPanel.SuspendLayout();
        settingsPanel.SuspendLayout();
        loadPanel.SuspendLayout();
        savePanel.SuspendLayout();
        sidePanel.SuspendLayout();
        listPanel.SuspendLayout();
        saveMenuStrip.SuspendLayout();
        loadMenuStrip.SuspendLayout();
        settingsMenuStrip.SuspendLayout();
        changePathMenuStrip.SuspendLayout();
        changeThemeMenuStrip.SuspendLayout();
        SuspendLayout();
        // 
        // bottomPanel
        // 
        bottomPanel.Controls.Add(separator8);
        bottomPanel.Controls.Add(separator7);
        bottomPanel.Dock = DockStyle.Bottom;
        bottomPanel.Location = new Point(1, 497);
        bottomPanel.Margin = new Padding(3, 4, 3, 4);
        bottomPanel.Name = "bottomPanel";
        bottomPanel.Size = new Size(1041, 33);
        bottomPanel.TabIndex = 0;
        // 
        // topPanel
        // 
        topPanel.Controls.Add(separator5);
        topPanel.Controls.Add(settingsPanel);
        topPanel.Controls.Add(loadPanel);
        topPanel.Controls.Add(savePanel);
        topPanel.Controls.Add(separator6);
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
        settingsPanel.Location = new Point(139, 0);
        settingsPanel.Margin = new Padding(3, 4, 3, 4);
        settingsPanel.Name = "settingsPanel";
        settingsPanel.Padding = new Padding(6, 0, 0, 0);
        settingsPanel.Size = new Size(90, 33);
        settingsPanel.TabIndex = 2;
        // 
        // settingsButton
        // 
        settingsButton.Dock = DockStyle.Fill;
        settingsButton.Location = new Point(6, 0);
        settingsButton.Margin = new Padding(3, 4, 3, 4);
        settingsButton.Name = "settingsButton";
        settingsButton.Size = new Size(84, 33);
        settingsButton.TabIndex = 0;
        settingsButton.Text = "Settings";
        settingsButton.UseVisualStyleBackColor = true;
        settingsButton.Click += activateDropDown;
        // 
        // loadPanel
        // 
        loadPanel.Controls.Add(loadButton);
        loadPanel.Dock = DockStyle.Left;
        loadPanel.Location = new Point(70, 0);
        loadPanel.Margin = new Padding(3, 4, 3, 4);
        loadPanel.Name = "loadPanel";
        loadPanel.Padding = new Padding(6, 0, 0, 0);
        loadPanel.Size = new Size(69, 33);
        loadPanel.TabIndex = 1;
        // 
        // loadButton
        // 
        loadButton.Dock = DockStyle.Fill;
        loadButton.Location = new Point(6, 0);
        loadButton.Margin = new Padding(3, 4, 3, 4);
        loadButton.Name = "loadButton";
        loadButton.Size = new Size(63, 33);
        loadButton.TabIndex = 0;
        loadButton.Text = "Load";
        loadButton.UseVisualStyleBackColor = true;
        loadButton.Click += activateDropDown;
        // 
        // savePanel
        // 
        savePanel.Controls.Add(saveButton);
        savePanel.Dock = DockStyle.Left;
        savePanel.Location = new Point(1, 0);
        savePanel.Margin = new Padding(3, 4, 3, 4);
        savePanel.Name = "savePanel";
        savePanel.Padding = new Padding(1, 0, 0, 0);
        savePanel.Size = new Size(69, 33);
        savePanel.TabIndex = 0;
        // 
        // saveButton
        // 
        saveButton.Dock = DockStyle.Fill;
        saveButton.Location = new Point(1, 0);
        saveButton.Margin = new Padding(3, 4, 3, 4);
        saveButton.Name = "saveButton";
        saveButton.Size = new Size(68, 33);
        saveButton.TabIndex = 0;
        saveButton.Text = "Save";
        saveButton.UseVisualStyleBackColor = true;
        saveButton.Click += activateDropDown;
        // 
        // separator6
        // 
        //separator6.Dock = DockStyle.Left;
        //separator6.Location = new Point(0, 0);
        //separator6.Name = "separator6";
        //separator6.Size = new Size(1, 33);
        //separator6.TabIndex = 4;
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
        mainListButton.Enabled = false;
        mainListButton.Location = new Point(5, 427);
        mainListButton.Margin = new Padding(3, 4, 3, 4);
        mainListButton.Name = "mainListButton";
        mainListButton.Size = new Size(219, 33);
        mainListButton.TabIndex = 1;
        mainListButton.Text = "Back to Menu";
        mainListButton.UseVisualStyleBackColor = true;
        mainListButton.Click += chooseList;
        // 
        // listPanel
        // 
        listPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        listPanel.AutoSize = true;
        listPanel.BackColor = Color.LightGray;
        listPanel.Controls.Add(talismanButton);
        listPanel.Controls.Add(dragonButton);
        listPanel.Controls.Add(charaButton);
        listPanel.Location = new Point(0, 0);
        listPanel.Margin = new Padding(3, 4, 3, 4);
        listPanel.MinimumSize = new Size(230, 0);
        listPanel.Name = "listPanel";
        listPanel.Size = new Size(232, 424);
        listPanel.TabIndex = 0;
        // 
        // talismanButton
        // 
        talismanButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        talismanButton.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
        talismanButton.Location = new Point(5, 137);
        talismanButton.Margin = new Padding(3, 4, 3, 4);
        talismanButton.Name = "talismanButton";
        talismanButton.Size = new Size(217, 57);
        talismanButton.TabIndex = 2;
        talismanButton.Text = "Wyrmprints";
        talismanButton.UseVisualStyleBackColor = true;
        talismanButton.Click += chooseList;
        // 
        // dragonButton
        // 
        dragonButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        dragonButton.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
        dragonButton.Location = new Point(5, 72);
        dragonButton.Margin = new Padding(3, 4, 3, 4);
        dragonButton.Name = "dragonButton";
        dragonButton.Size = new Size(217, 57);
        dragonButton.TabIndex = 1;
        dragonButton.Text = "Dragons";
        dragonButton.UseVisualStyleBackColor = true;
        dragonButton.Click += chooseList;
        // 
        // charaButton
        // 
        charaButton.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
        charaButton.Location = new Point(5, 8);
        charaButton.Margin = new Padding(3, 4, 3, 4);
        charaButton.Name = "charaButton";
        charaButton.Size = new Size(217, 57);
        charaButton.TabIndex = 0;
        charaButton.Text = "Characters";
        charaButton.UseVisualStyleBackColor = true;
        charaButton.Click += chooseList;
        // 
        // detailPanel
        // 
        detailPanel.BackColor = Color.DarkGray;
        detailPanel.Dock = DockStyle.Fill;
        detailPanel.Location = new Point(1, 0);
        detailPanel.Margin = new Padding(3, 4, 3, 4);
        detailPanel.Name = "detailPanel";
        detailPanel.Size = new Size(1041, 530);
        detailPanel.TabIndex = 3;
        // 
        // saveMenuStrip
        // 
        saveMenuStrip.ImageScalingSize = new Size(20, 20);
        saveMenuStrip.Items.AddRange(new ToolStripItem[] { saveToFolderMenuItem, saveToMasterMenuItem });
        saveMenuStrip.Name = "contextMenuStrip1";
        saveMenuStrip.Size = new Size(177, 52);
        // 
        // saveToFolderMenuItem
        // 
        saveToFolderMenuItem.Name = "saveToFolderMenuItem";
        saveToFolderMenuItem.Size = new Size(176, 24);
        saveToFolderMenuItem.Text = "Save to Folder";
        saveToFolderMenuItem.Click += saveTo;
        // 
        // saveToMasterMenuItem
        // 
        saveToMasterMenuItem.Name = "saveToMasterMenuItem";
        saveToMasterMenuItem.Size = new Size(176, 24);
        saveToMasterMenuItem.Text = "Save to Master";
        saveToMasterMenuItem.Click += saveTo;
        // 
        // loadMenuStrip
        // 
        loadMenuStrip.ImageScalingSize = new Size(20, 20);
        loadMenuStrip.Items.AddRange(new ToolStripItem[] { loadFromFolderMenuItem, loadFromMasterMenuItem });
        loadMenuStrip.Name = "loadMenuStrip";
        loadMenuStrip.Size = new Size(197, 52);
        // 
        // loadFromFolderMenuItem
        // 
        loadFromFolderMenuItem.Name = "loadFromFolderMenuItem";
        loadFromFolderMenuItem.Size = new Size(196, 24);
        loadFromFolderMenuItem.Text = "Load from Folder";
        loadFromFolderMenuItem.Click += loadFrom;
        // 
        // loadFromMasterMenuItem
        // 
        loadFromMasterMenuItem.Name = "loadFromMasterMenuItem";
        loadFromMasterMenuItem.Size = new Size(196, 24);
        loadFromMasterMenuItem.Text = "Load from Master";
        loadFromMasterMenuItem.Click += loadFrom;
        // 
        // settingsMenuStrip
        // 
        settingsMenuStrip.ImageScalingSize = new Size(20, 20);
        settingsMenuStrip.Items.AddRange(new ToolStripItem[] { changePathToolStripMenuItem, changeThemeToolStripMenuItem });
        settingsMenuStrip.Name = "settingsMenuStrip";
        settingsMenuStrip.Size = new Size(178, 52);
        // 
        // changePathToolStripMenuItem
        // 
        changePathToolStripMenuItem.DropDown = changePathMenuStrip;
        changePathToolStripMenuItem.Name = "changePathToolStripMenuItem";
        changePathToolStripMenuItem.Size = new Size(177, 24);
        changePathToolStripMenuItem.Text = "Change Path";
        // 
        // changePathMenuStrip
        // 
        changePathMenuStrip.ImageScalingSize = new Size(20, 20);
        changePathMenuStrip.Items.AddRange(new ToolStripItem[] { editPathToFolderToolStripMenuItem, editPathToMasterToolStripMenuItem });
        changePathMenuStrip.Name = "changePathMenuStrip";
        changePathMenuStrip.OwnerItem = changePathToolStripMenuItem;
        changePathMenuStrip.Size = new Size(208, 52);
        // 
        // editPathToFolderToolStripMenuItem
        // 
        editPathToFolderToolStripMenuItem.Name = "editPathToFolderToolStripMenuItem";
        editPathToFolderToolStripMenuItem.Size = new Size(207, 24);
        editPathToFolderToolStripMenuItem.Text = "Edit Path to Folder";
        editPathToFolderToolStripMenuItem.Click += editPath;
        // 
        // editPathToMasterToolStripMenuItem
        // 
        editPathToMasterToolStripMenuItem.Name = "editPathToMasterToolStripMenuItem";
        editPathToMasterToolStripMenuItem.Size = new Size(207, 24);
        editPathToMasterToolStripMenuItem.Text = "Edit Path to Master ";
        editPathToMasterToolStripMenuItem.Click += editPath;
        // 
        // changeThemeToolStripMenuItem
        // 
        changeThemeToolStripMenuItem.DropDown = changeThemeMenuStrip;
        changeThemeToolStripMenuItem.Name = "changeThemeToolStripMenuItem";
        changeThemeToolStripMenuItem.Size = new Size(177, 24);
        changeThemeToolStripMenuItem.Text = "Change Theme";
        // 
        // changeThemeMenuStrip
        // 
        changeThemeMenuStrip.ImageScalingSize = new Size(20, 20);
        changeThemeMenuStrip.Items.AddRange(new ToolStripItem[] { darkToolStripMenuItem, lightToolStripMenuItem });
        changeThemeMenuStrip.Name = "changeThemeMenuStrip";
        changeThemeMenuStrip.OwnerItem = changeThemeToolStripMenuItem;
        changeThemeMenuStrip.Size = new Size(112, 56);
        // 
        // darkToolStripMenuItem
        // 
        darkToolStripMenuItem.Checked = true;
        darkToolStripMenuItem.CheckState = CheckState.Checked;
        darkToolStripMenuItem.Name = "darkToolStripMenuItem";
        darkToolStripMenuItem.Size = new Size(111, 26);
        darkToolStripMenuItem.Text = "Dark";
        darkToolStripMenuItem.Click += changeTheme;
        // 
        // lightToolStripMenuItem
        // 
        lightToolStripMenuItem.Name = "lightToolStripMenuItem";
        lightToolStripMenuItem.Size = new Size(111, 26);
        lightToolStripMenuItem.Text = "Light";
        lightToolStripMenuItem.Click += changeTheme;
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
        separator7.Dock = DockStyle.Right;
        separator7.Location = new Point(1040, 0);
        separator7.Name = "separator7";
        separator7.Size = new Size(1, 33);
        separator7.TabIndex = 0;
        // 
        // separator8
        // 
        //separator8.Dock = DockStyle.Left;
        //separator8.Location = new Point(0, 0);
        //separator8.Name = "separator8";
        //separator8.Size = new Size(1, 33);
        //separator8.TabIndex = 1;
        // 
        // separator9
        // 
        separator9.Dock = DockStyle.Left;
        separator9.Location = new Point(0, 0);
        separator9.Name = "separator9";
        separator9.Size = new Size(1, 530);
        separator9.TabIndex = 9;
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
        Controls.Add(separator9);
        Name = "Base";
        Text = "Dragalia Lost Data Editor";
        Load += Base_Load;
        bottomPanel.ResumeLayout(false);
        topPanel.ResumeLayout(false);
        settingsPanel.ResumeLayout(false);
        loadPanel.ResumeLayout(false);
        savePanel.ResumeLayout(false);
        sidePanel.ResumeLayout(false);
        sidePanel.PerformLayout();
        listPanel.ResumeLayout(false);
        saveMenuStrip.ResumeLayout(false);
        loadMenuStrip.ResumeLayout(false);
        settingsMenuStrip.ResumeLayout(false);
        changePathMenuStrip.ResumeLayout(false);
        changeThemeMenuStrip.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private Panel bottomPanel;
    private Panel topPanel;
    private Panel sidePanel;
    private Panel listPanel;
    private Panel detailPanel;
    private Panel savePanel;
    private Panel loadPanel;
    private Panel settingsPanel;
    private ContextMenuStrip saveMenuStrip;
    private ToolStripMenuItem saveToFolderMenuItem;
    private ToolStripMenuItem saveToMasterMenuItem;
    private ContextMenuStrip loadMenuStrip;
    private ToolStripMenuItem loadFromFolderMenuItem;
    private ToolStripMenuItem loadFromMasterMenuItem;
    private ContextMenuStrip settingsMenuStrip;
    private ToolStripMenuItem changePathToolStripMenuItem;
    private ContextMenuStrip changePathMenuStrip;
    private ToolStripMenuItem editPathToFolderToolStripMenuItem;
    private ToolStripMenuItem editPathToMasterToolStripMenuItem;
    private ToolStripMenuItem changeThemeToolStripMenuItem;
    private ContextMenuStrip changeThemeMenuStrip;
    private ToolStripMenuItem darkToolStripMenuItem;
    private ToolStripMenuItem lightToolStripMenuItem;
    private NoFocusCueButton mainListButton;
    private NoFocusCueButton charaButton;
    private NoFocusCueButton talismanButton;
    private NoFocusCueButton dragonButton;
    private NoFocusCueButton saveButton;
    private NoFocusCueButton loadButton;
    private NoFocusCueButton settingsButton;
    private Panel separator1;
    private Panel separator2;
    private Panel separator3;
    private Panel separator4;
    private Panel separator5;
    private Panel separator6;
    private Panel separator8;
    private Panel separator7;
    private Panel separator9;
}
