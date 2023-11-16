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
    public partial class StBorrowItem : UserControl
    {
        const string cn = "datasource=localhost; username=root; password=; database=sportclub";
        string lgUserName="";
        public StBorrowItem()
        {
            InitializeComponent();
            setlgUser();
            
        }
        
        public void setlgUser()
        {
            MySqlConnection con = new MySqlConnection(cn);
            MySqlCommand cmd = new MySqlCommand("select UserName from Student where state='log'", con);
            MySqlDataReader reader1;
            con.Open();
            reader1 = cmd.ExecuteReader();
            if (reader1.Read())
            {
                lgUserName = reader1[0].ToString();
            }
            con.Close();
            
        }
        

        private void StBorrowItem_Load(object sender, EventArgs e)
        {
            setVisible();
            setColor();
        }

        private void CricketBat_Click(object sender, EventArgs e)
        {
            setVisible();
            BorrowBtn.Show();


        }

        public void setVisible()
        {
            
            BorrowBtn.Hide();
            CricketBallBtn.Hide();
            Racket.Hide();
            Flower.Hide();
            StumpBtn.Hide();
            VollyBallBtn.Hide();
            FootBallBtn.Hide();
            RugbyBtn.Hide();
            PadBtn.Hide();
            ChessBtn.Hide();
            SpearBtn.Hide();
            HurdleBtn.Hide();
            CarromBtn.Hide();
            MettressBtn.Hide();
        }

        public void setColor()
        {
            BorrowBtn.BackColor = Color.FromArgb(130, 130, 130, 130);
            CricketBallBtn.BackColor = Color.FromArgb(130, 130, 130, 130);
            Racket.BackColor = Color.FromArgb(130, 130, 130, 130);
            Flower.BackColor = Color.FromArgb(130, 130, 130, 130);
            StumpBtn.BackColor = Color.FromArgb(130, 130, 130, 130);
            VollyBallBtn.BackColor = Color.FromArgb(130, 130, 130, 130);
            FootBallBtn.BackColor = Color.FromArgb(130, 130, 130, 130);
            RugbyBtn.BackColor = Color.FromArgb(130, 130, 130, 130);
            PadBtn.BackColor = Color.FromArgb(130, 130, 130, 130);
            ChessBtn.BackColor = Color.FromArgb(130, 130, 130, 130);
            SpearBtn.BackColor = Color.FromArgb(130, 130, 130, 130);
            HurdleBtn.BackColor = Color.FromArgb(130, 130, 130, 130);
            CarromBtn.BackColor = Color.FromArgb(130, 130, 130, 130);
            MettressBtn.BackColor = Color.FromArgb(130, 130, 130, 130);
        }

        private void StBorrowItem_Click(object sender, EventArgs e)
        {
            setVisible();
        }

        private void CricketBall_Click(object sender, EventArgs e)
        {
            setVisible();
            CricketBallBtn.Show();

        }

        

        

        private void label1_Click(object sender, EventArgs e)
        {
            setVisible();
            BorrowBtn.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            setVisible();
            BorrowBtn.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            setVisible();
            BorrowBtn.Show();
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {
            setVisible();
            CricketBallBtn.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            setVisible();
            CricketBallBtn.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            setVisible();
            CricketBallBtn.Show();
        }

        private void BatmintonRacket_Click(object sender, EventArgs e)
        {
            setVisible();
            Racket.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            setVisible();
            Racket.Show();
        }

        private void label13_Click(object sender, EventArgs e)
        {
            setVisible();
            Racket.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            setVisible();
            Racket.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            setVisible();
            Racket.Show();
        }

        private void BatmintonFlowwer_Click(object sender, EventArgs e)
        {
            setVisible();
            Flower.Show();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            setVisible();
            Flower.Show();
        }

        private void label14_Click(object sender, EventArgs e)
        {
            setVisible();
            Flower.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            setVisible();
            Flower.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            setVisible();
            Flower.Show();
        }

        private void Stump_Click(object sender, EventArgs e)
        {
            setVisible();
            StumpBtn.Show();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            setVisible();
            StumpBtn.Show();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            setVisible();
            StumpBtn.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            setVisible();
            StumpBtn.Show();
        }

        private void VollyBall_Click(object sender, EventArgs e)
        {
            setVisible();
            VollyBallBtn.Show();
        }

        private void label12_Click(object sender, EventArgs e)
        {
            setVisible();
            VollyBallBtn.Show();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            setVisible();
            VollyBallBtn.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            setVisible();
            VollyBallBtn.Show();
        }

        private void FootBall_Click(object sender, EventArgs e)
        {
            setVisible();
            FootBallBtn.Show();
        }

        private void label17_Click(object sender, EventArgs e)
        {
            setVisible();
            FootBallBtn.Show();
        }

        private void label15_Click(object sender, EventArgs e)
        {
            setVisible();
            FootBallBtn.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            setVisible();
            FootBallBtn.Show();
        }

        private void RugbyBall_Click(object sender, EventArgs e)
        {
            setVisible();
            RugbyBtn.Show();
        }

        private void label19_Click(object sender, EventArgs e)
        {
            setVisible();
            RugbyBtn.Show();
        }

        private void label18_Click(object sender, EventArgs e)
        {
            setVisible();
            RugbyBtn.Show();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            setVisible();
            RugbyBtn.Show();
        }

        private void Pads_Click(object sender, EventArgs e)
        {
            setVisible();
            PadBtn.Show();
        }

        private void Pad_Click(object sender, EventArgs e)
        {
            setVisible();
            PadBtn.Show();
        }

        private void label20_Click(object sender, EventArgs e)
        {
            setVisible();
            PadBtn.Show();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            setVisible();
            PadBtn.Show();
        }

        private void ChessBoard_Click(object sender, EventArgs e)
        {
            setVisible();
            ChessBtn.Show();
        }

        private void label21_Click(object sender, EventArgs e)
        {
            setVisible();
            ChessBtn.Show();
        }

        private void label16_Click(object sender, EventArgs e)
        {
            setVisible();
            ChessBtn.Show();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            setVisible();
            ChessBtn.Show();
        }

        private void Spear_Click(object sender, EventArgs e)
        {
            setVisible();
            SpearBtn.Show();
        }

        private void label23_Click(object sender, EventArgs e)
        {
            setVisible();
            SpearBtn.Show();
        }

        private void label22_Click(object sender, EventArgs e)
        {
            setVisible();
            SpearBtn.Show();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            setVisible();
            SpearBtn.Show();
        }

        private void Hurdle_Click(object sender, EventArgs e)
        {
            setVisible();
            HurdleBtn.Show();
        }

        private void label25_Click(object sender, EventArgs e)
        {
            setVisible();
            HurdleBtn.Show();
        }

        private void label24_Click(object sender, EventArgs e)
        {
            setVisible();
            HurdleBtn.Show();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            setVisible();
            HurdleBtn.Show();
        }

        private void CorromBoard_Click(object sender, EventArgs e)
        {
            setVisible();
            CarromBtn.Show();
        }

        private void label27_Click(object sender, EventArgs e)
        {
            setVisible();
            CarromBtn.Show();
        }

        private void label26_Click(object sender, EventArgs e)
        {
            setVisible();
            CarromBtn.Show();
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            setVisible();
            CarromBtn.Show();
        }

        private void Mettress_Click(object sender, EventArgs e)
        {
            setVisible();
            MettressBtn.Show();
        }

        private void label29_Click(object sender, EventArgs e)
        {
            setVisible();
            MettressBtn.Show();
        }

        private void label28_Click(object sender, EventArgs e)
        {
            setVisible();
            MettressBtn.Show();
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            setVisible();
            MettressBtn.Show();
        }

        private void BorrowBtn_Click(object sender, EventArgs e)
        {
            setlgUser();
            string date = DateTime.Now.ToString("yyyy-MM-dd");
            MySqlConnection con = new MySqlConnection(cn);
            MySqlCommand cmd = new MySqlCommand("insert into borrowitem(UserName,Item,Date) values('" + lgUserName + "','Cricket Bat','" + date + "')", con);
            con.Open();
            cmd.ExecuteReader();
            con.Close();
            BorrowBtn.Hide();
        }

        private void CricketBallBtn_Click(object sender, EventArgs e)
        {
            setlgUser();
            string date = DateTime.Now.ToString("yyyy-MM-dd");
            MySqlConnection con = new MySqlConnection(cn);
            MySqlCommand cmd = new MySqlCommand("insert into borrowitem(UserName,Item,Date) values('" + lgUserName + "','Cricket Ball','" + date + "')", con);
            con.Open();
            cmd.ExecuteReader();
            con.Close();
            CricketBallBtn.Hide();
            
        }

        private void Racket_Click(object sender, EventArgs e)
        {
            setlgUser();
            string date = DateTime.Now.ToString("yyyy-MM-dd");
            MySqlConnection con = new MySqlConnection(cn);
            MySqlCommand cmd = new MySqlCommand("insert into borrowitem(UserName,Item,Date) values('" + lgUserName + "','Batminton Racket','" + date + "')", con);
            con.Open();
            cmd.ExecuteReader();
            con.Close();
            Racket.Hide();
        }

        private void Flower_Click(object sender, EventArgs e)
        {
            setlgUser();
            string date = DateTime.Now.ToString("yyyy-MM-dd");
            MySqlConnection con = new MySqlConnection(cn);
            MySqlCommand cmd = new MySqlCommand("insert into borrowitem(UserName,Item,Date) values('" + lgUserName + "','Batminton Flower','" + date + "')", con);
            con.Open();
            cmd.ExecuteReader();
            con.Close();
            Flower.Hide();
        }

        private void StumpBtn_Click(object sender, EventArgs e)
        {
            setlgUser();
            string date = DateTime.Now.ToString("yyyy-MM-dd");
            MySqlConnection con = new MySqlConnection(cn);
            MySqlCommand cmd = new MySqlCommand("insert into borrowitem(UserName,Item,Date) values('" + lgUserName + "','Stump','" + date + "')", con);
            con.Open();
            cmd.ExecuteReader();
            con.Close();
            StumpBtn.Hide();
        }

        private void VollyBallBtn_Click(object sender, EventArgs e)
        {
            setlgUser();
            string date = DateTime.Now.ToString("yyyy-MM-dd");
            MySqlConnection con = new MySqlConnection(cn);
            MySqlCommand cmd = new MySqlCommand("insert into borrowitem(UserName,Item,Date) values('" + lgUserName + "','Volly Ball','" + date + "')", con);
            con.Open();
            cmd.ExecuteReader();
            con.Close();
            VollyBallBtn.Hide();
        }

        private void FootBallBtn_Click(object sender, EventArgs e)
        {
            setlgUser();
            string date = DateTime.Now.ToString("yyyy-MM-dd");
            MySqlConnection con = new MySqlConnection(cn);
            MySqlCommand cmd = new MySqlCommand("insert into borrowitem(UserName,Item,Date) values('" + lgUserName + "','Foot Ball','" + date + "')", con);
            con.Open();
            cmd.ExecuteReader();
            con.Close();
            FootBallBtn.Hide();
        }

        private void RugbyBtn_Click(object sender, EventArgs e)
        {
            setlgUser();
            string date = DateTime.Now.ToString("yyyy-MM-dd");
            MySqlConnection con = new MySqlConnection(cn);
            MySqlCommand cmd = new MySqlCommand("insert into borrowitem(UserName,Item,Date) values('" + lgUserName + "','Rugby Ball','" + date + "')", con);
            con.Open();
            cmd.ExecuteReader();
            con.Close();
            RugbyBtn.Hide();
        }

        private void PadBtn_Click(object sender, EventArgs e)
        {
            setlgUser();
            string date = DateTime.Now.ToString("yyyy-MM-dd");
            MySqlConnection con = new MySqlConnection(cn);
            MySqlCommand cmd = new MySqlCommand("insert into borrowitem(UserName,Item,Date) values('" + lgUserName + "','Pad','" + date + "')", con);
            con.Open();
            cmd.ExecuteReader();
            con.Close();
            PadBtn.Hide();
        }

        private void ChessBtn_Click(object sender, EventArgs e)
        {
            setlgUser();
            string date = DateTime.Now.ToString("yyyy-MM-dd");
            MySqlConnection con = new MySqlConnection(cn);
            MySqlCommand cmd = new MySqlCommand("insert into borrowitem(UserName,Item,Date) values('" + lgUserName + "','Chess Board','" + date + "')", con);
            con.Open();
            cmd.ExecuteReader();
            con.Close();
            ChessBtn.Hide();
        }

        private void SpearBtn_Click(object sender, EventArgs e)
        {
            setlgUser();
            string date = DateTime.Now.ToString("yyyy-MM-dd");
            MySqlConnection con = new MySqlConnection(cn);
            MySqlCommand cmd = new MySqlCommand("insert into borrowitem(UserName,Item,Date) values('" + lgUserName + "','Spear','" + date + "')", con);
            con.Open();
            cmd.ExecuteReader();
            con.Close();
            SpearBtn.Hide();
        }

        private void HurdleBtn_Click(object sender, EventArgs e)
        {
            setlgUser();
            string date = DateTime.Now.ToString("yyyy-MM-dd");
            MySqlConnection con = new MySqlConnection(cn);
            MySqlCommand cmd = new MySqlCommand("insert into borrowitem(UserName,Item,Date) values('" + lgUserName + "','Hurdle','" + date + "')", con);
            con.Open();
            cmd.ExecuteReader();
            con.Close();
            HurdleBtn.Hide();
        }

        private void CarromBtn_Click(object sender, EventArgs e)
        {
            setlgUser();
            string date = DateTime.Now.ToString("yyyy-MM-dd");
            MySqlConnection con = new MySqlConnection(cn);
            MySqlCommand cmd = new MySqlCommand("insert into borrowitem(UserName,Item,Date) values('" + lgUserName + "','Carrom Board','" + date + "')", con);
            con.Open();
            cmd.ExecuteReader();
            con.Close();
            CarromBtn.Hide();
        }

        private void MettressBtn_Click(object sender, EventArgs e)
        {
            setlgUser();
            string date = DateTime.Now.ToString("yyyy-MM-dd");
            MySqlConnection con = new MySqlConnection(cn);
            MySqlCommand cmd = new MySqlCommand("insert into borrowitem(UserName,Item,Date) values('" + lgUserName + "','Mettress','" + date + "')", con);
            con.Open();
            cmd.ExecuteReader();
            con.Close();
            MettressBtn.Hide();
        }
    }
}
