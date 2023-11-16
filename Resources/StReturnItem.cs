using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Mini_Project
{
    public partial class StReturnItem : UserControl
    {
        const string cn = "datasource=localhost; username=root; password=; database=sportclub";
        int id;
        public StReturnItem()
        {
            InitializeComponent();
            loadData();
        }

        private void NumberPanel1_Click(object sender, EventArgs e)
        {

        }

        public void loadData()
        {
            string name = "";
            MySqlConnection con2 = new MySqlConnection(cn);
            MySqlCommand cmd2 = new MySqlCommand("select UserName from Student where state='log'", con2);
            MySqlDataReader reader2;
            con2.Open();
            reader2 = cmd2.ExecuteReader();
            if (reader2.Read())
            {
                name = reader2[0].ToString();
            }
            con2.Close();


            try
            {
                MySqlConnection con = new MySqlConnection(cn);
                MySqlCommand cmd = new MySqlCommand("select * from borrowitem where UserName='" + name + "'", con);
                MySqlDataAdapter da;
                DataTable dt;
                con.Open();
                cmd.ExecuteNonQuery();
                dt = new DataTable();
                da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                ReturnTb.DataSource = dt.DefaultView;
                con.Close();
            }
            catch (Exception ex)
            {

            }
        }

        private void ReturnTb_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ReturnBtn.Show();
            ReturnTb.CurrentRow.Selected = true;
            id = Convert.ToInt32(ReturnTb.Rows[e.RowIndex].Cells["Id"].Value.ToString());

            
        }

        private void StReturnItem_Load(object sender, EventArgs e)
        {
            ReturnBtn.Hide();
        }

        private void ReturnBtn_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(cn);
            MySqlCommand cmd = new MySqlCommand("delete from borrowitem where Id=" + id + "", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Return Success.");
            ReturnBtn.Hide();
            loadData();
        }
       
        private void ReturnTb_SelectionChanged(object sender, EventArgs e)
        {
            
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            loadData();
        }
    }
}
