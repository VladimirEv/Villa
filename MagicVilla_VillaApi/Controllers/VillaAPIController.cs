using MagicVilla_VillaApi.Data;
using MagicVilla_VillaApi.Models.Models.DTO;
using Microsoft.AspNetCore.Mvc;

namespace MagicVilla_VillaApi.Controllers
{
    //[Route("api/[controller]")]
    //[Route("api/VillaAPI")]
    [Route("api/[controller]/[action]")]   
    [ApiController]
    public class VillaAPIController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<VillaDTO> GetVillas()
        {
            return VillaStore.villaDTOList;
        }

        [HttpGet]
        public VillaDTO GetVilla(int id)
        {
            return VillaStore.villaDTOList.FirstOrDefault(i=>i.Id == id);
        }
    }
}
