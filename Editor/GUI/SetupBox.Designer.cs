

namespace Editor.GUI
{
    partial class SetupBox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            loadFromFolder = new NoFocusCueButton();
            loadFromAsset = new NoFocusCueButton();
            choicePanel = new Panel();
            folderBrowser = new FolderBrowserDialog();
            fileBrowser = new OpenFileDialog();
            panel1.SuspendLayout();
            choicePanel.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(516, 37);
            label1.TabIndex = 0;
            label1.Text = "Welcome to the Dragalia Lost Data Editor!";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(3, 48);
            label2.Name = "label2";
            label2.Size = new Size(300, 20);
            label2.TabIndex = 1;
            label2.Text = "Please choose how to initially load the data:";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDark;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(619, 44);
            panel1.TabIndex = 2;
            // 
            // loadFromFolder
            // 
            loadFromFolder.Anchor = AnchorStyles.None;
            loadFromFolder.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            loadFromFolder.Location = new Point(184, 100);
            loadFromFolder.Margin = new Padding(3, 4, 3, 4);
            loadFromFolder.Name = "loadFromFolder";
            loadFromFolder.Size = new Size(240, 55);
            loadFromFolder.TabIndex = 3;
            loadFromFolder.Text = "Load From Folder";
            loadFromFolder.UseVisualStyleBackColor = true;
            loadFromFolder.Click += setDefaultPath;
            // 
            // loadFromAsset
            // 
            loadFromAsset.Anchor = AnchorStyles.None;
            loadFromAsset.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            loadFromAsset.Location = new Point(184, 194);
            loadFromAsset.Margin = new Padding(3, 4, 3, 4);
            loadFromAsset.Name = "loadFromAsset";
            loadFromAsset.Size = new Size(240, 55);
            loadFromAsset.TabIndex = 4;
            loadFromAsset.Text = "Load From Master Asset";
            loadFromAsset.UseVisualStyleBackColor = true;
            loadFromAsset.Click += setDefaultPath;
            // 
            // choicePanel
            // 
            choicePanel.Controls.Add(loadFromAsset);
            choicePanel.Controls.Add(label2);
            choicePanel.Controls.Add(loadFromFolder);
            choicePanel.Dock = DockStyle.Fill;
            choicePanel.Location = new Point(0, 0);
            choicePanel.Margin = new Padding(3, 4, 3, 4);
            choicePanel.Name = "choicePanel";
            choicePanel.Size = new Size(619, 299);
            choicePanel.TabIndex = 5;
            // 
            // fileBrowser
            // 
            fileBrowser.FileName = "openFileDialog1";
            // 
            // SetupBox
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(619, 299);
            Controls.Add(panel1);
            Controls.Add(choicePanel);
            Margin = new Padding(3, 4, 3, 4);
            Name = "SetupBox";
            Text = "First Time Setup";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            choicePanel.ResumeLayout(false);
            choicePanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Panel panel1;
        private Button loadFromFolder;
        private Button loadFromAsset;
        private Panel choicePanel;
        private FolderBrowserDialog folderBrowser;
        private OpenFileDialog fileBrowser;
    }
}