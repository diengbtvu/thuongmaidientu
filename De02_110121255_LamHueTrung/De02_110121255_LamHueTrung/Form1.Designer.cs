namespace De02_110121255_LamHueTrung
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
            this.dgvCH = new System.Windows.Forms.DataGridView();
            this.idSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngonngu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giabia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.malt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tentheloai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdSach = new System.Windows.Forms.TextBox();
            this.txtTenSach = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGiaBia = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbbNgonNgu = new System.Windows.Forms.ComboBox();
            this.cbbTheLoai = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCH)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCH
            // 
            this.dgvCH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idSach,
            this.TenSach,
            this.ngonngu,
            this.giabia,
            this.malt,
            this.tentheloai});
            this.dgvCH.Location = new System.Drawing.Point(-1, 78);
            this.dgvCH.Name = "dgvCH";
            this.dgvCH.Size = new System.Drawing.Size(661, 310);
            this.dgvCH.TabIndex = 0;
            // 
            // idSach
            // 
            this.idSach.DataPropertyName = "idsach";
            this.idSach.HeaderText = "ID Sách";
            this.idSach.Name = "idSach";
            // 
            // TenSach
            // 
            this.TenSach.DataPropertyName = "tensach";
            this.TenSach.HeaderText = "Tên Sách";
            this.TenSach.Name = "TenSach";
            // 
            // ngonngu
            // 
            this.ngonngu.DataPropertyName = "ngonngu";
            this.ngonngu.HeaderText = "Ngôn Ngữ";
            this.ngonngu.Name = "ngonngu";
            // 
            // giabia
            // 
            this.giabia.DataPropertyName = "giabia";
            this.giabia.HeaderText = "Giá bìa";
            this.giabia.Name = "giabia";
            // 
            // malt
            // 
            this.malt.DataPropertyName = "matl";
            this.malt.HeaderText = "Mã Thể Loại";
            this.malt.Name = "malt";
            // 
            // tentheloai
            // 
            this.tentheloai.DataPropertyName = "tentheloai";
            this.tentheloai.HeaderText = "Tên Thể Loại";
            this.tentheloai.Name = "tentheloai";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(503, 49);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Id Sách";
            // 
            // txtIdSach
            // 
            this.txtIdSach.Location = new System.Drawing.Point(53, 9);
            this.txtIdSach.Name = "txtIdSach";
            this.txtIdSach.Size = new System.Drawing.Size(133, 20);
            this.txtIdSach.TabIndex = 3;
            // 
            // txtTenSach
            // 
            this.txtTenSach.Location = new System.Drawing.Point(266, 12);
            this.txtTenSach.Name = "txtTenSach";
            this.txtTenSach.Size = new System.Drawing.Size(137, 20);
            this.txtTenSach.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(208, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tên sách";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(439, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ngôn ngữ";
            // 
            // txtGiaBia
            // 
            this.txtGiaBia.Location = new System.Drawing.Point(53, 46);
            this.txtGiaBia.Name = "txtGiaBia";
            this.txtGiaBia.Size = new System.Drawing.Size(133, 20);
            this.txtGiaBia.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Giá bìa";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(202, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "tên thể loại";
            // 
            // cbbNgonNgu
            // 
            this.cbbNgonNgu.FormattingEnabled = true;
            this.cbbNgonNgu.Items.AddRange(new object[] {
            "Ngoại văn",
            "Việt Nam"});
            this.cbbNgonNgu.Location = new System.Drawing.Point(503, 6);
            this.cbbNgonNgu.Name = "cbbNgonNgu";
            this.cbbNgonNgu.Size = new System.Drawing.Size(140, 21);
            this.cbbNgonNgu.TabIndex = 14;
            // 
            // cbbTheLoai
            // 
            this.cbbTheLoai.FormattingEnabled = true;
            this.cbbTheLoai.Items.AddRange(new object[] {
            "Ngoại văn",
            "Việt Nam"});
            this.cbbTheLoai.Location = new System.Drawing.Point(267, 46);
            this.cbbTheLoai.Name = "cbbTheLoai";
            this.cbbTheLoai.Size = new System.Drawing.Size(140, 21);
            this.cbbTheLoai.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 390);
            this.Controls.Add(this.cbbTheLoai);
            this.Controls.Add(this.cbbNgonNgu);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtGiaBia);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTenSach);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIdSach);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dgvCH);
            this.Name = "Form1";
            this.Text = "De02_11021255_LamHueTrung";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCH;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIdSach;
        private System.Windows.Forms.TextBox txtTenSach;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtGiaBia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbbNgonNgu;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngonngu;
        private System.Windows.Forms.DataGridViewTextBoxColumn giabia;
        private System.Windows.Forms.DataGridViewTextBoxColumn malt;
        private System.Windows.Forms.DataGridViewTextBoxColumn tentheloai;
        private System.Windows.Forms.ComboBox cbbTheLoai;
    }
}

