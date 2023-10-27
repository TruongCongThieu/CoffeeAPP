using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DACN_TRUONGCONGTHIEU_6394
{
    public partial class frm_QuanLyBan : Form
    {
        string phanquyen = "";
        public frm_QuanLyBan(string quyen)
        {
            InitializeComponent();
            phanquyen = quyen;
        }
        public frm_QuanLyBan()
        {
            InitializeComponent();
        }
        LOPDUNGCHUNG lopchung = new LOPDUNGCHUNG();
        public void loaddl()
        {
            string sql = "select * from BAN";
            data_Ban.DataSource = lopchung.LoadDL(sql);
            LoadDanhmuc();
            LoadDanhmucMon();
            LoadBAN();
        }
        private void aDMINToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (phanquyen == "ADMIN")
            {
                frm_ADMIN admin = new frm_ADMIN(phanquyen);
                admin.Show();
                this.Hide();
            }
            else MessageBox.Show("Bạn không được phép sử dụng!");
           
        }

        public void LoadDanhmuc()
        {
            string sql = "Select * from DANHMUC";
            DataTable danhMucTable = lopchung.LoadDL(sql);
            cb_danhmuc.DataSource = danhMucTable;
            cb_danhmuc.ValueMember = "MADANHMUC";
            cb_danhmuc.DisplayMember = "TENDANHMUC";

            // Thêm một dòng dữ liệu giả với giá trị MADANHMUC là 0 và TENDANHMUC là "Chọn Danh Mục"
            DataRow newRow = danhMucTable.NewRow();
            newRow["MADANHMUC"] = 0;
            newRow["TENDANHMUC"] = "Chọn Danh Mục";
            danhMucTable.Rows.InsertAt(newRow, 0);

            // Chọn giá trị đầu tiên là 0
            cb_danhmuc.SelectedIndex = 0;
        }
        public void LoadDanhmucMon()
        {
            string sql = "SELECT * FROM DANHSACHMON";
            DataTable Mamon = lopchung.LoadDL(sql);
            cb_mon.DataSource = Mamon;
            cb_mon.ValueMember = "MAMON";
            cb_mon.DisplayMember = "TENMON";
            DataRow newRow = Mamon.NewRow();
            newRow["MAMON"] = 0;
            newRow["TENMON"] = "Chọn Món";
            Mamon.Rows.InsertAt(newRow, 0);

            // Chọn giá trị đầu tiên là 0
            cb_mon.SelectedIndex = 0;
        }
        public void LoadBAN()
        {
            string sql = "Select * from BAN";
            cb_chuyenban.DataSource = lopchung.LoadDL(sql);
            cb_chuyenban.ValueMember = "Id";
            cb_chuyenban.DisplayMember = "BAN";
        }
        public void resetdl()
        {
            cb_danhmuc.Text = "";
            cb_mon.Text = "";
            cb_chuyenban.Text = "";
            nud_soluong.Value = 0;
        }
        public void loadTrangThai(int id)
        {
            string query = "SELECT ID,TENMON,DANHMUC,GIA,SOLUONG,(GIA*SOLUONG)AS THANHTIEN FROM THONGTINBAN WHERE ID = '" + id + "'";
            DataTable table = lopchung.LoadDL(query);

            // Kiểm tra xem có dữ liệu trả về hay không
            if (table.Rows.Count > 0)
            {
                string updateQuery = "UPDATE BAN SET TRANGTHAI = N'CÓ NGƯỜI' WHERE ID = '" + id + "'";
                lopchung.ThemXoaSua(updateQuery);
                loaddl();
            }
            else
            {
                string updateQuery = "UPDATE BAN SET TRANGTHAI = N'TRỐNG' WHERE ID = '" + id + "'";
                lopchung.ThemXoaSua(updateQuery);
                loaddl();
            }
        }

        private int IdBan, IdBanChuyenDen;

        private void data_Ban_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lbl_ban.Text = "DANH SACH MÓN " + data_Ban.CurrentRow.Cells["BAN"].Value.ToString();
            if (e.RowIndex >= 0)
            {
                string idstring = data_Ban.CurrentRow.Cells["Id"].Value.ToString();
                int id = int.Parse(idstring);
                IdBan = id;
                string query = "SELECT ID,TENMON,DANHMUC,GIA,SOLUONG,(GIA*SOLUONG)AS THANHTIEN FROM THONGTINBAN WHERE ID = '" + id + "'";
                DataTable table = lopchung.LoadDL(query);

                // Kiểm tra xem có dữ liệu trả về hay không
                if (table.Rows.Count > 0)
                {
                    loadTrangThai(IdBan);
                    loaddl();
                    string sql = "SELECT ID,TENMON,DANHMUC,GIA,SOLUONG,(GIA*SOLUONG) AS THANHTIEN from THONGTINBAN WHERE ID = '" + id + "'";
                    data_thongtinban.DataSource = lopchung.LoadDL(sql);
                }
                else
                {
                    loadTrangThai(IdBan);
                    loaddl();
                    string sql = "SELECT ID,TENMON,DANHMUC,GIA,SOLUONG,(GIA*SOLUONG) AS THANHTIEN from THONGTINBAN WHERE ID = '" + id + "'";
                    data_thongtinban.DataSource = lopchung.LoadDL(sql);
                }
            }
        }
        private void frm_QuanLyBan_Load(object sender, EventArgs e)
        {
            IdBan = 0;
            loaddl();
           
        }
        private void btn_themmon_Click(object sender, EventArgs e)
        {
            if (IdBan == 0)
            {
                MessageBox.Show("Bạn Phải Chọn Bàn");
            }
            else
            {
                // Kiểm tra xem đã chọn danh mục và món chưa
                if (cb_danhmuc.SelectedIndex == 0)
                {
                    MessageBox.Show("Vui lòng chọn danh mục.");
                    return; 
                }

                if (cb_mon.SelectedIndex == 0)
                {
                    MessageBox.Show("Vui lòng chọn món.");
                    return; 
                }
                int soluong = (int)nud_soluong.Value;
                if (soluong == 0)
                {
                    MessageBox.Show("Nhập Số Lượng!");
                }
                else
                {
                    // Lấy MAMON từ ComboBox cb_mon đã chọn
                    string mamon = cb_mon.SelectedValue.ToString();

                    // Truy vấn để lấy giá của món từ bảng DANHSACHMON
                    string query = "SELECT GIA FROM DANHSACHMON WHERE MAMON = '" + mamon + "'";
                    DataTable giaTable = lopchung.LoadDL(query);

                    // Kiểm tra xem có dữ liệu trả về hay không
                    if (giaTable.Rows.Count > 0)
                    {
                        // Lấy giá của món 
                        int gia = Convert.ToInt32(giaTable.Rows[0]["GIA"]);

                        // Thêm giá trị MAMON, gia, soluong vào bảng THONGTINBAN
                        string sql = "INSERT INTO THONGTINBAN VALUES ('" + IdBan + "', N'" + cb_mon.Text + "', N'" + cb_danhmuc.Text + "', '" + gia + "', '" + soluong + "', '" + gia * soluong + "')";
                        int kq = lopchung.ThemXoaSua(sql);
                        if (kq >= 1)
                        {
                            MessageBox.Show("Thêm món thành công");

                            string loaddlban = "SELECT ID,TENMON,DANHMUC,GIA,SOLUONG,(GIA*SOLUONG) AS THANHTIEN from THONGTINBAN WHERE ID = '" + IdBan + "'";
                            data_thongtinban.DataSource = lopchung.LoadDL(loaddlban);
                            resetdl();
                            loadTrangThai(IdBan);
                            loaddl();
                        }
                        else MessageBox.Show("Thêm món thất bại");
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy giá của món.");
                    }
                }

            }
        }

        private void btn_chuyenban_Click(object sender, EventArgs e)
        {

            IdBanChuyenDen = (int)cb_chuyenban.SelectedValue;
            // Kiểm tra xem đã chọn bàn chưa
            if (IdBan == 0)
            {
                MessageBox.Show("Bạn phải chọn bàn trước.");
            }
            else
            {
                // Lấy ID của bàn hiện tại đổi thành IdBanChuyenDi cho dễ hiểu 
                int IdBanChuyenDi = IdBan;
                // Cập nhật lại ID của các món của bàn chuyển tới
                // Lấy thông tin của bàn cần chuyển đi
                string layttban = "SELECT ID,TENMON,DANHMUC,GIA,SOLUONG,(GIA*SOLUONG) AS THANHTIEN FROM THONGTINBAN WHERE ID = '" + IdBan + "'";
                DataTable dt = lopchung.LoadDL(layttban);

                if (dt.Rows.Count > 0)
                {
                    // Cập nhật thông tin bàn này với IdBanChuyenDen
                    DataRow row = dt.Rows[0];
                    int idMon = Convert.ToInt32(row["ID"]);
                    string tenMon = row["TENMON"].ToString();
                    string danhMuc = row["DANHMUC"].ToString();
                    int gia = Convert.ToInt32(row["GIA"]);
                    int soLuong = Convert.ToInt32(row["SOLUONG"]);

                    // Cập nhật thông tin bàn với IdBanChuyenDen
                    string updateBanChuyenDi = "UPDATE THONGTINBAN SET ID = N'" + IdBanChuyenDen + "', TENMON = N'" + tenMon + "', DANHMUC = N'" + danhMuc + "', GIA = N'" + gia + "', SOLUONG = N'" + soLuong + "'where ID = '" + IdBanChuyenDi + "'";
                    int kq1 = lopchung.ThemXoaSua(updateBanChuyenDi);
                    loadTrangThai(IdBanChuyenDen);
                    loadTrangThai(IdBanChuyenDi);
                    loaddl();
                    if (kq1 >= 1)
                    {
                        MessageBox.Show("Chuyển thông tin bàn thành công.");
                        // Xóa tất cả các món của bàn chuyển tới
                        string deleteQuery = "DELETE FROM THONGTINBAN WHERE ID = '" + IdBanChuyenDi + "'";
                        int kq2 = lopchung.ThemXoaSua(deleteQuery);

                    }
                    else
                    {
                        MessageBox.Show("Chuyển thông tin bàn thất bại.");
                    }
                }
                else
                {
                    MessageBox.Show("Không tìm thấy thông tin bàn cần chuyển đi.");
                }
            }

        }

        private void cb_mon_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void cb_mon_Click(object sender, EventArgs e)
        {
            if (cb_danhmuc.SelectedIndex == 0)
            {
                MessageBox.Show("Vui lòng chọn một danh mục trước khi chọn món.");
                return;
            }
        }
        private void cb_danhmuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_danhmuc.SelectedIndex > 0) // Kiểm tra nếu đã chọn một danh mục (khác "Chọn Danh Mục")
            {

                string selectedDanhMuc = cb_danhmuc.SelectedValue.ToString();
                string sql = "SELECT * FROM DANHSACHMON WHERE MADANHMUC = '" + selectedDanhMuc + "'";
                DataTable Mamon = lopchung.LoadDL(sql);
                cb_mon.DataSource = Mamon;
                cb_mon.ValueMember = "MAMON";
                cb_mon.DisplayMember = "TENMON";

                string sql2= "SELECT TENDANHMUC FROM DANHMUC WHERE MADANHMUC = '" + selectedDanhMuc + "'";
                DataTable tendanhmuc = lopchung.LoadDL(sql2);
                DataRow row = tendanhmuc.Rows[0];
                string Tendanhmuc = row["TENDANHMUC"].ToString();

                DataRow newRow = Mamon.NewRow();
                newRow["MAMON"] = 0;
                newRow["TENMON"] = "Chọn "+Tendanhmuc;
                Mamon.Rows.InsertAt(newRow, 0);

                // Chọn giá trị đầu tiên là 0
                cb_mon.SelectedIndex = 0;
            }
           
        }

        private void btn_inhoadon_Click(object sender, EventArgs e)
        {
            if (IdBan == 0)
            {
                MessageBox.Show("Bạn Phải Chọn Bàn");
            }
            else
            {
                string kiemtratrangthai = "SELECT TRANGTHAI from BAN where Id= '" + IdBan + "'";
                DataTable settrangthai = lopchung.LoadDL(kiemtratrangthai);
                if (settrangthai.Rows.Count > 0)
                {
                    DataRow rowtrangthai = settrangthai.Rows[0];
                    string trangthai = rowtrangthai["TRANGTHAI"].ToString();

                    if (trangthai == "TRỐNG")
                    {
                        MessageBox.Show("Bàn Trống không thể in hoá đơn.");
                    }
                    else
                    {
                        if (txt_giamgia.Text == "")
                        {
                            int giamgia = 0;
                            // Lấy thông tin bàn
                            string layttban = "SELECT (GIA * SOLUONG) AS THANHTIEN FROM THONGTINBAN WHERE ID = '" + IdBan + "'";
                            DataTable dt = lopchung.LoadDL(layttban);

                            // Tính tổng thành tiền của các món trên bàn
                            int tongThanhTien = 0;
                            foreach (DataRow row in dt.Rows)
                            {
                                int thanhTien = Convert.ToInt32(row["THANHTIEN"]);
                                tongThanhTien += thanhTien;
                            }
                            
                            DateTime ngaylapHD = DateTime.Now;
                            // Cập nhật thông tin vào bảng HOADON

                            string sql = "INSERT INTO HOADON (IdBan, NgayLapHD, GiamGia, TongTien) VALUES ('" + IdBan + "', CONVERT(datetime, '" + ngaylapHD + "', 103), N'" + giamgia + "', '" + tongThanhTien + "')";
                            int kq = lopchung.ThemXoaSua(sql);
                            if (kq >= 1)
                            {
                                frm_HoaDon hoadon = new frm_HoaDon(IdBan,phanquyen);
                                hoadon.Show();
                                this.Hide();
                            }
                            else
                                MessageBox.Show("Thất bại!.");
                        }
                        else
                        {
                            float giamgia = float.Parse(txt_giamgia.Text);
                            // Lấy thông tin bàn
                            string layttban = "SELECT (GIA * SOLUONG) AS THANHTIEN FROM THONGTINBAN WHERE ID = '" + IdBan + "'";
                            DataTable dt = lopchung.LoadDL(layttban);

                            // Tính tổng thành tiền của các món trên bàn
                            int tongThanhTien = 0;
                            foreach (DataRow row in dt.Rows)
                            {
                                int thanhTien = Convert.ToInt32(row["THANHTIEN"]);
                                tongThanhTien += thanhTien;
                            }

                            DateTime ngaylapHD = DateTime.Now;
                            
                            // Cập nhật thông tin vào bảng HOADON
                           string tong = (tongThanhTien - tongThanhTien*giamgia/100).ToString();
                            string sql = "INSERT INTO HOADON (IdBan, NgayLapHD, GiamGia, TongTien) VALUES ('" + IdBan + "', CONVERT(datetime, '" + ngaylapHD + "', 103), N'" + txt_giamgia.Text + "', '" + tong + "')";
                            //kiếm tra đã in hoá đơn chưa
                            int kq = lopchung.ThemXoaSua(sql);
                            if (kq >= 1)
                            {
                                frm_HoaDon hoadon = new frm_HoaDon(IdBan,phanquyen);
                                hoadon.Show();
                            }
                            else
                                MessageBox.Show("Thất bại!.");
                        }
                    }
                }
            }
        }

        private void thêmMónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_DanhMucMon danhsachmon = new frm_DanhMucMon();
            danhsachmon.Show();

        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn thoát?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn đăng xuất?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                frm_DangNhap dangnhap = new frm_DangNhap();
                dangnhap.Show();
                this.Hide();
            }
        }

        private void hoáĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void xemHoáĐơnChưaThanhToánToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (IdBan == 0)
            {
                MessageBox.Show("Bạn phải chọn bàn trước.");
            }else
            { 
            string sql = "Delete THONGTINBAN where ID ='" + IdBan + "'";
            int kq = lopchung.ThemXoaSua(sql);
            if (kq >= 1) MessageBox.Show("Đã xóa!");
            else MessageBox.Show("Thất bại!");
            string loadttban = "SELECT ID,TENMON,DANHMUC,GIA,SOLUONG,(GIA * SOLUONG) AS THANHTIEN FROM THONGTINBAN WHERE ID = '" + IdBan + "'";
            data_thongtinban.DataSource = lopchung.LoadDL(loadttban);
            loadTrangThai(IdBan);
            }
        }
    }
}
