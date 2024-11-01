using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ZapatillasVentas.Core.Entities;

namespace ZapatillasVentas.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientesController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok("List of all clients");
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok($"Details of client with ID {id}");
        }

        [HttpPost]
        public IActionResult Create([FromBody] Cliente cliente)
        {
            return Ok("Client created");
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] Cliente cliente)
        {
            return Ok($"Client with ID {id} updated");
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok($"Client with ID {id} deleted");
        }
    }
}

