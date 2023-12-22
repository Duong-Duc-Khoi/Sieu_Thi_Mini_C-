
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Sieu_Thi_Mini_C_
{
    public partial class frmNhapHang : Form
    {
        //thietlap bien toan cuc
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
        public frmNhapHang()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }


       
        private void frmNhapHang_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            string nhomhang = "Select distinct nhomhang from banghanghoa";
            SqlCommand cmd = new SqlCommand(nhomhang, con);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);

            DataTable da = new DataTable();
            dataAdapter.Fill(da);
            foreach (DataRow row in da.Rows[0].Table.Rows)
            {
                cbo_nhomhang.Items.Add(row["nhomhang"].ToString());
            }
            //
           
        }

        private void cbo_nhomhang_SelectedIndexChanged(object sender, EventArgs e)
        {
            lst_dshh.Items.Clear();
            string p_nhomhang = cbo_nhomhang.SelectedItem.ToString();
            string tenhang = "Select tenhang from banghanghoa where nhomhang=N'"+p_nhomhang+"'";
            SqlCommand cmd = new SqlCommand(tenhang, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable da2 = new DataTable();
            da.Fill(da2);
            foreach (DataRow row in da2.Rows)
                lst_dshh.Items.Add(row[0]);
            lst_dshh.Refresh();
            
        }
      
        private void btnHangHoa_Click(object sender, EventArgs e)
        {
            frmHangHoa frmHangHoa = new frmHangHoa();
            frmHangHoa.ShowDialog();
        }

        private void btnNhaCungCap_Click(object sender, EventArgs e)
        {
            frmNhaCungCap frmNhaCungCap = new frmNhaCungCap();  
            frmNhaCungCap.ShowDialog();
            
        }

        private void btnT_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLoaiHang_Click(object sender, EventArgs e)
        {

        }
       
        private void btn_xacnhan_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            if (string.IsNullOrEmpty(txt_sl.Text))
            {    
                
                MessageBox.Show("Chưa nhập số lượng!","Thông báo");
                return;
            }

            string p_tenhh =txt_mathang.Text.Trim();
            
            string sql = "Select mahh,tenhang,xuatxu,gianhap from banghanghoa where tenhang=N'" + p_tenhh + "'";
            DataTable current_data = (DataTable)dgv_thongtin.DataSource;
            SqlCommand cmd = new SqlCommand(sql,con);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            dataAdapter.SelectCommand = cmd;
            DataTable dt = new DataTable();
            
            dataAdapter.Fill(dt);
            dgv_thongtin.DataSource = dt;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            //
           
            //

            if (current_data == null)
            {
                current_data = new DataTable();
                
            }
            current_data.Merge(dt);
            dgv_thongtin.DataSource = current_data;
            //
            dgv_thongtin.CurrentRow.Cells["soluong"].Value = txt_sl.Text.Trim();
     
            dgv_thongtin.Refresh();

           
        }

        private void lst_dshh_SelectedValueChanged(object sender, EventArgs e)
        {
            txt_mathang.Text = lst_dshh.SelectedItem.ToString();
        }

        private void dgv_thongtin_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == dgv_thongtin.Rows.Count - 1)
            {
                return;
            }
            if (e.ColumnIndex == dgv_thongtin.Columns["dgv_btnXoa"].Index && e.RowIndex >= 0)
            {
                dgv_thongtin.Rows.RemoveAt(dgv_thongtin.CurrentRow.Index);
                return;
            }
           
        }

        private void txt_sl_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsDigit(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if (e.KeyChar == '\b')
            {
                e.Handled = false;
            }
        }
    }
}
