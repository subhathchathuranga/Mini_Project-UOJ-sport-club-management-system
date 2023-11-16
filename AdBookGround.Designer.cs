namespace Mini_Project
{
    partial class AdBookGround
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.GroundNo = new System.Windows.Forms.TextBox();
            this.Date = new System.Windows.Forms.TextBox();
            this.Sport = new System.Windows.Forms.TextBox();
            this.EndTime = new System.Windows.Forms.TextBox();
            this.StartTime = new System.Windows.Forms.TextBox();
            this.Book = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(69, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ground No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(69, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(69, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "Time  From";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(69, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 22);
            this.label4.TabIndex = 0;
            this.label4.Text = "Sport";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(391, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 22);
            this.label5.TabIndex = 0;
            this.label5.Text = "To";
            // 
            // GroundNo
            // 
            this.GroundNo.Location = new System.Drawing.Point(220, 51);
            this.GroundNo.Name = "GroundNo";
            this.GroundNo.Size = new System.Drawing.Size(365, 22);
            this.GroundNo.TabIndex = 1;
            // 
            // Date
            // 
            this.Date.Location = new System.Drawing.Point(220, 93);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(365, 22);
            this.Date.TabIndex = 1;
            // 
            // Sport
            // 
            this.Sport.Location = new System.Drawing.Point(220, 186);
            this.Sport.Name = "Sport";
            this.Sport.Size = new System.Drawing.Size(365, 22);
            this.Sport.TabIndex = 1;
            // 
            // EndTime
            // 
            this.EndTime.Location = new System.Drawing.Point(448, 138);
            this.EndTime.Name = "EndTime";
            this.EndTime.Size = new System.Drawing.Size(137, 22);
            this.EndTime.TabIndex = 1;
            // 
            // StartTime
            // 
            this.StartTime.Location = new System.Drawing.Point(220, 138);
            this.StartTime.Name = "StartTime";
            this.StartTime.Size = new System.Drawing.Size(137, 22);
            this.StartTime.TabIndex = 1;
            // 
            // Book
            // 
            this.Book.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Book.FlatAppearance.BorderSize = 0;
            this.Book.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Book.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Book.Location = new System.Drawing.Point(510, 269);
            this.Book.Name = "Book";
            this.Book.Size = new System.Drawing.Size(130, 51);
            this.Book.TabIndex = 2;
            this.Book.Text = "Book";
            this.Book.UseVisualStyleBackColor = false;
            this.Book.Click += new System.EventHandler(this.Book_Click);
            // 
            // AdBookGround
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Book);
            this.Controls.Add(this.StartTime);
            this.Controls.Add(this.EndTime);
            this.Controls.Add(this.Sport);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.GroundNo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AdBookGround";
            this.Size = new System.Drawing.Size(686, 355);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox GroundNo;
        private System.Windows.Forms.TextBox Date;
        private System.Windows.Forms.TextBox Sport;
        private System.Windows.Forms.TextBox EndTime;
        private System.Windows.Forms.TextBox StartTime;
        private System.Windows.Forms.Button Book;
    }
}
