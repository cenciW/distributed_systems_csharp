using Ficha21.Services;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Ficha21.Controllers
{
    [Route("api/contact")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        static private readonly ContactRepository _contactRepository = new ContactRepository();
        public ContactController()
        {
        }

        // GET api/<ContactController>
        [HttpGet]
        public string Get()
        {
            return JsonSerializer.Serialize(_contactRepository.GetAllContacts());
        }


        // GET api/<ContactController>/5
        [HttpGet("{id}")]
        public string Get(string id)
        {
            return _contactRepository.GetContactById(id).ToString();
        }

        // POST api/<ContactController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ContactController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ContactController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
