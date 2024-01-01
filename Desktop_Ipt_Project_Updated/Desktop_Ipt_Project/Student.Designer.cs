
namespace Desktop_Ipt_Project
{
    partial class Student
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
            this.label3 = new System.Windows.Forms.Label();
            this.std_id_lbl = new System.Windows.Forms.Label();
            this.username_txtbox = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.password_lbl = new System.Windows.Forms.Label();
            this.login_btn = new System.Windows.Forms.Button();
            this.PanelStudent = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.PanelStudent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(484, 75);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 33);
            this.label3.TabIndex = 3;
            this.label3.Text = "Student Login";
            // 
            // std_id_lbl
            // 
            this.std_id_lbl.AutoSize = true;
            this.std_id_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.std_id_lbl.Location = new System.Drawing.Point(378, 243);
            this.std_id_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.std_id_lbl.Name = "std_id_lbl";
            this.std_id_lbl.Size = new System.Drawing.Size(127, 29);
            this.std_id_lbl.TabIndex = 5;
            this.std_id_lbl.Text = "Student Id:";
            this.std_id_lbl.Click += new System.EventHandler(this.username_lbl_Click);
            // 
            // username_txtbox
            // 
            this.username_txtbox.Location = new System.Drawing.Point(535, 241);
            this.username_txtbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.username_txtbox.Name = "username_txtbox";
            this.username_txtbox.Size = new System.Drawing.Size(412, 26);
            this.username_txtbox.TabIndex = 4;
            this.username_txtbox.TextChanged += new System.EventHandler(this.username_txtbox_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(535, 330);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(412, 26);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // password_lbl
            // 
            this.password_lbl.AutoSize = true;
            this.password_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_lbl.Location = new System.Drawing.Point(378, 327);
            this.password_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.password_lbl.Name = "password_lbl";
            this.password_lbl.Size = new System.Drawing.Size(126, 29);
            this.password_lbl.TabIndex = 5;
            this.password_lbl.Text = "Password:";
            this.password_lbl.Click += new System.EventHandler(this.username_lbl_Click);
            // 
            // login_btn
            // 
            this.login_btn.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.login_btn.Location = new System.Drawing.Point(626, 406);
            this.login_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(112, 56);
            this.login_btn.TabIndex = 6;
            this.login_btn.Text = "Login";
            this.login_btn.UseVisualStyleBackColor = false;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(341, 35);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(252, 40);
            this.label4.TabIndex = 50;
            this.label4.Text = "Student Login";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PanelStudent);
            this.Controls.Add(this.login_btn);
            this.Controls.Add(this.password_lbl);
            this.Controls.Add(this.std_id_lbl);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.username_txtbox);
            this.Controls.Add(this.label3);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Student";
            this.Text = "Student";
            this.Load += new System.EventHandler(this.Student_Load);
            this.PanelStudent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label std_id_lbl;
        private System.Windows.Forms.TextBox username_txtbox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label password_lbl;
        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.Panel PanelStudent;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
    }
}