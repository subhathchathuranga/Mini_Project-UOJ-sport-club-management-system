using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Mini_Project
{
    public partial class SignInPage : UserControl
    {
        const string cn = "datasource=localhost; username=root; password=; database=sportclub";
        public SignInPage()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\MiniProject.mdf;Integrated Security=True;Connect Timeout=30");

        private void SignBtn_MouseEnter(object sender, EventArgs e)
        {
            SignBtn.BackColor = Color.Red;
        }

        private void SignBtn_MouseLeave(object sender, EventArgs e)
        {
            SignBtn.BackColor = Color.Lime;
        }

        private void SignBtn_Click(object sender, EventArgs e)
        {
            if (SignUserName.Text == "" && SignPassword.Text == "")
            {
                MessageBox.Show("Empty Feild !");
            }
            else
            {
                if (RePassword.Text == SignPassword.Text)
                {
                    try
                    {
                        MySqlConnection con = new MySqlConnection(cn);
                        MySqlCommand cmd = new MySqlCommand("insert into Student(UserName,Password,FName,LName,Faculty,AcadamicYear,Email) values('" + SignUserName.Text + "','" + SignPassword.Text + "','" + SignFName.Text + "','" + SignLName.Text + "','" + SignFaculty.Text + "','" + SignAcadamic.Text + "','" + SignEmail.Text + "')", con);
                        con.Open();
                        cmd.ExecuteReader();
                        con.Close();
                        SignUserName.Text = "";
                        SignPassword.Text = "";
                        SignFName.Text = "";
                        SignLName.Text = "";
                        SignFaculty.Text = "";
                        SignAcadamic.Text = "";
                        SignEmail.Text = "";
                        this.Hide();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Password not Matched!");
                }
                
            }
        }

        

        private void SigninBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            
        }
    }
}
