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
    public partial class frm_QuanLyNhanVien : Form
    {
        public frm_QuanLyNhanVien()
        {
            InitializeComponent();
        }
        LOPDUNGCHUNG lopchung = new LOPDUNGCHUNG();
        public void loadNV()
        {
            string sql = "Select * from QUANLYNHANVIEN";
            data_dsnhanvien.DataSource = lopchung.LoadDL(sql);
        }
        public void resetdl()
        {
            txt_MaNV.Text = "";
            txt_TenNV.Text = "";
            cb_gioitinh.Text = "chọn giới tính";
            dtp_NgaySinh.Text = "";
            txt_Diachi.Text = "";
            txt_sdt.Text = "";
        }

        public void loaddl()
        {
            string sql = "select *from QUANLYNHANVIEN";
            data_dsnhanvien.DataSource = lopchung.LoadDL(sql);
        }
        private void btn_Them_Click(object sender, EventArgs e)
        {
            int MANV = int.Parse(txt_MaNV.Text);
            string manv = "Select MANV from QUANLYNHANVIEN where MANV = '" + MANV + "'";
            DataTable dt = lopchung.LoadDL(manv);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Mã nhân viên đã tồn tại. Vui lòng nhập lại mã nhân viên");
            }
            else
            {
                
                bool ngaySinhHopLe = DateTime.TryParse(dtp_NgaySinh.Value.ToString("yyyy-MM-dd"), out DateTime date) && date <= DateTime.Now;
                bool chonGioiTinh = cb_gioitinh.SelectedItem != null && cb_gioitinh.SelectedItem.ToString() != "Chọn giới tính";

                bool soDienThoaiHopLe = txt_sdt.Text.Length <= 10;

                if (ngaySinhHopLe && soDienThoaiHopLe && chonGioiTinh)
                {
                    string sql = "Insert into QUANLYNHANVIEN values ('" + MANV + "',N'" + txt_TenNV.Text + "',N'" + cb_gioitinh.SelectedItem + "', CONVERT(datetime, '" + dtp_NgaySinh.Text + "', 103), N'" + txt_Diachi.Text + "',N'" + txt_sdt.Text + "')";
                    int kq = lopchung.ThemXoaSua(sql);
                    if (kq >= 1)
                    {
                        MessageBox.Show("Thêm nhân viên thành công");
                        loaddl();
                        resetdl();
                    }
                    else
                    {
                        MessageBox.Show("Thêm nhân viên thất bại");
                    }
                }
                else
                {
                    if (!ngaySinhHopLe)
                    {
                        MessageBox.Show("Ngày sinh không hợp lệ. Vui lòng kiểm tra lại.");
                    }

                    if (!soDienThoaiHopLe)
                    {
                        MessageBox.Show("Số điện thoại vượt quá số quy định (tối đa 10 số). Vui lòng kiểm tra lại.");
                    }
                    if (!chonGioiTinh)
                    {
                        MessageBox.Show("Vui lòng chọn giới tính.");
                    }
                }
               
            }
        }


        private void data_dsnhanvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_MaNV.Text= data_dsnhanvien.CurrentRow.Cells["MANV"].Value.ToString();
            txt_TenNV.Text = data_dsnhanvien.CurrentRow.Cells["TENNV"].Value.ToString();
            cb_gioitinh.SelectedItem = data_dsnhanvien.CurrentRow.Cells["GIOITINH"].Value.ToString();
            dtp_NgaySinh.Text = data_dsnhanvien.CurrentRow.Cells["NGAYSINH"].Value.ToString();
            txt_Diachi.Text = data_dsnhanvien.CurrentRow.Cells["DIACHI"].Value.ToString();
            txt_sdt.Text = data_dsnhanvien.CurrentRow.Cells["SDT"].Value.ToString();
        }

        private void frm_QuanLyNhanVien_Load(object sender, EventArgs e)
        {
            loadNV();
        }


        private void btn_Sua_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE QUANLYNHANVIEN SET TENNV = N'" + txt_TenNV.Text + "', GIOITINH = N'" + cb_gioitinh.SelectedItem + "', NGAYSINH = CONVERT(datetime, '" + dtp_NgaySinh.Text + "', 103), DIACHI = N'" + txt_Diachi.Text + "', SDT = N'" + txt_sdt.Text + "' WHERE MANV = '" + txt_MaNV.Text+ "'";

            
            int kq = lopchung.ThemXoaSua(sql);

            if (kq >= 1)
            {
                MessageBox.Show("Sửa nhân viên thành công");
                resetdl(); 
                loadNV(); 
            }
            else
            {
                MessageBox.Show("Sửa nhân viên thất bại");
            }
        }

        private void data_dsnhanvien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_MaNV.Text = data_dsnhanvien.CurrentRow.Cells["MANV"].Value.ToString();
            txt_TenNV.Text = data_dsnhanvien.CurrentRow.Cells["TENNV"].Value.ToString();
            cb_gioitinh.SelectedItem = data_dsnhanvien.CurrentRow.Cells["GIOITINH"].Value.ToString();
            dtp_NgaySinh.Text = data_dsnhanvien.CurrentRow.Cells["NGAYSINH"].Value.ToString();
            txt_Diachi.Text = data_dsnhanvien.CurrentRow.Cells["DIACHI"].Value.ToString();
            txt_sdt.Text = data_dsnhanvien.CurrentRow.Cells["SDT"].Value.ToString();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            string sql = "DELETE FROM QUANLYNHANVIEN where MANV = '" + txt_MaNV.Text + "'";
            int kq = lopchung.ThemXoaSua(sql);
            if (kq >= 1) MessageBox.Show("Xoá Nhân Viên thành công");
            else MessageBox.Show("Xoá Nhân Viên thất bại");
            loadNV();
            resetdl();
        }

        private void btn_dong_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn đóng?", "Xác nhận đóng", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btn_tim_Click(object sender, EventArgs e)
        {

            // Truy vấn SQL để lấy danh sách các món có tên khớp với tim
            string sql = "SELECT * FROM QUANLYNHANVIEN WHERE TENNV LIKE '%" + txt_Tim.Text + "%'";
                
            DataTable table = lopchung.LoadDL(sql);

            // Kiểm tra xem có kết quả nào được tìm thấy không
            if (table.Rows.Count > 0)
            {
                data_dsnhanvien.DataSource = table;
            }
            else
            {
                MessageBox.Show("Không tìm thấy nhân viên có tên: " + txt_Tim.Text);
            }
        }

        private void btn_xem_Click(object sender, EventArgs e)
        {
            loaddl();
        }
    }
}
