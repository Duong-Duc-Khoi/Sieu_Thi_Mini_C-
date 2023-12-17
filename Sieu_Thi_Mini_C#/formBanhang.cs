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
using System.Data.SqlClient;
using System.Configuration;
using System.Drawing.Text;
using System.Net.NetworkInformation;



namespace Sieu_Thi_Mini_C_
{
    public partial class formBanhang : Form
    {

        //thietlap bien toan cuc
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
        public formBanhang()
        {
            InitializeComponent();
        }
        private void load_dgv()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            string sql = "select* from banghoadon";
            SqlCommand cmd = new SqlCommand(sql, con);
            //tao doi tuong data adapter de lay du lieu
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.SelectCommand = cmd;
            //do du lieu tu da va database
            DataTable tb = new DataTable();
            da.Fill(tb);
            cmd.Dispose();
            con.Close();        
        }

        private void btnkiemtra_Click(object sender, EventArgs e)
        {
            SqlConnection con= new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
            string p_mavach=txt_mahh.Text.Trim();
            string tenhang="Select tenhang,giaban from banghanghoa where mavach=N'"+p_mavach+"'";
            DataTable current_data = (DataTable)dgv_thongtin.DataSource;
            SqlCommand cmd= new SqlCommand(tenhang, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable tb = new DataTable();
            da.Fill(tb);
            cmd.Dispose();
            con.Close();
            if(current_data == null)
            {
                current_data = new DataTable();
            }
            current_data.Merge(tb);
            dgv_thongtin.DataSource = current_data;
        }

        private void dgv_thongtin_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            if (e.ColumnIndex == dgv_thongtin.Columns["dgv_xoahang"].Index && e.RowIndex >=0 )
            {
                dgv_thongtin.Rows.RemoveAt(dgv_thongtin.CurrentRow.Index);
            }       
            if (e.ColumnIndex == dgv_thongtin.Columns["dgv_tangsl"].Index && e.RowIndex >= 0)
            {
                int p_soluong = Convert.ToInt32(dgv_thongtin.CurrentRow.Cells[2].Value);
                
                
                string p_tenhang = dgv_thongtin.CurrentRow.Cells["dgv_tenhh"].Value.ToString();

                string sql = "Select soluong from banghanghoa where tenhang='"+p_tenhang+"'";

                SqlCommand cmd = new SqlCommand(sql, con);      
                int p_soluongmax = (int)cmd.ExecuteScalar();
                if (p_soluong == p_soluongmax)
                {
                    return;
                }
                p_soluong++;
                
                dgv_thongtin.CurrentRow.Cells[2].Value = p_soluong;
                dgv_thongtin.Refresh();
            }

            if (e.ColumnIndex == dgv_thongtin.Columns["dgv_giamsl"].Index && e.RowIndex >= 0)
            {
                int p_soluong = Convert.ToInt32(dgv_thongtin.CurrentRow.Cells[2].Value);
                p_soluong--;
                if (p_soluong == 0)
                {
                    return;
                }
                dgv_thongtin.CurrentRow.Cells[2].Value = p_soluong;
                dgv_thongtin.Refresh();
                
            }
            int p_dongia = Convert.ToInt32(dgv_thongtin.CurrentRow.Cells["dgv_dongia"].Value);
            int p_soluongg = Convert.ToInt32(dgv_thongtin.CurrentRow.Cells["dgv_soluong"].Value);
            int p_thanhtien = p_dongia * p_soluongg;
            dgv_thongtin.CurrentRow.Cells["dgv_thanhtien"].Value = p_thanhtien;


        }

        private void txt_mahh_TextChanged(object sender, EventArgs e)
        {

        }
    }


  

}