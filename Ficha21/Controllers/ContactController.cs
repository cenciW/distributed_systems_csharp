using Ficha21.Models;
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

        public IActionResult Get()
        {
            return Ok(JsonSerializer.Serialize(_contactRepository.GetAllContacts()));
        }


        // GET api/<ContactController>/5
        [HttpGet("{id}")]
        public IActionResult Get(string id)
        {
            var contact = _contactRepository.GetContactById(id);
            if (contact != null)
            {
                return Ok(JsonSerializer.Serialize(contact));
            }
            return NotFound(new { error = "Contato não encontrado." });
        }


        // POST api/<ContactController>
        [HttpPost]
        public IActionResult Post(Contact c)
        {
            if (!string.IsNullOrWhiteSpace(c.Id) && !string.IsNullOrWhiteSpace(c.Name))
            {
                _contactRepository.AddContact(c);
                // Converte o Contact para JSON e retorna com status 200
                return Ok(JsonSerializer.Serialize(c));
            }

            // Retorna um erro 400 com uma mensagem de erro
            return BadRequest(new { error = "Contato não adicionado." });
        }


        // PUT api/<ContactController>/5
        [HttpPut("{id}")]
        public IActionResult Put(Contact c)
        {
            if (_contactRepository.UpdateContact(c))
            {
                return Ok(JsonSerializer.Serialize(c));
            }
            return BadRequest(new { error = "Contato não atualizado." });
        }

        // DELETE api/<ContactController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(string id)
        {
            var contact = _contactRepository.GetContactById(id);
            if (contact != null)
            {
                _contactRepository.DeleteContact(id);
                return Ok(new { message = "Contato deletado com sucesso."});
            }
            return NotFound(new { error = "Contato não encontrado." });
        }

    }
}
