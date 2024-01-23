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
            loadFromFolder = new Button();
            loadFromAsset = new Button();
            choicePanel = new Panel();
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
            label1.Size = new Size(416, 30);
            label1.TabIndex = 0;
            label1.Text = "Welcome to the Dragalia Lost Data Editor!";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(3, 36);
            label2.Name = "label2";
            label2.Size = new Size(237, 15);
            label2.TabIndex = 1;
            label2.Text = "Please choose how to initially load the data:";
            label2.Click += label2_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDark;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(485, 33);
            panel1.TabIndex = 2;
            // 
            // loadFromFolder
            // 
            loadFromFolder.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            loadFromFolder.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            loadFromFolder.Location = new Point(147, 76);
            loadFromFolder.Name = "loadFromFolder";
            loadFromFolder.Size = new Size(193, 41);
            loadFromFolder.TabIndex = 3;
            loadFromFolder.Text = "Load From Folder";
            loadFromFolder.UseVisualStyleBackColor = true;
            loadFromFolder.Click += loadFromFolder_Click;
            // 
            // loadFromAsset
            // 
            loadFromAsset.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            loadFromAsset.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            loadFromAsset.Location = new Point(147, 142);
            loadFromAsset.Name = "loadFromAsset";
            loadFromAsset.Size = new Size(193, 41);
            loadFromAsset.TabIndex = 4;
            loadFromAsset.Text = "Load From Master Asset";
            loadFromAsset.UseVisualStyleBackColor = true;
            // 
            // choicePanel
            // 
            choicePanel.Controls.Add(label2);
            choicePanel.Controls.Add(loadFromFolder);
            choicePanel.Dock = DockStyle.Fill;
            choicePanel.Location = new Point(0, 0);
            choicePanel.Name = "choicePanel";
            choicePanel.Size = new Size(485, 214);
            choicePanel.TabIndex = 5;
            // 
            // SetupBox
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(485, 214);
            Controls.Add(loadFromAsset);
            Controls.Add(panel1);
            Controls.Add(choicePanel);
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
    }
}