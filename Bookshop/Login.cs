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

            string sql = "select count(*) from User_tbl where ID='" + id + "' and Password='" + pass + "'";

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
                    string sqlCheck = "select count(*) from User_tbl where ID='" + id + "' and Password='" + pass + "' and Role='A'";
                    DataTable dtCheck = database.DataTable(sqlCheck);

                    if(dtCheck.Rows[0][0].ToString() == "1")
                    {
                        this.Visible = false;
                        admin.Show();
                    }
                    else
                    {
                        this.Visible = false;
                        client.Show();
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

                string sql = "select count(*) from User_tbl where ID='" + id + "' and Password='" + pass + "'";

                Sql database = new Sql();

                DataTable dt = database.DataTable(sql);

                if (id == "" || pass == "")
                {
                    DialogResult error = MessageBox.Show("กรุณากรอกข้อมูลให้ครับทุกช่อง", "ผิดพลาก", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    if (error == DialogResult.OK)
                    {
                        id_txt.Clear();
                        pass_txt.Clear();
                    }
                }
                else
                {
                    if (dt.Rows[0][0].ToString() == "1")
                    {
                        string sqlCheck = "select count(*) from User_tbl where ID='" + id + "' and Password='" + pass + "' and Role='A'";
                        
                        DataTable dtCheck = database.DataTable(sqlCheck);

                        if (dtCheck.Rows[0][0].ToString() == "1")
                        {
                            this.Visible = false;
                            admin.Show();
                        }
                        else
                        {
                            this.Visible = false;
                            client.Show();
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
