using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bookshop
{
    public partial class Manage_Form : Form
    {
        public Manage_Form()
        {
            InitializeComponent();
        }

        private void saveCre_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string creBook = creBook_txt.Text;
                string creVol = creVol_txt.Text;
                string crePrice = crePrice_txt.Text;
                int creValue = int.Parse(creValue_txt.Text);
                string crePublish = crePublish_txt.Text;
                string creAuthor = creAuthor_txt.Text;

                string sql = "insert into Store_tbl values ('" + creBook + "', " + creVol + ", " + crePrice + ", '" + crePublish + "', '" + creAuthor + "', 'A')";

                for (int i = 0; i < creValue; i++)
                {
                    Sql database = new Sql();
                    database.InsertDel(sql);
                }
                
                creBook_txt.Clear();
                creVol_txt.Clear();
                crePrice_txt.Clear();
                creValue_txt.Clear();
                crePublish_txt.Clear();
                creAuthor_txt.Clear();

                MessageBox.Show("Create book name " + creBook  + " " + creVol + " success.", "Create Book", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Please enter data all text box.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void search_btn_Click(object sender, EventArgs e)
        {

        }

        private void saveEdit_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string ID = searchBookID_txt.Text;
                string editBook = editBook_txt.Text;
                string editVol = editVol_txt.Text;
                string editPrice = editPrice_txt.Text;
                string editPub = editPublish_txt.Text;
                string editAuth = editAuthor_txt.Text;

                string sql = "update Store_tbl set Bookname='" + editBook + "', Volume=" + editVol + ", Price=" + editPrice + ", Publisher='" + editPub + "', Author='" + editAuth + "' where ID=" + ID;

                Sql database = new Sql();

                database.InsertDel(sql);

                searchBookID_txt.Clear();
                editBook_txt.Clear();
                editVol_txt.Clear();
                editPrice_txt.Clear();
                editPublish_txt.Clear();
                editAuthor_txt.Clear();

                MessageBox.Show("Update book detail success.", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Infomation incorrect.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void delBook_btn_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult del = MessageBox.Show("Delete this book?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (del == DialogResult.Yes)
                {
                    string name = editBook_txt.Text;
                    string sql = "delete from Store_tbl where Bookname='" + name + "'";

                    Sql database = new Sql();

                    database.InsertDel(sql);

                    searchBookID_txt.Clear();
                    editBook_txt.Clear();
                    editVol_txt.Clear();
                    editPrice_txt.Clear();
                    editPublish_txt.Clear();
                    editAuthor_txt.Clear();
                }
            }
            catch
            {
                MessageBox.Show("Can't Delete this book.", "Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void searchBookID_txt_TextChanged(object sender, EventArgs e)
        {
            editBook_txt.Clear();
            editVol_txt.Clear();
            editPrice_txt.Clear();
            editPublish_txt.Clear();
            editAuthor_txt.Clear();

            try
            {
                string searchBook = searchBookID_txt.Text;
                string sql = "select * from Store_tbl where ID=" + searchBook;

                Sql database = new Sql();

                DataTable dt = database.DataTable(sql);

                editBook_txt.Text = dt.Rows[0][1].ToString();
                editVol_txt.Text = dt.Rows[0][2].ToString();
                editPrice_txt.Text = dt.Rows[0][3].ToString();
                editPublish_txt.Text = dt.Rows[0][4].ToString();
                editAuthor_txt.Text = dt.Rows[0][5].ToString();
            }
            catch
            {
                return;
            }
        }
    }
}
