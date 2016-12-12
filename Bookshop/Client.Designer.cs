namespace Bookshop
{
    partial class Client_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Client_Form));
            this.rent_btn = new System.Windows.Forms.Button();
            this.store_btn = new System.Windows.Forms.Button();
            this.customer_btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.logout_btn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.show_panel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rent_btn
            // 
            this.rent_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rent_btn.FlatAppearance.BorderSize = 0;
            this.rent_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rent_btn.Font = new System.Drawing.Font("Prompt Light", 14F);
            this.rent_btn.ForeColor = System.Drawing.Color.White;
            this.rent_btn.Image = ((System.Drawing.Image)(resources.GetObject("rent_btn.Image")));
            this.rent_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rent_btn.Location = new System.Drawing.Point(-1, 169);
            this.rent_btn.Name = "rent_btn";
            this.rent_btn.Size = new System.Drawing.Size(167, 55);
            this.rent_btn.TabIndex = 7;
            this.rent_btn.Text = "Rent";
            this.rent_btn.UseVisualStyleBackColor = false;
            this.rent_btn.Click += new System.EventHandler(this.rent_btn_Click);
            // 
            // store_btn
            // 
            this.store_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.store_btn.FlatAppearance.BorderSize = 0;
            this.store_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.store_btn.Font = new System.Drawing.Font("Prompt Light", 14F);
            this.store_btn.ForeColor = System.Drawing.Color.White;
            this.store_btn.Image = ((System.Drawing.Image)(resources.GetObject("store_btn.Image")));
            this.store_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.store_btn.Location = new System.Drawing.Point(-1, 114);
            this.store_btn.Name = "store_btn";
            this.store_btn.Size = new System.Drawing.Size(167, 55);
            this.store_btn.TabIndex = 6;
            this.store_btn.Text = "    Book Store";
            this.store_btn.UseVisualStyleBackColor = false;
            this.store_btn.Click += new System.EventHandler(this.store_btn_Click);
            // 
            // customer_btn
            // 
            this.customer_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.customer_btn.FlatAppearance.BorderSize = 0;
            this.customer_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customer_btn.Font = new System.Drawing.Font("Prompt Light", 14F);
            this.customer_btn.ForeColor = System.Drawing.Color.White;
            this.customer_btn.Image = ((System.Drawing.Image)(resources.GetObject("customer_btn.Image")));
            this.customer_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.customer_btn.Location = new System.Drawing.Point(-1, 59);
            this.customer_btn.Name = "customer_btn";
            this.customer_btn.Size = new System.Drawing.Size(167, 55);
            this.customer_btn.TabIndex = 5;
            this.customer_btn.Text = "   Customer";
            this.customer_btn.UseVisualStyleBackColor = false;
            this.customer_btn.Click += new System.EventHandler(this.customer_btn_Click);
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1980, 60);
            this.panel1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Prompt Light", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(-121, -13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(691, 80);
            this.label1.TabIndex = 0;
            this.label1.Text = "      B  o  o  k  S  h  o  p";
            // 
            // logout_btn
            // 
            this.logout_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.logout_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.logout_btn.FlatAppearance.BorderSize = 0;
            this.logout_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout_btn.Font = new System.Drawing.Font("Prompt Light", 14F);
            this.logout_btn.ForeColor = System.Drawing.Color.White;
            this.logout_btn.Image = ((System.Drawing.Image)(resources.GetObject("logout_btn.Image")));
            this.logout_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logout_btn.Location = new System.Drawing.Point(0, 731);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.Size = new System.Drawing.Size(167, 55);
            this.logout_btn.TabIndex = 10;
            this.logout_btn.Text = "Log Out";
            this.logout_btn.UseVisualStyleBackColor = false;
            this.logout_btn.Click += new System.EventHandler(this.logout_btn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Location = new System.Drawing.Point(0, 58);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(167, 1080);
            this.panel2.TabIndex = 12;
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // show_panel
            // 
            this.show_panel.AllowDrop = true;
            this.show_panel.AutoSize = true;
            this.show_panel.Location = new System.Drawing.Point(168, 59);
            this.show_panel.Name = "show_panel";
            this.show_panel.Size = new System.Drawing.Size(1198, 729);
            this.show_panel.TabIndex = 13;
            // 
            // Client_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1366, 786);
            this.Controls.Add(this.show_panel);
            this.Controls.Add(this.logout_btn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.rent_btn);
            this.Controls.Add(this.store_btn);
            this.Controls.Add(this.customer_btn);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Client_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Client";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Client_Form_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button rent_btn;
        private System.Windows.Forms.Button store_btn;
        private System.Windows.Forms.Button customer_btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button logout_btn;
        private System.Windows.Forms.Panel panel2;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.Panel show_panel;
    }
}