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
        public CashChange_Form()
        {
            InitializeComponent();
        }

        private void CashChange_Form_Load(object sender, EventArgs e)
        {
        
        }

        public void getPrice (int price)
        {
            totalCash_lbl.Text = price.ToString();
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void calCash_btn_Click(object sender, EventArgs e)
        {
            Rent_Form rent = new Rent_Form();
            DataTable dt = (DataTable)(rent.rentBook_dgv.DataSource);

            int rows = dt.Rows.Count;
            //string cusID = dt.Rows[]
            //string sql = "insert into Rent_tbl (CustomerID, Bookname, Volume, Date) values (" + 
        }
    }
}
