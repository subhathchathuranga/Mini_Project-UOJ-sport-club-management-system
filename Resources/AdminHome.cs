using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mini_Project
{
    public partial class AdminHome : UserControl
    {
        public AdminHome()
        {
            InitializeComponent();
        }

        private void AdminHome_Load(object sender, EventArgs e)
        {
            panel3.Width = BorrowedItem.Width;
            panel3.Left = BorrowedItem.Left;

            panel2.BackColor = Color.FromArgb(150, 0, 0, 0);

            adBorrowedItem1.BringToFront();
        }

        private void BorrowedItem_Click(object sender, EventArgs e)
        {
            panel3.Width = BorrowedItem.Width;
            panel3.Left = BorrowedItem.Left;

            adBorrowedItem1.BringToFront();
        }

        private void BookGround_Click(object sender, EventArgs e)
        {
            panel3.Width = BookGround.Width;
            panel3.Left = BookGround.Left;

            adBookGround1.BringToFront();
        }

        private void CreateEvent_Click(object sender, EventArgs e)
        {
            panel3.Width = CreateEvent.Width;
            panel3.Left = CreateEvent.Left;

            adCreateEvent1.BringToFront();
        }

        

        private void close_MouseEnter(object sender, EventArgs e)
        {
            close.BackColor = Color.Black;
        }

        private void close_MouseLeave(object sender, EventArgs e)
        {
            close.BackColor = Color.FromArgb(1, 7, 50);
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
