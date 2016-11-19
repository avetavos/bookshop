using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookshop
{
    class Sql
    {
        SqlConnection con = new SqlConnection(@"Data Source=QUANTUM-PC;Initial Catalog=bookshop;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();

        public void InsertDel (string sql)
        {
            cmd.CommandText = sql;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public SqlDataReader DataReader (string sql)
        {
            cmd.CommandText = sql;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            return reader;
        }

        public DataTable DataTable (string sql)
        {
            SqlDataAdapter sda = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Open();
            con.Close();

            return dt;
        }
    }
}
