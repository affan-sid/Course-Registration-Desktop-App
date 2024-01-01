
namespace Desktop_Ipt_Project
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
            this.Admin_btn = new System.Windows.Forms.Button();
            this.Student_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.PanelStudent = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.PanelStudent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Admin_btn
            // 
            this.Admin_btn.BackColor = System.Drawing.SystemColors.Highlight;
            this.Admin_btn.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Admin_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Admin_btn.Location = new System.Drawing.Point(285, 181);
            this.Admin_btn.Name = "Admin_btn";
            this.Admin_btn.Size = new System.Drawing.Size(139, 49);
            this.Admin_btn.TabIndex = 0;
            this.Admin_btn.Text = "Admin";
            this.Admin_btn.UseVisualStyleBackColor = false;
            this.Admin_btn.Click += new System.EventHandler(this.Admin_btn_Click);
            // 
            // Student_btn
            // 
            this.Student_btn.BackColor = System.Drawing.SystemColors.Highlight;
            this.Student_btn.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Student_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Student_btn.Location = new System.Drawing.Point(475, 181);
            this.Student_btn.Name = "Student_btn";
            this.Student_btn.Size = new System.Drawing.Size(142, 49);
            this.Student_btn.TabIndex = 1;
            this.Student_btn.Text = "Student";
            this.Student_btn.UseVisualStyleBackColor = false;
            this.Student_btn.Click += new System.EventHandler(this.Student_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(241, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Course Registration Module";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(133, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(667, 73);
            this.panel1.TabIndex = 70;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(147, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(339, 29);
            this.label4.TabIndex = 50;
            this.label4.Text = "Course Registration Module";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PanelStudent
            // 
            this.PanelStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(76)))));
            this.PanelStudent.Controls.Add(this.pictureBox2);
            this.PanelStudent.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelStudent.Location = new System.Drawing.Point(0, 0);
            this.PanelStudent.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PanelStudent.Name = "PanelStudent";
            this.PanelStudent.Size = new System.Drawing.Size(133, 450);
            this.PanelStudent.TabIndex = 69;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Desktop_Ipt_Project.Properties.Resources.download;
            this.pictureBox2.Location = new System.Drawing.Point(-2, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(135, 73);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 69;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PanelStudent);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Student_btn);
            this.Controls.Add(this.Admin_btn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.PanelStudent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Admin_btn;
        private System.Windows.Forms.Button Student_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel PanelStudent;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

