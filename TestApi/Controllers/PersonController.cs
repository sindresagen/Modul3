using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TestApi.Model;

namespace TestApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        /*
         * CRUD - Create, Read, Update, Delete
         */
        private Person[] _data = new[]
        {
            new Person() {Id = 1, Email = "per@mail.net", Name = "Per"},
            new Person() {Id = 2, Email = "pål@mail.net", Name = "Pål"},
        };

        [HttpGet("{id}")]
        public async Task<Person> GetOne(int id)
        {
            return await Task.Run(() =>  
                _data.SingleOrDefault(p=>p.Id==id)
            );
        }

        [HttpGet]
        public async Task<IEnumerable<Person>> GetMany()
        {
            return await Task.Run(() => _data);
        }

        [HttpPost]
        public async  Task<int> Create(Person person)
        {
            return await Task.Run(() => 1);
        }

        [HttpPut]
        public async Task<int> Edit(Person person)
        {
            return await Task.Run(() => 1);
        }

        [HttpDelete]
        public async Task<int> Delete(int id)
        {
            return await Task.Run(() => 1);
        }
    }
}
