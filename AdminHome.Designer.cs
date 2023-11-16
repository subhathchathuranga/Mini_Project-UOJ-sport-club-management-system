namespace Mini_Project
{
    partial class AdminHome
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BorrowedItem = new System.Windows.Forms.Button();
            this.CreateEvent = new System.Windows.Forms.Button();
            this.BookGround = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.close = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.adCreateEvent1 = new Mini_Project.AdCreateEvent();
            this.adBorrowedItem1 = new Mini_Project.AdBorrowedItem();
            this.adBookGround1 = new Mini_Project.AdBookGround();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // BorrowedItem
            // 
            this.BorrowedItem.FlatAppearance.BorderSize = 0;
            this.BorrowedItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BorrowedItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BorrowedItem.Location = new System.Drawing.Point(0, 0);
            this.BorrowedItem.Name = "BorrowedItem";
            this.BorrowedItem.Size = new System.Drawing.Size(150, 76);
            this.BorrowedItem.TabIndex = 1;
            this.BorrowedItem.Text = "Borrowed Item";
            this.BorrowedItem.UseVisualStyleBackColor = true;
            this.BorrowedItem.Click += new System.EventHandler(this.BorrowedItem_Click);
            // 
            // CreateEvent
            // 
            this.CreateEvent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(7)))), ((int)(((byte)(50)))));
            this.CreateEvent.FlatAppearance.BorderSize = 0;
            this.CreateEvent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateEvent.ForeColor = System.Drawing.Color.White;
            this.CreateEvent.Location = new System.Drawing.Point(300, 0);
            this.CreateEvent.Name = "CreateEvent";
            this.CreateEvent.Size = new System.Drawing.Size(150, 76);
            this.CreateEvent.TabIndex = 9;
            this.CreateEvent.Text = "Create Event";
            this.CreateEvent.UseVisualStyleBackColor = false;
            this.CreateEvent.Click += new System.EventHandler(this.CreateEvent_Click);
            // 
            // BookGround
            // 
            this.BookGround.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(7)))), ((int)(((byte)(50)))));
            this.BookGround.FlatAppearance.BorderSize = 0;
            this.BookGround.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BookGround.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookGround.ForeColor = System.Drawing.Color.White;
            this.BookGround.Location = new System.Drawing.Point(150, 0);
            this.BookGround.Name = "BookGround";
            this.BookGround.Size = new System.Drawing.Size(150, 76);
            this.BookGround.TabIndex = 7;
            this.BookGround.Text = "Book Ground";
            this.BookGround.UseVisualStyleBackColor = false;
            this.BookGround.Click += new System.EventHandler(this.BookGround_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(7)))), ((int)(((byte)(50)))));
            this.panel1.Controls.Add(this.close);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.CreateEvent);
            this.panel1.Controls.Add(this.BookGround);
            this.panel1.Controls.Add(this.BorrowedItem);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1082, 76);
            this.panel1.TabIndex = 6;
            // 
            // close
            // 
            this.close.BackgroundImage = global::Mini_Project.Properties.Resources.LogOut__Converted_;
            this.close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.close.FlatAppearance.BorderSize = 0;
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close.Location = new System.Drawing.Point(1036, 3);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(43, 42);
            this.close.TabIndex = 12;
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            this.close.MouseEnter += new System.EventHandler(this.close_MouseEnter);
            this.close.MouseLeave += new System.EventHandler(this.close_MouseLeave);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(0, 70);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(150, 6);
            this.panel3.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.adCreateEvent1);
            this.panel2.Controls.Add(this.adBorrowedItem1);
            this.panel2.Controls.Add(this.adBookGround1);
            this.panel2.Location = new System.Drawing.Point(150, 112);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(795, 454);
            this.panel2.TabIndex = 7;
            // 
            // adCreateEvent1
            // 
            this.adCreateEvent1.BackColor = System.Drawing.Color.White;
            this.adCreateEvent1.Location = new System.Drawing.Point(55, 53);
            this.adCreateEvent1.Name = "adCreateEvent1";
            this.adCreateEvent1.Size = new System.Drawing.Size(686, 355);
            this.adCreateEvent1.TabIndex = 2;
            // 
            // adBorrowedItem1
            // 
            this.adBorrowedItem1.BackColor = System.Drawing.Color.White;
            this.adBorrowedItem1.Location = new System.Drawing.Point(55, 53);
            this.adBorrowedItem1.Name = "adBorrowedItem1";
            this.adBorrowedItem1.Size = new System.Drawing.Size(686, 355);
            this.adBorrowedItem1.TabIndex = 1;
            // 
            // adBookGround1
            // 
            this.adBookGround1.BackColor = System.Drawing.Color.White;
            this.adBookGround1.Location = new System.Drawing.Point(55, 53);
            this.adBookGround1.Name = "adBookGround1";
            this.adBookGround1.Size = new System.Drawing.Size(686, 355);
            this.adBookGround1.TabIndex = 0;
            // 
            // AdminHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Mini_Project.Properties.Resources.LogOut__Converted_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Name = "AdminHome";
            this.Size = new System.Drawing.Size(1082, 603);
            this.Load += new System.EventHandler(this.AdminHome_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BorrowedItem;
        private System.Windows.Forms.Button CreateEvent;
        private System.Windows.Forms.Button BookGround;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private AdCreateEvent adCreateEvent1;
        private AdBorrowedItem adBorrowedItem1;
        private AdBookGround adBookGround1;
        private System.Windows.Forms.Button close;
    }
}
