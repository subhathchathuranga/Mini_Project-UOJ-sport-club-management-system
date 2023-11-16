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
    public partial class Profile : UserControl
    {
        const string cn = "datasource=localhost; username=root; password=; database=sportclub";
        public Profile()
        {
            InitializeComponent();
            setValue();
            this.Refresh();
        }
        public void setValue()
        {
            MySqlConnection con = new MySqlConnection(cn);
            MySqlCommand cmd = new MySqlCommand("select FName from Student where state='log'", con);
            MySqlDataReader reader1;
            con.Open();
            reader1 = cmd.ExecuteReader();
            if (reader1.Read())
            {
                FirstName.Text = reader1[0].ToString();
            }
            con.Close();

            MySqlConnection con2 = new MySqlConnection(cn);
            MySqlCommand cmd2 = new MySqlCommand("select LName from Student where state='log'", con2);
            MySqlDataReader reader2;
            con2.Open();
            reader2 = cmd2.ExecuteReader();
            if (reader2.Read())
            {
                LastName.Text = reader2[0].ToString();
            }
            con2.Close();

            

            MySqlConnection con3 = new MySqlConnection(cn);
            MySqlCommand cmd3 = new MySqlCommand("select AcadamicYear from Student where state='log'", con3);
            MySqlDataReader reader3;
            con3.Open();
            reader3 = cmd3.ExecuteReader();
            if (reader3.Read())
            {
                AcadamicYear.Text = reader3[0].ToString();
            }
            con3.Close();

            

            MySqlConnection con4 = new MySqlConnection(cn);
            MySqlCommand cmd4 = new MySqlCommand("select Faculty from Student where state='log'", con4);
            MySqlDataReader reader4;
            con4.Open();
            reader4 = cmd4.ExecuteReader();
            if (reader4.Read())
            {
                Faculty.Text = reader4[0].ToString();
            }
            con4.Close();

            

            MySqlConnection con5 = new MySqlConnection(cn);
            MySqlCommand cmd5 = new MySqlCommand("select Email from Student where state='log'", con5);
            MySqlDataReader reader5;
            con5.Open();
            reader5 = cmd5.ExecuteReader();
            if (reader5.Read())
            {
                Mail.Text = reader5[0].ToString();
            }
            con5.Close();

            
        }

        private void close_MouseEnter(object sender, EventArgs e)
        {
            close.BackColor = Color.FromArgb(45, 45, 45);
        }

        private void close_MouseLeave(object sender, EventArgs e)
        {
            close.BackColor = Color.Black;
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            string quary2 = "UPDATE student SET state='' WHERE state='log'";
            MySqlConnection con2 = new MySqlConnection(cn);
            MySqlCommand cmd2 = new MySqlCommand(quary2, con2);
            MySqlDataReader reader2;
            con2.Open();
            reader2 = cmd2.ExecuteReader();
            while (reader2.Read()) { }
            con2.Close();
            Application.Restart();
            
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            setValue();
        }
    }
}
