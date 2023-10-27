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
    public partial class frm_DanhMucMon : Form
    {
        public frm_DanhMucMon()
        {
            InitializeComponent();
        }
        LOPDUNGCHUNG lopchung = new LOPDUNGCHUNG();
        public void LoadDSMON()
        {
            string sql = "SELECT DS.MAMON, DM.TENDANHMUC, DS.TENMON, DS.GIA " +
                  "FROM DANHSACHMON AS DS " +
                  "INNER JOIN DANHMUC AS DM ON DS.MADANHMUC = DM.MADANHMUC "+
                  "ORDER BY MAMON ";
            data_dsmon.DataSource = lopchung.LoadDL(sql);
        }
        public void LoadDM()
        {
            string sql = "Select * from DANHMUC";
            cb_DanhMuc.DataSource = lopchung.LoadDL(sql);
            cb_DanhMuc.ValueMember = "MADANHMUC";
            cb_DanhMuc.DisplayMember = "TENDANHMUC";
        }
        public void resetdl()
        {
            txt_ID.Text = "";
            txt_Ten.Text = "";
            txt_Gia.Text = "";
            cb_DanhMuc.Text = ""; 
        }
        private void btn_tim_Click(object sender, EventArgs e)
        {
            string tim = txt_Tim.Text;

            // Truy vấn SQL để lấy danh sách các món có tên khớp với tim
            string sql = "SELECT DS.MAMON, DM.TENDANHMUC, DS.TENMON, DS.GIA " +
                  "FROM DANHSACHMON AS DS " +
                  "INNER JOIN DANHMUC AS DM ON DS.MADANHMUC = DM.MADANHMUC " +
                  "WHERE TENMON LIKE '%" + tim + "%'" +
                  "ORDER BY MAMON ";
            DataTable table = lopchung.LoadDL(sql);

            // Kiểm tra xem có kết quả nào được tìm thấy không
            if (table.Rows.Count > 0)
            {
                data_dsmon.DataSource = table;
            }
            else
            {
                MessageBox.Show("Không tìm thấy món có tên: " + tim);
            }
        }

        private void data_dsmon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_ID.Text = data_dsmon.CurrentRow.Cells["MAMON"].Value.ToString();
            string tendanhmuc = data_dsmon.CurrentRow.Cells["TENDANHMUC"].Value.ToString();
            txt_Ten.Text = data_dsmon.CurrentRow.Cells["TENMON"].Value.ToString();
            txt_Gia.Text = data_dsmon.CurrentRow.Cells["GIA"].Value.ToString();
            cb_DanhMuc.Text = tendanhmuc;
        }

        private void btn_xem_Click(object sender, EventArgs e)
        {
            LoadDSMON();
        }

        private void frm_DanhMucMon_Load(object sender, EventArgs e)
        {
            LoadDM();
            LoadDSMON();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            string sql = "Insert into DANHSACHMON values ('" +  cb_DanhMuc.SelectedValue  + "',N'" + txt_Ten.Text + "',N'" + txt_Gia.Text +  "')";
            int kq = lopchung.ThemXoaSua(sql);
            if (kq >= 1) MessageBox.Show("Thêm món thành công");
            else MessageBox.Show("Thêm món thất bại");
            LoadDSMON();
            resetdl();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            string sql = "Update DANHSACHMON set  MADANHMUC = N'" + cb_DanhMuc.SelectedValue + "', TENMON = N'" + txt_Ten.Text + "', GIA = N'" + txt_Gia.Text  + "'where MAMON = '" + txt_ID.Text + "'";
            int kq = lopchung.ThemXoaSua(sql);
            if (kq >= 1) MessageBox.Show("Sửa món thành công");
            else MessageBox.Show("Sửa món thất bại");
            LoadDSMON();
            resetdl();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            string sql = "Delete DANHSACHMON where MAMON = '" + txt_ID.Text + "'";
            int kq = lopchung.ThemXoaSua(sql);
            if (kq >= 1) MessageBox.Show("Xoá món thành công");
            else MessageBox.Show("Xoá món thất bại");
            LoadDSMON();
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
    }
}
