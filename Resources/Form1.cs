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
    
    public partial class Form1 : Form
    {
        const string cn = "datasource=localhost; username=root; password=; database=sportclub";
        //public string LgUser = "";
        
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Signin_MouseEnter(object sender, EventArgs e)
        {
            Signin.BackColor = Color.FromArgb(182, 182, 182);
            
            
        }

        private void Signin_MouseLeave(object sender, EventArgs e)
        {
            Signin.BackColor = Color.White;
        }

        private void Signup_MouseEnter(object sender, EventArgs e)
        {
            Signup.BackColor = Color.FromArgb(182, 182, 182);
        }

        private void Signup_MouseLeave(object sender, EventArgs e)
        {
            Signup.BackColor = Color.White;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(150,20, 9, 87);
            home1.Hide();
            signInPage1.Hide();
            adminHome1.Hide();
            about1.Hide();

            
        }
        
        public void Signin_Click(object sender, EventArgs e)
        {
            //LgUser =UserName.Text;
            
            
            
            
            
            

            

            if (UserName.Text == "Admin" && Password.Text == "123")
            {
                
                adminHome1.Show();
                adminHome1.BringToFront();
            }
            else
            {
                if (Password.Text == getPassword(UserName.Text))
                {
                    
                    //StBorrowItem stBorrow=new StBorrowItem(LgUser);
                    setLgUser();
                    Home ob = new Home();
                    //StBorrowItem ob2=new StBorrowItem();
                    home1.Refresh();
                    home1.Show();
                    home1.BringToFront();
                    this.Refresh();
                    //setUser();

                }
                else
                {
                    MessageBox.Show("Invalid User Name Or Password !");
                }

            }
        }
        public void setLgUser()
        {
            string quary2 = "UPDATE student SET state='log' WHERE UserName='" + UserName.Text + "'";
            MySqlConnection con2 = new MySqlConnection(cn);
            MySqlCommand cmd2 = new MySqlCommand(quary2, con2);
            MySqlDataReader reader2;
            con2.Open();
            reader2 = cmd2.ExecuteReader();
            while (reader2.Read()) { }
            con2.Close();
        }
        private string getPassword(string userName)
        {

            try
            {
                string DBpasword = "zz";
                MySqlConnection con = new MySqlConnection(cn);
                MySqlCommand cmd = new MySqlCommand("select Password from Student where UserName='" + UserName.Text + "'", con);
                MySqlDataReader reader1;
                con.Open();
                reader1 = cmd.ExecuteReader();
                if (reader1.Read())
                {
                    DBpasword = reader1[0].ToString();
                }
                con.Close();
                return DBpasword;
            }
            catch (Exception ex)
            {
                return "zz";
            }
        }

        private void Signup_Click(object sender, EventArgs e)
        {
            signInPage1.BringToFront();
            signInPage1.Show();
        }

        

        private void button1_Click_1(object sender, EventArgs e)
        {
            about1.Show();
            about1.BringToFront();
        }
    }
}
