using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sieu_Thi_Mini_C_
{
    public partial class frmDangNhap : Form
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);//khai báo biến kết nối con
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {

        }

        private void txtMatkhau_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //kết nối sql và lấy quyền 
            string taikhoan = txtTaikhoan.Text.Trim();
            string password = txtMatkhau.Text.Trim();
            string sql = "Select count(*) from NhanVien where UserName='" + taikhoan + "' and Password='" + password + "'";//lệnh sql lấy dữ liệu về quyền tk trong sql
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }

           

            //kiem tra xem nhap thong tin chua
            if (txtTaikhoan.Text == "" || txtMatkhau.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin! ", "Thông báo", MessageBoxButtons.OK);//bắt lỗi nếu không nhập thì báo 
            }

            else
//kiem tra xem phải là tk admin ko?
            {
                if (txtTaikhoan.Text != "admin" || txtMatkhau.Text != "123")
                {
                    string t = "Username hoặc password sai !,Bạn vui lòng kiểm tra lại ";
                    MessageBox.Show((t), "thong báo", MessageBoxButtons.OK);
                }
                else
                {
                    if (txtTaikhoan.Text == "admin" && txtMatkhau.Text == "123")
                    {
                        MessageBox.Show("Ban dang nhap vao tai khoan Admin", "Thong bao ", MessageBoxButtons.OK);
                        frmMain a1 = new frmMain();//khai báo biến a1 kiểu frmMain
                        a1.Show();//hiện form main
                        this.Hide();// ẩn form đăng nhập này đi
                    }
                    //kiem tra tk nhan vien

                else
                    {
                        SqlCommand nv = new SqlCommand(sql, con);//khai bao biến lệnh sql(sql command)
                        int getRole = (int)nv.ExecuteScalar();
                        if (getRole == 1) {
                            MessageBox.Show("Ban dang nhap vao tai khoan Nhân Vien", "Thong bao ", MessageBoxButtons.OK);

                            frmBanHang bh = new frmBanHang();//khai báo biến bh là frmBanHang                     
                            bh.Show();
                            this.Hide();//ẩn form này đi

                        }
                        else
                        {
                            string t = "Username hoặc password sai !,Bạn vui lòng kiểm tra lại ";
                            MessageBox.Show((t), "thong báo", MessageBoxButtons.OK);
                        }

                    }
                

                                  







                }
                }
                }
            }
}
