namespace Mini_Project
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.UserName = new System.Windows.Forms.TextBox();
            this.Signup = new System.Windows.Forms.Button();
            this.Signin = new System.Windows.Forms.Button();
            this.Password = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.about1 = new Mini_Project.About();
            this.adminHome1 = new Mini_Project.AdminHome();
            this.home1 = new Mini_Project.Home();
            this.signInPage1 = new Mini_Project.SignInPage();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.UserName);
            this.panel1.Controls.Add(this.Signup);
            this.panel1.Controls.Add(this.Signin);
            this.panel1.Controls.Add(this.Password);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(238, 72);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(615, 446);
            this.panel1.TabIndex = 0;
            // 
            // UserName
            // 
            this.UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserName.Location = new System.Drawing.Point(221, 65);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(323, 27);
            this.UserName.TabIndex = 6;
            // 
            // Signup
            // 
            this.Signup.BackColor = System.Drawing.Color.White;
            this.Signup.FlatAppearance.BorderSize = 0;
            this.Signup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Signup.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Signup.Location = new System.Drawing.Point(174, 321);
            this.Signup.Name = "Signup";
            this.Signup.Size = new System.Drawing.Size(294, 36);
            this.Signup.TabIndex = 5;
            this.Signup.Text = "Sign Up";
            this.Signup.UseVisualStyleBackColor = false;
            this.Signup.Click += new System.EventHandler(this.Signup_Click);
            this.Signup.MouseEnter += new System.EventHandler(this.Signup_MouseEnter);
            this.Signup.MouseLeave += new System.EventHandler(this.Signup_MouseLeave);
            // 
            // Signin
            // 
            this.Signin.BackColor = System.Drawing.Color.White;
            this.Signin.FlatAppearance.BorderSize = 0;
            this.Signin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Signin.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Signin.Location = new System.Drawing.Point(174, 254);
            this.Signin.Name = "Signin";
            this.Signin.Size = new System.Drawing.Size(294, 36);
            this.Signin.TabIndex = 4;
            this.Signin.Text = "Sign In";
            this.Signin.UseVisualStyleBackColor = false;
            this.Signin.Click += new System.EventHandler(this.Signin_Click);
            this.Signin.MouseEnter += new System.EventHandler(this.Signin_MouseEnter);
            this.Signin.MouseLeave += new System.EventHandler(this.Signin_MouseLeave);
            // 
            // Password
            // 
            this.Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.Location = new System.Drawing.Point(221, 157);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(323, 27);
            this.Password.TabIndex = 3;
            this.Password.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(78, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(78, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "User Name";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 577);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1082, 26);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(354, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(399, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "universityofvavuniyasport@gmail.com / 024 2222264";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(987, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 32);
            this.button1.TabIndex = 2;
            this.button1.Text = "About";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // about1
            // 
            this.about1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("about1.BackgroundImage")));
            this.about1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.about1.Location = new System.Drawing.Point(0, 0);
            this.about1.Name = "about1";
            this.about1.Size = new System.Drawing.Size(1090, 602);
            this.about1.TabIndex = 10;
            // 
            // adminHome1
            // 
            this.adminHome1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("adminHome1.BackgroundImage")));
            this.adminHome1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.adminHome1.Location = new System.Drawing.Point(0, 1);
            this.adminHome1.Name = "adminHome1";
            this.adminHome1.Size = new System.Drawing.Size(1082, 611);
            this.adminHome1.TabIndex = 9;
            // 
            // home1
            // 
            this.home1.BackColor = System.Drawing.Color.White;
            this.home1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("home1.BackgroundImage")));
            this.home1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.home1.Location = new System.Drawing.Point(0, 0);
            this.home1.Name = "home1";
            this.home1.Size = new System.Drawing.Size(1082, 603);
            this.home1.TabIndex = 8;
            // 
            // signInPage1
            // 
            this.signInPage1.BackColor = System.Drawing.Color.White;
            this.signInPage1.Location = new System.Drawing.Point(0, 0);
            this.signInPage1.Name = "signInPage1";
            this.signInPage1.Size = new System.Drawing.Size(1082, 612);
            this.signInPage1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Mini_Project.Properties.Resources.DSC_9411;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1082, 603);
            this.Controls.Add(this.about1);
            this.Controls.Add(this.adminHome1);
            this.Controls.Add(this.home1);
            this.Controls.Add(this.signInPage1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(1100, 650);
            this.MinimumSize = new System.Drawing.Size(1100, 650);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sport Club";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Signup;
        private System.Windows.Forms.Button Signin;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox UserName;
        private System.Windows.Forms.Button button1;
        private SignInPage signInPage1;
        private Home home1;
        private AdminHome adminHome1;
        private About about1;
    }
}