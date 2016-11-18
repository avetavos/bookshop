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
    public partial class Customer_Form : Form
    {
        public Customer_Form()
        {
            InitializeComponent();
            creTel_txt.MaxLength = 10;
            editTel_txt.MaxLength = 10;
        }

        private void Customer_Form_Load(object sender, EventArgs e)
        {
            creBirth_dtp.Value = DateTime.Now.AddDays(0);
            editBirth_dtp.Value = DateTime.Now.AddDays(0);
        }

        private void saveCre_btn_Click(object sender, EventArgs e)
        {
            if (creName_txt.Text == "" || creLast_txt.Text == "" || creType_cbb.Text == "" || creAdd_rtb.Text == "")
            {
                MessageBox.Show("Please enter data all text box.", "Enter", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                string creName = creName_txt.Text;
                string creLast = creLast_txt.Text;
                string creBirth = creBirth_dtp.Value.ToString("dd-MM-yyyy");
                string creGender;
                string creEmail = creEmail_txt.Text;
                string creTel = creTel_txt.Text;
                string creType;
                string creAdd = creAdd_rtb.Text;
                if (creGender_cbb.Text == "Male")
                {
                    creGender = "Male";
                }
                else
                {
                    creGender = "Female";
                }

                if (creType_cbb.Text == "Common")
                {
                    creType = "Common";
                }
                else
                {
                    creType = "VIP";
                }

                string sql = "insert into User_tbl values ('" + creName + "', '" + creLast + "', '" + creGender + "', '" + creTel + "', '" + creEmail + "', '" + creType + "', '" + creBirth + "', '" + creAdd + "')";

                Sql database = new Sql();

                database.InsertDel(sql);

                creName_txt.Clear();
                creLast_txt.Clear();
                creBirth_dtp.Value = DateTime.Today.AddDays(0);
                creEmail_txt.Clear();
                creTel_txt.Clear();
                creType_cbb.SelectedItem = null;
                creGender_cbb.SelectedItem = null;
                creAdd_rtb.Clear();

                MessageBox.Show("Create customer " + creName + " success.", "Create Customer", MessageBoxButtons.OK, MessageBoxIcon.Information);

                searchUserID_txt.Clear();
            }
        }

        private void saveEdit_btn_Click(object sender, EventArgs e)
        {
            string editName = editName_txt.Text;
            string editLast = editLast_txt.Text;
            string editBirth = editBirth_dtp.Value.ToString("dd-MM-yyyy");
            string editGender;
            string editEmail = editEmail_txt.Text;
            string editTel = editTel_txt.Text;
            string editType;
            string editAdd = editAdd_rtb.Text;
            if (editGender_cbb.Text == "Male")
            {
                editGender = "Male";
            }
            else
            {
                editGender = "Female";
            }

            if (editType_cbb.Text == "Common")
            {
                editType = "Common";
            }
            else
            {
                editType = "VIP";
            }

            string sql = "update User_tbl set Name='" + editName + "', Lastname='" + editLast + "', Gender='" + editGender + "', Tel=" + editTel + ", Email='" + editEmail + "', Type='" + editType + "', Birth='" + editBirth + "', Address='" + editAdd + "'";

            Sql database = new Sql();

            database.InsertDel(sql);

            MessageBox.Show("Update customer " + editName + " success.", "Update Customer", MessageBoxButtons.OK, MessageBoxIcon.Information);

            editName_txt.Clear();
            editLast_txt.Clear();
            editBirth_dtp.Value = DateTime.Today.AddDays(0);
            editEmail_txt.Clear();
            editTel_txt.Clear();
            editType_cbb.SelectedItem = null;
            editGender_cbb.SelectedItem = null;
            editAdd_rtb.Clear();
        }

        private void delUser_btn_Click(object sender, EventArgs e)
        {
            string delUser = searchUserID_txt.Text;

            DialogResult resultDel = MessageBox.Show("Delete " + editName_txt.Text + " ?", "Delete Customer", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultDel == DialogResult.Yes)
            {
                string sql = "delete from User_tbl where ID=" + delUser;

                Sql database = new Sql();

                database.InsertDel(sql);

                editName_txt.Clear();
                editLast_txt.Clear();
                editBirth_dtp.Value = DateTime.Today.AddDays(0);
                editEmail_txt.Clear();
                editTel_txt.Clear();
                editType_cbb.SelectedItem = null;
                editGender_cbb.SelectedItem = null;
                editAdd_rtb.Clear();
            }

            searchUserID_txt.Clear();
        }

        private void searchUserID_txt_TextChanged(object sender, EventArgs e)
        {
            editName_txt.Clear();
            editLast_txt.Clear();
            editBirth_dtp.Value = DateTime.Now.AddDays(0);
            editEmail_txt.Clear();
            editTel_txt.Clear();
            editType_cbb.SelectedItem = null;
            editGender_cbb.SelectedItem = null;
            editAdd_rtb.Clear();

            try
            {
                int temp = int.Parse(searchUserID_txt.Text);
                string sql = "select * from User_tbl where ID=" + temp;

                Sql database = new Sql();
                DataTable dt = database.DataTable(sql);

                string tempDate = dt.Rows[0][7].ToString();
                string[] stringDate = tempDate.Split('-');
                int[] date = new int[stringDate.Length];

                for (int i = 0; i < date.Length; i++)
                {
                    date[i] = int.Parse(stringDate[i]);
                }

                editName_txt.Text = dt.Rows[0][1].ToString();
                editLast_txt.Text = dt.Rows[0][2].ToString();
                editEmail_txt.Text = dt.Rows[0][5].ToString();
                editTel_txt.Text = "0" + dt.Rows[0][4].ToString();
                editAdd_rtb.Text = dt.Rows[0][8].ToString();

                if (dt.Rows[0][3].ToString() == "Male")
                {
                    editGender_cbb.SelectedItem = "Male";
                }
                else
                {
                    editGender_cbb.SelectedItem = "Female";
                }

                if (dt.Rows[0][6].ToString() == "Common")
                {
                    editType_cbb.SelectedItem = "Common";
                }
                else
                {
                    editType_cbb.SelectedItem = "VIP";
                }
                editBirth_dtp.Value = new DateTime(date[2], date[1], date[0]);
            }
            catch
            {
                return;
            }
        }
    }
}
