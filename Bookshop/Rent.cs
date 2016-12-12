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
    public partial class Rent_Form : Form
    {
        int totalPrice;

        public Rent_Form()
        {
            InitializeComponent();
            rent_rdb.Checked = true;
            rentBook_dgv.Columns[4].Visible = false;
        }

        private void calCash_btn_Click(object sender, EventArgs e)
        {
            if (rent_rdb.Checked)
            {
                CashChange_Form cc = new CashChange_Form();
                cc.Show();
                
                for (int i = 0; i < rentBook_dgv.Rows.Count; i++)
                {
                    int temp = int.Parse(rentBook_dgv.Rows[i].Cells[3].ToString());
                    totalPrice += temp;
                }
            }
        }

        private void showName_txt_TextChanged(object sender, EventArgs e)
        {
            searchBook_txt.Enabled = true;
        }

        private void delData_Click(object sender, EventArgs e)
        {
            string ID = rentBook_dgv.SelectedRows[0].Cells[4].Value.ToString();
            string status = "update Store_tbl set Status='A' where ID=" + ID;
            Sql database = new Sql();
            database.InsertDel(status);

            rentBook_dgv.Rows.RemoveAt(rentBook_dgv.SelectedRows[0].Index);

            for (int i = 0; i < rentBook_dgv.Rows.Count; i++)
            {
                rentBook_dgv.Rows[i].Cells[0].Value = i + 1;
            }
        }

        private void Rent_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            CashChange_Form cc = new CashChange_Form();
            cc.Close();
        }

        private void searchCus_txt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string ID = searchCus_txt.Text;
                string sql = "select Name, Lastname, Type from Customer_tbl where ID=" + ID;

                Sql database = new Sql();

                DataTable dt = database.DataTable(sql);

                showName_txt.Text = dt.Rows[0][0].ToString() + "  " + dt.Rows[0][1].ToString();

                if (dt.Rows[0][2].ToString() == "C")
                {
                    showType_txt.Text = "Common";
                }

                else
                {
                    showType_txt.Text = "VIP";
                }
            }

            catch
            {
                return;
            }
        }

        private void searchBook_txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    string bookID = searchBook_txt.Text;

                    string sql = "select count(*) from Store_tbl where ID=" + bookID;

                    Sql database = new Sql();

                    DataTable dt = database.DataTable(sql);


                    int rows = rentBook_dgv.Rows.Count; ;

                    if (showType_txt.Text == "Common" && dt.Rows[0][0].ToString() == "1")
                    {
                        if (rows < 5)
                        {
                            string sqlBook = "select Bookname, Volume, Price, Status, ID from Store_tbl where ID =" + bookID;

                            DataTable dtBook = database.DataTable(sqlBook);

                            if (dtBook.Rows[0][3].ToString() == "Available")
                            {
                                rentBook_dgv.Rows.Add();
                                rentBook_dgv.Rows[rows].Cells[0].Value = rows + 1;
                                rentBook_dgv.Rows[rows].Cells[1].Value = dtBook.Rows[0][0].ToString();
                                rentBook_dgv.Rows[rows].Cells[2].Value = dtBook.Rows[0][1].ToString();
                                rentBook_dgv.Rows[rows].Cells[3].Value = int.Parse(dtBook.Rows[0][2].ToString()) / 10;
                                rentBook_dgv.Rows[rows].Cells[4].Value = dtBook.Rows[0][4].ToString();

                                string status = "update Store_tbl set Status='N' where ID=" + bookID;
                                database.InsertDel(status);

                            }
                            else
                            {
                                MessageBox.Show("Can't rent this book.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }

                        }
                        else
                        {
                            MessageBox.Show("Common customer not rent more than 5.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }

                    else if (dt.Rows[0][0].ToString() == "1")
                    {
                        if (rows < 10)
                        {
                            string sqlBook = "select Bookname, Volume, Price, Status, ID from Store_tbl where ID =" + bookID;

                            DataTable dtBook = database.DataTable(sqlBook);

                            if (dtBook.Rows[0][3].ToString() == "A")
                            {
                                rentBook_dgv.Rows.Add();
                                rentBook_dgv.Rows[rows].Cells[0].Value = rows + 1;
                                rentBook_dgv.Rows[rows].Cells[1].Value = dtBook.Rows[0][0].ToString();
                                rentBook_dgv.Rows[rows].Cells[2].Value = dtBook.Rows[0][1].ToString();
                                rentBook_dgv.Rows[rows].Cells[3].Value = int.Parse(dtBook.Rows[0][2].ToString()) / 10;
                                rentBook_dgv.Rows[rows].Cells[4].Value = dtBook.Rows[0][4].ToString();

                                string status = "update Book_tbl set Status='N' where ID=" + bookID;
                                database.InsertDel(status);
                            }
                            else
                            {
                                MessageBox.Show("Can't rent this book.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }

                        else
                        {
                            MessageBox.Show("VIP customer not rent more than 10.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }

                    searchBook_txt.Text = "";

                }

                catch
                {
                    return;
                }
            }
        }

        public int cash ()
        {
            return totalPrice;
        }
    }
}
