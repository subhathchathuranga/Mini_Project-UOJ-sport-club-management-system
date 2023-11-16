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
    public partial class StGroundBook : UserControl
    {
        const string cn = "datasource=localhost; username=root; password=; database=sportclub";
        public StGroundBook()
        {
            InitializeComponent();
        }

        private void StGroundBook_Load(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection con = new MySqlConnection(cn);
                MySqlCommand cmd = new MySqlCommand("select * from groundbook", con);
                MySqlDataAdapter da;
                DataTable dt;
                con.Open();
                cmd.ExecuteNonQuery();
                dt = new DataTable();
                da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                GroundBookTb.DataSource = dt.DefaultView;
                con.Close();
            }
            catch (Exception ex)
            {

            }
        }
    }
}
