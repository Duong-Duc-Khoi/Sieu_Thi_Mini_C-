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
using System.Drawing.Text;
using System.Net.NetworkInformation;
using e_excel = Microsoft.Office.Interop.Excel;


namespace Sieu_Thi_Mini_C_
{
    public partial class frm_trahang : Form
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
        public frm_trahang()
        {
            InitializeComponent();
        }
        private void load_lst_tenhang()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            string sql = "select* from banghanghoa";
            SqlCommand cmd = new SqlCommand(sql, con);
            //tao doi tuong data adapter de lay du lieu
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.SelectCommand = cmd;
            //do du lieu tu da va database
            DataTable tb = new DataTable();
            da.Fill(tb);
           // cmd.Dispose();
            con.Close();
            //
            DataRow dr = tb.NewRow();
            dr["mahh"] = "";
            dr["tenhang"]= "---- Chọn tên hàng ----";
            tb.Rows.InsertAt(dr, 0);
            //hien thi tb vao combobox
            lst_dshh.DataSource = tb;
            lst_dshh.DisplayMember = "tenhang";
            lst_dshh.ValueMember = "mahh";
        }
       
        private void frm_trahang_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            this.WindowState = FormWindowState.Maximized;
            
            load_lst_tenhang();
           
        }
        private void luu(string p_matrahang, string mahh,string tenhang, int soluong,int tientralai,string lydotrahang )
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            string sql = "Insert bangphieutrahangchitiet values ( @matrahang,@mahh,@tenhh, @soluong,@tientralai, @lydotrahang )";
            SqlCommand cmd = new SqlCommand(sql, con);

            cmd.Parameters.Add("@matrahang", SqlDbType.NVarChar, 50).Value = p_matrahang;
            cmd.Parameters.Add("@mahh", SqlDbType.NVarChar, 50).Value = mahh;
            cmd.Parameters.Add("@tenhh", SqlDbType.NVarChar, 50).Value = tenhang;
            cmd.Parameters.Add("@soluong", SqlDbType.Int).Value = soluong;
            cmd.Parameters.Add("@tientralai",SqlDbType.Int).Value= tientralai;
            cmd.Parameters.Add("@lydotrahang", SqlDbType.NVarChar, 200).Value = lydotrahang;
       
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();

            //  int randomNumber = random();
            // txt_shd.Text = randomNumber.ToString();
        }
        private void btn_xacnhan_Click(object sender, EventArgs e)
        {
            string p_matrahang = txt_matrahang.Text.Trim();

            // Kiểm tra mã trả hàng không trống
            if (string.IsNullOrEmpty(p_matrahang))
            {
                MessageBox.Show("Mã trả hàng không được để trống.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            for (int i = 0; i < dgv_thongtin.Rows.Count - 1; i++)
            {
                string tenhang = dgv_thongtin.Rows[i].Cells["dgv_tenhh"].Value.ToString();

                // Kiểm tra số lượng không trống và là số hợp lệ
                string soluongStr = dgv_thongtin.Rows[i].Cells["dgv_soluong"].Value?.ToString(); // Sử dụng toán tử null-conditional (?.)

                if (string.IsNullOrEmpty(soluongStr) || !int.TryParse(soluongStr, out int soluongTra))
                {
                    MessageBox.Show("Số lượng trả hàng không được để trống và phải là số hợp lệ.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int giaban = int.Parse(dgv_thongtin.Rows[i].Cells["dgv_dongia"].Value.ToString());
                string mahh = dgv_thongtin.Rows[i].Cells["dgv_mahh"].Value.ToString();

                // Kiểm tra lý do trả hàng không trống
                string lydotrahang = dgv_thongtin.Rows[i].Cells["dgv_lydo"].Value?.ToString(); // Sử dụng toán tử null-conditional (?.)
                if (string.IsNullOrEmpty(lydotrahang))
                {
                    MessageBox.Show("Lý do trả hàng không được để trống.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int tientralai = int.Parse(dgv_thongtin.Rows[i].Cells["dgv_tientralai"].Value.ToString());

                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                // Kiểm tra số lượng trong kho
                string sqlCheck = "SELECT soluong FROM banghanghoa WHERE mahh = @mahh";
                SqlCommand cmdCheck = new SqlCommand(sqlCheck, con);
                cmdCheck.Parameters.AddWithValue("@mahh", mahh);
                int soluongTrongKho = Convert.ToInt32(cmdCheck.ExecuteScalar());

                if (soluongTra > soluongTrongKho)
                {
                    MessageBox.Show($"Số lượng trả hàng cho {tenhang} vượt quá số lượng trong kho ({soluongTrongKho}).", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    con.Close();
                    return; // Thoát nếu không đủ hàng trong kho
                }

                // Lưu thông tin trả hàng
                luu(p_matrahang, mahh, tenhang, soluongTra, tientralai, lydotrahang);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                // Cập nhật số lượng trong kho
                string sqlUpdate = "UPDATE banghanghoa SET soluong = soluong - @soluongTra WHERE mahh = @mahh";
                SqlCommand cmdUpdate = new SqlCommand(sqlUpdate, con);
                cmdUpdate.Parameters.AddWithValue("@soluongTra", soluongTra);
                cmdUpdate.Parameters.AddWithValue("@mahh", mahh);
                cmdUpdate.ExecuteNonQuery();
            }

            con.Close();
            MessageBox.Show("Lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }





        private void lst_dshh_SelectedValueChanged(object sender, EventArgs e)
        {
            // txt_mathang.Text = lst_dshh.SelectedItem.ToString();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            string p_mahh = lst_dshh.SelectedValue.ToString();

            string sql = "Select mahh,tenhang,giaban from banghanghoa where mahh=N'" + p_mahh + "'";
            DataTable current_data = (DataTable)dgv_thongtin.DataSource;
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            dataAdapter.SelectCommand = cmd;
            DataTable dt = new DataTable();

            dataAdapter.Fill(dt);
            dgv_thongtin.DataSource = dt;
            cmd.ExecuteNonQuery();
            if (current_data == null)
            {
                current_data = new DataTable();
            }
            current_data.Merge(dt);
            dgv_thongtin.DataSource = current_data;
            dgv_thongtin.Refresh();
        }

        private void dgv_thongtin_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            if (e.RowIndex == dgv_thongtin.Rows.Count - 1)
            {
                return;
            }
            if (e.ColumnIndex == dgv_thongtin.Columns["dgv_btnxoa"].Index && e.RowIndex >= 0)
            {
                dgv_thongtin.Rows.RemoveAt(dgv_thongtin.CurrentRow.Index);
                return;
            }
            for (int i = 0; i < dgv_thongtin.Rows.Count; ++i)
            {
                int p_dongia = Convert.ToInt32(dgv_thongtin.Rows[i].Cells["dgv_dongia"].Value);
                int p_soluongg = Convert.ToInt32(dgv_thongtin.Rows[i].Cells["dgv_soluong"].Value);
                int p_thanhtien = p_dongia * p_soluongg;
                dgv_thongtin.Rows[i].Cells["dgv_tientralai"].Value = p_thanhtien;
            }
        }

        private void btnLammoiphieu_Click(object sender, EventArgs e)
        {
            // Xóa tất cả các dòng trong datagridview
            for (int i = dgv_thongtin.Rows.Count - 2; i >= 0; i--)
            {
                // Xóa dòng khỏi datagridview
                dgv_thongtin.Rows.RemoveAt(i);
                // Xóa dòng khỏi cơ sở dữ liệu nếu cần
                // ...
              
            }
            txt_matrahang.Text = null;
            frm_trahang_Load(sender, e);
        }

        private void btnHangHoa_Click(object sender, EventArgs e)
        {
            frmHangHoa frmHangHoa   = new frmHangHoa();
            frmHangHoa.ShowDialog();
            this.Close();
        }

        private void btnNhaCungCap_Click(object sender, EventArgs e)
        {
            frmNhaCungCap frm= new frmNhaCungCap();
            frm.ShowDialog();
            this.Close();
        }

        private void btnNhapHang_Click(object sender, EventArgs e)
        {
            frmNhapHang frm= new frmNhapHang();
            frm.ShowDialog();
            this.Close();
        }

        private void btnT_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
