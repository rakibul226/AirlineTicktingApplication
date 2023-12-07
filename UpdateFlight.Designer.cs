namespace TicktingApplication
{
    partial class UpdateFlight
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
            this.UpdateTicketShow = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.Flight = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.From = new System.Windows.Forms.TextBox();
            this.To = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.level2 = new System.Windows.Forms.Label();
            this.Seat = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.UpdateTicketShow)).BeginInit();
            this.SuspendLayout();
            // 
            // UpdateTicketShow
            // 
            this.UpdateTicketShow.AllowUserToAddRows = false;
            this.UpdateTicketShow.AllowUserToDeleteRows = false;
            this.UpdateTicketShow.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.UpdateTicketShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UpdateTicketShow.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.UpdateTicketShow.Location = new System.Drawing.Point(27, 194);
            this.UpdateTicketShow.Name = "UpdateTicketShow";
            this.UpdateTicketShow.ReadOnly = true;
            this.UpdateTicketShow.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.UpdateTicketShow.RowTemplate.Height = 24;
            this.UpdateTicketShow.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.UpdateTicketShow.Size = new System.Drawing.Size(742, 169);
            this.UpdateTicketShow.TabIndex = 37;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(193, 372);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(216, 38);
            this.button1.TabIndex = 38;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Desktop;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button2.Location = new System.Drawing.Point(431, 372);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(216, 38);
            this.button2.TabIndex = 46;
            this.button2.Text = "Reset";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(54, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 23);
            this.label5.TabIndex = 47;
            this.label5.Text = "Flight :";
            // 
            // Flight
            // 
            this.Flight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Flight.Location = new System.Drawing.Point(48, 140);
            this.Flight.Name = "Flight";
            this.Flight.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.Flight.Size = new System.Drawing.Size(106, 30);
            this.Flight.TabIndex = 48;
            this.Flight.Text = " ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(216, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 23);
            this.label3.TabIndex = 49;
            this.label3.Text = "From :";
            // 
            // From
            // 
            this.From.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.From.Location = new System.Drawing.Point(211, 140);
            this.From.Name = "From";
            this.From.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.From.Size = new System.Drawing.Size(106, 30);
            this.From.TabIndex = 50;
            this.From.Text = " ";
            // 
            // To
            // 
            this.To.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.To.Location = new System.Drawing.Point(361, 140);
            this.To.Name = "To";
            this.To.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.To.Size = new System.Drawing.Size(106, 30);
            this.To.TabIndex = 51;
            this.To.Text = " ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(366, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 23);
            this.label1.TabIndex = 52;
            this.label1.Text = "To :";
            // 
            // Date
            // 
            this.Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date.Location = new System.Drawing.Point(501, 140);
            this.Date.Name = "Date";
            this.Date.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.Date.Size = new System.Drawing.Size(106, 30);
            this.Date.TabIndex = 53;
            this.Date.Text = " ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(509, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 23);
            this.label4.TabIndex = 54;
            this.label4.Text = "Date :";
            // 
            // level2
            // 
            this.level2.AutoSize = true;
            this.level2.BackColor = System.Drawing.Color.Transparent;
            this.level2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.level2.ForeColor = System.Drawing.Color.Black;
            this.level2.Location = new System.Drawing.Point(650, 114);
            this.level2.Name = "level2";
            this.level2.Size = new System.Drawing.Size(64, 23);
            this.level2.TabIndex = 55;
            this.level2.Text = "Seat :";
            // 
            // Seat
            // 
            this.Seat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Seat.Location = new System.Drawing.Point(643, 140);
            this.Seat.Name = "Seat";
            this.Seat.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.Seat.Size = new System.Drawing.Size(106, 30);
            this.Seat.TabIndex = 56;
            this.Seat.Text = " ";
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
            this.label8.TabIndex = 57;
            this.label8.Text = "X";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // UpdateFlight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Seat);
            this.Controls.Add(this.level2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.To);
            this.Controls.Add(this.From);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Flight);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.UpdateTicketShow);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UpdateFlight";
            this.Text = "UpdateFlight";
            this.Load += new System.EventHandler(this.UpdateFlight_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UpdateTicketShow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView UpdateTicketShow;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Flight;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox From;
        private System.Windows.Forms.TextBox To;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Date;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label level2;
        private System.Windows.Forms.TextBox Seat;
        private System.Windows.Forms.Label label8;
    }
}