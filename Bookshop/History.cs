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
    public partial class History_Form : Form
    {
        public History_Form()
        {
            InitializeComponent();
        }

        private void History_Form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bookShopDataSet4.Login_tbl' table. You can move, or remove it, as needed.
            this.login_tblTableAdapter.Fill(this.bookShopDataSet4.Login_tbl);

        }
    }
}
