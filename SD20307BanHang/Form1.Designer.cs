namespace SD20307BanHang
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            btnTaoMoi = new Button();
            label1 = new Label();
            dgvHoaDon = new DataGridView();
            panel2 = new Panel();
            btnXoaCTHD = new Button();
            btnUpdateGio = new Button();
            label2 = new Label();
            dgvGioHang = new DataGridView();
            panel3 = new Panel();
            btnFindSP = new Button();
            txtTimKiem = new TextBox();
            label3 = new Label();
            dgvSanPham = new DataGridView();
            panel4 = new Panel();
            btnHuy = new Button();
            btnThanhToan = new Button();
            txtSoTienCanTra = new TextBox();
            label9 = new Label();
            txtSoTienKhachDua = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            lbTongTien = new Label();
            cbbNhanVien = new ComboBox();
            cbbKhachHang = new ComboBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHoaDon).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGioHang).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSanPham).BeginInit();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnTaoMoi);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(dgvHoaDon);
            panel1.Location = new Point(0, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(780, 181);
            panel1.TabIndex = 0;
            // 
            // btnTaoMoi
            // 
            btnTaoMoi.Location = new Point(679, 2);
            btnTaoMoi.Name = "btnTaoMoi";
            btnTaoMoi.Size = new Size(98, 23);
            btnTaoMoi.TabIndex = 15;
            btnTaoMoi.Text = "Tạo mới";
            btnTaoMoi.UseVisualStyleBackColor = true;
            btnTaoMoi.Click += btnTaoMoi_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 6);
            label1.Name = "label1";
            label1.Size = new Size(113, 15);
            label1.TabIndex = 1;
            label1.Text = "Danh Sách Hóa Đơn";
            // 
            // dgvHoaDon
            // 
            dgvHoaDon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHoaDon.Dock = DockStyle.Bottom;
            dgvHoaDon.Location = new Point(0, 31);
            dgvHoaDon.Name = "dgvHoaDon";
            dgvHoaDon.Size = new Size(780, 150);
            dgvHoaDon.TabIndex = 0;
            dgvHoaDon.CellClick += dgvHoaDon_CellClick;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnXoaCTHD);
            panel2.Controls.Add(btnUpdateGio);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(dgvGioHang);
            panel2.Location = new Point(0, 212);
            panel2.Name = "panel2";
            panel2.Size = new Size(780, 173);
            panel2.TabIndex = 1;
            // 
            // btnXoaCTHD
            // 
            btnXoaCTHD.Location = new Point(679, 0);
            btnXoaCTHD.Name = "btnXoaCTHD";
            btnXoaCTHD.Size = new Size(98, 23);
            btnXoaCTHD.TabIndex = 14;
            btnXoaCTHD.Text = "Xóa";
            btnXoaCTHD.UseVisualStyleBackColor = true;
            // 
            // btnUpdateGio
            // 
            btnUpdateGio.Location = new Point(549, 2);
            btnUpdateGio.Name = "btnUpdateGio";
            btnUpdateGio.Size = new Size(98, 23);
            btnUpdateGio.TabIndex = 13;
            btnUpdateGio.Text = "Cập nhật";
            btnUpdateGio.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(0, 8);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 2;
            label2.Text = "Giỏ Hàng";
            // 
            // dgvGioHang
            // 
            dgvGioHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGioHang.Dock = DockStyle.Bottom;
            dgvGioHang.Location = new Point(0, 29);
            dgvGioHang.Name = "dgvGioHang";
            dgvGioHang.Size = new Size(780, 144);
            dgvGioHang.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnFindSP);
            panel3.Controls.Add(txtTimKiem);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(dgvSanPham);
            panel3.Location = new Point(0, 391);
            panel3.Name = "panel3";
            panel3.Size = new Size(780, 251);
            panel3.TabIndex = 2;
            // 
            // btnFindSP
            // 
            btnFindSP.Location = new Point(244, 19);
            btnFindSP.Name = "btnFindSP";
            btnFindSP.Size = new Size(75, 40);
            btnFindSP.TabIndex = 12;
            btnFindSP.Text = "Tìm";
            btnFindSP.UseVisualStyleBackColor = true;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(3, 29);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(226, 23);
            txtTimKiem.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 10);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 3;
            label3.Text = "Sản Phẩm";
            // 
            // dgvSanPham
            // 
            dgvSanPham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSanPham.Dock = DockStyle.Bottom;
            dgvSanPham.Location = new Point(0, 65);
            dgvSanPham.Name = "dgvSanPham";
            dgvSanPham.Size = new Size(780, 186);
            dgvSanPham.TabIndex = 0;
            dgvSanPham.CellClick += dgvSanPham_CellClick;
            // 
            // panel4
            // 
            panel4.Controls.Add(btnHuy);
            panel4.Controls.Add(btnThanhToan);
            panel4.Controls.Add(txtSoTienCanTra);
            panel4.Controls.Add(label9);
            panel4.Controls.Add(txtSoTienKhachDua);
            panel4.Controls.Add(label8);
            panel4.Controls.Add(label7);
            panel4.Controls.Add(label6);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(lbTongTien);
            panel4.Controls.Add(cbbNhanVien);
            panel4.Controls.Add(cbbKhachHang);
            panel4.Location = new Point(786, 1);
            panel4.Name = "panel4";
            panel4.Size = new Size(277, 641);
            panel4.TabIndex = 3;
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(172, 507);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(75, 40);
            btnHuy.TabIndex = 11;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            // 
            // btnThanhToan
            // 
            btnThanhToan.Location = new Point(45, 507);
            btnThanhToan.Name = "btnThanhToan";
            btnThanhToan.Size = new Size(75, 40);
            btnThanhToan.TabIndex = 10;
            btnThanhToan.Text = "Thanh toán";
            btnThanhToan.UseVisualStyleBackColor = true;
            btnThanhToan.Click += btnThanhToan_Click;
            // 
            // txtSoTienCanTra
            // 
            txtSoTienCanTra.Location = new Point(43, 435);
            txtSoTienCanTra.Name = "txtSoTienCanTra";
            txtSoTienCanTra.ReadOnly = true;
            txtSoTienCanTra.Size = new Size(226, 23);
            txtSoTienCanTra.TabIndex = 9;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(16, 405);
            label9.Name = "label9";
            label9.Size = new Size(82, 15);
            label9.TabIndex = 8;
            label9.Text = "Số tiền cần trả";
            // 
            // txtSoTienKhachDua
            // 
            txtSoTienKhachDua.Location = new Point(43, 362);
            txtSoTienKhachDua.Name = "txtSoTienKhachDua";
            txtSoTienKhachDua.Size = new Size(226, 23);
            txtSoTienKhachDua.TabIndex = 7;
            txtSoTienKhachDua.TextChanged += txtSoTienKhachDua_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(16, 332);
            label8.Name = "label8";
            label8.Size = new Size(101, 15);
            label8.TabIndex = 6;
            label8.Text = "Số tiền khách đưa";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 36);
            label7.Name = "label7";
            label7.Size = new Size(72, 15);
            label7.TabIndex = 5;
            label7.Text = "Khách Hàng";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 120);
            label6.Name = "label6";
            label6.Size = new Size(61, 15);
            label6.TabIndex = 4;
            label6.Text = "Nhân viên";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(16, 237);
            label5.Name = "label5";
            label5.Size = new Size(61, 15);
            label5.TabIndex = 3;
            label5.Text = "Tổng Tiền";
            // 
            // lbTongTien
            // 
            lbTongTien.AutoSize = true;
            lbTongTien.Font = new Font("Segoe UI", 20F);
            lbTongTien.ForeColor = Color.Crimson;
            lbTongTien.Location = new Point(56, 264);
            lbTongTien.Name = "lbTongTien";
            lbTongTien.Size = new Size(71, 37);
            lbTongTien.TabIndex = 2;
            lbTongTien.Text = "NaN";
            // 
            // cbbNhanVien
            // 
            cbbNhanVien.FormattingEnabled = true;
            cbbNhanVien.Location = new Point(43, 153);
            cbbNhanVien.Name = "cbbNhanVien";
            cbbNhanVien.Size = new Size(226, 23);
            cbbNhanVien.TabIndex = 1;
            cbbNhanVien.SelectionChangeCommitted += cbbNhanVien_SelectionChangeCommitted;
            // 
            // cbbKhachHang
            // 
            cbbKhachHang.FormattingEnabled = true;
            cbbKhachHang.Location = new Point(43, 68);
            cbbKhachHang.Name = "cbbKhachHang";
            cbbKhachHang.Size = new Size(226, 23);
            cbbKhachHang.TabIndex = 0;
            cbbKhachHang.SelectionChangeCommitted += cbbKhachHang_SelectionChangeCommitted;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1074, 654);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHoaDon).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGioHang).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSanPham).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel4;
        private Panel panel2;
        private Panel panel3;
        private Label label1;
        private DataGridView dgvHoaDon;
        private Label label2;
        private DataGridView dgvGioHang;
        private Label label3;
        private DataGridView dgvSanPham;
        private Label label5;
        private Label lbTongTien;
        private ComboBox cbbNhanVien;
        private ComboBox cbbKhachHang;
        private Label label8;
        private Label label7;
        private Label label6;
        private TextBox txtSoTienCanTra;
        private Label label9;
        private TextBox txtSoTienKhachDua;
        private Button btnFindSP;
        private TextBox txtTimKiem;
        private Button btnHuy;
        private Button btnThanhToan;
        private Button btnTaoMoi;
        private Button btnXoaCTHD;
        private Button btnUpdateGio;
    }
}
