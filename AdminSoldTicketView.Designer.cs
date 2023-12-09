namespace TicktingApplication
{
    partial class AdminSoldTicketView
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
            this.SoldTicker = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SoldTicker)).BeginInit();
            this.SuspendLayout();
            // 
            // SoldTicker
            // 
            this.SoldTicker.AllowUserToAddRows = false;
            this.SoldTicker.AllowUserToDeleteRows = false;
            this.SoldTicker.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.SoldTicker.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SoldTicker.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.SoldTicker.Location = new System.Drawing.Point(29, 88);
            this.SoldTicker.Name = "SoldTicker";
            this.SoldTicker.ReadOnly = true;
            this.SoldTicker.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.SoldTicker.RowTemplate.Height = 24;
            this.SoldTicker.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SoldTicker.Size = new System.Drawing.Size(742, 222);
            this.SoldTicker.TabIndex = 37;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Red;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(752, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 36);
            this.label8.TabIndex = 38;
            this.label8.Text = "X";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // SoldTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.SoldTicker);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SoldTicket";
            this.Text = "SoldTicket";
            this.Load += new System.EventHandler(this.SoldTicket_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SoldTicker)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView SoldTicker;
        private System.Windows.Forms.Label label8;
    }
}