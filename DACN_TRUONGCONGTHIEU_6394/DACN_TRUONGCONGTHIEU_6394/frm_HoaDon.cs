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
    public partial class frm_HoaDon : Form
    {
        public frm_HoaDon(int idban,string quyen)
        {
            InitializeComponent();
            Idban = idban;
            phanquyen = quyen;
        }
        LOPDUNGCHUNG lopchung = new LOPDUNGCHUNG();
        private int Idban;
        private string phanquyen;
        public void resetdl()
        {
            txt_MaHD.Text = "";
            txt_Ban.Text = "";
            dtp_NgayLap.Text = "";
            data_DanhSachMon.DataSource = null;
            txt_GiamGia.Text = "";
            txt_TongTien.Text = "";
        }
        private void frm_HoaDon_Load(object sender, EventArgs e)
        {
            lbl_Hoadon.Text = "HOÁ ĐƠN BÀN SỐ " + Idban;
            string sql = "SELECT TENMON,SOLUONG,THANHTIEN from THONGTINBAN Where ID = '" + Idban + "'";
            data_DanhSachMon.DataSource = lopchung.LoadDL(sql);
            string hoadon = "SELECT * FROM HOADON WHERE IDBAN = '" + Idban + "'";
            DataTable dt = lopchung.LoadDL(hoadon);
            if (dt.Rows.Count > 0)
            {
                // Cập nhật thông tin bàn này với IdBanChuyenDen
                DataRow row = dt.Rows[0];
                int mahd = Convert.ToInt32(row["MAHD"]);
                DateTime ngaylaphd =Convert.ToDateTime(row["NGAYLAPHD"]);
                int giamgia = Convert.ToInt32(row["GIAMGIA"]);
                int tongtien = Convert.ToInt32(row["TONGTIEN"]);

                txt_MaHD.Text = mahd.ToString();
                txt_Ban.Text = "BÀN "+Idban.ToString();
                dtp_NgayLap.Text = ngaylaphd.ToShortDateString();
                txt_GiamGia.Text = giamgia.ToString();
                txt_TongTien.Text = tongtien.ToString();

            }
            }

        private void btn_ThanhToan_Click(object sender, EventArgs e)
        {
            string hoadon = "SELECT * FROM HOADON WHERE IDBAN = '" + Idban + "'";
            DataTable dt = lopchung.LoadDL(hoadon);
            if (dt.Rows.Count > 0)
            {
                // Cập nhật thông tin bàn này với IdBanChuyenDen
                DataRow row = dt.Rows[0];
                DateTime ngaylaphd = Convert.ToDateTime(row["NGAYLAPHD"]);
               string tongtien = Convert.ToString(row["TONGTIEN"]);

                string sql= "INSERT INTO DOANHTHU VALUES (N'Bàn " + Idban + "', CONVERT(datetime, '" + ngaylaphd + "', 103), N'"  + tongtien + "')";
                int kq = lopchung.ThemXoaSua(sql);
                if (kq >= 1)
                {
                    MessageBox.Show("Đã Thanh Toán.");
                    resetdl();
                   string xoahd = "Delete HOADON where IDBAN ='" + Idban + "'";
                    lopchung.ThemXoaSua(xoahd);
                    string xoattban = "Delete THONGTINBAN where ID ='" + Idban + "'";
                    lopchung.ThemXoaSua(xoattban);
                    string updateQuery = "UPDATE BAN SET TRANGTHAI = N'TRỐNG' WHERE ID = '" + Idban + "'";
                    lopchung.ThemXoaSua(updateQuery);
                }
                else MessageBox.Show("Thanh Toán Thất Bại.");
            }
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            frm_QuanLyBan qlban = new frm_QuanLyBan(phanquyen);
            qlban.Show();
            this.Close();
        }

       
    }
}
