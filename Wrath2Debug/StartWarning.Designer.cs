
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
            this.label1 = new System.Windows.Forms.Label();
            this.ProceedButton = new System.Windows.Forms.Button();
            this.WarnCancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(501, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Warning:  Everything in the debug folder will be deleted.  Your mod folder will b" +
    "e backed up and restored.";
            // 
            // ProceedButton
            // 
            this.ProceedButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ProceedButton.Location = new System.Drawing.Point(178, 44);
            this.ProceedButton.Name = "ProceedButton";
            this.ProceedButton.Size = new System.Drawing.Size(75, 23);
            this.ProceedButton.TabIndex = 1;
            this.ProceedButton.Text = "Proceed";
            this.ProceedButton.UseVisualStyleBackColor = true;
            this.ProceedButton.Click += new System.EventHandler(this.ProceedButton_Click);
            // 
            // WarnCancelButton
            // 
            this.WarnCancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.WarnCancelButton.Location = new System.Drawing.Point(259, 44);
            this.WarnCancelButton.Name = "WarnCancelButton";
            this.WarnCancelButton.Size = new System.Drawing.Size(75, 23);
            this.WarnCancelButton.TabIndex = 2;
            this.WarnCancelButton.Text = "Cancel";
            this.WarnCancelButton.UseVisualStyleBackColor = true;
            // 
            // StartWarning
            // 
            this.AcceptButton = this.ProceedButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.WarnCancelButton;
            this.ClientSize = new System.Drawing.Size(520, 79);
            this.ControlBox = false;
            this.Controls.Add(this.WarnCancelButton);
            this.Controls.Add(this.ProceedButton);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "StartWarning";
            this.Text = "StartWarning";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ProceedButton;
        private System.Windows.Forms.Button WarnCancelButton;
    }
}