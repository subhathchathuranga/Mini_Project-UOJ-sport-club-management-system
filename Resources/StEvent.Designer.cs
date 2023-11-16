namespace Mini_Project
{
    partial class StEvent
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
            this.EventTb = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.EventTb)).BeginInit();
            this.SuspendLayout();
            // 
            // EventTb
            // 
            this.EventTb.AllowUserToAddRows = false;
            this.EventTb.AllowUserToDeleteRows = false;
            this.EventTb.BackgroundColor = System.Drawing.Color.White;
            this.EventTb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EventTb.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EventTb.Location = new System.Drawing.Point(3, 3);
            this.EventTb.Name = "EventTb";
            this.EventTb.ReadOnly = true;
            this.EventTb.RowHeadersWidth = 51;
            this.EventTb.RowTemplate.Height = 24;
            this.EventTb.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.EventTb.Size = new System.Drawing.Size(971, 541);
            this.EventTb.TabIndex = 0;
            // 
            // StEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.EventTb);
            this.Name = "StEvent";
            this.Size = new System.Drawing.Size(977, 547);
            this.Load += new System.EventHandler(this.StEvent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EventTb)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView EventTb;
    }
}
