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
    public class VentasController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok("List of all sales");
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok($"Details of sale with ID {id}");
        }

        [HttpPost]
        public IActionResult Create([FromBody] Venta venta)
        {
            return Ok("Sale created");
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] Venta venta)
        {
            return Ok($"Sale with ID {id} updated");
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok($"Sale with ID {id} deleted");
        }
    }
}

