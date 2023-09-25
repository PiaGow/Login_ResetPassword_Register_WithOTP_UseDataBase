namespace otpTest
{
    partial class FormIn4
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
            this.labName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtBio = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labName.Location = new System.Drawing.Point(312, 82);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(118, 49);
            this.labName.TabIndex = 2;
            this.labName.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 309);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 367);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 27);
            this.label3.TabIndex = 4;
            this.label3.Text = "Bio";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(133, 309);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(396, 34);
            this.txtEmail.TabIndex = 7;
            // 
            // txtBio
            // 
            this.txtBio.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBio.Location = new System.Drawing.Point(133, 367);
            this.txtBio.Multiline = true;
            this.txtBio.Name = "txtBio";
            this.txtBio.Size = new System.Drawing.Size(396, 90);
            this.txtBio.TabIndex = 8;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(24, 47);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(148, 142);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkKhaki;
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.txtBio);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.labName);
            this.panel1.Location = new System.Drawing.Point(17, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(610, 550);
            this.panel1.TabIndex = 10;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(374, 482);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(126, 42);
            this.btnLogout.TabIndex = 12;
            this.btnLogout.Text = "Đăng xuất";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(175, 482);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnEdit.Size = new System.Drawing.Size(126, 42);
            this.btnEdit.TabIndex = 11;
            this.btnEdit.Text = "Chỉnh sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 254);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 27);
            this.label1.TabIndex = 10;
            this.label1.Text = "Tên hiển thị";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(133, 251);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(396, 34);
            this.txtName.TabIndex = 6;
            // 
            // FormIn4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Olive;
            this.ClientSize = new System.Drawing.Size(657, 574);
            this.Controls.Add(this.panel1);
            this.Name = "FormIn4";
            this.Text = "Thông tin tài khoản";
            this.Load += new System.EventHandler(this.FormIn4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtBio;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnEdit;
    }
}