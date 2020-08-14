using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EstoqueNaoFiscal.Application.Interfaces;
using EstoqueNaoFiscal.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EstoqueNaoFiscal.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IApplicationUsers _applicationUsers;
        public UsersController(IApplicationUsers applicationUsers)
        {

            _applicationUsers = applicationUsers;

        }

        /// <summary>
        /// Get All Users
        /// </summary>
        /// <returns>Json with All Users</returns>
        [HttpGet]
        public string Get()
        {
            return JsonConvert.SerializeObject(_applicationUsers.GetAll());
        }

        /// <summary>
        /// Get Users By Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Json User</returns>
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return JsonConvert.SerializeObject(_applicationUsers.GetById(id));
        }

        // POST api/<UsersController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<UsersController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<UsersController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
