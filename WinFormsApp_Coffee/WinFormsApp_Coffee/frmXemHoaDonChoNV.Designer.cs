﻿
namespace WinFormsApp_Coffee
{
    partial class frmXemHoaDonChoNV
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmXemHoaDonChoNV));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtngay1 = new System.Windows.Forms.DateTimePicker();
            this.dtNgay = new System.Windows.Forms.DateTimePicker();
            this.btnTHongke = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnXemhoadon = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtNgay = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenban = new System.Windows.Forms.TextBox();
            this.txtNV = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvQlhoadon = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtTong = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQlhoadon)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(360, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Xem hóa đơn";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1023, 813);
            this.panel1.TabIndex = 1;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.dtngay1);
            this.groupBox4.Controls.Add(this.dtNgay);
            this.groupBox4.Controls.Add(this.btnTHongke);
            this.groupBox4.Location = new System.Drawing.Point(3, 197);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1017, 89);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Thống kê hóa đơn theo ngày";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(391, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 25);
            this.label7.TabIndex = 17;
            this.label7.Text = "Đến ngày:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 25);
            this.label6.TabIndex = 16;
            this.label6.Text = "Từ ngày:";
            // 
            // dtngay1
            // 
            this.dtngay1.CustomFormat = "dd/MM/yyyy";
            this.dtngay1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtngay1.Location = new System.Drawing.Point(499, 32);
            this.dtngay1.Name = "dtngay1";
            this.dtngay1.Size = new System.Drawing.Size(259, 31);
            this.dtngay1.TabIndex = 15;
            this.dtngay1.Value = new System.DateTime(2021, 10, 10, 0, 0, 0, 0);
            // 
            // dtNgay
            // 
            this.dtNgay.CustomFormat = "dd/MM/yyyy";
            this.dtNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgay.Location = new System.Drawing.Point(101, 33);
            this.dtNgay.Name = "dtNgay";
            this.dtNgay.Size = new System.Drawing.Size(259, 31);
            this.dtNgay.TabIndex = 14;
            this.dtNgay.Value = new System.DateTime(2021, 10, 10, 0, 0, 0, 0);
            // 
            // btnTHongke
            // 
            this.btnTHongke.Location = new System.Drawing.Point(780, 27);
            this.btnTHongke.Name = "btnTHongke";
            this.btnTHongke.Size = new System.Drawing.Size(231, 44);
            this.btnTHongke.TabIndex = 13;
            this.btnTHongke.Text = "Thống kê";
            this.btnTHongke.UseVisualStyleBackColor = true;
            this.btnTHongke.Click += new System.EventHandler(this.btnTHongke_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnXemhoadon);
            this.groupBox3.Location = new System.Drawing.Point(6, 292);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1017, 96);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Xem chi tiết hóa đơn";
            // 
            // btnXemhoadon
            // 
            this.btnXemhoadon.Location = new System.Drawing.Point(12, 30);
            this.btnXemhoadon.Name = "btnXemhoadon";
            this.btnXemhoadon.Size = new System.Drawing.Size(996, 50);
            this.btnXemhoadon.TabIndex = 10;
            this.btnXemhoadon.Text = "Xem chi tiết hóa đơn";
            this.btnXemhoadon.UseVisualStyleBackColor = true;
            this.btnXemhoadon.Click += new System.EventHandler(this.btnXemhoadon_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtNgay);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtTenban);
            this.groupBox2.Controls.Add(this.txtNV);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtMaHD);
            this.groupBox2.Location = new System.Drawing.Point(3, 57);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1017, 134);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin hóa đơn";
            // 
            // txtNgay
            // 
            this.txtNgay.BackColor = System.Drawing.Color.White;
            this.txtNgay.Location = new System.Drawing.Point(203, 30);
            this.txtNgay.Name = "txtNgay";
            this.txtNgay.ReadOnly = true;
            this.txtNgay.Size = new System.Drawing.Size(223, 31);
            this.txtNgay.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(540, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã HĐ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(93, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ngày lập";
            // 
            // txtTenban
            // 
            this.txtTenban.BackColor = System.Drawing.Color.White;
            this.txtTenban.Location = new System.Drawing.Point(630, 80);
            this.txtTenban.Name = "txtTenban";
            this.txtTenban.ReadOnly = true;
            this.txtTenban.Size = new System.Drawing.Size(223, 31);
            this.txtTenban.TabIndex = 9;
            // 
            // txtNV
            // 
            this.txtNV.BackColor = System.Drawing.Color.White;
            this.txtNV.Location = new System.Drawing.Point(203, 80);
            this.txtNV.Name = "txtNV";
            this.txtNV.ReadOnly = true;
            this.txtNV.Size = new System.Drawing.Size(223, 31);
            this.txtNV.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(540, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Tên bàn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tên nhân viên";
            // 
            // txtMaHD
            // 
            this.txtMaHD.BackColor = System.Drawing.Color.White;
            this.txtMaHD.Location = new System.Drawing.Point(630, 30);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.ReadOnly = true;
            this.txtMaHD.Size = new System.Drawing.Size(223, 31);
            this.txtMaHD.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvQlhoadon);
            this.groupBox1.Location = new System.Drawing.Point(3, 394);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1017, 416);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách hóa đơn";
            // 
            // dgvQlhoadon
            // 
            this.dgvQlhoadon.AllowUserToAddRows = false;
            this.dgvQlhoadon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvQlhoadon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQlhoadon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgvQlhoadon.Location = new System.Drawing.Point(5, 29);
            this.dgvQlhoadon.Margin = new System.Windows.Forms.Padding(2);
            this.dgvQlhoadon.Name = "dgvQlhoadon";
            this.dgvQlhoadon.RowHeadersWidth = 62;
            this.dgvQlhoadon.RowTemplate.Height = 25;
            this.dgvQlhoadon.Size = new System.Drawing.Size(1007, 379);
            this.dgvQlhoadon.TabIndex = 1;
            this.dgvQlhoadon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvQlhoadon_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaHD";
            this.Column1.HeaderText = "Mã HĐ";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Tentk";
            this.Column2.HeaderText = "Tên nhân viên";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Ngaylap";
            dataGridViewCellStyle1.Format = "dd/MM/yyyy";
            this.Column3.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column3.HeaderText = "Ngày lập";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Tenban";
            this.Column4.HeaderText = "Tên bàn";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Trangthaihoadon";
            this.Column5.HeaderText = "Trạng thái";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Tongtien";
            dataGridViewCellStyle2.Format = "#,###";
            this.Column6.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column6.HeaderText = "Tổng tiền";
            this.Column6.MinimumWidth = 8;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtTong);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Location = new System.Drawing.Point(12, 833);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(1023, 88);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Tổng doanh thu";
            // 
            // txtTong
            // 
            this.txtTong.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtTong.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtTong.ForeColor = System.Drawing.Color.DarkOrange;
            this.txtTong.Location = new System.Drawing.Point(591, 30);
            this.txtTong.Name = "txtTong";
            this.txtTong.ReadOnly = true;
            this.txtTong.Size = new System.Drawing.Size(423, 45);
            this.txtTong.TabIndex = 5;
            this.txtTong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(438, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(156, 38);
            this.label8.TabIndex = 4;
            this.label8.Text = "Tổng cộng";
            // 
            // frmXemHoaDonChoNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 932);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmXemHoaDonChoNV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xem hóa đơn";
            this.Load += new System.EventHandler(this.frmXemHoaDonChoNV_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQlhoadon)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvQlhoadon;
        private System.Windows.Forms.TextBox txtTenban;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNgay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnXemhoadon;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DateTimePicker dtNgay;
        private System.Windows.Forms.Button btnTHongke;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtngay1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtTong;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}