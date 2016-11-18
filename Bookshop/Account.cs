﻿using System;
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
    public partial class Account_Form : Form
    {
        public Account_Form()
        {
            InitializeComponent();
            creID_txt.MaxLength = 20;
            crePass_txt.MaxLength = 20;
            reCrePass_txt.MaxLength = 20;
        }


        private void saveAcc_btn_Click(object sender, EventArgs e)
        {
            string id = creID_txt.Text;
            string pass = crePass_txt.Text;
            string rePass = reCrePass_txt.Text;
            string name = creName_txt.Text;
            string last = creLast_txt.Text;
            string gender;
            string type;

            if(creGender_cbb.Text == "Male")
            {
                gender = "Male";
            }
            else
            {
                gender = "Female";
            }

            if (creType_cbb.Text == "Administator")
            {
                type = "Admin";
            }
            else
            {
                type = "Client";
            }

            if (pass != rePass || creID_txt.Text == "")
            {
                MessageBox.Show("Username or Password incorrect.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                crePass_txt.Clear();
                reCrePass_txt.Clear();
            }
            else
            {
                try
                {
                    string sql = "insert into Customer_tbl values ('" + id + "', '" + pass + "', '" + type + "', '" + name + "', '" + last + "', '" + gender + "')";

                    Sql database = new Sql();

                    database.InsertDel(sql);

                    MessageBox.Show("Create account " + id + " success.", "Create Account", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    creID_txt.Clear();
                    crePass_txt.Clear();
                    reCrePass_txt.Clear();
                    creName_txt.Clear();
                    creLast_txt.Clear();
                    creGender_cbb.SelectedItem = null;
                    creType_cbb.SelectedItem = null;

                    delAcc_cbb.Items.Clear();
                    editAcc_cbb.Items.Clear();

                    string sqlDelAdd = "select ID from Customer_tbl";

                    SqlDataReader reader = database.DataReader(sqlDelAdd);

                    while (reader.Read())
                    {
                        delAcc_cbb.Items.Add(reader[0]);
                        editAcc_cbb.Items.Add(reader[0]);
                    }
                }
                catch
                {
                    MessageBox.Show("Infomation incorrect.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Account_Form_Load(object sender, EventArgs e)
        {
            string sql = "select ID from Customer_tbl";

            Sql database = new Sql();

            SqlDataReader reader = database.DataReader(sql);

            while (reader.Read())
            {
                delAcc_cbb.Items.Add(reader[0]);
                editAcc_cbb.Items.Add(reader[0]);
            }
        }

        private void delAcc_btn_Click(object sender, EventArgs e)
        {
            string id = delAcc_cbb.SelectedItem.ToString();
            DialogResult delAcc = MessageBox.Show("Delete " + id + " ?", "Delete Account", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (delAcc == DialogResult.Yes)
            {
                string sql = "delete from Customer_tbl where ID='" + id + "'";

                Sql database = new Sql();

                database.InsertDel(sql);

                delAcc_cbb.Items.Clear();
                editAcc_cbb.Items.Clear();

                string sqldel = "select ID from Customer_tbl";

                SqlDataReader reader = database.DataReader(sqldel);

                while (reader.Read())
                {
                    delAcc_cbb.Items.Add(reader[0]);
                    editAcc_cbb.Items.Add(reader[0]);
                }
            }
            else
            {
                delAcc_cbb.Text = "";
            }
        }

        private void editAcc_cbb_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectItem = editAcc_cbb.SelectedItem.ToString();
            string sql = "select * from Customer_tbl where ID='" + selectItem + "'";

            Sql database = new Sql();

            DataTable dt = database.DataTable(sql);

            editID_txt.Text = dt.Rows[0][0].ToString();
            editName_txt.Text = dt.Rows[0][3].ToString();
            editLast_txt.Text = dt.Rows[0][4].ToString();

            if (dt.Rows[0][5].ToString() == "Male")
            {
                editGender_cbb.SelectedItem = "Male";
            }
            else
            {
                editGender_cbb.SelectedItem = "Female";
            }

            if(dt.Rows[0][2].ToString() == "Admin")
            {
                editType_cbb.SelectedItem = "Administrator";
            }
            else
            {
                editType_cbb.SelectedItem = "Client";
            }
        }

        private void editAcc_btn_Click(object sender, EventArgs e)
        {
            string id = editID_txt.Text;
            string pass = editPass_txt.Text;
            string rePass = reEditPass_txt.Text;
            string name = editName_txt.Text;
            string last = editLast_txt.Text;
            string gender;
            string type;

            if (editGender_cbb.Text == "Male")
            {
                gender = "Male";
            }
            else
            {
                gender = "Female";
            }

            if (editType_cbb.Text == "Administrator")
            {
                type = "Admin";
            }
            else
            {
                type = "Client";
            }

            if (pass != rePass)
            {
                MessageBox.Show("Password do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                editPass_txt.Clear();
                reEditPass_txt.Clear();
            }
            else
            {
                if (pass == "")
                {
                    MessageBox.Show("Please enter password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    try
                    {
                        string sql = "update Customer_tbl set ID='" + id + "', Password='" + pass + "', Role='" + type + "', Name='" + name + "', Lastname='" + last + "', Gender='" + gender + "' where ID='" + id + "'";

                        Sql database = new Sql();

                        database.InsertDel(sql);

                        MessageBox.Show("Update success.", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        editID_txt.Clear();
                        editPass_txt.Clear();
                        reEditPass_txt.Clear();
                        editName_txt.Clear();
                        editLast_txt.Clear();
                        editGender_cbb.SelectedItem = null;
                        editType_cbb.SelectedItem = null;

                        delAcc_cbb.Items.Clear();
                        editAcc_cbb.Items.Clear();

                        string sqldel = "select ID from Customer_tbl";

                        SqlDataReader reader = database.DataReader(sqldel);

                        while (reader.Read())
                        {
                            delAcc_cbb.Items.Add(reader[0]);
                            editAcc_cbb.Items.Add(reader[0]);
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Information incorrect.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void editAcc_cbb_ValueMemberChanged(object sender, EventArgs e)
        {
            editName_txt.Clear();
            editPass_txt.Clear();
            reEditPass_txt.Clear();
            editName_txt.Clear();
            editLast_txt.Clear();
            editGender_cbb.SelectedItem = null;
            editType_cbb.SelectedItem = null;
        }
    }
}