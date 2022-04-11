namespace StudentHousing
{
    partial class mainApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainApp));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Userscbb = new System.Windows.Forms.ComboBox();
            this.addAgrrementToList = new System.Windows.Forms.Button();
            this.allAgreements = new System.Windows.Forms.ListBox();
            this.agreementtbx = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.searchbtn = new System.Windows.Forms.Button();
            this.searchListBox = new System.Windows.Forms.ListBox();
            this.searchtbx = new System.Windows.Forms.TextBox();
            this.submitComplaintbtn = new System.Windows.Forms.TabPage();
            this.UploadComplaintbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.complainttbx = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.ruleslbl = new System.Windows.Forms.Label();
            this.SignOutlbl = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.profilePictureBox = new System.Windows.Forms.PictureBox();
            this.usernamelbl = new System.Windows.Forms.Label();
            this.uploadPicturebtn = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.submitComplaintbtn.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.submitComplaintbtn);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(12, 65);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(858, 388);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.Userscbb);
            this.tabPage1.Controls.Add(this.addAgrrementToList);
            this.tabPage1.Controls.Add(this.allAgreements);
            this.tabPage1.Controls.Add(this.agreementtbx);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(850, 362);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Create an Agreement";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(3, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Write to:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(3, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Contents of the Agreement:";
            // 
            // Userscbb
            // 
            this.Userscbb.FormattingEnabled = true;
            this.Userscbb.Location = new System.Drawing.Point(3, 50);
            this.Userscbb.Name = "Userscbb";
            this.Userscbb.Size = new System.Drawing.Size(253, 21);
            this.Userscbb.TabIndex = 4;
            // 
            // addAgrrementToList
            // 
            this.addAgrrementToList.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addAgrrementToList.Location = new System.Drawing.Point(175, 296);
            this.addAgrrementToList.Name = "addAgrrementToList";
            this.addAgrrementToList.Size = new System.Drawing.Size(81, 31);
            this.addAgrrementToList.TabIndex = 3;
            this.addAgrrementToList.Text = "Submit";
            this.addAgrrementToList.UseVisualStyleBackColor = true;
            this.addAgrrementToList.Click += new System.EventHandler(this.addAgrrementToList_Click);
            // 
            // allAgreements
            // 
            this.allAgreements.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.allAgreements.FormattingEnabled = true;
            this.allAgreements.ItemHeight = 20;
            this.allAgreements.Location = new System.Drawing.Point(259, 12);
            this.allAgreements.Name = "allAgreements";
            this.allAgreements.Size = new System.Drawing.Size(585, 344);
            this.allAgreements.TabIndex = 2;
            // 
            // agreementtbx
            // 
            this.agreementtbx.Location = new System.Drawing.Point(6, 110);
            this.agreementtbx.Multiline = true;
            this.agreementtbx.Name = "agreementtbx";
            this.agreementtbx.Size = new System.Drawing.Size(250, 142);
            this.agreementtbx.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.searchbtn);
            this.tabPage2.Controls.Add(this.searchListBox);
            this.tabPage2.Controls.Add(this.searchtbx);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(850, 362);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Search Agreements";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // searchbtn
            // 
            this.searchbtn.Location = new System.Drawing.Point(99, 61);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(75, 23);
            this.searchbtn.TabIndex = 4;
            this.searchbtn.Text = "Search";
            this.searchbtn.UseVisualStyleBackColor = true;
            this.searchbtn.Click += new System.EventHandler(this.searchbtn_Click);
            // 
            // searchListBox
            // 
            this.searchListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchListBox.FormattingEnabled = true;
            this.searchListBox.ItemHeight = 20;
            this.searchListBox.Location = new System.Drawing.Point(279, 7);
            this.searchListBox.Name = "searchListBox";
            this.searchListBox.Size = new System.Drawing.Size(565, 344);
            this.searchListBox.TabIndex = 2;
            // 
            // searchtbx
            // 
            this.searchtbx.Location = new System.Drawing.Point(23, 35);
            this.searchtbx.Name = "searchtbx";
            this.searchtbx.Size = new System.Drawing.Size(221, 20);
            this.searchtbx.TabIndex = 1;
            // 
            // submitComplaintbtn
            // 
            this.submitComplaintbtn.Controls.Add(this.UploadComplaintbtn);
            this.submitComplaintbtn.Controls.Add(this.label1);
            this.submitComplaintbtn.Controls.Add(this.complainttbx);
            this.submitComplaintbtn.Location = new System.Drawing.Point(4, 22);
            this.submitComplaintbtn.Name = "submitComplaintbtn";
            this.submitComplaintbtn.Padding = new System.Windows.Forms.Padding(3);
            this.submitComplaintbtn.Size = new System.Drawing.Size(850, 362);
            this.submitComplaintbtn.TabIndex = 2;
            this.submitComplaintbtn.Text = "Make a Complaint";
            this.submitComplaintbtn.UseVisualStyleBackColor = true;
            // 
            // UploadComplaintbtn
            // 
            this.UploadComplaintbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UploadComplaintbtn.Location = new System.Drawing.Point(603, 280);
            this.UploadComplaintbtn.Name = "UploadComplaintbtn";
            this.UploadComplaintbtn.Size = new System.Drawing.Size(111, 59);
            this.UploadComplaintbtn.TabIndex = 3;
            this.UploadComplaintbtn.Text = "Submit";
            this.UploadComplaintbtn.UseVisualStyleBackColor = true;
            this.UploadComplaintbtn.Click += new System.EventHandler(this.UploadComplaintbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(25, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Type your complaint";
            // 
            // complainttbx
            // 
            this.complainttbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.complainttbx.Location = new System.Drawing.Point(29, 68);
            this.complainttbx.Multiline = true;
            this.complainttbx.Name = "complainttbx";
            this.complainttbx.Size = new System.Drawing.Size(528, 271);
            this.complainttbx.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.ruleslbl);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(850, 362);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "House Rules";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // ruleslbl
            // 
            this.ruleslbl.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ruleslbl.Location = new System.Drawing.Point(3, 0);
            this.ruleslbl.Name = "ruleslbl";
            this.ruleslbl.Size = new System.Drawing.Size(841, 359);
            this.ruleslbl.TabIndex = 0;
            this.ruleslbl.Text = "label1";
            // 
            // SignOutlbl
            // 
            this.SignOutlbl.AutoSize = true;
            this.SignOutlbl.Location = new System.Drawing.Point(751, 45);
            this.SignOutlbl.Name = "SignOutlbl";
            this.SignOutlbl.Size = new System.Drawing.Size(46, 13);
            this.SignOutlbl.TabIndex = 1;
            this.SignOutlbl.TabStop = true;
            this.SignOutlbl.Text = "Sign out";
            this.SignOutlbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SignOutlbl_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(13, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Student Housing B.V. App";
            // 
            // profilePictureBox
            // 
            this.profilePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("profilePictureBox.Image")));
            this.profilePictureBox.Location = new System.Drawing.Point(816, 7);
            this.profilePictureBox.Name = "profilePictureBox";
            this.profilePictureBox.Size = new System.Drawing.Size(54, 52);
            this.profilePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.profilePictureBox.TabIndex = 3;
            this.profilePictureBox.TabStop = false;
            // 
            // usernamelbl
            // 
            this.usernamelbl.Location = new System.Drawing.Point(736, 17);
            this.usernamelbl.Name = "usernamelbl";
            this.usernamelbl.Size = new System.Drawing.Size(74, 18);
            this.usernamelbl.TabIndex = 4;
            this.usernamelbl.Text = "Alex";
            this.usernamelbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // uploadPicturebtn
            // 
            this.uploadPicturebtn.Location = new System.Drawing.Point(655, 17);
            this.uploadPicturebtn.Name = "uploadPicturebtn";
            this.uploadPicturebtn.Size = new System.Drawing.Size(75, 41);
            this.uploadPicturebtn.TabIndex = 6;
            this.uploadPicturebtn.Text = "Upload a Picture";
            this.uploadPicturebtn.UseVisualStyleBackColor = true;
            this.uploadPicturebtn.Click += new System.EventHandler(this.uploadPicturebtn_Click);
            // 
            // mainApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 465);
            this.Controls.Add(this.uploadPicturebtn);
            this.Controls.Add(this.usernamelbl);
            this.Controls.Add(this.profilePictureBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SignOutlbl);
            this.Controls.Add(this.tabControl1);
            this.Name = "mainApp";
            this.Text = "mainApp";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.submitComplaintbtn.ResumeLayout(false);
            this.submitComplaintbtn.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox agreementtbx;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox allAgreements;
        private System.Windows.Forms.TextBox searchtbx;
        private System.Windows.Forms.TabPage submitComplaintbtn;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button addAgrrementToList;
        private System.Windows.Forms.Label ruleslbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox complainttbx;
        private System.Windows.Forms.ListBox searchListBox;
        private System.Windows.Forms.LinkLabel SignOutlbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox profilePictureBox;
        private System.Windows.Forms.Label usernamelbl;
        private System.Windows.Forms.Button uploadPicturebtn;
        private System.Windows.Forms.ComboBox Userscbb;
        private System.Windows.Forms.Button searchbtn;
        private System.Windows.Forms.Button UploadComplaintbtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}