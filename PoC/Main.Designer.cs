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
            this.lblUserCount = new System.Windows.Forms.Label();
            this.btnListUsers = new System.Windows.Forms.Button();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.lblUserCountVal = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlWebBrowser
            // 
            this.pnlWebBrowser.Location = new System.Drawing.Point(13, 13);
            this.pnlWebBrowser.Name = "pnlWebBrowser";
            this.pnlWebBrowser.Size = new System.Drawing.Size(608, 417);
            this.pnlWebBrowser.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblUserCountVal);
            this.panel2.Controls.Add(this.lblUserCount);
            this.panel2.Controls.Add(this.btnListUsers);
            this.panel2.Controls.Add(this.btnAddUser);
            this.panel2.Location = new System.Drawing.Point(627, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(188, 417);
            this.panel2.TabIndex = 1;
            // 
            // lblUserCount
            // 
            this.lblUserCount.AutoSize = true;
            this.lblUserCount.Location = new System.Drawing.Point(4, 397);
            this.lblUserCount.Name = "lblUserCount";
            this.lblUserCount.Size = new System.Drawing.Size(79, 17);
            this.lblUserCount.TabIndex = 2;
            this.lblUserCount.Text = "User Count";
            // 
            // btnListUsers
            // 
            this.btnListUsers.Location = new System.Drawing.Point(4, 40);
            this.btnListUsers.Name = "btnListUsers";
            this.btnListUsers.Size = new System.Drawing.Size(181, 30);
            this.btnListUsers.TabIndex = 1;
            this.btnListUsers.Text = "List Users";
            this.btnListUsers.UseVisualStyleBackColor = true;
            // 
            // btnAddUser
            // 
            this.btnAddUser.Location = new System.Drawing.Point(4, 4);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(181, 30);
            this.btnAddUser.TabIndex = 0;
            this.btnAddUser.Text = "Add User";
            this.btnAddUser.UseVisualStyleBackColor = true;
            // 
            // lblUserCountVal
            // 
            this.lblUserCountVal.AutoSize = true;
            this.lblUserCountVal.Location = new System.Drawing.Point(89, 397);
            this.lblUserCountVal.Name = "lblUserCountVal";
            this.lblUserCountVal.Size = new System.Drawing.Size(16, 17);
            this.lblUserCountVal.TabIndex = 3;
            this.lblUserCountVal.Text = "0";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 443);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlWebBrowser);
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