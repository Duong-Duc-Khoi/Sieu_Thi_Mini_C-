﻿using System;
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
            SqlCommand cmd= new SqlCommand(tenhang, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable tb = new DataTable();
            da.Fill(tb);
            cmd.Dispose();
            con.Close();
           
            dgv_thongtin.Rows[0].Cells[3].Value = "1";
            dgv_thongtin.DataSource = tb;
        }

        private void dgv_thongtin_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == dgv_thongtin.Columns["dgv_xoahang"].Index && e.RowIndex >=0 )
            {
                dgv_thongtin.Rows.RemoveAt(dgv_thongtin.CurrentRow.Index);
            }

            
            if (e.ColumnIndex == dgv_thongtin.Columns["dgv_tangsl"].Index && e.RowIndex >= 0)
            {
              int p_soluong = int.Parse(dgv_thongtin.Rows[0].Cells[3].Value.ToString());
              p_soluong++;
              dgv_thongtin.Rows[0].Cells[3].Value = p_soluong;   
            }

        }
    }


  

}