namespace Bookshop
{
    partial class CashChange_Form
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.totalCash_lbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.change_txt = new System.Windows.Forms.TextBox();
            this.calCash_btn = new System.Windows.Forms.Button();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Prompt Light", 12F);
            this.label1.Location = new System.Drawing.Point(14, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "ค่าเช่าหนังสือรวมทั้งสิ้น";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Prompt Light", 12F);
            this.label2.Location = new System.Drawing.Point(365, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "บาท";
            // 
            // totalCash_lbl
            // 
            this.totalCash_lbl.AutoSize = true;
            this.totalCash_lbl.Font = new System.Drawing.Font("Prompt Light", 12F);
            this.totalCash_lbl.Location = new System.Drawing.Point(276, 26);
            this.totalCash_lbl.Name = "totalCash_lbl";
            this.totalCash_lbl.Size = new System.Drawing.Size(0, 24);
            this.totalCash_lbl.TabIndex = 2;
            this.totalCash_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Prompt Light", 12F);
            this.label3.Location = new System.Drawing.Point(14, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "ลูกค้าชำระเงินจำนวน";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Prompt Light", 12F);
            this.label4.Location = new System.Drawing.Point(365, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "บาท";
            // 
            // change_txt
            // 
            this.change_txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.change_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.change_txt.Font = new System.Drawing.Font("Prompt Light", 12F);
            this.change_txt.Location = new System.Drawing.Point(203, 105);
            this.change_txt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.change_txt.Name = "change_txt";
            this.change_txt.Size = new System.Drawing.Size(131, 25);
            this.change_txt.TabIndex = 5;
            // 
            // calCash_btn
            // 
            this.calCash_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.calCash_btn.FlatAppearance.BorderSize = 0;
            this.calCash_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calCash_btn.Font = new System.Drawing.Font("Prompt Light", 12F);
            this.calCash_btn.Location = new System.Drawing.Point(21, 180);
            this.calCash_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.calCash_btn.Name = "calCash_btn";
            this.calCash_btn.Size = new System.Drawing.Size(189, 50);
            this.calCash_btn.TabIndex = 6;
            this.calCash_btn.Text = "คิดเงิน";
            this.calCash_btn.UseVisualStyleBackColor = false;
            this.calCash_btn.Click += new System.EventHandler(this.calCash_btn_Click);
            // 
            // cancel_btn
            // 
            this.cancel_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cancel_btn.FlatAppearance.BorderSize = 0;
            this.cancel_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel_btn.Font = new System.Drawing.Font("Prompt Light", 12F);
            this.cancel_btn.Location = new System.Drawing.Point(217, 180);
            this.cancel_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(189, 50);
            this.cancel_btn.TabIndex = 7;
            this.cancel_btn.Text = "ยกเลิก";
            this.cancel_btn.UseVisualStyleBackColor = false;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // CashChange_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 252);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.calCash_btn);
            this.Controls.Add(this.change_txt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.totalCash_lbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Prompt", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "CashChange_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CashChange";
            this.Load += new System.EventHandler(this.CashChange_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label totalCash_lbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox change_txt;
        private System.Windows.Forms.Button calCash_btn;
        private System.Windows.Forms.Button cancel_btn;
    }
}