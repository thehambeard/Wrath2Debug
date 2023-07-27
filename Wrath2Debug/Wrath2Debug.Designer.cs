
namespace Wrath2Debug
{
    partial class Wrath2Debug
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
            this.VanillaWrathButton = new System.Windows.Forms.Button();
            this.VanillaPath = new System.Windows.Forms.TextBox();
            this.DebugPathButton = new System.Windows.Forms.Button();
            this.DebugPath = new System.Windows.Forms.TextBox();
            this.StartButton = new System.Windows.Forms.Button();
            this.FolderPathWarning = new System.Windows.Forms.Label();
            this.InstallDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.LogBox = new System.Windows.Forms.TextBox();
            this.DotPeekPathButton = new System.Windows.Forms.Button();
            this.DotPeekPath = new System.Windows.Forms.TextBox();
            this.dnSpyPathButton = new System.Windows.Forms.Button();
            this.dnSpyPath = new System.Windows.Forms.TextBox();
            this.UnityPathButton = new System.Windows.Forms.Button();
            this.UnityPath = new System.Windows.Forms.TextBox();
            this.InstallFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // VanillaWrathButton
            // 
            this.VanillaWrathButton.Location = new System.Drawing.Point(16, 22);
            this.VanillaWrathButton.Name = "VanillaWrathButton";
            this.VanillaWrathButton.Size = new System.Drawing.Size(131, 23);
            this.VanillaWrathButton.TabIndex = 1;
            this.VanillaWrathButton.Text = "Release Wrath";
            this.VanillaWrathButton.UseVisualStyleBackColor = true;
            this.VanillaWrathButton.Click += new System.EventHandler(this.VanillaWrathButton_Click);
            // 
            // VanillaPath
            // 
            this.VanillaPath.Location = new System.Drawing.Point(153, 25);
            this.VanillaPath.Name = "VanillaPath";
            this.VanillaPath.Size = new System.Drawing.Size(562, 20);
            this.VanillaPath.TabIndex = 2;
            this.VanillaPath.Text = "C:\\Program Files (x86)\\Steam\\steamapps\\common\\Pathfinder Second Adventure";
            this.VanillaPath.TextChanged += new System.EventHandler(this.VanillaPath_TextChanged);
            // 
            // DebugPathButton
            // 
            this.DebugPathButton.Location = new System.Drawing.Point(16, 51);
            this.DebugPathButton.Name = "DebugPathButton";
            this.DebugPathButton.Size = new System.Drawing.Size(131, 23);
            this.DebugPathButton.TabIndex = 3;
            this.DebugPathButton.Text = "Debug Wrath";
            this.DebugPathButton.UseVisualStyleBackColor = true;
            this.DebugPathButton.Click += new System.EventHandler(this.DebugPathButton_Click);
            // 
            // DebugPath
            // 
            this.DebugPath.Location = new System.Drawing.Point(153, 54);
            this.DebugPath.Name = "DebugPath";
            this.DebugPath.Size = new System.Drawing.Size(562, 20);
            this.DebugPath.TabIndex = 4;
            this.DebugPath.Text = "C:\\Program Files (x86)\\Steam\\steamapps\\common\\Pathfinder Second Adventure Debug";
            this.DebugPath.TextChanged += new System.EventHandler(this.DebugPath_TextChanged);
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(326, 167);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(75, 23);
            this.StartButton.TabIndex = 11;
            this.StartButton.Text = "Start Conversion";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // FolderPathWarning
            // 
            this.FolderPathWarning.AutoSize = true;
            this.FolderPathWarning.Location = new System.Drawing.Point(13, 9);
            this.FolderPathWarning.Name = "FolderPathWarning";
            this.FolderPathWarning.Size = new System.Drawing.Size(255, 13);
            this.FolderPathWarning.TabIndex = 8;
            this.FolderPathWarning.Text = "If file path is red it means the folder path is not found.";
            // 
            // LogBox
            // 
            this.LogBox.Location = new System.Drawing.Point(16, 199);
            this.LogBox.Multiline = true;
            this.LogBox.Name = "LogBox";
            this.LogBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.LogBox.Size = new System.Drawing.Size(699, 328);
            this.LogBox.TabIndex = 12;
            // 
            // DotPeekPathButton
            // 
            this.DotPeekPathButton.Location = new System.Drawing.Point(16, 109);
            this.DotPeekPathButton.Name = "DotPeekPathButton";
            this.DotPeekPathButton.Size = new System.Drawing.Size(131, 23);
            this.DotPeekPathButton.TabIndex = 7;
            this.DotPeekPathButton.Text = "DotPeek Path";
            this.DotPeekPathButton.UseVisualStyleBackColor = true;
            this.DotPeekPathButton.Click += new System.EventHandler(this.DotPeekPathButton_Click);
            // 
            // DotPeekPath
            // 
            this.DotPeekPath.Location = new System.Drawing.Point(153, 112);
            this.DotPeekPath.Name = "DotPeekPath";
            this.DotPeekPath.Size = new System.Drawing.Size(562, 20);
            this.DotPeekPath.TabIndex = 8;
            this.DotPeekPath.Text = "Path to DotPeek...";
            this.DotPeekPath.TextChanged += new System.EventHandler(this.DotPeekPath_TextChanged);
            // 
            // dnSpyPathButton
            // 
            this.dnSpyPathButton.Location = new System.Drawing.Point(16, 138);
            this.dnSpyPathButton.Name = "dnSpyPathButton";
            this.dnSpyPathButton.Size = new System.Drawing.Size(131, 23);
            this.dnSpyPathButton.TabIndex = 9;
            this.dnSpyPathButton.Text = "dnSpy Path";
            this.dnSpyPathButton.UseVisualStyleBackColor = true;
            this.dnSpyPathButton.Click += new System.EventHandler(this.dnSpyPathButton_Click);
            // 
            // dnSpyPath
            // 
            this.dnSpyPath.Location = new System.Drawing.Point(153, 141);
            this.dnSpyPath.Name = "dnSpyPath";
            this.dnSpyPath.Size = new System.Drawing.Size(562, 20);
            this.dnSpyPath.TabIndex = 10;
            this.dnSpyPath.Text = "Path to dnSpy...";
            this.dnSpyPath.TextChanged += new System.EventHandler(this.dnSpyPath_TextChanged);
            // 
            // UnityPathButton
            // 
            this.UnityPathButton.Location = new System.Drawing.Point(16, 80);
            this.UnityPathButton.Name = "UnityPathButton";
            this.UnityPathButton.Size = new System.Drawing.Size(131, 23);
            this.UnityPathButton.TabIndex = 5;
            this.UnityPathButton.Text = "Unity Path";
            this.UnityPathButton.UseVisualStyleBackColor = true;
            this.UnityPathButton.Click += new System.EventHandler(this.UnityPathButton_Click);
            // 
            // UnityPath
            // 
            this.UnityPath.Location = new System.Drawing.Point(153, 83);
            this.UnityPath.Name = "UnityPath";
            this.UnityPath.Size = new System.Drawing.Size(562, 20);
            this.UnityPath.TabIndex = 6;
            this.UnityPath.Text = "C:\\Program Files\\Unity\\Hub\\Editor\\2020.3.33f1";
            this.UnityPath.TextChanged += new System.EventHandler(this.UnityPath_TextChanged);
            // 
            // InstallFileDialog
            // 
            this.InstallFileDialog.ValidateNames = false;
            // 
            // Wrath2Debug
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 535);
            this.Controls.Add(this.UnityPath);
            this.Controls.Add(this.UnityPathButton);
            this.Controls.Add(this.LogBox);
            this.Controls.Add(this.FolderPathWarning);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.dnSpyPath);
            this.Controls.Add(this.DotPeekPath);
            this.Controls.Add(this.DebugPath);
            this.Controls.Add(this.dnSpyPathButton);
            this.Controls.Add(this.DotPeekPathButton);
            this.Controls.Add(this.DebugPathButton);
            this.Controls.Add(this.VanillaPath);
            this.Controls.Add(this.VanillaWrathButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Wrath2Debug";
            this.Text = "Wrath2Debug";
            this.Load += new System.EventHandler(this.Wrath2Debug_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button VanillaWrathButton;
        private System.Windows.Forms.TextBox VanillaPath;
        private System.Windows.Forms.Button DebugPathButton;
        private System.Windows.Forms.TextBox DebugPath;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Label FolderPathWarning;
        private System.Windows.Forms.FolderBrowserDialog InstallDialog;
        private System.Windows.Forms.TextBox LogBox;
        private System.Windows.Forms.Button DotPeekPathButton;
        private System.Windows.Forms.TextBox DotPeekPath;
        private System.Windows.Forms.Button dnSpyPathButton;
        private System.Windows.Forms.TextBox dnSpyPath;
        private System.Windows.Forms.Button UnityPathButton;
        private System.Windows.Forms.TextBox UnityPath;
        private System.Windows.Forms.OpenFileDialog InstallFileDialog;
    }
}

