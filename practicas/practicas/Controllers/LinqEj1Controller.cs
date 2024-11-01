using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace practicas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LInqEje1Controller : ControllerBase
    {
        // GET: api/<LInqEje1Controller>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<LInqEje1Controller>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

       
    }
}
