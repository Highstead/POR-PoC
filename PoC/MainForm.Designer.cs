namespace PoR.PoC
{
    partial class MainForm
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
            this.WebBrowser = new System.Windows.Forms.Panel();
            this.AddButton = new System.Windows.Forms.Button();
            this.ListUserButton = new System.Windows.Forms.Button();
            this.lblUserCountLabel = new System.Windows.Forms.Label();
            this.lblUserCountValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // WebBrowser
            // 
            this.WebBrowser.Location = new System.Drawing.Point(12, 12);
            this.WebBrowser.Name = "WebBrowser";
            this.WebBrowser.Size = new System.Drawing.Size(653, 396);
            this.WebBrowser.TabIndex = 0;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(671, 13);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(137, 30);
            this.AddButton.TabIndex = 4;
            this.AddButton.Text = "Add User";
            this.AddButton.UseMnemonic = false;
            this.AddButton.UseVisualStyleBackColor = true;
            // 
            // ListUserButton
            // 
            this.ListUserButton.Location = new System.Drawing.Point(671, 49);
            this.ListUserButton.Name = "ListUserButton";
            this.ListUserButton.Size = new System.Drawing.Size(136, 31);
            this.ListUserButton.TabIndex = 5;
            this.ListUserButton.Text = "List Users";
            this.ListUserButton.UseVisualStyleBackColor = true;
            // 
            // lblUserCountLabel
            // 
            this.lblUserCountLabel.AutoSize = true;
            this.lblUserCountLabel.Location = new System.Drawing.Point(671, 390);
            this.lblUserCountLabel.Name = "lblUserCountLabel";
            this.lblUserCountLabel.Size = new System.Drawing.Size(87, 17);
            this.lblUserCountLabel.TabIndex = 6;
            this.lblUserCountLabel.Text = "User Count: ";
            // 
            // lblUserCountValue
            // 
            this.lblUserCountValue.AutoSize = true;
            this.lblUserCountValue.Location = new System.Drawing.Point(755, 391);
            this.lblUserCountValue.Name = "lblUserCountValue";
            this.lblUserCountValue.Size = new System.Drawing.Size(16, 17);
            this.lblUserCountValue.TabIndex = 7;
            this.lblUserCountValue.Text = "0";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(820, 420);
            this.Controls.Add(this.lblUserCountValue);
            this.Controls.Add(this.lblUserCountLabel);
            this.Controls.Add(this.ListUserButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.WebBrowser);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel WebBrowser;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button ListUserButton;
        private System.Windows.Forms.Label lblUserCountLabel;
        private System.Windows.Forms.Label lblUserCountValue;

    }
}

