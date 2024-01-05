using MagicVilla.Modelos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MagicVilla.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VillaController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Villa> GetVillas()
        {
            return new List<Villa>
            {

                new Villa { Id = 1, Nombre = "Edison" },
                new Villa { Id = 2, Nombre = "Alberto" }
            };
        }
    }

}
