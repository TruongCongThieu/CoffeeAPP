namespace DACN_TRUONGCONGTHIEU_6394
{
    partial class frm_QuanLyNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_QuanLyNhanVien));
            this.btn_dong = new System.Windows.Forms.Button();
            this.lbl_gioitinh = new System.Windows.Forms.Label();
            this.lbl_ngaysinh = new System.Windows.Forms.Label();
            this.txt_TenNV = new System.Windows.Forms.TextBox();
            this.lbl_tennv = new System.Windows.Forms.Label();
            this.txt_MaNV = new System.Windows.Forms.TextBox();
            this.txt_Tim = new System.Windows.Forms.TextBox();
            this.lbl_manv = new System.Windows.Forms.Label();
            this.data_dsnhanvien = new System.Windows.Forms.DataGridView();
            this.btn_tim = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_xem = new System.Windows.Forms.Button();
            this.txt_Diachi = new System.Windows.Forms.TextBox();
            this.lbl_diachi = new System.Windows.Forms.Label();
            this.dtp_NgaySinh = new System.Windows.Forms.DateTimePicker();
            this.txt_sdt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_gioitinh = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.data_dsnhanvien)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_dong
            // 
            this.btn_dong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_dong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_dong.Location = new System.Drawing.Point(1094, 479);
            this.btn_dong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_dong.Name = "btn_dong";
            this.btn_dong.Size = new System.Drawing.Size(89, 43);
            this.btn_dong.TabIndex = 30;
            this.btn_dong.Text = "Đóng";
            this.btn_dong.UseVisualStyleBackColor = false;
            this.btn_dong.Click += new System.EventHandler(this.btn_dong_Click);
            // 
            // lbl_gioitinh
            // 
            this.lbl_gioitinh.AutoSize = true;
            this.lbl_gioitinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_gioitinh.Location = new System.Drawing.Point(16, 171);
            this.lbl_gioitinh.Name = "lbl_gioitinh";
            this.lbl_gioitinh.Size = new System.Drawing.Size(81, 18);
            this.lbl_gioitinh.TabIndex = 28;
            this.lbl_gioitinh.Text = "Giới Tính:";
            // 
            // lbl_ngaysinh
            // 
            this.lbl_ngaysinh.AutoSize = true;
            this.lbl_ngaysinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ngaysinh.Location = new System.Drawing.Point(16, 218);
            this.lbl_ngaysinh.Name = "lbl_ngaysinh";
            this.lbl_ngaysinh.Size = new System.Drawing.Size(89, 18);
            this.lbl_ngaysinh.TabIndex = 27;
            this.lbl_ngaysinh.Text = "Ngày Sinh:";
            // 
            // txt_TenNV
            // 
            this.txt_TenNV.Location = new System.Drawing.Point(122, 130);
            this.txt_TenNV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_TenNV.Name = "txt_TenNV";
            this.txt_TenNV.Size = new System.Drawing.Size(233, 22);
            this.txt_TenNV.TabIndex = 25;
            // 
            // lbl_tennv
            // 
            this.lbl_tennv.AutoSize = true;
            this.lbl_tennv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tennv.Location = new System.Drawing.Point(16, 133);
            this.lbl_tennv.Name = "lbl_tennv";
            this.lbl_tennv.Size = new System.Drawing.Size(68, 18);
            this.lbl_tennv.TabIndex = 24;
            this.lbl_tennv.Text = "Tên NV:";
            // 
            // txt_MaNV
            // 
            this.txt_MaNV.Location = new System.Drawing.Point(122, 87);
            this.txt_MaNV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_MaNV.Name = "txt_MaNV";
            this.txt_MaNV.Size = new System.Drawing.Size(233, 22);
            this.txt_MaNV.TabIndex = 23;
            // 
            // txt_Tim
            // 
            this.txt_Tim.Location = new System.Drawing.Point(377, 36);
            this.txt_Tim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Tim.Name = "txt_Tim";
            this.txt_Tim.Size = new System.Drawing.Size(638, 22);
            this.txt_Tim.TabIndex = 22;
            // 
            // lbl_manv
            // 
            this.lbl_manv.AutoSize = true;
            this.lbl_manv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_manv.Location = new System.Drawing.Point(16, 90);
            this.lbl_manv.Name = "lbl_manv";
            this.lbl_manv.Size = new System.Drawing.Size(68, 18);
            this.lbl_manv.TabIndex = 21;
            this.lbl_manv.Text = "Mã  NV:";
            // 
            // data_dsnhanvien
            // 
            this.data_dsnhanvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_dsnhanvien.Location = new System.Drawing.Point(377, 87);
            this.data_dsnhanvien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.data_dsnhanvien.Name = "data_dsnhanvien";
            this.data_dsnhanvien.RowHeadersWidth = 51;
            this.data_dsnhanvien.RowTemplate.Height = 24;
            this.data_dsnhanvien.Size = new System.Drawing.Size(843, 354);
            this.data_dsnhanvien.TabIndex = 20;
            this.data_dsnhanvien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_dsnhanvien_CellClick);
            this.data_dsnhanvien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_dsnhanvien_CellContentClick);
            // 
            // btn_tim
            // 
            this.btn_tim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_tim.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_tim.Location = new System.Drawing.Point(1030, 34);
            this.btn_tim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_tim.Name = "btn_tim";
            this.btn_tim.Size = new System.Drawing.Size(93, 26);
            this.btn_tim.TabIndex = 19;
            this.btn_tim.Text = "Tìm kiếm";
            this.btn_tim.UseVisualStyleBackColor = false;
            this.btn_tim.Click += new System.EventHandler(this.btn_tim_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Xoa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_Xoa.Location = new System.Drawing.Point(765, 479);
            this.btn_Xoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(89, 43);
            this.btn_Xoa.TabIndex = 17;
            this.btn_Xoa.Text = "Xoá";
            this.btn_Xoa.UseVisualStyleBackColor = false;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Sua.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_Sua.Location = new System.Drawing.Point(573, 479);
            this.btn_Sua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(89, 43);
            this.btn_Sua.TabIndex = 18;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = false;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Them.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_Them.Location = new System.Drawing.Point(377, 479);
            this.btn_Them.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(89, 43);
            this.btn_Them.TabIndex = 16;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = false;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_xem
            // 
            this.btn_xem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_xem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_xem.Location = new System.Drawing.Point(159, 479);
            this.btn_xem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_xem.Name = "btn_xem";
            this.btn_xem.Size = new System.Drawing.Size(112, 43);
            this.btn_xem.TabIndex = 15;
            this.btn_xem.Text = "Xem Tất Cả";
            this.btn_xem.UseVisualStyleBackColor = false;
            this.btn_xem.Click += new System.EventHandler(this.btn_xem_Click);
            // 
            // txt_Diachi
            // 
            this.txt_Diachi.Location = new System.Drawing.Point(122, 321);
            this.txt_Diachi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Diachi.Multiline = true;
            this.txt_Diachi.Name = "txt_Diachi";
            this.txt_Diachi.Size = new System.Drawing.Size(233, 104);
            this.txt_Diachi.TabIndex = 32;
            // 
            // lbl_diachi
            // 
            this.lbl_diachi.AutoSize = true;
            this.lbl_diachi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_diachi.Location = new System.Drawing.Point(18, 322);
            this.lbl_diachi.Name = "lbl_diachi";
            this.lbl_diachi.Size = new System.Drawing.Size(68, 18);
            this.lbl_diachi.TabIndex = 31;
            this.lbl_diachi.Text = "Địa Chỉ:";
            // 
            // dtp_NgaySinh
            // 
            this.dtp_NgaySinh.CustomFormat = "dd/MM/yyyy";
            this.dtp_NgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_NgaySinh.Location = new System.Drawing.Point(122, 215);
            this.dtp_NgaySinh.Margin = new System.Windows.Forms.Padding(4);
            this.dtp_NgaySinh.Name = "dtp_NgaySinh";
            this.dtp_NgaySinh.Size = new System.Drawing.Size(233, 22);
            this.dtp_NgaySinh.TabIndex = 35;
            // 
            // txt_sdt
            // 
            this.txt_sdt.Location = new System.Drawing.Point(122, 271);
            this.txt_sdt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_sdt.Name = "txt_sdt";
            this.txt_sdt.Size = new System.Drawing.Size(233, 22);
            this.txt_sdt.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 272);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 18);
            this.label1.TabIndex = 36;
            this.label1.Text = "SDT:";
            // 
            // cb_gioitinh
            // 
            this.cb_gioitinh.FormattingEnabled = true;
            this.cb_gioitinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ",
            "Khác"});
            this.cb_gioitinh.Location = new System.Drawing.Point(122, 170);
            this.cb_gioitinh.Margin = new System.Windows.Forms.Padding(4);
            this.cb_gioitinh.Name = "cb_gioitinh";
            this.cb_gioitinh.Size = new System.Drawing.Size(233, 24);
            this.cb_gioitinh.TabIndex = 41;
            this.cb_gioitinh.Text = "chọn giới tính";
            // 
            // frm_QuanLyNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1233, 554);
            this.Controls.Add(this.cb_gioitinh);
            this.Controls.Add(this.txt_sdt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtp_NgaySinh);
            this.Controls.Add(this.txt_Diachi);
            this.Controls.Add(this.lbl_diachi);
            this.Controls.Add(this.btn_dong);
            this.Controls.Add(this.lbl_gioitinh);
            this.Controls.Add(this.lbl_ngaysinh);
            this.Controls.Add(this.txt_TenNV);
            this.Controls.Add(this.lbl_tennv);
            this.Controls.Add(this.txt_MaNV);
            this.Controls.Add(this.txt_Tim);
            this.Controls.Add(this.lbl_manv);
            this.Controls.Add(this.data_dsnhanvien);
            this.Controls.Add(this.btn_tim);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.btn_xem);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_QuanLyNhanVien";
            this.Text = "QUẢN LÝ NHÂN VIÊN";
            this.Load += new System.EventHandler(this.frm_QuanLyNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_dsnhanvien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_dong;
        private System.Windows.Forms.Label lbl_gioitinh;
        private System.Windows.Forms.Label lbl_ngaysinh;
        private System.Windows.Forms.TextBox txt_TenNV;
        private System.Windows.Forms.Label lbl_tennv;
        private System.Windows.Forms.TextBox txt_MaNV;
        private System.Windows.Forms.TextBox txt_Tim;
        private System.Windows.Forms.Label lbl_manv;
        private System.Windows.Forms.DataGridView data_dsnhanvien;
        private System.Windows.Forms.Button btn_tim;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_xem;
        private System.Windows.Forms.TextBox txt_Diachi;
        private System.Windows.Forms.Label lbl_diachi;
        private System.Windows.Forms.DateTimePicker dtp_NgaySinh;
        private System.Windows.Forms.TextBox txt_sdt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_gioitinh;
    }
}