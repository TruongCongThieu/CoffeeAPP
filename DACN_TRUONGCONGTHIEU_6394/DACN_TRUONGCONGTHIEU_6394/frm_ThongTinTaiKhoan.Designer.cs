namespace DACN_TRUONGCONGTHIEU_6394
{
    partial class frm_ThongTinTaiKhoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ThongTinTaiKhoan));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_tentk = new System.Windows.Forms.TextBox();
            this.txt_MatKhauMoi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_MatKhauCu = new System.Windows.Forms.TextBox();
            this.btn_luu = new System.Windows.Forms.Button();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Tài Khoản";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật Khẩu Cũ";
            // 
            // txt_tentk
            // 
            this.txt_tentk.Location = new System.Drawing.Point(145, 66);
            this.txt_tentk.Name = "txt_tentk";
            this.txt_tentk.Size = new System.Drawing.Size(184, 22);
            this.txt_tentk.TabIndex = 2;
            // 
            // txt_MatKhauMoi
            // 
            this.txt_MatKhauMoi.Location = new System.Drawing.Point(145, 172);
            this.txt_MatKhauMoi.Name = "txt_MatKhauMoi";
            this.txt_MatKhauMoi.Size = new System.Drawing.Size(184, 22);
            this.txt_MatKhauMoi.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mật Khẩu Mới";
            // 
            // txt_MatKhauCu
            // 
            this.txt_MatKhauCu.Location = new System.Drawing.Point(145, 123);
            this.txt_MatKhauCu.Name = "txt_MatKhauCu";
            this.txt_MatKhauCu.Size = new System.Drawing.Size(184, 22);
            this.txt_MatKhauCu.TabIndex = 5;
            // 
            // btn_luu
            // 
            this.btn_luu.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_luu.Location = new System.Drawing.Point(23, 243);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(133, 30);
            this.btn_luu.TabIndex = 6;
            this.btn_luu.Text = "Lưu Thông Tin";
            this.btn_luu.UseVisualStyleBackColor = true;
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Thoat.Location = new System.Drawing.Point(200, 243);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(82, 30);
            this.btn_Thoat.TabIndex = 7;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(335, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(247, 247);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // frm_ThongTinTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(582, 399);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.btn_luu);
            this.Controls.Add(this.txt_MatKhauCu);
            this.Controls.Add(this.txt_MatKhauMoi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_tentk);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Location = new System.Drawing.Point(0, 5);
            this.Name = "frm_ThongTinTaiKhoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Thông Tin Tài Khoản";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_tentk;
        private System.Windows.Forms.TextBox txt_MatKhauMoi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_MatKhauCu;
        private System.Windows.Forms.Button btn_luu;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}