namespace Mini_Project
{
    partial class Home
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.StName = new System.Windows.Forms.Label();
            this.Profile = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.StBorrowItem = new System.Windows.Forms.Button();
            this.StReturnItem = new System.Windows.Forms.Button();
            this.StGroundBook = new System.Windows.Forms.Button();
            this.StEvents = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.profile1 = new Mini_Project.Profile();
            this.stReturnItem1 = new Mini_Project.StReturnItem();
            this.stBorrowItem1 = new Mini_Project.StBorrowItem();
            this.stGroundBook1 = new Mini_Project.StGroundBook();
            this.stEvent1 = new Mini_Project.StEvent();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Profile)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(7)))), ((int)(((byte)(50)))));
            this.panel1.Controls.Add(this.StName);
            this.panel1.Controls.Add(this.Profile);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.StBorrowItem);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1090, 76);
            this.panel1.TabIndex = 0;
            // 
            // StName
            // 
            this.StName.AutoSize = true;
            this.StName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StName.Location = new System.Drawing.Point(930, 11);
            this.StName.Name = "StName";
            this.StName.Size = new System.Drawing.Size(66, 20);
            this.StName.TabIndex = 7;
            this.StName.Text = "Student";
            // 
            // Profile
            // 
            this.Profile.Image = global::Mini_Project.Properties.Resources.WhatsApp_Image_2023_03_09_at_5__Converted_1;
            this.Profile.Location = new System.Drawing.Point(1013, 0);
            this.Profile.Name = "Profile";
            this.Profile.Size = new System.Drawing.Size(57, 56);
            this.Profile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Profile.TabIndex = 6;
            this.Profile.TabStop = false;
            this.Profile.Click += new System.EventHandler(this.Profile_Click);
            this.Profile.MouseEnter += new System.EventHandler(this.Profile_MouseEnter);
            this.Profile.MouseLeave += new System.EventHandler(this.Profile_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(907, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Hi";
            // 
            // StBorrowItem
            // 
            this.StBorrowItem.FlatAppearance.BorderSize = 0;
            this.StBorrowItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StBorrowItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StBorrowItem.Location = new System.Drawing.Point(0, 0);
            this.StBorrowItem.Name = "StBorrowItem";
            this.StBorrowItem.Size = new System.Drawing.Size(150, 76);
            this.StBorrowItem.TabIndex = 1;
            this.StBorrowItem.Text = "Borrow Item";
            this.StBorrowItem.UseVisualStyleBackColor = true;
            this.StBorrowItem.Click += new System.EventHandler(this.StBorrowItem_Click);
            this.StBorrowItem.MouseEnter += new System.EventHandler(this.StBorrowItem_MouseEnter);
            this.StBorrowItem.MouseLeave += new System.EventHandler(this.StBorrowItem_MouseLeave);
            // 
            // StReturnItem
            // 
            this.StReturnItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(7)))), ((int)(((byte)(50)))));
            this.StReturnItem.FlatAppearance.BorderSize = 0;
            this.StReturnItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StReturnItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StReturnItem.ForeColor = System.Drawing.Color.White;
            this.StReturnItem.Location = new System.Drawing.Point(150, 0);
            this.StReturnItem.Name = "StReturnItem";
            this.StReturnItem.Size = new System.Drawing.Size(150, 76);
            this.StReturnItem.TabIndex = 2;
            this.StReturnItem.Text = "Return Item";
            this.StReturnItem.UseVisualStyleBackColor = false;
            this.StReturnItem.Click += new System.EventHandler(this.StReturnItem_Click);
            this.StReturnItem.MouseEnter += new System.EventHandler(this.StReturnItem_MouseEnter);
            this.StReturnItem.MouseLeave += new System.EventHandler(this.StReturnItem_MouseLeave);
            // 
            // StGroundBook
            // 
            this.StGroundBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(7)))), ((int)(((byte)(50)))));
            this.StGroundBook.FlatAppearance.BorderSize = 0;
            this.StGroundBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StGroundBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StGroundBook.ForeColor = System.Drawing.Color.White;
            this.StGroundBook.Location = new System.Drawing.Point(300, 0);
            this.StGroundBook.Name = "StGroundBook";
            this.StGroundBook.Size = new System.Drawing.Size(150, 76);
            this.StGroundBook.TabIndex = 4;
            this.StGroundBook.Text = "Ground Reservations";
            this.StGroundBook.UseVisualStyleBackColor = false;
            this.StGroundBook.Click += new System.EventHandler(this.StGroundBook_Click);
            this.StGroundBook.MouseEnter += new System.EventHandler(this.StGroundBook_MouseEnter);
            this.StGroundBook.MouseLeave += new System.EventHandler(this.StGroundBook_MouseLeave);
            // 
            // StEvents
            // 
            this.StEvents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(7)))), ((int)(((byte)(50)))));
            this.StEvents.FlatAppearance.BorderSize = 0;
            this.StEvents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StEvents.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StEvents.ForeColor = System.Drawing.Color.White;
            this.StEvents.Location = new System.Drawing.Point(450, 0);
            this.StEvents.Name = "StEvents";
            this.StEvents.Size = new System.Drawing.Size(150, 76);
            this.StEvents.TabIndex = 5;
            this.StEvents.Text = "Events";
            this.StEvents.UseVisualStyleBackColor = false;
            this.StEvents.Click += new System.EventHandler(this.StEvents_Click);
            this.StEvents.MouseEnter += new System.EventHandler(this.StEvents_MouseEnter);
            this.StEvents.MouseLeave += new System.EventHandler(this.StEvents_MouseLeave);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 70);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(150, 6);
            this.panel2.TabIndex = 6;
            // 
            // profile1
            // 
            this.profile1.Location = new System.Drawing.Point(354, 122);
            this.profile1.Name = "profile1";
            this.profile1.Size = new System.Drawing.Size(399, 443);
            this.profile1.TabIndex = 9;
            // 
            // stReturnItem1
            // 
            this.stReturnItem1.BackColor = System.Drawing.Color.Transparent;
            this.stReturnItem1.Location = new System.Drawing.Point(0, 75);
            this.stReturnItem1.Name = "stReturnItem1";
            this.stReturnItem1.Size = new System.Drawing.Size(1090, 565);
            this.stReturnItem1.TabIndex = 8;
            // 
            // stBorrowItem1
            // 
            this.stBorrowItem1.AllowDrop = true;
            this.stBorrowItem1.AutoScroll = true;
            this.stBorrowItem1.BackColor = System.Drawing.Color.Transparent;
            this.stBorrowItem1.Location = new System.Drawing.Point(0, 75);
            this.stBorrowItem1.Name = "stBorrowItem1";
            this.stBorrowItem1.Size = new System.Drawing.Size(1090, 565);
            this.stBorrowItem1.TabIndex = 7;
            // 
            // stGroundBook1
            // 
            this.stGroundBook1.BackColor = System.Drawing.Color.White;
            this.stGroundBook1.Location = new System.Drawing.Point(0, 75);
            this.stGroundBook1.Name = "stGroundBook1";
            this.stGroundBook1.Size = new System.Drawing.Size(1090, 562);
            this.stGroundBook1.TabIndex = 10;
            // 
            // stEvent1
            // 
            this.stEvent1.Location = new System.Drawing.Point(0, 75);
            this.stEvent1.Name = "stEvent1";
            this.stEvent1.Size = new System.Drawing.Size(1090, 562);
            this.stEvent1.TabIndex = 11;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Mini_Project.Properties.Resources._1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.stEvent1);
            this.Controls.Add(this.stGroundBook1);
            this.Controls.Add(this.profile1);
            this.Controls.Add(this.stReturnItem1);
            this.Controls.Add(this.stBorrowItem1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.StEvents);
            this.Controls.Add(this.StGroundBook);
            this.Controls.Add(this.StReturnItem);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Name = "Home";
            this.Size = new System.Drawing.Size(1090, 640);
            this.Load += new System.EventHandler(this.Home_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Profile)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox Profile;
        private System.Windows.Forms.Button StBorrowItem;
        private System.Windows.Forms.Button StReturnItem;
        private System.Windows.Forms.Button StGroundBook;
        private System.Windows.Forms.Button StEvents;
        private System.Windows.Forms.Label StName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private StBorrowItem stBorrowItem1;
        private StReturnItem stReturnItem1;
        private Profile profile1;
        private StGroundBook stGroundBook1;
        private StEvent stEvent1;
    }
}
