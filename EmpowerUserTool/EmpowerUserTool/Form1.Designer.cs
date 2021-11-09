namespace EmpowerUserTool
{
    partial class Form1
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
            this.DownloadEmpowerUsers = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DownloadEmpowerUsers
            // 
            this.DownloadEmpowerUsers.Location = new System.Drawing.Point(224, 24);
            this.DownloadEmpowerUsers.Name = "DownloadEmpowerUsers";
            this.DownloadEmpowerUsers.Size = new System.Drawing.Size(271, 44);
            this.DownloadEmpowerUsers.TabIndex = 0;
            this.DownloadEmpowerUsers.Text = "Download Empower Users";
            this.DownloadEmpowerUsers.UseVisualStyleBackColor = true;
            this.DownloadEmpowerUsers.Click += new System.EventHandler(this.DownloadEmpowerUsers_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 520);
            this.Controls.Add(this.DownloadEmpowerUsers);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button DownloadEmpowerUsers;
    }
}

