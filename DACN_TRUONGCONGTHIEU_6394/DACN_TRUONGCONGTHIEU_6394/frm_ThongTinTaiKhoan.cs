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
    public partial class frm_ThongTinTaiKhoan : Form
    {
        public frm_ThongTinTaiKhoan()
        {
            InitializeComponent();
        }
        LOPDUNGCHUNG lopchung = new LOPDUNGCHUNG();

        public void resetdl()
        {
            txt_tentk.Text = "";
            txt_MatKhauCu.Text = "";
            txt_MatKhauMoi.Text = "";
        }
        private void btn_luu_Click(object sender, EventArgs e)
        {
            string kiemtra = "Select * from THONGTINTAIKHOAN where TAIKHOAN = '" + txt_tentk.Text + "' AND MATKHAU = '"+txt_MatKhauCu.Text+"'";
            DataTable dt = lopchung.LoadDL(kiemtra);
            if (dt.Rows.Count > 0)
            {
                string sql = "Update THONGTINTAIKHOAN SET MATKHAU = " + txt_MatKhauMoi.Text + " Where TAIKHOAN = '" + txt_tentk.Text + "'";
                int kq = lopchung.ThemXoaSua(sql);
                if (kq >= 1)
                {
                    MessageBox.Show("Lưu Thành Công.");
                    resetdl();
                }
                else
                {
                    MessageBox.Show("Lưu Thất Bại.");
                }
            }
            else
            {
                MessageBox.Show("Tên tài khoản hoặc mật khẩu không đúng");
                resetdl();
            }

        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn thoát?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}

