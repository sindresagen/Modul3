using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace ForumOppgave
{
    class DbConnectionHelper
    {
        public DataSet DBConnection(string TableName, SqlParameter[] p, string Query, CommandType cmdText)
        {
            string connString = @"Data Source=(localdb)\MSSQLLocalDB; Initial Catalog=ForumOppgave;Integrated Security=True";
            DataSet ds = new DataSet();
            SqlConnection con = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter sda = new SqlDataAdapter();
            try
            {
                con.ConnectionString = connString;
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                if (cmdText == CommandType.StoredProcedure)
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = Query;

                    if (p.Length > 0)
                    {
                        for (int i = 0; i < p.Length; i++)
                        {
                            cmd.Parameters.Add(p[i]);
                        }
                    }
                }

                if (cmdText == CommandType.Text)
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = Query;
                }

                if (cmdText == CommandType.TableDirect)
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = Query;
                }

                cmd.Connection = con;
                sda.SelectCommand = cmd;
                sda.Fill(ds, TableName);
                con.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return ds;
        }

    }
}
