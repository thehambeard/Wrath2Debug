
namespace Wrath2Debug
{
    partial class StartWarning
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
            label1 = new System.Windows.Forms.Label();
            ProceedButton = new System.Windows.Forms.Button();
            WarnCancelButton = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = System.Drawing.Color.Red;
            label1.Location = new System.Drawing.Point(14, 10);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(562, 15);
            label1.TabIndex = 0;
            label1.Text = "Warning:  Everything in the debug folder will be deleted.  Your mod folder will be backed up and restored.";
            // 
            // ProceedButton
            // 
            ProceedButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            ProceedButton.Location = new System.Drawing.Point(208, 51);
            ProceedButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            ProceedButton.Name = "ProceedButton";
            ProceedButton.Size = new System.Drawing.Size(88, 27);
            ProceedButton.TabIndex = 1;
            ProceedButton.Text = "Proceed";
            ProceedButton.UseVisualStyleBackColor = true;
            ProceedButton.Click += ProceedButton_Click;
            // 
            // WarnCancelButton
            // 
            WarnCancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            WarnCancelButton.Location = new System.Drawing.Point(302, 51);
            WarnCancelButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            WarnCancelButton.Name = "WarnCancelButton";
            WarnCancelButton.Size = new System.Drawing.Size(88, 27);
            WarnCancelButton.TabIndex = 2;
            WarnCancelButton.Text = "Cancel";
            WarnCancelButton.UseVisualStyleBackColor = true;
            // 
            // StartWarning
            // 
            AcceptButton = ProceedButton;
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            CancelButton = WarnCancelButton;
            ClientSize = new System.Drawing.Size(607, 91);
            ControlBox = false;
            Controls.Add(WarnCancelButton);
            Controls.Add(ProceedButton);
            Controls.Add(label1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "StartWarning";
            Text = "StartWarning";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ProceedButton;
        private System.Windows.Forms.Button WarnCancelButton;
    }
}