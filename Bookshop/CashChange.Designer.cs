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
            this.label1.Font = new System.Drawing.Font("TH SarabunPSK", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "ค่าเช่าหนังสือรวมทั้งสิ้น";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("TH SarabunPSK", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.Location = new System.Drawing.Point(313, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "บาท";
            // 
            // totalCash_lbl
            // 
            this.totalCash_lbl.AutoSize = true;
            this.totalCash_lbl.Font = new System.Drawing.Font("TH SarabunPSK", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.totalCash_lbl.Location = new System.Drawing.Point(241, 20);
            this.totalCash_lbl.Name = "totalCash_lbl";
            this.totalCash_lbl.Size = new System.Drawing.Size(0, 33);
            this.totalCash_lbl.TabIndex = 2;
            this.totalCash_lbl.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("TH SarabunPSK", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label3.Location = new System.Drawing.Point(12, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 33);
            this.label3.TabIndex = 3;
            this.label3.Text = "ลูกค้าชำระเงินจำนวน";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("TH SarabunPSK", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label4.Location = new System.Drawing.Point(313, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 33);
            this.label4.TabIndex = 4;
            this.label4.Text = "บาท";
            // 
            // change_txt
            // 
            this.change_txt.Font = new System.Drawing.Font("TH SarabunPSK", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.change_txt.Location = new System.Drawing.Point(195, 74);
            this.change_txt.Name = "change_txt";
            this.change_txt.Size = new System.Drawing.Size(100, 39);
            this.change_txt.TabIndex = 5;
            // 
            // calCash_btn
            // 
            this.calCash_btn.Font = new System.Drawing.Font("TH SarabunPSK", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.calCash_btn.Location = new System.Drawing.Point(18, 138);
            this.calCash_btn.Name = "calCash_btn";
            this.calCash_btn.Size = new System.Drawing.Size(162, 38);
            this.calCash_btn.TabIndex = 6;
            this.calCash_btn.Text = "คิดเงิน";
            this.calCash_btn.UseVisualStyleBackColor = true;
            this.calCash_btn.Click += new System.EventHandler(this.calCash_btn_Click);
            // 
            // cancel_btn
            // 
            this.cancel_btn.Font = new System.Drawing.Font("TH SarabunPSK", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.cancel_btn.Location = new System.Drawing.Point(186, 138);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(162, 38);
            this.cancel_btn.TabIndex = 7;
            this.cancel_btn.Text = "ยกเลิก";
            this.cancel_btn.UseVisualStyleBackColor = true;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // CashChange_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 193);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.calCash_btn);
            this.Controls.Add(this.change_txt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.totalCash_lbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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