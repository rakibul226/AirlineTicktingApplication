namespace TicktingApplication
{
    partial class userBookedTickert
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
            this.userBookedTicket = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.userBookedTicket)).BeginInit();
            this.SuspendLayout();
            // 
            // userBookedTicket
            // 
            this.userBookedTicket.AllowUserToAddRows = false;
            this.userBookedTicket.AllowUserToDeleteRows = false;
            this.userBookedTicket.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.userBookedTicket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userBookedTicket.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.userBookedTicket.Location = new System.Drawing.Point(29, 141);
            this.userBookedTicket.Name = "userBookedTicket";
            this.userBookedTicket.ReadOnly = true;
            this.userBookedTicket.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.userBookedTicket.RowTemplate.Height = 24;
            this.userBookedTicket.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.userBookedTicket.Size = new System.Drawing.Size(742, 169);
            this.userBookedTicket.TabIndex = 38;
            // 
            // userBookedTickert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.userBookedTicket);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "userBookedTickert";
            this.Text = "userBookedTickert";
            this.Load += new System.EventHandler(this.userBookedTickert_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userBookedTicket)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView userBookedTicket;
    }
}