using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using ForumFullstackOppgave.DbModel;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ForumFullstackOppgave.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {
        // GET: api/<PostController>
        [HttpGet]
        public IEnumerable<Post> Get()
        {
            var conStr = @"Data Source=(localdb)\MSSQLLocalDB; Initial Catalog=ForumOppgave;Integrated Security=True";
            var conn = new SqlConnection(conStr);
            return conn.Query<Post>("select * from Post");
        }

        // GET api/<PostController>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // POST api/<PostController>
        [HttpPost]
        public void Post(Post post)
        {
        }

        // PUT api/<PostController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/<PostController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
