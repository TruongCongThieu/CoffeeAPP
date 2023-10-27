namespace DACN_TRUONGCONGTHIEU_6394
{
    partial class frm_DanhMucMon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_DanhMucMon));
            this.btn_xem = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_tim = new System.Windows.Forms.Button();
            this.data_dsmon = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Tim = new System.Windows.Forms.TextBox();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Ten = new System.Windows.Forms.TextBox();
            this.cb_DanhMuc = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Gia = new System.Windows.Forms.TextBox();
            this.btn_dong = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.data_dsmon)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_xem
            // 
            this.btn_xem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_xem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_xem.Location = new System.Drawing.Point(28, 12);
            this.btn_xem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_xem.Name = "btn_xem";
            this.btn_xem.Size = new System.Drawing.Size(89, 43);
            this.btn_xem.TabIndex = 0;
            this.btn_xem.Text = "Xem";
            this.btn_xem.UseVisualStyleBackColor = false;
            this.btn_xem.Click += new System.EventHandler(this.btn_xem_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Them.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_Them.Location = new System.Drawing.Point(163, 12);
            this.btn_Them.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(89, 43);
            this.btn_Them.TabIndex = 1;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = false;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Sua.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_Sua.Location = new System.Drawing.Point(299, 12);
            this.btn_Sua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(89, 43);
            this.btn_Sua.TabIndex = 2;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = false;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Xoa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_Xoa.Location = new System.Drawing.Point(428, 12);
            this.btn_Xoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(89, 43);
            this.btn_Xoa.TabIndex = 2;
            this.btn_Xoa.Text = "Xoá";
            this.btn_Xoa.UseVisualStyleBackColor = false;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_tim
            // 
            this.btn_tim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_tim.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_tim.Location = new System.Drawing.Point(968, 84);
            this.btn_tim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_tim.Name = "btn_tim";
            this.btn_tim.Size = new System.Drawing.Size(93, 26);
            this.btn_tim.TabIndex = 3;
            this.btn_tim.Text = "Tìm";
            this.btn_tim.UseVisualStyleBackColor = false;
            this.btn_tim.Click += new System.EventHandler(this.btn_tim_Click);
            // 
            // data_dsmon
            // 
            this.data_dsmon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_dsmon.Location = new System.Drawing.Point(15, 71);
            this.data_dsmon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.data_dsmon.Name = "data_dsmon";
            this.data_dsmon.RowHeadersWidth = 51;
            this.data_dsmon.RowTemplate.Height = 24;
            this.data_dsmon.Size = new System.Drawing.Size(655, 354);
            this.data_dsmon.TabIndex = 4;
            this.data_dsmon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_dsmon_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(787, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "ID:";
            // 
            // txt_Tim
            // 
            this.txt_Tim.Location = new System.Drawing.Point(739, 85);
            this.txt_Tim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Tim.Name = "txt_Tim";
            this.txt_Tim.Size = new System.Drawing.Size(223, 22);
            this.txt_Tim.TabIndex = 6;
            // 
            // txt_ID
            // 
            this.txt_ID.Location = new System.Drawing.Point(827, 161);
            this.txt_ID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(233, 22);
            this.txt_ID.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(773, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Tên:";
            // 
            // txt_Ten
            // 
            this.txt_Ten.Location = new System.Drawing.Point(827, 220);
            this.txt_Ten.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Ten.Name = "txt_Ten";
            this.txt_Ten.Size = new System.Drawing.Size(233, 22);
            this.txt_Ten.TabIndex = 9;
            // 
            // cb_DanhMuc
            // 
            this.cb_DanhMuc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_DanhMuc.FormattingEnabled = true;
            this.cb_DanhMuc.Location = new System.Drawing.Point(827, 290);
            this.cb_DanhMuc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_DanhMuc.Name = "cb_DanhMuc";
            this.cb_DanhMuc.Size = new System.Drawing.Size(233, 24);
            this.cb_DanhMuc.TabIndex = 10;
            this.cb_DanhMuc.Text = " ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(721, 295);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 18);
            this.label3.TabIndex = 11;
            this.label3.Text = "Danh Mục:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(776, 356);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 18);
            this.label4.TabIndex = 12;
            this.label4.Text = "Giá:";
            // 
            // txt_Gia
            // 
            this.txt_Gia.Location = new System.Drawing.Point(827, 352);
            this.txt_Gia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Gia.Name = "txt_Gia";
            this.txt_Gia.Size = new System.Drawing.Size(233, 22);
            this.txt_Gia.TabIndex = 13;
            // 
            // btn_dong
            // 
            this.btn_dong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_dong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_dong.Location = new System.Drawing.Point(555, 12);
            this.btn_dong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_dong.Name = "btn_dong";
            this.btn_dong.Size = new System.Drawing.Size(89, 43);
            this.btn_dong.TabIndex = 14;
            this.btn_dong.Text = "Đóng";
            this.btn_dong.UseVisualStyleBackColor = false;
            this.btn_dong.Click += new System.EventHandler(this.btn_dong_Click);
            // 
            // frm_DanhMucMon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1084, 450);
            this.Controls.Add(this.btn_dong);
            this.Controls.Add(this.txt_Gia);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cb_DanhMuc);
            this.Controls.Add(this.txt_Ten);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_ID);
            this.Controls.Add(this.txt_Tim);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.data_dsmon);
            this.Controls.Add(this.btn_tim);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.btn_xem);
            this.Location = new System.Drawing.Point(0, 5);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frm_DanhMucMon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh Mục Món";
            this.Load += new System.EventHandler(this.frm_DanhMucMon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_dsmon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_xem;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_tim;
        private System.Windows.Forms.DataGridView data_dsmon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Tim;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Ten;
        private System.Windows.Forms.ComboBox cb_DanhMuc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Gia;
        private System.Windows.Forms.Button btn_dong;
    }
}