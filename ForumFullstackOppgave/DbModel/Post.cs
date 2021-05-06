using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace ForumFullstackOppgave.DbModel
{
    public class Post
    {
        public string Title;
        public string PostContent;
        public string Poster;

        public Post(string title, string postContent, string poster)
        {
            Title = title;
            PostContent = postContent;
            Poster = poster;
        }

        public Post()
        {
            
        }

        private DataTable dataTable = new DataTable();

        public void PullData()
        {
            var conStr = @"Data Source=(localdb)\MSSQLLocalDB; Initial Catalog=ForumOppgave;Integrated Security=True";
            string query = "select * from Post";

            SqlConnection conn = new SqlConnection(conStr);
            SqlCommand command = new SqlCommand(query, conn);
            conn.Open();

            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(dataTable);
            conn.Close();
            da.Dispose();
        }
    }
}
