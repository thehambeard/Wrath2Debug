
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
            VanillaWrathButton = new System.Windows.Forms.Button();
            VanillaPath = new System.Windows.Forms.TextBox();
            DebugPathButton = new System.Windows.Forms.Button();
            DebugPath = new System.Windows.Forms.TextBox();
            StartButton = new System.Windows.Forms.Button();
            FolderPathWarning = new System.Windows.Forms.Label();
            InstallDialog = new System.Windows.Forms.FolderBrowserDialog();
            LogBox = new System.Windows.Forms.TextBox();
            DotPeekPathButton = new System.Windows.Forms.Button();
            DotPeekPath = new System.Windows.Forms.TextBox();
            dnSpyPathButton = new System.Windows.Forms.Button();
            dnSpyPath = new System.Windows.Forms.TextBox();
            UnityPathButton = new System.Windows.Forms.Button();
            UnityPath = new System.Windows.Forms.TextBox();
            InstallFileDialog = new System.Windows.Forms.OpenFileDialog();
            SymlinkCheckbox = new System.Windows.Forms.CheckBox();
            SuspendLayout();
            // 
            // VanillaWrathButton
            // 
            VanillaWrathButton.Location = new System.Drawing.Point(19, 25);
            VanillaWrathButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            VanillaWrathButton.Name = "VanillaWrathButton";
            VanillaWrathButton.Size = new System.Drawing.Size(153, 27);
            VanillaWrathButton.TabIndex = 1;
            VanillaWrathButton.Text = "Release Wrath";
            VanillaWrathButton.UseVisualStyleBackColor = true;
            VanillaWrathButton.Click += VanillaWrathButton_Click;
            // 
            // VanillaPath
            // 
            VanillaPath.Location = new System.Drawing.Point(178, 29);
            VanillaPath.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            VanillaPath.Name = "VanillaPath";
            VanillaPath.Size = new System.Drawing.Size(655, 23);
            VanillaPath.TabIndex = 2;
            VanillaPath.Text = "C:\\Program Files (x86)\\Steam\\steamapps\\common\\Pathfinder Second Adventure";
            VanillaPath.TextChanged += VanillaPath_TextChanged;
            // 
            // DebugPathButton
            // 
            DebugPathButton.Location = new System.Drawing.Point(19, 59);
            DebugPathButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            DebugPathButton.Name = "DebugPathButton";
            DebugPathButton.Size = new System.Drawing.Size(153, 27);
            DebugPathButton.TabIndex = 3;
            DebugPathButton.Text = "Debug Wrath";
            DebugPathButton.UseVisualStyleBackColor = true;
            DebugPathButton.Click += DebugPathButton_Click;
            // 
            // DebugPath
            // 
            DebugPath.Location = new System.Drawing.Point(178, 62);
            DebugPath.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            DebugPath.Name = "DebugPath";
            DebugPath.Size = new System.Drawing.Size(655, 23);
            DebugPath.TabIndex = 4;
            DebugPath.Text = "C:\\Program Files (x86)\\Steam\\steamapps\\common\\Pathfinder Second Adventure Debug";
            DebugPath.TextChanged += DebugPath_TextChanged;
            // 
            // StartButton
            // 
            StartButton.Location = new System.Drawing.Point(380, 193);
            StartButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            StartButton.Name = "StartButton";
            StartButton.Size = new System.Drawing.Size(88, 27);
            StartButton.TabIndex = 11;
            StartButton.Text = "Start Conversion";
            StartButton.UseVisualStyleBackColor = true;
            StartButton.Click += StartButton_Click;
            // 
            // FolderPathWarning
            // 
            FolderPathWarning.AutoSize = true;
            FolderPathWarning.Location = new System.Drawing.Point(15, 10);
            FolderPathWarning.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            FolderPathWarning.Name = "FolderPathWarning";
            FolderPathWarning.Size = new System.Drawing.Size(290, 15);
            FolderPathWarning.TabIndex = 8;
            FolderPathWarning.Text = "If file path is red it means the folder path is not found.";
            // 
            // LogBox
            // 
            LogBox.Location = new System.Drawing.Point(19, 230);
            LogBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            LogBox.Multiline = true;
            LogBox.Name = "LogBox";
            LogBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            LogBox.Size = new System.Drawing.Size(815, 378);
            LogBox.TabIndex = 12;
            // 
            // DotPeekPathButton
            // 
            DotPeekPathButton.Location = new System.Drawing.Point(19, 126);
            DotPeekPathButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            DotPeekPathButton.Name = "DotPeekPathButton";
            DotPeekPathButton.Size = new System.Drawing.Size(153, 27);
            DotPeekPathButton.TabIndex = 7;
            DotPeekPathButton.Text = "DotPeek Path";
            DotPeekPathButton.UseVisualStyleBackColor = true;
            DotPeekPathButton.Click += DotPeekPathButton_Click;
            // 
            // DotPeekPath
            // 
            DotPeekPath.Location = new System.Drawing.Point(178, 129);
            DotPeekPath.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            DotPeekPath.Name = "DotPeekPath";
            DotPeekPath.Size = new System.Drawing.Size(655, 23);
            DotPeekPath.TabIndex = 8;
            DotPeekPath.Text = "<user>\\AppData\\Local\\JetBrains\\Installations\\dotPeek231\\dotPeek64.exe";
            DotPeekPath.TextChanged += DotPeekPath_TextChanged;
            // 
            // dnSpyPathButton
            // 
            dnSpyPathButton.Location = new System.Drawing.Point(19, 159);
            dnSpyPathButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            dnSpyPathButton.Name = "dnSpyPathButton";
            dnSpyPathButton.Size = new System.Drawing.Size(153, 27);
            dnSpyPathButton.TabIndex = 9;
            dnSpyPathButton.Text = "dnSpy Path";
            dnSpyPathButton.UseVisualStyleBackColor = true;
            dnSpyPathButton.Click += dnSpyPathButton_Click;
            // 
            // dnSpyPath
            // 
            dnSpyPath.Location = new System.Drawing.Point(178, 163);
            dnSpyPath.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            dnSpyPath.Name = "dnSpyPath";
            dnSpyPath.Size = new System.Drawing.Size(655, 23);
            dnSpyPath.TabIndex = 10;
            dnSpyPath.Text = "Path to dnSpy...";
            dnSpyPath.TextChanged += dnSpyPath_TextChanged;
            // 
            // UnityPathButton
            // 
            UnityPathButton.Location = new System.Drawing.Point(19, 92);
            UnityPathButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            UnityPathButton.Name = "UnityPathButton";
            UnityPathButton.Size = new System.Drawing.Size(153, 27);
            UnityPathButton.TabIndex = 5;
            UnityPathButton.Text = "Unity Path";
            UnityPathButton.UseVisualStyleBackColor = true;
            UnityPathButton.Click += UnityPathButton_Click;
            // 
            // UnityPath
            // 
            UnityPath.Location = new System.Drawing.Point(178, 96);
            UnityPath.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            UnityPath.Name = "UnityPath";
            UnityPath.Size = new System.Drawing.Size(655, 23);
            UnityPath.TabIndex = 6;
            UnityPath.Text = "C:\\Program Files\\Unity\\Hub\\Editor\\2020.3.48f1";
            UnityPath.TextChanged += UnityPath_TextChanged;
            // 
            // InstallFileDialog
            // 
            InstallFileDialog.ValidateNames = false;
            // 
            // SymlinkCheckbox
            // 
            SymlinkCheckbox.AutoSize = true;
            SymlinkCheckbox.Location = new System.Drawing.Point(19, 198);
            SymlinkCheckbox.Name = "SymlinkCheckbox";
            SymlinkCheckbox.Size = new System.Drawing.Size(159, 19);
            SymlinkCheckbox.TabIndex = 13;
            SymlinkCheckbox.Text = "Symlink Large Directories";
            SymlinkCheckbox.UseVisualStyleBackColor = true;
            // 
            // Wrath2Debug
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(848, 617);
            Controls.Add(SymlinkCheckbox);
            Controls.Add(UnityPath);
            Controls.Add(UnityPathButton);
            Controls.Add(LogBox);
            Controls.Add(FolderPathWarning);
            Controls.Add(StartButton);
            Controls.Add(dnSpyPath);
            Controls.Add(DotPeekPath);
            Controls.Add(DebugPath);
            Controls.Add(dnSpyPathButton);
            Controls.Add(DotPeekPathButton);
            Controls.Add(DebugPathButton);
            Controls.Add(VanillaPath);
            Controls.Add(VanillaWrathButton);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "Wrath2Debug";
            Text = "Wrath2Debug";
            Load += Wrath2Debug_Load;
            ResumeLayout(false);
            PerformLayout();
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
        private System.Windows.Forms.CheckBox SymlinkCheckbox;
    }
}

