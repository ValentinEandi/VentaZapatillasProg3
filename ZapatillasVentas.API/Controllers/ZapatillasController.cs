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
    public class ZapatillasController : ControllerBase
    {
        
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok("List of all zapatillas");
        }

        
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok($"Details of zapatilla with ID {id}");
        }

      
        [HttpPost]
        public IActionResult Create([FromBody] Zapatilla zapatilla)
        {
            return Ok("Zapatilla created");
        }

        
        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] Zapatilla zapatilla)
        {
            return Ok($"Zapatilla with ID {id} updated");
        }

        
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok($"Zapatilla with ID {id} deleted");
        }
    }
}


