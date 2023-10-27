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
    public partial class frm_DangNhap : Form
    {
        public frm_DangNhap()
        {
            InitializeComponent();
        }
        LOPDUNGCHUNG lopchung = new LOPDUNGCHUNG();
        public void hienmk()
        {
            if (chk_HienMk.Checked)
            {
                txt_MatKhau.UseSystemPasswordChar = false;
            }
            else
            {
                txt_MatKhau.UseSystemPasswordChar = true;
            }
        }
        private void chk_HienMk_CheckedChanged(object sender, EventArgs e)
        {
            hienmk();
        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            string sql = "Select COUNT (*) from THONGTINTAIKHOAN where TAIKHOAN = '" + txt_TaiKhoan.Text + "' and MATKHAU = '" + txt_MatKhau.Text + "'";
            int kq = (int)lopchung.Scalar(sql);
            if (kq >= 1)
            {
                string sql2 = "Select * from THONGTINTAIKHOAN where TAIKHOAN = '" + txt_TaiKhoan.Text + "' and MATKHAU = '" + txt_MatKhau.Text + "'";
                DataTable dt = lopchung.LoadDL(sql2);
                frm_QuanLyBan QlBan = new frm_QuanLyBan(dt.Rows[0][2].ToString());
                QlBan.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu!");
                txt_TaiKhoan.Clear();
                txt_MatKhau.Clear();
            }
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn thoát ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void frm_DangNhap_Load(object sender, EventArgs e)
        {
            hienmk();
        }
    }
}
