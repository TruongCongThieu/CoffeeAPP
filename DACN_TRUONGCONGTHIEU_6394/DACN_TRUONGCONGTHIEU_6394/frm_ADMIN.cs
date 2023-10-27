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
    public partial class frm_ADMIN : Form
    {
        public frm_ADMIN(string quyen)
        {
            InitializeComponent();
            phanquyen = quyen;
        }
        private string phanquyen;
        private void cậpNhậtTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_ThongTinTaiKhoan"] == null)
            {
                frm_ThongTinTaiKhoan qltk = new frm_ThongTinTaiKhoan();
                qltk.MdiParent = this;
                qltk.Show();

            }
            else Application.OpenForms["frm_ThongTinTaiKhoan"].Activate();
        }

        private void frm_ADMIN_Load(object sender, EventArgs e)
        {
            
        }


        private void danhMụcMónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_DanhMucMon"] == null)
            {
                frm_DanhMucMon qlmon = new frm_DanhMucMon();
                qlmon.MdiParent = this;
                qlmon.Show();

            }
            else Application.OpenForms["frm_DanhMucMon"].Activate();
        }

        private void quanlybanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_QuanLyBan"] != null)
            {
                frm_QuanLyBan qlban = new frm_QuanLyBan(phanquyen);
                qlban.Show();
                this.Hide();

            }
            else Application.OpenForms["frm_QuanLyBan"].Activate();
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

        private void doanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_DoanhThu"] == null)
            {
                frm_DoanhThu qldoanhthu = new frm_DoanhThu();
                qldoanhthu.MdiParent = this;
                qldoanhthu.Show();
            }
            else Application.OpenForms["frm_DoanhThu"].Activate();
        }

        private void quảnLýNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_QuanLyNhanVien nhanvien = new frm_QuanLyNhanVien();
            nhanvien.Show();
            nhanvien.MdiParent = this;
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn thoát ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
