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
    public partial class AdCreateEvent : UserControl
    {
        const string cn = "datasource=localhost; username=root; password=; database=sportclub";
        public AdCreateEvent()
        {
            InitializeComponent();
        }

        private void Post_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection con = new MySqlConnection(cn);
                MySqlCommand cmd = new MySqlCommand("insert into Event(Sport,GroundNo,Date,StartTime,EndTime,Teams) values('" + EventSport.Text + "','" + EventGroundNo.Text + "','" + EventDate.Text + "','" + StartTime.Text + "','" + EndTime.Text + "','" + Teams.Text + "')", con);
                con.Open();
                cmd.ExecuteReader();
                con.Close();
                EventSport.Text = "";
                EventGroundNo.Text = "";
                EventDate.Text = "";
                StartTime.Text = "";
                EndTime.Text = "";
                Teams.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
