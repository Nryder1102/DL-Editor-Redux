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
        settingsPanel = new Panel();
        settingsButton = new Button();
        loadPanel = new Panel();
        loadButton = new Button();
        savePanel = new Panel();
        saveButton = new Button();
        sidePanel = new Panel();
        mainListButton = new Button();
        listPanel = new Panel();
        talismanButton = new Button();
        dragonButton = new Button();
        charaButton = new Button();
        detailPanel = new Panel();
        saveMenuStrip = new ContextMenuStrip(components);
        saveToFolderMenuItem = new ToolStripMenuItem();
        saveToMasterMenuItem = new ToolStripMenuItem();
        loadMenuStrip = new ContextMenuStrip(components);
        loadFromFolderToolStripMenuItem = new ToolStripMenuItem();
        loadFromMasterToolStripMenuItem = new ToolStripMenuItem();
        settingsMenuStrip = new ContextMenuStrip(components);
        changePathToolStripMenuItem = new ToolStripMenuItem();
        changePathMenuStrip = new ContextMenuStrip(components);
        editPathToFolderToolStripMenuItem = new ToolStripMenuItem();
        editPathToMasterToolStripMenuItem = new ToolStripMenuItem();
        changeThemeToolStripMenuItem = new ToolStripMenuItem();
        changeThemeMenuStrip = new ContextMenuStrip(components);
        darkToolStripMenuItem = new ToolStripMenuItem();
        lightToolStripMenuItem = new ToolStripMenuItem();
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
        bottomPanel.BackColor = Color.DimGray;
        bottomPanel.BorderStyle = BorderStyle.FixedSingle;
        bottomPanel.Dock = DockStyle.Bottom;
        bottomPanel.Location = new Point(0, 436);
        bottomPanel.Name = "bottomPanel";
        bottomPanel.Size = new Size(934, 25);
        bottomPanel.TabIndex = 0;
        // 
        // topPanel
        // 
        topPanel.BackColor = Color.DimGray;
        topPanel.BorderStyle = BorderStyle.FixedSingle;
        topPanel.Controls.Add(settingsPanel);
        topPanel.Controls.Add(loadPanel);
        topPanel.Controls.Add(savePanel);
        topPanel.Dock = DockStyle.Top;
        topPanel.Location = new Point(0, 0);
        topPanel.Name = "topPanel";
        topPanel.Size = new Size(934, 25);
        topPanel.TabIndex = 1;
        // 
        // settingsPanel
        // 
        settingsPanel.BackColor = Color.DimGray;
        settingsPanel.Controls.Add(settingsButton);
        settingsPanel.Dock = DockStyle.Left;
        settingsPanel.Location = new Point(120, 0);
        settingsPanel.Name = "settingsPanel";
        settingsPanel.Padding = new Padding(5, 0, 0, 0);
        settingsPanel.Size = new Size(77, 23);
        settingsPanel.TabIndex = 2;
        // 
        // settingsButton
        // 
        settingsButton.Dock = DockStyle.Fill;
        settingsButton.Location = new Point(5, 0);
        settingsButton.Name = "settingsButton";
        settingsButton.Size = new Size(72, 23);
        settingsButton.TabIndex = 0;
        settingsButton.Text = "Settings";
        settingsButton.UseVisualStyleBackColor = true;
        settingsButton.Click += activateDropDown;
        // 
        // loadPanel
        // 
        loadPanel.BackColor = Color.DimGray;
        loadPanel.Controls.Add(loadButton);
        loadPanel.Dock = DockStyle.Left;
        loadPanel.Location = new Point(60, 0);
        loadPanel.Name = "loadPanel";
        loadPanel.Padding = new Padding(5, 0, 0, 0);
        loadPanel.Size = new Size(60, 23);
        loadPanel.TabIndex = 1;
        // 
        // loadButton
        // 
        loadButton.Dock = DockStyle.Fill;
        loadButton.Location = new Point(5, 0);
        loadButton.Name = "loadButton";
        loadButton.Size = new Size(55, 23);
        loadButton.TabIndex = 0;
        loadButton.Text = "Load";
        loadButton.UseVisualStyleBackColor = true;
        loadButton.Click += activateDropDown;
        // 
        // savePanel
        // 
        savePanel.BackColor = Color.DimGray;
        savePanel.Controls.Add(saveButton);
        savePanel.Dock = DockStyle.Left;
        savePanel.Location = new Point(0, 0);
        savePanel.Name = "savePanel";
        savePanel.Padding = new Padding(1, 0, 0, 0);
        savePanel.Size = new Size(60, 23);
        savePanel.TabIndex = 0;
        // 
        // saveButton
        // 
        saveButton.Dock = DockStyle.Fill;
        saveButton.Location = new Point(1, 0);
        saveButton.Name = "saveButton";
        saveButton.Size = new Size(59, 23);
        saveButton.TabIndex = 0;
        saveButton.Text = "Save";
        saveButton.UseVisualStyleBackColor = true;
        saveButton.Click += activateDropDown;
        // 
        // sidePanel
        // 
        sidePanel.BackColor = Color.Gray;
        sidePanel.BorderStyle = BorderStyle.FixedSingle;
        sidePanel.Controls.Add(mainListButton);
        sidePanel.Controls.Add(listPanel);
        sidePanel.Dock = DockStyle.Left;
        sidePanel.Location = new Point(0, 25);
        sidePanel.Name = "sidePanel";
        sidePanel.Size = new Size(200, 411);
        sidePanel.TabIndex = 2;
        // 
        // mainListButton
        // 
        mainListButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        mainListButton.Enabled = false;
        mainListButton.Location = new Point(2, 382);
        mainListButton.Name = "mainListButton";
        mainListButton.Size = new Size(195, 25);
        mainListButton.TabIndex = 1;
        mainListButton.Text = "Back to Menu";
        mainListButton.UseVisualStyleBackColor = true;
        mainListButton.Click += chooseList;
        // 
        // listPanel
        // 
        listPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        listPanel.BackColor = Color.LightGray;
        listPanel.Controls.Add(talismanButton);
        listPanel.Controls.Add(dragonButton);
        listPanel.Controls.Add(charaButton);
        listPanel.Location = new Point(0, 0);
        listPanel.Name = "listPanel";
        listPanel.Size = new Size(200, 380);
        listPanel.TabIndex = 0;
        // 
        // talismanButton
        // 
        talismanButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        talismanButton.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
        talismanButton.Location = new Point(3, 103);
        talismanButton.Name = "talismanButton";
        talismanButton.Size = new Size(192, 43);
        talismanButton.TabIndex = 2;
        talismanButton.Text = "Wyrmprints";
        talismanButton.UseVisualStyleBackColor = true;
        talismanButton.Click += chooseList;
        // 
        // dragonButton
        // 
        dragonButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        dragonButton.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
        dragonButton.Location = new Point(3, 54);
        dragonButton.Name = "dragonButton";
        dragonButton.Size = new Size(192, 43);
        dragonButton.TabIndex = 1;
        dragonButton.Text = "Dragons";
        dragonButton.UseVisualStyleBackColor = true;
        dragonButton.Click += chooseList;
        // 
        // charaButton
        // 
        charaButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        charaButton.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
        charaButton.Location = new Point(3, 5);
        charaButton.Name = "charaButton";
        charaButton.Size = new Size(192, 43);
        charaButton.TabIndex = 0;
        charaButton.Text = "Characters";
        charaButton.UseVisualStyleBackColor = true;
        charaButton.Click += chooseList;
        // 
        // detailPanel
        // 
        detailPanel.BackColor = Color.DarkGray;
        detailPanel.Dock = DockStyle.Fill;
        detailPanel.Location = new Point(200, 25);
        detailPanel.Name = "detailPanel";
        detailPanel.Size = new Size(734, 411);
        detailPanel.TabIndex = 3;
        // 
        // saveMenuStrip
        // 
        saveMenuStrip.Items.AddRange(new ToolStripItem[] { saveToFolderMenuItem, saveToMasterMenuItem });
        saveMenuStrip.Name = "contextMenuStrip1";
        saveMenuStrip.Size = new Size(152, 48);
        // 
        // saveToFolderMenuItem
        // 
        saveToFolderMenuItem.Name = "saveToFolderMenuItem";
        saveToFolderMenuItem.Size = new Size(151, 22);
        saveToFolderMenuItem.Text = "Save to Folder";
        saveToFolderMenuItem.Click += saveTo;
        // 
        // saveToMasterMenuItem
        // 
        saveToMasterMenuItem.Name = "saveToMasterMenuItem";
        saveToMasterMenuItem.Size = new Size(151, 22);
        saveToMasterMenuItem.Text = "Save to Master";
        saveToMasterMenuItem.Click += saveTo;
        // 
        // loadMenuStrip
        // 
        loadMenuStrip.Items.AddRange(new ToolStripItem[] { loadFromFolderToolStripMenuItem, loadFromMasterToolStripMenuItem });
        loadMenuStrip.Name = "loadMenuStrip";
        loadMenuStrip.Size = new Size(169, 48);
        // 
        // loadFromFolderToolStripMenuItem
        // 
        loadFromFolderToolStripMenuItem.Name = "loadFromFolderToolStripMenuItem";
        loadFromFolderToolStripMenuItem.Size = new Size(168, 22);
        loadFromFolderToolStripMenuItem.Text = "Load from Folder";
        loadFromFolderToolStripMenuItem.Click += loadFrom;
        // 
        // loadFromMasterToolStripMenuItem
        // 
        loadFromMasterToolStripMenuItem.Name = "loadFromMasterToolStripMenuItem";
        loadFromMasterToolStripMenuItem.Size = new Size(168, 22);
        loadFromMasterToolStripMenuItem.Text = "Load from Master";
        loadFromMasterToolStripMenuItem.Click += loadFrom;
        // 
        // settingsMenuStrip
        // 
        settingsMenuStrip.Items.AddRange(new ToolStripItem[] { changePathToolStripMenuItem, changeThemeToolStripMenuItem });
        settingsMenuStrip.Name = "settingsMenuStrip";
        settingsMenuStrip.Size = new Size(155, 48);
        // 
        // changePathToolStripMenuItem
        // 
        changePathToolStripMenuItem.DropDown = changePathMenuStrip;
        changePathToolStripMenuItem.Name = "changePathToolStripMenuItem";
        changePathToolStripMenuItem.Size = new Size(154, 22);
        changePathToolStripMenuItem.Text = "Change Path";
        // 
        // changePathMenuStrip
        // 
        changePathMenuStrip.Items.AddRange(new ToolStripItem[] { editPathToFolderToolStripMenuItem, editPathToMasterToolStripMenuItem });
        changePathMenuStrip.Name = "changePathMenuStrip";
        changePathMenuStrip.OwnerItem = changePathToolStripMenuItem;
        changePathMenuStrip.Size = new Size(178, 48);
        // 
        // editPathToFolderToolStripMenuItem
        // 
        editPathToFolderToolStripMenuItem.Name = "editPathToFolderToolStripMenuItem";
        editPathToFolderToolStripMenuItem.Size = new Size(177, 22);
        editPathToFolderToolStripMenuItem.Text = "Edit Path to Folder";
        editPathToFolderToolStripMenuItem.Click += editPath;
        // 
        // editPathToMasterToolStripMenuItem
        // 
        editPathToMasterToolStripMenuItem.Name = "editPathToMasterToolStripMenuItem";
        editPathToMasterToolStripMenuItem.Size = new Size(177, 22);
        editPathToMasterToolStripMenuItem.Text = "Edit Path to Master ";
        editPathToMasterToolStripMenuItem.Click += editPath;
        // 
        // changeThemeToolStripMenuItem
        // 
        changeThemeToolStripMenuItem.DropDown = changeThemeMenuStrip;
        changeThemeToolStripMenuItem.Name = "changeThemeToolStripMenuItem";
        changeThemeToolStripMenuItem.Size = new Size(154, 22);
        changeThemeToolStripMenuItem.Text = "Change Theme";
        // 
        // changeThemeMenuStrip
        // 
        changeThemeMenuStrip.Items.AddRange(new ToolStripItem[] { darkToolStripMenuItem, lightToolStripMenuItem });
        changeThemeMenuStrip.Name = "changeThemeMenuStrip";
        changeThemeMenuStrip.OwnerItem = changeThemeToolStripMenuItem;
        changeThemeMenuStrip.Size = new Size(102, 48);
        // 
        // darkToolStripMenuItem
        // 
        darkToolStripMenuItem.Checked = true;
        darkToolStripMenuItem.CheckState = CheckState.Checked;
        darkToolStripMenuItem.Name = "darkToolStripMenuItem";
        darkToolStripMenuItem.Size = new Size(101, 22);
        darkToolStripMenuItem.Text = "Dark";
        darkToolStripMenuItem.Click += changeTheme;
        // 
        // lightToolStripMenuItem
        // 
        lightToolStripMenuItem.Name = "lightToolStripMenuItem";
        lightToolStripMenuItem.Size = new Size(101, 22);
        lightToolStripMenuItem.Text = "Light";
        lightToolStripMenuItem.Click += changeTheme;
        // 
        // Base
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(64, 64, 64);
        ClientSize = new Size(934, 461);
        Controls.Add(detailPanel);
        Controls.Add(sidePanel);
        Controls.Add(topPanel);
        Controls.Add(bottomPanel);
        Margin = new Padding(3, 2, 3, 2);
        Name = "Base";
        Text = "Dragalia Lost Data Editor";
        Load += Base_Load;
        topPanel.ResumeLayout(false);
        settingsPanel.ResumeLayout(false);
        loadPanel.ResumeLayout(false);
        savePanel.ResumeLayout(false);
        sidePanel.ResumeLayout(false);
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
    private Button mainListButton;
    private Button charaButton;
    private Button talismanButton;
    private Button dragonButton;
    private Panel savePanel;
    private Button saveButton;
    private Panel loadPanel;
    private Button loadButton;
    private Panel settingsPanel;
    private Button settingsButton;
    private ContextMenuStrip saveMenuStrip;
    private ToolStripMenuItem saveToFolderMenuItem;
    private ToolStripMenuItem saveToMasterMenuItem;
    private ContextMenuStrip loadMenuStrip;
    private ToolStripMenuItem loadFromFolderToolStripMenuItem;
    private ToolStripMenuItem loadFromMasterToolStripMenuItem;
    private ContextMenuStrip settingsMenuStrip;
    private ToolStripMenuItem changePathToolStripMenuItem;
    private ContextMenuStrip changePathMenuStrip;
    private ToolStripMenuItem editPathToFolderToolStripMenuItem;
    private ToolStripMenuItem editPathToMasterToolStripMenuItem;
    private ToolStripMenuItem changeThemeToolStripMenuItem;
    private ContextMenuStrip changeThemeMenuStrip;
    private ToolStripMenuItem darkToolStripMenuItem;
    private ToolStripMenuItem lightToolStripMenuItem;
}
