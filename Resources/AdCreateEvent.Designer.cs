namespace Mini_Project
{
    partial class AdCreateEvent
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
            this.Post = new System.Windows.Forms.Button();
            this.StartTime = new System.Windows.Forms.TextBox();
            this.EndTime = new System.Windows.Forms.TextBox();
            this.Teams = new System.Windows.Forms.TextBox();
            this.EventDate = new System.Windows.Forms.TextBox();
            this.EventGroundNo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.EventSport = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Post
            // 
            this.Post.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Post.FlatAppearance.BorderSize = 0;
            this.Post.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Post.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Post.Location = new System.Drawing.Point(508, 269);
            this.Post.Name = "Post";
            this.Post.Size = new System.Drawing.Size(130, 51);
            this.Post.TabIndex = 13;
            this.Post.Text = "Post";
            this.Post.UseVisualStyleBackColor = false;
            this.Post.Click += new System.EventHandler(this.Post_Click);
            // 
            // StartTime
            // 
            this.StartTime.Location = new System.Drawing.Point(226, 161);
            this.StartTime.Name = "StartTime";
            this.StartTime.Size = new System.Drawing.Size(137, 22);
            this.StartTime.TabIndex = 8;
            // 
            // EndTime
            // 
            this.EndTime.Location = new System.Drawing.Point(454, 161);
            this.EndTime.Name = "EndTime";
            this.EndTime.Size = new System.Drawing.Size(137, 22);
            this.EndTime.TabIndex = 9;
            // 
            // Teams
            // 
            this.Teams.Location = new System.Drawing.Point(226, 209);
            this.Teams.Name = "Teams";
            this.Teams.Size = new System.Drawing.Size(365, 22);
            this.Teams.TabIndex = 10;
            // 
            // EventDate
            // 
            this.EventDate.Location = new System.Drawing.Point(226, 116);
            this.EventDate.Name = "EventDate";
            this.EventDate.Size = new System.Drawing.Size(365, 22);
            this.EventDate.TabIndex = 11;
            // 
            // EventGroundNo
            // 
            this.EventGroundNo.Location = new System.Drawing.Point(226, 74);
            this.EventGroundNo.Name = "EventGroundNo";
            this.EventGroundNo.Size = new System.Drawing.Size(365, 22);
            this.EventGroundNo.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(75, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Teams";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(397, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "To";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(75, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "Time  From";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(75, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 22);
            this.label2.TabIndex = 6;
            this.label2.Text = "Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 22);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ground No";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(75, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 22);
            this.label6.TabIndex = 7;
            this.label6.Text = "Sport";
            // 
            // EventSport
            // 
            this.EventSport.Location = new System.Drawing.Point(226, 28);
            this.EventSport.Name = "EventSport";
            this.EventSport.Size = new System.Drawing.Size(365, 22);
            this.EventSport.TabIndex = 12;
            // 
            // AdCreateEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Post);
            this.Controls.Add(this.StartTime);
            this.Controls.Add(this.EndTime);
            this.Controls.Add(this.Teams);
            this.Controls.Add(this.EventDate);
            this.Controls.Add(this.EventSport);
            this.Controls.Add(this.EventGroundNo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AdCreateEvent";
            this.Size = new System.Drawing.Size(686, 355);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Post;
        private System.Windows.Forms.TextBox StartTime;
        private System.Windows.Forms.TextBox EndTime;
        private System.Windows.Forms.TextBox Teams;
        private System.Windows.Forms.TextBox EventDate;
        private System.Windows.Forms.TextBox EventGroundNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox EventSport;
    }
}
