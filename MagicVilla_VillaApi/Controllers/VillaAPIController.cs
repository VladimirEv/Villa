using MagicVilla_VillaApi.Models;
using MagicVilla_VillaApi.Models.Models.DTO;
using Microsoft.AspNetCore.Mvc;

namespace MagicVilla_VillaApi.Controllers
{
    //[Route("api/[controller]")]
    [Route("api/VillaAPI")]
    [ApiController]
    public class VillaAPIController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<VillaDTO> GetVillas()
        {           
            return new List<VillaDTO>
            {
                new VillaDTO{Id = 1, Name = "Pool View"},
                new VillaDTO{Id = 2, Name = "Beach View"}
            };
        }
    }
}
