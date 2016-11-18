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
    public partial class Admin_Form : Form
    {
        public Admin_Form()
        {
            InitializeComponent();
        }

        private void account_btn_Click(object sender, EventArgs e)
        {
            Account_Form account = new Account_Form();
            account.TopLevel = false;
            account.AutoScroll = true;
            this.show_panel.Controls.Add(account);
            account.Show();

            Customer_Form customer = new Customer_Form();
            if (Application.OpenForms.OfType<Customer_Form>().Any()) 
            {
                customer.Close();
            }
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void customer_btn_Click(object sender, EventArgs e)
        {
            Customer_Form customer = new Customer_Form();
            customer.TopLevel = false;
            customer.AutoScroll = true;
            this.show_panel.Controls.Add(customer);
            customer.Show();
        }

        private void store_btn_Click(object sender, EventArgs e)
        {
            Manage_Form manage = new Manage_Form();
            manage.TopLevel = false;
            manage.AutoScroll = true;
            this.show_panel.Controls.Add(manage);
            manage.Show();
        }

        private void rent_btn_Click(object sender, EventArgs e)
        {
            Rent_Form rent = new Rent_Form();
            rent.TopLevel = false;
            rent.AutoScroll = true;
            this.show_panel.Controls.Add(rent);
            rent.Show();
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            this.Close();
            Login_Form login = new Login_Form();
            login.Visible = true;
        }
    }
}
