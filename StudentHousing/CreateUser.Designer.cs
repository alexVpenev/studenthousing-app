namespace StudentHousing
{
    partial class CreateUser
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
            this.newUsernametxb = new System.Windows.Forms.TextBox();
            this.newPasswordtxb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CreateUserBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // newUsernametxb
            // 
            this.newUsernametxb.Location = new System.Drawing.Point(68, 54);
            this.newUsernametxb.Name = "newUsernametxb";
            this.newUsernametxb.Size = new System.Drawing.Size(100, 20);
            this.newUsernametxb.TabIndex = 0;
            // 
            // newPasswordtxb
            // 
            this.newPasswordtxb.Location = new System.Drawing.Point(68, 103);
            this.newPasswordtxb.Name = "newPasswordtxb";
            this.newPasswordtxb.Size = new System.Drawing.Size(100, 20);
            this.newPasswordtxb.TabIndex = 1;
            this.newPasswordtxb.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter your Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Enter your Password:";
            // 
            // CreateUserBtn
            // 
            this.CreateUserBtn.Location = new System.Drawing.Point(48, 139);
            this.CreateUserBtn.Name = "CreateUserBtn";
            this.CreateUserBtn.Size = new System.Drawing.Size(75, 23);
            this.CreateUserBtn.TabIndex = 5;
            this.CreateUserBtn.Text = "Sign In";
            this.CreateUserBtn.UseVisualStyleBackColor = true;
            this.CreateUserBtn.Click += new System.EventHandler(this.CreateUserBtn_Click);
            // 
            // CreateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(182, 178);
            this.Controls.Add(this.CreateUserBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.newPasswordtxb);
            this.Controls.Add(this.newUsernametxb);
            this.Name = "CreateUser";
            this.Text = "Sign In";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox newUsernametxb;
        private System.Windows.Forms.TextBox newPasswordtxb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button CreateUserBtn;
    }
}