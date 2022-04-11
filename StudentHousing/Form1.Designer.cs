namespace StudentHousing
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
            this.usernametxb = new System.Windows.Forms.TextBox();
            this.passwordtxb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LogInbtn = new System.Windows.Forms.Button();
            this.CreateUserbtn = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // usernametxb
            // 
            this.usernametxb.Location = new System.Drawing.Point(81, 61);
            this.usernametxb.Name = "usernametxb";
            this.usernametxb.Size = new System.Drawing.Size(100, 20);
            this.usernametxb.TabIndex = 0;
            // 
            // passwordtxb
            // 
            this.passwordtxb.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.passwordtxb.Location = new System.Drawing.Point(81, 98);
            this.passwordtxb.Name = "passwordtxb";
            this.passwordtxb.PasswordChar = '*';
            this.passwordtxb.Size = new System.Drawing.Size(100, 20);
            this.passwordtxb.TabIndex = 1;
            this.passwordtxb.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password:";
            // 
            // LogInbtn
            // 
            this.LogInbtn.Location = new System.Drawing.Point(56, 159);
            this.LogInbtn.Name = "LogInbtn";
            this.LogInbtn.Size = new System.Drawing.Size(75, 23);
            this.LogInbtn.TabIndex = 5;
            this.LogInbtn.Text = "Log in";
            this.LogInbtn.UseVisualStyleBackColor = true;
            this.LogInbtn.Click += new System.EventHandler(this.LogInbtn_Click);
            // 
            // CreateUserbtn
            // 
            this.CreateUserbtn.AutoSize = true;
            this.CreateUserbtn.Location = new System.Drawing.Point(17, 194);
            this.CreateUserbtn.Name = "CreateUserbtn";
            this.CreateUserbtn.Size = new System.Drawing.Size(164, 13);
            this.CreateUserbtn.TabIndex = 6;
            this.CreateUserbtn.TabStop = true;
            this.CreateUserbtn.Text = "Don\'t have an Account?: Sign in!";
            this.CreateUserbtn.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CreateUserbtn_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Student Housing B.V. App";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(196, 222);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CreateUserbtn);
            this.Controls.Add(this.LogInbtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passwordtxb);
            this.Controls.Add(this.usernametxb);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox usernametxb;
        private System.Windows.Forms.TextBox passwordtxb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button LogInbtn;
        private System.Windows.Forms.LinkLabel CreateUserbtn;
        private System.Windows.Forms.Label label3;
    }
}

