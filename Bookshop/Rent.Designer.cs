namespace Bookshop
{
    partial class Rent_Form
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.rentBook_dgv = new System.Windows.Forms.DataGridView();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bookname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rentBook_grb = new System.Windows.Forms.GroupBox();
            this.delData = new System.Windows.Forms.Button();
            this.showType_txt = new System.Windows.Forms.Label();
            this.showName_txt = new System.Windows.Forms.Label();
            this.calCash_btn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.restore_rdb = new System.Windows.Forms.RadioButton();
            this.rent_rdb = new System.Windows.Forms.RadioButton();
            this.searchBook_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.searchCus_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.rentBook_dgv)).BeginInit();
            this.rentBook_grb.SuspendLayout();
            this.SuspendLayout();
            // 
            // rentBook_dgv
            // 
            this.rentBook_dgv.AllowUserToAddRows = false;
            this.rentBook_dgv.AllowUserToDeleteRows = false;
            this.rentBook_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.rentBook_dgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.rentBook_dgv.BackgroundColor = System.Drawing.Color.White;
            this.rentBook_dgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rentBook_dgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.rentBook_dgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Prompt Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.rentBook_dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.rentBook_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rentBook_dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No,
            this.Bookname,
            this.Vol,
            this.Price,
            this.ID});
            this.rentBook_dgv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.rentBook_dgv.Location = new System.Drawing.Point(521, 38);
            this.rentBook_dgv.Name = "rentBook_dgv";
            this.rentBook_dgv.ReadOnly = true;
            this.rentBook_dgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Prompt Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.rentBook_dgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.rentBook_dgv.RowHeadersVisible = false;
            this.rentBook_dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.rentBook_dgv.Size = new System.Drawing.Size(639, 485);
            this.rentBook_dgv.TabIndex = 0;
            // 
            // No
            // 
            this.No.HeaderText = "No.";
            this.No.Name = "No";
            this.No.ReadOnly = true;
            this.No.Width = 59;
            // 
            // Bookname
            // 
            this.Bookname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Bookname.HeaderText = "Book";
            this.Bookname.Name = "Bookname";
            this.Bookname.ReadOnly = true;
            // 
            // Vol
            // 
            this.Vol.HeaderText = "Volume";
            this.Vol.Name = "Vol";
            this.Vol.ReadOnly = true;
            this.Vol.Width = 91;
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Width = 73;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            this.ID.Width = 55;
            // 
            // rentBook_grb
            // 
            this.rentBook_grb.Controls.Add(this.delData);
            this.rentBook_grb.Controls.Add(this.showType_txt);
            this.rentBook_grb.Controls.Add(this.showName_txt);
            this.rentBook_grb.Controls.Add(this.calCash_btn);
            this.rentBook_grb.Controls.Add(this.label5);
            this.rentBook_grb.Controls.Add(this.label4);
            this.rentBook_grb.Controls.Add(this.label3);
            this.rentBook_grb.Controls.Add(this.restore_rdb);
            this.rentBook_grb.Controls.Add(this.rent_rdb);
            this.rentBook_grb.Controls.Add(this.searchBook_txt);
            this.rentBook_grb.Controls.Add(this.label2);
            this.rentBook_grb.Controls.Add(this.searchCus_txt);
            this.rentBook_grb.Controls.Add(this.label1);
            this.rentBook_grb.Controls.Add(this.rentBook_dgv);
            this.rentBook_grb.Font = new System.Drawing.Font("Prompt Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.rentBook_grb.Location = new System.Drawing.Point(12, 12);
            this.rentBook_grb.Name = "rentBook_grb";
            this.rentBook_grb.Size = new System.Drawing.Size(1175, 686);
            this.rentBook_grb.TabIndex = 1;
            this.rentBook_grb.TabStop = false;
            this.rentBook_grb.Text = "Rent";
            // 
            // delData
            // 
            this.delData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.delData.FlatAppearance.BorderSize = 0;
            this.delData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delData.Font = new System.Drawing.Font("Prompt Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.delData.Location = new System.Drawing.Point(1039, 538);
            this.delData.Name = "delData";
            this.delData.Size = new System.Drawing.Size(121, 40);
            this.delData.TabIndex = 38;
            this.delData.Text = "Delete";
            this.delData.UseVisualStyleBackColor = false;
            this.delData.Click += new System.EventHandler(this.delData_Click);
            // 
            // showType_txt
            // 
            this.showType_txt.AutoSize = true;
            this.showType_txt.Location = new System.Drawing.Point(121, 160);
            this.showType_txt.Name = "showType_txt";
            this.showType_txt.Size = new System.Drawing.Size(0, 24);
            this.showType_txt.TabIndex = 37;
            // 
            // showName_txt
            // 
            this.showName_txt.AutoSize = true;
            this.showName_txt.Location = new System.Drawing.Point(121, 100);
            this.showName_txt.Name = "showName_txt";
            this.showName_txt.Size = new System.Drawing.Size(0, 24);
            this.showName_txt.TabIndex = 36;
            this.showName_txt.TextChanged += new System.EventHandler(this.showName_txt_TextChanged);
            // 
            // calCash_btn
            // 
            this.calCash_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.calCash_btn.FlatAppearance.BorderSize = 0;
            this.calCash_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calCash_btn.Location = new System.Drawing.Point(1014, 618);
            this.calCash_btn.Name = "calCash_btn";
            this.calCash_btn.Size = new System.Drawing.Size(146, 51);
            this.calCash_btn.TabIndex = 35;
            this.calCash_btn.Text = "Cash";
            this.calCash_btn.UseVisualStyleBackColor = false;
            this.calCash_btn.Click += new System.EventHandler(this.calCash_btn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 24);
            this.label5.TabIndex = 34;
            this.label5.Text = "Type of service";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 24);
            this.label4.TabIndex = 32;
            this.label4.Text = "Type : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 24);
            this.label3.TabIndex = 30;
            this.label3.Text = "Name :";
            // 
            // restore_rdb
            // 
            this.restore_rdb.AutoSize = true;
            this.restore_rdb.Location = new System.Drawing.Point(56, 300);
            this.restore_rdb.Name = "restore_rdb";
            this.restore_rdb.Size = new System.Drawing.Size(77, 28);
            this.restore_rdb.TabIndex = 29;
            this.restore_rdb.TabStop = true;
            this.restore_rdb.Text = "Return";
            this.restore_rdb.UseVisualStyleBackColor = true;
            // 
            // rent_rdb
            // 
            this.rent_rdb.AutoSize = true;
            this.rent_rdb.Location = new System.Drawing.Point(57, 260);
            this.rent_rdb.Name = "rent_rdb";
            this.rent_rdb.Size = new System.Drawing.Size(62, 28);
            this.rent_rdb.TabIndex = 28;
            this.rent_rdb.TabStop = true;
            this.rent_rdb.Text = "Rent";
            this.rent_rdb.UseVisualStyleBackColor = true;
            // 
            // searchBook_txt
            // 
            this.searchBook_txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.searchBook_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchBook_txt.Enabled = false;
            this.searchBook_txt.Location = new System.Drawing.Point(31, 387);
            this.searchBook_txt.Name = "searchBook_txt";
            this.searchBook_txt.Size = new System.Drawing.Size(465, 25);
            this.searchBook_txt.TabIndex = 26;
            this.searchBook_txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.searchBook_txt_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 360);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 24);
            this.label2.TabIndex = 25;
            this.label2.Text = "Book ID";
            // 
            // searchCus_txt
            // 
            this.searchCus_txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.searchCus_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchCus_txt.Font = new System.Drawing.Font("Prompt Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.searchCus_txt.Location = new System.Drawing.Point(121, 37);
            this.searchCus_txt.Name = "searchCus_txt";
            this.searchCus_txt.Size = new System.Drawing.Size(375, 25);
            this.searchCus_txt.TabIndex = 23;
            this.searchCus_txt.TextChanged += new System.EventHandler(this.searchCus_txt_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Prompt Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(10, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Customer ID";
            // 
            // Rent_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1199, 710);
            this.Controls.Add(this.rentBook_grb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Rent_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rent";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Rent_Form_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.rentBook_dgv)).EndInit();
            this.rentBook_grb.ResumeLayout(false);
            this.rentBook_grb.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox rentBook_grb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchCus_txt;
        private System.Windows.Forms.TextBox searchBook_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton restore_rdb;
        private System.Windows.Forms.RadioButton rent_rdb;
        private System.Windows.Forms.Button calCash_btn;
        private System.Windows.Forms.Label showType_txt;
        private System.Windows.Forms.Label showName_txt;
        private System.Windows.Forms.Button delData;
        public System.Windows.Forms.DataGridView rentBook_dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bookname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
    }
}