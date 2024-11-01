using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ZapatillasVentas.Core.Entities;

namespace ZapatillasVentas.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ZapatillasController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAll() => Ok();

        [HttpGet("{id}")]
        public IActionResult GetById(int id) => Ok(); 

        [HttpPost]
        public IActionResult Create([FromBody] Zapatilla zapatilla) => Ok(); 

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] Zapatilla zapatilla) => Ok(); 

        [HttpDelete("{id}")]
        public IActionResult Delete(int id) => Ok(); 
    }
}