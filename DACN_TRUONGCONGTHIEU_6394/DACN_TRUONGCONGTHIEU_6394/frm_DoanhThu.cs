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
    public partial class frm_DoanhThu : Form
    {
        public frm_DoanhThu()
        {
            InitializeComponent();
        }
        LOPDUNGCHUNG lopchung = new LOPDUNGCHUNG();
        private void btn_Thongke_Click(object sender, EventArgs e)
        {
            DateTime TuNgay = dtp_TuNgay.Value;
            DateTime DenNgay = dtp_DenNgay.Value;
            TuNgay = TuNgay.AddDays(-1);
            string TuNgaystring = TuNgay.ToString();
            string DenNgaystring = DenNgay.ToString();

            string sql = "SELECT * FROM DOANHTHU WHERE NGAYTHANHTOAN >= CONVERT(datetime, '" + TuNgaystring + "', 103) AND NGAYTHANHTOAN <= CONVERT(datetime, '" + DenNgaystring + "', 103)";

            data_ThongKe.DataSource = lopchung.LoadDL(sql);
        }

        private void frm_DoanhThu_Load(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM DOANHTHU";
            data_ThongKe.DataSource = lopchung.LoadDL(sql);
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn thoát?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        
    }
}
