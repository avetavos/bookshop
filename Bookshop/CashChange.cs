using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bookshop
{
    public partial class CashChange_Form : Form
    {
        public int price;
        public CashChange_Form()
        {
            InitializeComponent();
        }

        private void CashChange_Form_Load(object sender, EventArgs e)
        {
            totalCash_lbl.Text = price.ToString();
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void calCash_btn_Click(object sender, EventArgs e)
        {

        }
    }
}
