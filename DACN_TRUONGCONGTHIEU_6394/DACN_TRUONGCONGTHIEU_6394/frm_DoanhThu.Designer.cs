namespace DACN_TRUONGCONGTHIEU_6394
{
    partial class frm_DoanhThu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_DoanhThu));
            this.dtp_TuNgay = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtp_DenNgay = new System.Windows.Forms.DateTimePicker();
            this.btn_Thongke = new System.Windows.Forms.Button();
            this.data_ThongKe = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_thoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.data_ThongKe)).BeginInit();
            this.SuspendLayout();
            // 
            // dtp_TuNgay
            // 
            this.dtp_TuNgay.CustomFormat = "dd/MM/yyyy";
            this.dtp_TuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_TuNgay.Location = new System.Drawing.Point(88, 23);
            this.dtp_TuNgay.Margin = new System.Windows.Forms.Padding(2);
            this.dtp_TuNgay.Name = "dtp_TuNgay";
            this.dtp_TuNgay.Size = new System.Drawing.Size(168, 20);
            this.dtp_TuNgay.TabIndex = 0;
            this.dtp_TuNgay.Value = new System.DateTime(2023, 10, 15, 23, 17, 39, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(258, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Đến Ngày";
            // 
            // dtp_DenNgay
            // 
            this.dtp_DenNgay.CustomFormat = "dd/MM/yyyy";
            this.dtp_DenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_DenNgay.Location = new System.Drawing.Point(338, 24);
            this.dtp_DenNgay.Margin = new System.Windows.Forms.Padding(2);
            this.dtp_DenNgay.Name = "dtp_DenNgay";
            this.dtp_DenNgay.Size = new System.Drawing.Size(164, 20);
            this.dtp_DenNgay.TabIndex = 2;
            // 
            // btn_Thongke
            // 
            this.btn_Thongke.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_Thongke.ForeColor = System.Drawing.Color.Yellow;
            this.btn_Thongke.Location = new System.Drawing.Point(506, 21);
            this.btn_Thongke.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Thongke.Name = "btn_Thongke";
            this.btn_Thongke.Size = new System.Drawing.Size(85, 28);
            this.btn_Thongke.TabIndex = 3;
            this.btn_Thongke.Text = "Thống Kê";
            this.btn_Thongke.UseVisualStyleBackColor = false;
            this.btn_Thongke.Click += new System.EventHandler(this.btn_Thongke_Click);
            // 
            // data_ThongKe
            // 
            this.data_ThongKe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_ThongKe.Location = new System.Drawing.Point(10, 57);
            this.data_ThongKe.Margin = new System.Windows.Forms.Padding(2);
            this.data_ThongKe.Name = "data_ThongKe";
            this.data_ThongKe.RowTemplate.Height = 24;
            this.data_ThongKe.Size = new System.Drawing.Size(581, 299);
            this.data_ThongKe.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 24);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Từ Ngày";
            // 
            // btn_thoat
            // 
            this.btn_thoat.BackColor = System.Drawing.Color.Red;
            this.btn_thoat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_thoat.Location = new System.Drawing.Point(506, 359);
            this.btn_thoat.Margin = new System.Windows.Forms.Padding(2);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(85, 34);
            this.btn_thoat.TabIndex = 7;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = false;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // frm_DoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(600, 402);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.data_ThongKe);
            this.Controls.Add(this.btn_Thongke);
            this.Controls.Add(this.dtp_DenNgay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtp_TuNgay);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frm_DoanhThu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Doanh Thu";
            this.Load += new System.EventHandler(this.frm_DoanhThu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_ThongKe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtp_TuNgay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtp_DenNgay;
        private System.Windows.Forms.Button btn_Thongke;
        private System.Windows.Forms.DataGridView data_ThongKe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_thoat;
    }
}