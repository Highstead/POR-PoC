namespace PoR.PoC
{
    partial class Main
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
            this.pnlWebBrowser = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblUserCountVal = new System.Windows.Forms.Label();
            this.lblUserCount = new System.Windows.Forms.Label();
            this.btnListUsers = new System.Windows.Forms.Button();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlWebBrowser
            // 
            this.pnlWebBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlWebBrowser.Location = new System.Drawing.Point(10, 11);
            this.pnlWebBrowser.Margin = new System.Windows.Forms.Padding(0);
            this.pnlWebBrowser.Name = "pnlWebBrowser";
            this.pnlWebBrowser.Padding = new System.Windows.Forms.Padding(0, 0, 141, 0);
            this.pnlWebBrowser.Size = new System.Drawing.Size(599, 339);
            this.pnlWebBrowser.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.lblUserCountVal);
            this.panel2.Controls.Add(this.lblUserCount);
            this.panel2.Controls.Add(this.btnListUsers);
            this.panel2.Controls.Add(this.btnAddUser);
            this.panel2.Location = new System.Drawing.Point(470, 11);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(141, 339);
            this.panel2.TabIndex = 1;
            // 
            // lblUserCountVal
            // 
            this.lblUserCountVal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUserCountVal.AutoSize = true;
            this.lblUserCountVal.Location = new System.Drawing.Point(67, 323);
            this.lblUserCountVal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUserCountVal.Name = "lblUserCountVal";
            this.lblUserCountVal.Size = new System.Drawing.Size(13, 13);
            this.lblUserCountVal.TabIndex = 3;
            this.lblUserCountVal.Text = "0";
            // 
            // lblUserCount
            // 
            this.lblUserCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUserCount.AutoSize = true;
            this.lblUserCount.Location = new System.Drawing.Point(3, 323);
            this.lblUserCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUserCount.Name = "lblUserCount";
            this.lblUserCount.Size = new System.Drawing.Size(60, 13);
            this.lblUserCount.TabIndex = 2;
            this.lblUserCount.Text = "User Count";
            // 
            // btnListUsers
            // 
            this.btnListUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnListUsers.Location = new System.Drawing.Point(3, 32);
            this.btnListUsers.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnListUsers.Name = "btnListUsers";
            this.btnListUsers.Size = new System.Drawing.Size(136, 24);
            this.btnListUsers.TabIndex = 1;
            this.btnListUsers.Text = "List Users";
            this.btnListUsers.UseVisualStyleBackColor = true;
            // 
            // btnAddUser
            // 
            this.btnAddUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddUser.Location = new System.Drawing.Point(3, 3);
            this.btnAddUser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(136, 24);
            this.btnAddUser.TabIndex = 0;
            this.btnAddUser.Text = "Add User";
            this.btnAddUser.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 360);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlWebBrowser);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Main";
            this.Text = "Main";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlWebBrowser;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblUserCount;
        private System.Windows.Forms.Button btnListUsers;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Label lblUserCountVal;
    }
}