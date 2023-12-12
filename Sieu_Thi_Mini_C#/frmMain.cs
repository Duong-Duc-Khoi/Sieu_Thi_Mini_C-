using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sieu_Thi_Mini_C_
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void btnBanhang_Click(object sender, EventArgs e)
        {
            frmBanHang banhang = new frmBanHang();
            banhang.ShowDialog();
          
        }

        private void btnNhanvien_Click(object sender, EventArgs e)
        {
            frmNhanVien nhanVien = new frmNhanVien();
            nhanVien.ShowDialog();
           
        }

        private void btnKhachhang_Click(object sender, EventArgs e)
        {
            frmKhachHang khachHang = new frmKhachHang();
            khachHang.ShowDialog();
            
        }

        private void btnKho_Click(object sender, EventArgs e)
        {
            frmNhaCungCap nhaCungCap = new frmNhaCungCap();
            nhaCungCap.ShowDialog();
            
        }

        private void btnDoanhthu_Click(object sender, EventArgs e)
        {
           
        }

        private void btnBaocao_Click(object sender, EventArgs e)
        {

        }

        private void btn_dangxuat_Click(object sender, EventArgs e)
        {
            this.Close();
            frmDangNhap frmDangNhap = new frmDangNhap();
            frmDangNhap.ShowDialog();
            frmDangNhap.Enabled = true;
        }
    }
}
