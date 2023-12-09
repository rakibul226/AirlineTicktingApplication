namespace TicktingApplication
{
    partial class AdminViewOfferedTicket
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AvaibleTicketShow = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.ViewCanceledTicket = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AvaibleTicketShow)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkCyan;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(113, 381);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(293, 38);
            this.button1.TabIndex = 7;
            this.button1.Text = "View Sold Ticket";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(246, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 40);
            this.label1.TabIndex = 8;
            this.label1.Text = "Biman Bangladesh";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(322, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 27);
            this.label2.TabIndex = 10;
            this.label2.Text = "Offered Flight";
            // 
            // AvaibleTicketShow
            // 
            this.AvaibleTicketShow.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AvaibleTicketShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AvaibleTicketShow.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.AvaibleTicketShow.Location = new System.Drawing.Point(25, 184);
            this.AvaibleTicketShow.Name = "AvaibleTicketShow";
            this.AvaibleTicketShow.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.AvaibleTicketShow.RowTemplate.Height = 24;
            this.AvaibleTicketShow.Size = new System.Drawing.Size(742, 169);
            this.AvaibleTicketShow.TabIndex = 35;
            this.AvaibleTicketShow.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AvaibleTicketShow_CellContentClick);
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
            this.label8.TabIndex = 36;
            this.label8.Text = "X";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // ViewCanceledTicket
            // 
            this.ViewCanceledTicket.BackColor = System.Drawing.Color.Crimson;
            this.ViewCanceledTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewCanceledTicket.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ViewCanceledTicket.Location = new System.Drawing.Point(412, 381);
            this.ViewCanceledTicket.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ViewCanceledTicket.Name = "ViewCanceledTicket";
            this.ViewCanceledTicket.Size = new System.Drawing.Size(293, 38);
            this.ViewCanceledTicket.TabIndex = 37;
            this.ViewCanceledTicket.Text = "View Canceled Ticket";
            this.ViewCanceledTicket.UseVisualStyleBackColor = false;
            this.ViewCanceledTicket.Click += new System.EventHandler(this.ViewCanceledTicket_Click);
            // 
            // AdminViewOfferedTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ViewCanceledTicket);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.AvaibleTicketShow);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminViewOfferedTicket";
            this.Text = "ViewTicket";
            this.Load += new System.EventHandler(this.ViewTicket_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AvaibleTicketShow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView AvaibleTicketShow;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button ViewCanceledTicket;
    }
}