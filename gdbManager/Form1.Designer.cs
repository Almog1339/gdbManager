using System;

namespace gdbManager
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
            this.btn_Save = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label10 = new System.Windows.Forms.Label();
            this.combo_PolygonsLyr = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.combo_users = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.combo_PointsLyr = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.lbl_error = new System.Windows.Forms.Label();
            this.combo_LinesLyr = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_lines = new System.Windows.Forms.Button();
            this.btn_polygons = new System.Windows.Forms.Button();
            this.btn_points = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pointsFileDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Save
            // 
            this.btn_Save.Enabled = false;
            this.btn_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.Location = new System.Drawing.Point(666, 201);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(83, 29);
            this.btn_Save.TabIndex = 0;
            this.btn_Save.Text = "&Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label10);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.combo_PolygonsLyr);
            this.splitContainer1.Panel2.Controls.Add(this.label6);
            this.splitContainer1.Panel2.Controls.Add(this.combo_users);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.label12);
            this.splitContainer1.Panel2.Controls.Add(this.combo_PointsLyr);
            this.splitContainer1.Panel2.Controls.Add(this.label11);
            this.splitContainer1.Panel2.Controls.Add(this.lbl_error);
            this.splitContainer1.Panel2.Controls.Add(this.combo_LinesLyr);
            this.splitContainer1.Panel2.Controls.Add(this.label8);
            this.splitContainer1.Panel2.Controls.Add(this.btn_lines);
            this.splitContainer1.Panel2.Controls.Add(this.btn_polygons);
            this.splitContainer1.Panel2.Controls.Add(this.btn_points);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.btn_Save);
            this.splitContainer1.Size = new System.Drawing.Size(761, 285);
            this.splitContainer1.SplitterDistance = 39;
            this.splitContainer1.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(259, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(242, 16);
            this.label10.TabIndex = 1;
            this.label10.Text = "Geo Database Management  Tool";
            // 
            // combo_PolygonsLyr
            // 
            this.combo_PolygonsLyr.Enabled = false;
            this.combo_PolygonsLyr.FormattingEnabled = true;
            this.combo_PolygonsLyr.Location = new System.Drawing.Point(462, 159);
            this.combo_PolygonsLyr.Name = "combo_PolygonsLyr";
            this.combo_PolygonsLyr.Size = new System.Drawing.Size(287, 21);
            this.combo_PolygonsLyr.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(424, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 18);
            this.label6.TabIndex = 27;
            this.label6.Text = "Lyr";
            // 
            // combo_users
            // 
            this.combo_users.FormattingEnabled = true;
            this.combo_users.Location = new System.Drawing.Point(232, 18);
            this.combo_users.Name = "combo_users";
            this.combo_users.Size = new System.Drawing.Size(370, 21);
            this.combo_users.TabIndex = 26;
            this.combo_users.SelectedIndexChanged += new System.EventHandler(this.Combo_users_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(186, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 18);
            this.label1.TabIndex = 25;
            this.label1.Text = "User";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(11, 57);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 16);
            this.label12.TabIndex = 1;
            this.label12.Text = "GDB\'s:";
            // 
            // combo_PointsLyr
            // 
            this.combo_PointsLyr.Enabled = false;
            this.combo_PointsLyr.FormattingEnabled = true;
            this.combo_PointsLyr.Location = new System.Drawing.Point(462, 88);
            this.combo_PointsLyr.Name = "combo_PointsLyr";
            this.combo_PointsLyr.Size = new System.Drawing.Size(287, 21);
            this.combo_PointsLyr.TabIndex = 24;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(424, 91);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 18);
            this.label11.TabIndex = 23;
            this.label11.Text = "Lyr:";
            // 
            // lbl_error
            // 
            this.lbl_error.AutoSize = true;
            this.lbl_error.Location = new System.Drawing.Point(57, 218);
            this.lbl_error.Name = "lbl_error";
            this.lbl_error.Size = new System.Drawing.Size(10, 13);
            this.lbl_error.TabIndex = 22;
            this.lbl_error.Text = ".";
            // 
            // combo_LinesLyr
            // 
            this.combo_LinesLyr.Enabled = false;
            this.combo_LinesLyr.FormattingEnabled = true;
            this.combo_LinesLyr.Location = new System.Drawing.Point(462, 125);
            this.combo_LinesLyr.Name = "combo_LinesLyr";
            this.combo_LinesLyr.Size = new System.Drawing.Size(287, 21);
            this.combo_LinesLyr.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(424, 128);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 18);
            this.label8.TabIndex = 9;
            this.label8.Text = "Lyr";
            // 
            // btn_lines
            // 
            this.btn_lines.Enabled = false;
            this.btn_lines.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_lines.FlatAppearance.BorderSize = 2;
            this.btn_lines.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_lines.Location = new System.Drawing.Point(96, 123);
            this.btn_lines.Name = "btn_lines";
            this.btn_lines.Size = new System.Drawing.Size(311, 23);
            this.btn_lines.TabIndex = 8;
            this.btn_lines.Text = "...";
            this.btn_lines.UseVisualStyleBackColor = true;
            this.btn_lines.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_polygons
            // 
            this.btn_polygons.Enabled = false;
            this.btn_polygons.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_polygons.FlatAppearance.BorderSize = 2;
            this.btn_polygons.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_polygons.Location = new System.Drawing.Point(96, 157);
            this.btn_polygons.Name = "btn_polygons";
            this.btn_polygons.Size = new System.Drawing.Size(311, 23);
            this.btn_polygons.TabIndex = 7;
            this.btn_polygons.Text = "...";
            this.btn_polygons.UseVisualStyleBackColor = true;
            this.btn_polygons.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_points
            // 
            this.btn_points.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_points.FlatAppearance.BorderSize = 2;
            this.btn_points.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_points.Location = new System.Drawing.Point(96, 91);
            this.btn_points.Name = "btn_points";
            this.btn_points.Size = new System.Drawing.Size(311, 23);
            this.btn_points.TabIndex = 6;
            this.btn_points.Text = "...";
            this.btn_points.UseVisualStyleBackColor = true;
            this.btn_points.Click += new System.EventHandler(this.btn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Errors:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Lines";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Polygons";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Points";
            // 
            // pointsFileDialog
            // 
            this.pointsFileDialog.FileName = "pointsFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 285);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog pointsFileDialog;
        private System.Windows.Forms.Button btn_lines;
        private System.Windows.Forms.Button btn_polygons;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox combo_LinesLyr;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox combo_PointsLyr;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.Button btn_points;
        public System.Windows.Forms.Label lbl_error;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox combo_users;
        private System.Windows.Forms.ComboBox combo_PolygonsLyr;
        private System.Windows.Forms.Label label6;
    }
}

