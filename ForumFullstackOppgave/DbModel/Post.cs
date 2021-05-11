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

    }
}
