
namespace Desktop_Ipt_Project
{
    partial class AdminFunction
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
            this.crs_btn = new System.Windows.Forms.Button();
            this.std_btn = new System.Windows.Forms.Button();
            this.reg_btn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.add_btn = new System.Windows.Forms.Button();
            this.edit_btn = new System.Windows.Forms.Button();
            this.details_btn = new System.Windows.Forms.Button();
            this.del_btn = new System.Windows.Forms.Button();
            this.id_lbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PanelStudent = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.PanelStudent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // crs_btn
            // 
            this.crs_btn.BackColor = System.Drawing.SystemColors.Highlight;
            this.crs_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crs_btn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.crs_btn.Location = new System.Drawing.Point(242, 22);
            this.crs_btn.Name = "crs_btn";
            this.crs_btn.Size = new System.Drawing.Size(111, 34);
            this.crs_btn.TabIndex = 0;
            this.crs_btn.Text = "Courses";
            this.crs_btn.UseVisualStyleBackColor = false;
            this.crs_btn.Click += new System.EventHandler(this.crs_btn_Click);
            // 
            // std_btn
            // 
            this.std_btn.BackColor = System.Drawing.SystemColors.Highlight;
            this.std_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.std_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.std_btn.Location = new System.Drawing.Point(50, 22);
            this.std_btn.Name = "std_btn";
            this.std_btn.Size = new System.Drawing.Size(111, 34);
            this.std_btn.TabIndex = 0;
            this.std_btn.Text = "Students";
            this.std_btn.UseVisualStyleBackColor = false;
            this.std_btn.Click += new System.EventHandler(this.std_btn_Click);
            // 
            // reg_btn
            // 
            this.reg_btn.BackColor = System.Drawing.SystemColors.Highlight;
            this.reg_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reg_btn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.reg_btn.Location = new System.Drawing.Point(450, 22);
            this.reg_btn.Name = "reg_btn";
            this.reg_btn.Size = new System.Drawing.Size(108, 34);
            this.reg_btn.TabIndex = 0;
            this.reg_btn.Text = "Registrations";
            this.reg_btn.UseVisualStyleBackColor = false;
            this.reg_btn.Click += new System.EventHandler(this.reg_btn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(193, 109);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(384, 281);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // add_btn
            // 
            this.add_btn.BackColor = System.Drawing.Color.Tomato;
            this.add_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.add_btn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.add_btn.Location = new System.Drawing.Point(624, 155);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(75, 32);
            this.add_btn.TabIndex = 2;
            this.add_btn.Text = "Add";
            this.add_btn.UseVisualStyleBackColor = false;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // edit_btn
            // 
            this.edit_btn.BackColor = System.Drawing.Color.Tomato;
            this.edit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.edit_btn.Location = new System.Drawing.Point(624, 196);
            this.edit_btn.Name = "edit_btn";
            this.edit_btn.Size = new System.Drawing.Size(75, 32);
            this.edit_btn.TabIndex = 2;
            this.edit_btn.Text = "Edit";
            this.edit_btn.UseVisualStyleBackColor = false;
            this.edit_btn.Click += new System.EventHandler(this.edit_btn_Click);
            // 
            // details_btn
            // 
            this.details_btn.BackColor = System.Drawing.Color.Tomato;
            this.details_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.details_btn.Location = new System.Drawing.Point(624, 240);
            this.details_btn.Name = "details_btn";
            this.details_btn.Size = new System.Drawing.Size(75, 30);
            this.details_btn.TabIndex = 2;
            this.details_btn.Text = "Details";
            this.details_btn.UseVisualStyleBackColor = false;
            this.details_btn.Click += new System.EventHandler(this.details_btn_Click);
            // 
            // del_btn
            // 
            this.del_btn.BackColor = System.Drawing.Color.Tomato;
            this.del_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.del_btn.Location = new System.Drawing.Point(624, 282);
            this.del_btn.Name = "del_btn";
            this.del_btn.Size = new System.Drawing.Size(75, 32);
            this.del_btn.TabIndex = 2;
            this.del_btn.Text = "Delete";
            this.del_btn.UseVisualStyleBackColor = false;
            this.del_btn.Click += new System.EventHandler(this.del_btn_Click);
            // 
            // id_lbl
            // 
            this.id_lbl.AutoSize = true;
            this.id_lbl.Location = new System.Drawing.Point(190, 428);
            this.id_lbl.Name = "id_lbl";
            this.id_lbl.Size = new System.Drawing.Size(0, 13);
            this.id_lbl.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(294, 428);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 3;
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
            this.PanelStudent.TabIndex = 68;
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.std_btn);
            this.panel1.Controls.Add(this.crs_btn);
            this.panel1.Controls.Add(this.reg_btn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(133, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(667, 73);
            this.panel1.TabIndex = 69;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(237, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 29);
            this.label4.TabIndex = 50;
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AdminFunction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PanelStudent);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.id_lbl);
            this.Controls.Add(this.del_btn);
            this.Controls.Add(this.details_btn);
            this.Controls.Add(this.edit_btn);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AdminFunction";
            this.Text = "AdminFunction";
            this.Load += new System.EventHandler(this.AdminFunction_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.PanelStudent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button crs_btn;
        private System.Windows.Forms.Button std_btn;
        private System.Windows.Forms.Button reg_btn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Button edit_btn;
        private System.Windows.Forms.Button details_btn;
        private System.Windows.Forms.Button del_btn;
        private System.Windows.Forms.Label id_lbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel PanelStudent;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
    }
}