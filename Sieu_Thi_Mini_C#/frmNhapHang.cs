
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
           
            string nhomhang = "Select distinct nhomhang from banghanghoa";
            SqlCommand cmd = new SqlCommand(nhomhang, con);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);

            DataTable da = new DataTable();
            dataAdapter.Fill(da);
            foreach (DataRow row in da.Rows[0].Table.Rows)
            {
                cbo_nhomhang.Items.Add(row["nhomhang"].ToString());
            }
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
    }
}
