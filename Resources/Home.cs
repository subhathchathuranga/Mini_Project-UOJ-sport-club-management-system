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
    public partial class Home : UserControl
    {
        const string cn = "datasource=localhost; username=root; password=; database=sportclub";
        string lgUserName="";

       
        
        public Home()
        {
            InitializeComponent();
            setLable();
            this.Refresh();

        }

        



        private void label5_Click(object sender, EventArgs e)
        {

        }

    

        private void Home_Load(object sender, EventArgs e)
        {
            
            stBorrowItem1.BringToFront();
            
            panel2.Width = StBorrowItem.Width;
            panel2.Left = StBorrowItem.Left;

            profile1.Hide();
            setLable();

        }

        public void setLable()
        {
            string name="";
            MySqlConnection con = new MySqlConnection(cn);
            MySqlCommand cmd = new MySqlCommand("select FName from Student where state='log'", con);
            MySqlDataReader reader1;
            con.Open();
            reader1 = cmd.ExecuteReader();
            if (reader1.Read())
            {
                name = reader1[0].ToString();
            }
            con.Close();
            StName.Text= name;
        }
        /*private string getName()
        {
            try
            {
                string name = "z";
                MySqlConnection con = new MySqlConnection(cn);
                MySqlCommand cmd = new MySqlCommand("select FName from Student where UserName='" + lgUserName + "'", con);
                MySqlDataReader reader1;
                con.Open();
                reader1 = cmd.ExecuteReader();
                if (reader1.Read())
                {
                    name = reader1[0].ToString();
                }
                con.Close();
                return name;
            }
            catch (Exception ex)
            {
                return "z";
            }
        }*/

        private void Profile_MouseEnter(object sender, EventArgs e)
        {
            Profile.BackColor = Color.FromArgb(165, 165, 190);
        }

        private void Profile_MouseLeave(object sender, EventArgs e)
        {
            Profile.BackColor = Color.FromArgb(1,7,50);
        }

        private void StBorrowItem_MouseEnter(object sender, EventArgs e)
        {
            StBorrowItem.BackColor = Color.FromArgb(165, 165, 190);
            StBorrowItem.ForeColor = Color.Black;
        }

        private void StBorrowItem_MouseLeave(object sender, EventArgs e)
        {
            StBorrowItem.BackColor = Color.FromArgb(1, 7, 50);
            StBorrowItem.ForeColor = Color.White;
        }

        private void StReturnItem_MouseEnter(object sender, EventArgs e)
        {
            StReturnItem.BackColor = Color.FromArgb(165, 165, 190);
            StReturnItem.ForeColor = Color.Black;
        }

        private void StReturnItem_MouseLeave(object sender, EventArgs e)
        {
            StReturnItem.BackColor = Color.FromArgb(1, 7, 50);
            StReturnItem.ForeColor = Color.White;
        }

        private void StGroundBook_MouseEnter(object sender, EventArgs e)
        {
            StGroundBook.BackColor = Color.FromArgb(165, 165, 190);
            StGroundBook.ForeColor = Color.Black;
        }

        private void StGroundBook_MouseLeave(object sender, EventArgs e)
        {
            StGroundBook.BackColor = Color.FromArgb(1, 7, 50);
            StGroundBook.ForeColor = Color.White;
        }

        private void StEvents_MouseEnter(object sender, EventArgs e)
        {
            StEvents.BackColor = Color.FromArgb(165, 165, 190);
            StEvents.ForeColor = Color.Black;
        }

        private void StEvents_MouseLeave(object sender, EventArgs e)
        {
            StEvents.BackColor = Color.FromArgb(1, 7, 50);
            StEvents.ForeColor = Color.White;
        }

        

        /*public void setName(String name)
        {
            StName.Text = name;
        }*/

        private void StBorrowItem_Click(object sender, EventArgs e)
        {
            stBorrowItem1.BringToFront();
            setLable();
            panel2.Width = StBorrowItem.Width;
            panel2.Left = StBorrowItem.Left;
        }

        private void StReturnItem_Click(object sender, EventArgs e)
        {
            //StReturnItem ob=new StReturnItem();
            //ob.loadData();
            setLable();
            stReturnItem1.BringToFront();

            panel2.Width = StReturnItem.Width;
            panel2.Left = StReturnItem.Left;
        }

        private void StGroundBook_Click(object sender, EventArgs e)
        {
            setLable();
            stGroundBook1.BringToFront();
            panel2.Width = StGroundBook.Width;
            panel2.Left = StGroundBook.Left;
        }

        private void StEvents_Click(object sender, EventArgs e)
        {
            setLable();
            stEvent1.BringToFront();
            panel2.Width = StEvents.Width;
            panel2.Left = StEvents.Left;
        }

        

        private void Profile_Click(object sender, EventArgs e)
        {
            //Profile ob=new Profile();
            //ob.setValue();
            setLable();
            profile1.Show();
            profile1.BringToFront();
            
        }

        public void hidee()
        {
            this.Hide();
        }
    }
}
