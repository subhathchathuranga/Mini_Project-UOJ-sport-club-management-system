namespace Mini_Project
{
    partial class StGroundBook
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
            this.GroundBookTb = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.GroundBookTb)).BeginInit();
            this.SuspendLayout();
            // 
            // GroundBookTb
            // 
            this.GroundBookTb.AllowUserToAddRows = false;
            this.GroundBookTb.AllowUserToDeleteRows = false;
            this.GroundBookTb.BackgroundColor = System.Drawing.Color.White;
            this.GroundBookTb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GroundBookTb.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GroundBookTb.Location = new System.Drawing.Point(3, 4);
            this.GroundBookTb.Name = "GroundBookTb";
            this.GroundBookTb.ReadOnly = true;
            this.GroundBookTb.RowHeadersWidth = 51;
            this.GroundBookTb.RowTemplate.Height = 24;
            this.GroundBookTb.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GroundBookTb.Size = new System.Drawing.Size(971, 541);
            this.GroundBookTb.TabIndex = 0;
            // 
            // StGroundBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.GroundBookTb);
            this.Name = "StGroundBook";
            this.Size = new System.Drawing.Size(977, 547);
            this.Load += new System.EventHandler(this.StGroundBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GroundBookTb)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView GroundBookTb;
    }
}
