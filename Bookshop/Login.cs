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
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
            id_txt.MaxLength = 20;
            pass_txt.MaxLength = 20;
        }

        public void login_btn_Click(object sender, EventArgs e)
        {
            string id = id_txt.Text;
            string pass = pass_txt.Text;
            Admin_Form admin = new Admin_Form();
            Client_Form client = new Client_Form();

            string sql = "select count(*) from Account_tbl where UserName='" + id + "' and Password='" + pass + "'";

            Sql database = new Sql();

            DataTable dt = database.DataTable(sql);

            if (id == "" || pass == "")
            {
                    id_txt.Clear();
                    pass_txt.Clear();
                    MessageBox.Show("ผู้ใช้ หรือ รหัสผ่านไม่ถูกต้องหรุญากรอกใหม่อีกครั้ง", "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(dt.Rows[0][0].ToString() == "1")
                {
                    string sqlCheck = "select count(*) from Account_tbl where UserName='" + id + "' and Password='" + pass + "' and Role='A'";
                    DataTable dtCheck = database.DataTable(sqlCheck);

                    if(dtCheck.Rows[0][0].ToString() == "1")
                    {
                        this.Visible = false;
                        admin.Show();

                        string getData = "select * from Account_tbl where UserName='" + id + "' and Password='" + pass + "'";
                        DataTable loginData = database.DataTable(getData);
                        string username = loginData.Rows[0][1].ToString();
                        string name = loginData.Rows[0][4].ToString();
                        string lastname = loginData.Rows[0][5].ToString();
                        string date = DateTime.Now.ToString("(HH.mm) dd-MM-yyyy");

                        string loginUpdate = "insert into Login_tbl values ('" + username + "', '" + name + "', '" + lastname + "', 'Administrator', '" + date + "', 'Login')";
                        database.InsertDel(loginUpdate);

                        admin.id = id;
                        admin.pass = pass;
                    }
                    else
                    {
                        this.Visible = false;
                        client.Show();

                        string getData = "select * from Account_tbl where UserName='" + id + "' and Password='" + pass + "'";
                        DataTable loginData = database.DataTable(getData);
                        string username = loginData.Rows[0][1].ToString();
                        string name = loginData.Rows[0][4].ToString();
                        string lastname = loginData.Rows[0][5].ToString();
                        string date = DateTime.Now.ToString("(HH.mm) dd-MM-yyyy");

                        string loginUpdate = "insert into Login_tbl values ('" + username + "', '" + name + "', '" + lastname + "', 'Client', '" + date + "', 'Login')";
                        database.InsertDel(loginUpdate);

                        client.id = id;
                        client.pass = pass;
                    }
                }
                else
                {
                    DialogResult error = MessageBox.Show("ผู้ใช้ หรือ รหัสผ่านไม่ถูกต้องหรุญากรอกใหม่อีกครั้ง", "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    if (error == DialogResult.OK)
                    {
                        id_txt.Clear();
                        pass_txt.Clear();
                    }
                }
            }
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pass_txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string id = id_txt.Text;
                string pass = pass_txt.Text;
                Admin_Form admin = new Admin_Form();
                Client_Form client = new Client_Form();

                string sql = "select count(*) from Account_tbl where UserName='" + id + "' and Password='" + pass + "'";

                Sql database = new Sql();

                DataTable dt = database.DataTable(sql);

                if (id == "" || pass == "")
                {
                    id_txt.Clear();
                    pass_txt.Clear();
                    MessageBox.Show("ผู้ใช้ หรือ รหัสผ่านไม่ถูกต้องหรุญากรอกใหม่อีกครั้ง", "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (dt.Rows[0][0].ToString() == "1")
                    {
                        string sqlCheck = "select count(*) from Account_tbl where UserName='" + id + "' and Password='" + pass + "' and Role='A'";
                        DataTable dtCheck = database.DataTable(sqlCheck);

                        if (dtCheck.Rows[0][0].ToString() == "1")
                        {
                            this.Visible = false;
                            admin.Show();

                            string getData = "select * from Account_tbl where UserName='" + id + "' and Password='" + pass + "'";
                            DataTable loginData = database.DataTable(getData);
                            string username = loginData.Rows[0][1].ToString();
                            string name = loginData.Rows[0][4].ToString();
                            string lastname = loginData.Rows[0][5].ToString();
                            string date = DateTime.Now.ToString("(HH.mm) dd-MM-yyyy");

                            string loginUpdate = "insert into Login_tbl values ('" + username + "', '" + name + "', '" + lastname + "', 'Administrator', '" + date + "', 'Login')";
                            database.InsertDel(loginUpdate);

                            admin.id = id;
                            admin.pass = pass;
                        }
                        else
                        {
                            this.Visible = false;
                            client.Show();

                            string getData = "select * from Account_tbl where UserName='" + id + "' and Password='" + pass + "'";
                            DataTable loginData = database.DataTable(getData);
                            string username = loginData.Rows[0][1].ToString();
                            string name = loginData.Rows[0][4].ToString();
                            string lastname = loginData.Rows[0][5].ToString();
                            string date = DateTime.Now.ToString("(HH.mm) dd-MM-yyyy");

                            string loginUpdate = "insert into Login_tbl values ('" + username + "', '" + name + "', '" + lastname + "', 'Client', '" + date + "', 'Login')";
                            database.InsertDel(loginUpdate);

                            client.id = id;
                            client.pass = pass;
                        }
                    }
                    else
                    {
                        DialogResult error = MessageBox.Show("ผู้ใช้ หรือ รหัสผ่านไม่ถูกต้องหรุญากรอกใหม่อีกครั้ง", "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        if (error == DialogResult.OK)
                        {
                            id_txt.Clear();
                            pass_txt.Clear();
                        }
                    }
                }
            }
        }
    }
}
