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
    public partial class frmHangHoa : Form
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
        public frmHangHoa()
        {
            InitializeComponent();
        }
        private void load_dgv()
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
            cmd.Dispose();
            con.Close();
            //Hien thi
            dgv_thongtin.DataSource = tb;
            dgv_thongtin.Refresh();
        }

        private void textVat_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnT_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
