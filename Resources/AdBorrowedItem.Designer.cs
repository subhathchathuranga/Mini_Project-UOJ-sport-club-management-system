namespace Mini_Project
{
    partial class AdBorrowedItem
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
            this.BorrowItemTb = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.BorrowItemTb)).BeginInit();
            this.SuspendLayout();
            // 
            // BorrowItemTb
            // 
            this.BorrowItemTb.AllowUserToAddRows = false;
            this.BorrowItemTb.AllowUserToDeleteRows = false;
            this.BorrowItemTb.BackgroundColor = System.Drawing.Color.White;
            this.BorrowItemTb.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BorrowItemTb.Location = new System.Drawing.Point(17, 3);
            this.BorrowItemTb.Name = "BorrowItemTb";
            this.BorrowItemTb.ReadOnly = true;
            this.BorrowItemTb.RowHeadersWidth = 51;
            this.BorrowItemTb.RowTemplate.Height = 24;
            this.BorrowItemTb.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.BorrowItemTb.Size = new System.Drawing.Size(650, 349);
            this.BorrowItemTb.TabIndex = 0;
            // 
            // AdBorrowedItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BorrowItemTb);
            this.Name = "AdBorrowedItem";
            this.Size = new System.Drawing.Size(686, 355);
            this.Load += new System.EventHandler(this.AdBorrowedItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BorrowItemTb)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView BorrowItemTb;
    }
}
