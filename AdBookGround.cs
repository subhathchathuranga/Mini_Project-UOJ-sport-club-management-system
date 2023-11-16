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
    public partial class AdBookGround : UserControl
    {
        const string cn = "datasource=localhost; username=root; password=; database=sportclub";
        public AdBookGround()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Book_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(cn);
            MySqlCommand cmd = new MySqlCommand("insert into groundbook(GroundNo,Date,StartTime,EndTime,Sport) values('" + GroundNo.Text + "','" + Date.Text + "','" + StartTime.Text + "','" + EndTime.Text + "','" + Sport.Text + "')", con);
            con.Open();
            cmd.ExecuteReader();
            con.Close();
            GroundNo.Text = "";
            Date.Text = "";
            StartTime.Text = "";
            EndTime.Text = "";
            Sport.Text = "";
        }
    }
}
