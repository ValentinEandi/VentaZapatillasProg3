using Microsoft.AspNetCore.Mvc;
using Persona; // Asegúrate de usar el espacio de nombres correcto
using System.Collections.Generic;
using System.Linq;
using practicas;

namespace Persona.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PersonasController : ControllerBase
    {
        [HttpPost("saludos")]
        public ActionResult<List<string>> ObtenerSaludos([FromBody] List<string> nombres)
        {
            if (nombres == null || nombres.Count != 3)
            {
                return BadRequest("Se deben proporcionar exactamente tres nombres.");
            }

            var saludos = nombres.Select(nombre => new Persona { Nombre = nombre }.GetSaludo()).ToList();
            return Ok(saludos);
        }
    }
}

