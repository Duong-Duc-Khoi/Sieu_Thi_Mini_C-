namespace Sieu_Thi_Mini_C_
{
    partial class formBanhang
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formBanhang));
            this.txt_mahh = new System.Windows.Forms.TextBox();
            this.dgv_thongtin = new System.Windows.Forms.DataGridView();
            this.dgv_xoahang = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dgv_tenhh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_giamsl = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dgv_soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_tangsl = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dgv_dongia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_thanhtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_tiendua = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_tienhang = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_vat = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_thanhtoan = new System.Windows.Forms.TextBox();
            this.grb1 = new System.Windows.Forms.GroupBox();
            this.btnT = new System.Windows.Forms.Button();
            this.btnXuatHang = new System.Windows.Forms.Button();
            this.btnNhapHang = new System.Windows.Forms.Button();
            this.btnLoaiHang = new System.Windows.Forms.Button();
            this.btnNhaCungCap = new System.Windows.Forms.Button();
            this.btnHangHoa = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnLammoiphieu = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnkiemtra = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_shd = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_thongtin)).BeginInit();
            this.grb1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_mahh
            // 
            this.txt_mahh.AcceptsReturn = true;
            this.txt_mahh.Location = new System.Drawing.Point(244, 120);
            this.txt_mahh.Margin = new System.Windows.Forms.Padding(4);
            this.txt_mahh.MaximumSize = new System.Drawing.Size(824, 50);
            this.txt_mahh.MinimumSize = new System.Drawing.Size(548, 30);
            this.txt_mahh.Name = "txt_mahh";
            this.txt_mahh.Size = new System.Drawing.Size(548, 30);
            this.txt_mahh.TabIndex = 10;
            this.txt_mahh.TextChanged += new System.EventHandler(this.txt_mahh_TextChanged);
            // 
            // dgv_thongtin
            // 
            this.dgv_thongtin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_thongtin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgv_xoahang,
            this.dgv_tenhh,
            this.dgv_giamsl,
            this.dgv_soluong,
            this.dgv_tangsl,
            this.dgv_dongia,
            this.dgv_thanhtien});
            this.dgv_thongtin.Location = new System.Drawing.Point(177, 160);
            this.dgv_thongtin.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_thongtin.Name = "dgv_thongtin";
            this.dgv_thongtin.RowHeadersWidth = 51;
            this.dgv_thongtin.RowTemplate.Height = 24;
            this.dgv_thongtin.Size = new System.Drawing.Size(809, 487);
            this.dgv_thongtin.TabIndex = 1;
            this.dgv_thongtin.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_thongtin_CellClick);
            // 
            // dgv_xoahang
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.NullValue = "X";
            this.dgv_xoahang.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_xoahang.HeaderText = "Xóa";
            this.dgv_xoahang.MinimumWidth = 6;
            this.dgv_xoahang.Name = "dgv_xoahang";
            this.dgv_xoahang.Text = "x";
            this.dgv_xoahang.ToolTipText = "x";
            this.dgv_xoahang.Width = 50;
            // 
            // dgv_tenhh
            // 
            this.dgv_tenhh.DataPropertyName = "tenhang";
            this.dgv_tenhh.HeaderText = "Tên hàng hóa";
            this.dgv_tenhh.MinimumWidth = 6;
            this.dgv_tenhh.Name = "dgv_tenhh";
            this.dgv_tenhh.ReadOnly = true;
            this.dgv_tenhh.Width = 200;
            // 
            // dgv_giamsl
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.NullValue = "-";
            this.dgv_giamsl.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_giamsl.HeaderText = "(-)";
            this.dgv_giamsl.MinimumWidth = 6;
            this.dgv_giamsl.Name = "dgv_giamsl";
            this.dgv_giamsl.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_giamsl.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dgv_giamsl.Text = "-";
            this.dgv_giamsl.ToolTipText = "-";
            this.dgv_giamsl.UseColumnTextForButtonValue = true;
            this.dgv_giamsl.Width = 50;
            // 
            // dgv_soluong
            // 
            this.dgv_soluong.DataPropertyName = "p_soluong";
            dataGridViewCellStyle3.NullValue = "1";
            this.dgv_soluong.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_soluong.HeaderText = "SL";
            this.dgv_soluong.MinimumWidth = 6;
            this.dgv_soluong.Name = "dgv_soluong";
            this.dgv_soluong.Width = 125;
            // 
            // dgv_tangsl
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.NullValue = "+";
            this.dgv_tangsl.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_tangsl.HeaderText = "(+)";
            this.dgv_tangsl.MinimumWidth = 6;
            this.dgv_tangsl.Name = "dgv_tangsl";
            this.dgv_tangsl.Text = "+";
            this.dgv_tangsl.Width = 50;
            // 
            // dgv_dongia
            // 
            this.dgv_dongia.DataPropertyName = "giaban";
            dataGridViewCellStyle5.NullValue = "0";
            this.dgv_dongia.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_dongia.HeaderText = "Đơn giá";
            this.dgv_dongia.MinimumWidth = 6;
            this.dgv_dongia.Name = "dgv_dongia";
            this.dgv_dongia.ReadOnly = true;
            this.dgv_dongia.Width = 125;
            // 
            // dgv_thanhtien
            // 
            this.dgv_thanhtien.DataPropertyName = "thanhtien";
            this.dgv_thanhtien.HeaderText = "Thành tiền";
            this.dgv_thanhtien.MinimumWidth = 6;
            this.dgv_thanhtien.Name = "dgv_thanhtien";
            this.dgv_thanhtien.ReadOnly = true;
            this.dgv_thanhtien.Width = 150;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(136, 122);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.MaximumSize = new System.Drawing.Size(275, 34);
            this.label1.MinimumSize = new System.Drawing.Size(10, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 34);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã vạch";
            // 
            // txt_tiendua
            // 
            this.txt_tiendua.AcceptsReturn = true;
            this.txt_tiendua.Location = new System.Drawing.Point(229, 671);
            this.txt_tiendua.Margin = new System.Windows.Forms.Padding(4);
            this.txt_tiendua.MaximumSize = new System.Drawing.Size(824, 35);
            this.txt_tiendua.MinimumSize = new System.Drawing.Size(200, 35);
            this.txt_tiendua.Name = "txt_tiendua";
            this.txt_tiendua.Size = new System.Drawing.Size(200, 30);
            this.txt_tiendua.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 670);
            this.label2.MaximumSize = new System.Drawing.Size(200, 35);
            this.label2.MinimumSize = new System.Drawing.Size(20, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 35);
            this.label2.TabIndex = 43;
            this.label2.Text = "Tiền khách đưa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(84, 725);
            this.label3.MaximumSize = new System.Drawing.Size(200, 35);
            this.label3.MinimumSize = new System.Drawing.Size(20, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 35);
            this.label3.TabIndex = 45;
            this.label3.Text = "Tiền hàng";
            // 
            // txt_tienhang
            // 
            this.txt_tienhang.AcceptsReturn = true;
            this.txt_tienhang.Location = new System.Drawing.Point(229, 722);
            this.txt_tienhang.Margin = new System.Windows.Forms.Padding(4);
            this.txt_tienhang.MaximumSize = new System.Drawing.Size(824, 35);
            this.txt_tienhang.MinimumSize = new System.Drawing.Size(200, 35);
            this.txt_tienhang.Name = "txt_tienhang";
            this.txt_tienhang.ReadOnly = true;
            this.txt_tienhang.Size = new System.Drawing.Size(200, 30);
            this.txt_tienhang.TabIndex = 44;
            this.txt_tienhang.TextChanged += new System.EventHandler(this.txt_tienhang_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(461, 673);
            this.label4.MaximumSize = new System.Drawing.Size(200, 35);
            this.label4.MinimumSize = new System.Drawing.Size(20, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 35);
            this.label4.TabIndex = 47;
            this.label4.Text = "Tiền VAT";
            // 
            // txt_vat
            // 
            this.txt_vat.AcceptsReturn = true;
            this.txt_vat.Location = new System.Drawing.Point(564, 667);
            this.txt_vat.Margin = new System.Windows.Forms.Padding(4);
            this.txt_vat.MaximumSize = new System.Drawing.Size(824, 35);
            this.txt_vat.MinimumSize = new System.Drawing.Size(200, 35);
            this.txt_vat.Name = "txt_vat";
            this.txt_vat.ReadOnly = true;
            this.txt_vat.Size = new System.Drawing.Size(200, 30);
            this.txt_vat.TabIndex = 46;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(461, 724);
            this.label5.MaximumSize = new System.Drawing.Size(200, 35);
            this.label5.MinimumSize = new System.Drawing.Size(20, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 35);
            this.label5.TabIndex = 49;
            this.label5.Text = "Thanh toán";
            // 
            // txt_thanhtoan
            // 
            this.txt_thanhtoan.AcceptsReturn = true;
            this.txt_thanhtoan.Location = new System.Drawing.Point(564, 721);
            this.txt_thanhtoan.Margin = new System.Windows.Forms.Padding(4);
            this.txt_thanhtoan.MaximumSize = new System.Drawing.Size(824, 35);
            this.txt_thanhtoan.MinimumSize = new System.Drawing.Size(200, 35);
            this.txt_thanhtoan.Name = "txt_thanhtoan";
            this.txt_thanhtoan.ReadOnly = true;
            this.txt_thanhtoan.Size = new System.Drawing.Size(200, 30);
            this.txt_thanhtoan.TabIndex = 48;
            this.txt_thanhtoan.TextChanged += new System.EventHandler(this.txt_thanhtoan_TextChanged);
            // 
            // grb1
            // 
            this.grb1.BackColor = System.Drawing.Color.Lavender;
            this.grb1.Controls.Add(this.btnT);
            this.grb1.Controls.Add(this.btnXuatHang);
            this.grb1.Controls.Add(this.btnNhapHang);
            this.grb1.Controls.Add(this.btnLoaiHang);
            this.grb1.Controls.Add(this.btnNhaCungCap);
            this.grb1.Controls.Add(this.btnHangHoa);
            this.grb1.Location = new System.Drawing.Point(1065, 94);
            this.grb1.Name = "grb1";
            this.grb1.Size = new System.Drawing.Size(268, 584);
            this.grb1.TabIndex = 52;
            this.grb1.TabStop = false;
            this.grb1.Text = "Quản lý kho hàng";
            // 
            // btnT
            // 
            this.btnT.Location = new System.Drawing.Point(43, 486);
            this.btnT.Name = "btnT";
            this.btnT.Size = new System.Drawing.Size(176, 54);
            this.btnT.TabIndex = 47;
            this.btnT.Text = "Thoát";
            this.btnT.UseVisualStyleBackColor = true;
            this.btnT.Click += new System.EventHandler(this.btnT_Click);
            // 
            // btnXuatHang
            // 
            this.btnXuatHang.Location = new System.Drawing.Point(43, 403);
            this.btnXuatHang.Name = "btnXuatHang";
            this.btnXuatHang.Size = new System.Drawing.Size(176, 54);
            this.btnXuatHang.TabIndex = 46;
            this.btnXuatHang.Text = "Xuất Hàng";
            this.btnXuatHang.UseVisualStyleBackColor = true;
            this.btnXuatHang.Click += new System.EventHandler(this.btnXuatHang_Click);
            // 
            // btnNhapHang
            // 
            this.btnNhapHang.Location = new System.Drawing.Point(43, 319);
            this.btnNhapHang.Name = "btnNhapHang";
            this.btnNhapHang.Size = new System.Drawing.Size(176, 54);
            this.btnNhapHang.TabIndex = 45;
            this.btnNhapHang.Text = "Nhập Hàng";
            this.btnNhapHang.UseVisualStyleBackColor = true;
            this.btnNhapHang.Click += new System.EventHandler(this.btnNhapHang_Click);
            // 
            // btnLoaiHang
            // 
            this.btnLoaiHang.Location = new System.Drawing.Point(43, 230);
            this.btnLoaiHang.Name = "btnLoaiHang";
            this.btnLoaiHang.Size = new System.Drawing.Size(176, 54);
            this.btnLoaiHang.TabIndex = 44;
            this.btnLoaiHang.Text = "Loại Hàng";
            this.btnLoaiHang.UseVisualStyleBackColor = true;
            // 
            // btnNhaCungCap
            // 
            this.btnNhaCungCap.Location = new System.Drawing.Point(43, 149);
            this.btnNhaCungCap.Name = "btnNhaCungCap";
            this.btnNhaCungCap.Size = new System.Drawing.Size(176, 54);
            this.btnNhaCungCap.TabIndex = 43;
            this.btnNhaCungCap.Text = "Nhà Cung Cấp";
            this.btnNhaCungCap.UseVisualStyleBackColor = true;
            this.btnNhaCungCap.Click += new System.EventHandler(this.btnNhaCungCap_Click);
            // 
            // btnHangHoa
            // 
            this.btnHangHoa.Location = new System.Drawing.Point(43, 63);
            this.btnHangHoa.Name = "btnHangHoa";
            this.btnHangHoa.Size = new System.Drawing.Size(176, 54);
            this.btnHangHoa.TabIndex = 42;
            this.btnHangHoa.Text = "Hàng Hóa";
            this.btnHangHoa.UseVisualStyleBackColor = true;
            this.btnHangHoa.Click += new System.EventHandler(this.btnHangHoa_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button1.Location = new System.Drawing.Point(807, 683);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 60);
            this.button1.TabIndex = 53;
            this.button1.Text = "IN HÓA ĐƠN";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnLammoiphieu
            // 
            this.btnLammoiphieu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLammoiphieu.Image = ((System.Drawing.Image)(resources.GetObject("btnLammoiphieu.Image")));
            this.btnLammoiphieu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLammoiphieu.Location = new System.Drawing.Point(1123, 685);
            this.btnLammoiphieu.Margin = new System.Windows.Forms.Padding(4);
            this.btnLammoiphieu.Name = "btnLammoiphieu";
            this.btnLammoiphieu.Size = new System.Drawing.Size(162, 60);
            this.btnLammoiphieu.TabIndex = 54;
            this.btnLammoiphieu.Text = "Làm Mới Phiếu";
            this.btnLammoiphieu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLammoiphieu.UseVisualStyleBackColor = true;
            this.btnLammoiphieu.Click += new System.EventHandler(this.btnLammoiphieu_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Sieu_Thi_Mini_C_.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(46, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(313, 101);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 50;
            this.pictureBox1.TabStop = false;
            // 
            // btnkiemtra
            // 
            this.btnkiemtra.BackColor = System.Drawing.Color.Lavender;
            this.btnkiemtra.BackgroundImage = global::Sieu_Thi_Mini_C_.Properties.Resources.analytics_2;
            this.btnkiemtra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnkiemtra.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnkiemtra.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnkiemtra.Location = new System.Drawing.Point(800, 116);
            this.btnkiemtra.Margin = new System.Windows.Forms.Padding(4);
            this.btnkiemtra.Name = "btnkiemtra";
            this.btnkiemtra.Size = new System.Drawing.Size(199, 36);
            this.btnkiemtra.TabIndex = 10;
            this.btnkiemtra.Text = "Kiểm tra          ";
            this.btnkiemtra.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnkiemtra.UseVisualStyleBackColor = false;
            this.btnkiemtra.Click += new System.EventHandler(this.btnkiemtra_Click);
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.Lavender;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.Location = new System.Drawing.Point(447, 26);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(477, 76);
            this.label12.TabIndex = 55;
            this.label12.Text = "QUẦY THU NGÂN 1\n ------------------------";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 22);
            this.label6.TabIndex = 56;
            this.label6.Text = "Số hóa đơn";
            // 
            // txt_shd
            // 
            this.txt_shd.BackColor = System.Drawing.Color.Lavender;
            this.txt_shd.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_shd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_shd.Location = new System.Drawing.Point(12, 213);
            this.txt_shd.Name = "txt_shd";
            this.txt_shd.ReadOnly = true;
            this.txt_shd.Size = new System.Drawing.Size(153, 42);
            this.txt_shd.TabIndex = 57;
            this.txt_shd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // formBanhang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1423, 993);
            this.Controls.Add(this.txt_shd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnLammoiphieu);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.grb1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_thanhtoan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_vat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_tienhang);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnkiemtra);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_thongtin);
            this.Controls.Add(this.txt_tiendua);
            this.Controls.Add(this.txt_mahh);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "formBanhang";
            this.Load += new System.EventHandler(this.formBanhang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_thongtin)).EndInit();
            this.grb1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_mahh;
        private System.Windows.Forms.DataGridView dgv_thongtin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_tiendua;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_tienhang;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_vat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_thanhtoan;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnkiemtra;
        private System.Windows.Forms.GroupBox grb1;
        private System.Windows.Forms.Button btnT;
        private System.Windows.Forms.Button btnXuatHang;
        private System.Windows.Forms.Button btnNhapHang;
        private System.Windows.Forms.Button btnLoaiHang;
        private System.Windows.Forms.Button btnNhaCungCap;
        private System.Windows.Forms.Button btnHangHoa;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnLammoiphieu;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_shd;
        private System.Windows.Forms.DataGridViewButtonColumn dgv_xoahang;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_tenhh;
        private System.Windows.Forms.DataGridViewButtonColumn dgv_giamsl;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_soluong;
        private System.Windows.Forms.DataGridViewButtonColumn dgv_tangsl;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_dongia;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_thanhtien;
    }
}