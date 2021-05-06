using System;
using System.Data;
using System.Data.SqlClient;

namespace ForumOppgave
{
    class Program
    {
        static void Main(string[] args)
        {
            DataSet ds = new DataSet();
            SqlParameter[] p = new SqlParameter[1];
            string Query = "Describe Query Information/either sp, text or TableDirect";
            DbConnectionHelper dbh = new DbConnectionHelper();
            ds = dbh.DBConnection("Post", p, "", CommandType.StoredProcedure);
        }
    }
}
