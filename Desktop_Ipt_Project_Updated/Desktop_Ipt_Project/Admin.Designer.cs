
namespace Desktop_Ipt_Project
{
    partial class Admin
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
            this.username_txtbox = new System.Windows.Forms.TextBox();
            this.username_lbl = new System.Windows.Forms.Label();
            this.password_txtbox = new System.Windows.Forms.TextBox();
            this.password_lbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.login_btn = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.PanelStudent = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.PanelStudent.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // username_txtbox
            // 
            this.username_txtbox.Location = new System.Drawing.Point(518, 245);
            this.username_txtbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.username_txtbox.Name = "username_txtbox";
            this.username_txtbox.Size = new System.Drawing.Size(398, 26);
            this.username_txtbox.TabIndex = 0;
            this.username_txtbox.TextChanged += new System.EventHandler(this.username_txtbox_TextChanged);
            // 
            // username_lbl
            // 
            this.username_lbl.AutoSize = true;
            this.username_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_lbl.Location = new System.Drawing.Point(388, 245);
            this.username_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.username_lbl.Name = "username_lbl";
            this.username_lbl.Size = new System.Drawing.Size(130, 29);
            this.username_lbl.TabIndex = 1;
            this.username_lbl.Text = "Username:";
            this.username_lbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // password_txtbox
            // 
            this.password_txtbox.Location = new System.Drawing.Point(518, 319);
            this.password_txtbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.password_txtbox.Name = "password_txtbox";
            this.password_txtbox.Size = new System.Drawing.Size(398, 26);
            this.password_txtbox.TabIndex = 0;
            this.password_txtbox.TextChanged += new System.EventHandler(this.password_txtbox_TextChanged);
            // 
            // password_lbl
            // 
            this.password_lbl.AutoSize = true;
            this.password_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_lbl.Location = new System.Drawing.Point(391, 319);
            this.password_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.password_lbl.Name = "password_lbl";
            this.password_lbl.Size = new System.Drawing.Size(126, 29);
            this.password_lbl.TabIndex = 1;
            this.password_lbl.Text = "Password:";
            this.password_lbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(512, 60);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 33);
            this.label3.TabIndex = 2;
            this.label3.Text = "Admin Login";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // login_btn
            // 
            this.login_btn.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.login_btn.Location = new System.Drawing.Point(634, 408);
            this.login_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(120, 49);
            this.login_btn.TabIndex = 3;
            this.login_btn.Text = "Login";
            this.login_btn.UseVisualStyleBackColor = false;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Desktop_Ipt_Project.Properties.Resources.download;
            this.pictureBox2.Location = new System.Drawing.Point(-3, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(203, 112);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 69;
            this.pictureBox2.TabStop = false;
            // 
            // PanelStudent
            // 
            this.PanelStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(76)))));
            this.PanelStudent.Controls.Add(this.pictureBox2);
            this.PanelStudent.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelStudent.Location = new System.Drawing.Point(0, 0);
            this.PanelStudent.Name = "PanelStudent";
            this.PanelStudent.Size = new System.Drawing.Size(200, 692);
            this.PanelStudent.TabIndex = 68;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(355, 34);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(228, 40);
            this.label4.TabIndex = 50;
            this.label4.Text = "Admin Login";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(200, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 112);
            this.panel1.TabIndex = 69;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PanelStudent);
            this.Controls.Add(this.login_btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.password_lbl);
            this.Controls.Add(this.username_lbl);
            this.Controls.Add(this.password_txtbox);
            this.Controls.Add(this.username_txtbox);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Admin";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.PanelStudent.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox username_txtbox;
        private System.Windows.Forms.Label username_lbl;
        private System.Windows.Forms.TextBox password_txtbox;
        private System.Windows.Forms.Label password_lbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel PanelStudent;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
    }
}