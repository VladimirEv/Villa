using MagicVilla_VillaApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace MagicVilla_VillaApi.Controllers
{
    [Route("api/VillaAPI")]
    [ApiController]
    public class VillaAPIController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Villa> GetVillas()
        {           
            return new List<Villa>
            {
                new Villa{Id = 1, Name = "Pool View"},
                new Villa{Id = 2, Name = "Beach View"}
            };
        }
    }
}
