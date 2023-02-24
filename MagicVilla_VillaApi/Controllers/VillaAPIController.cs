using MagicVilla_VillaApi.Data;
using MagicVilla_VillaApi.Models.Models.DTO;
using Microsoft.AspNetCore.Mvc;
using System.Drawing;

namespace MagicVilla_VillaApi.Controllers
{
    //[Route("api/[controller]")]    
    //[Route("api/[controller]/[action]")]
    [Route("api/VillaAPI")]
    [ApiController]
    public class VillaAPIController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<VillaDTO>> GetVillas()
        {
            return Ok(VillaStore.villaDTOList);
        }
         
        [HttpGet("{id:int}")]
        public ActionResult<VillaDTO> GetVilla(int id)
        {
            if(id==0)
            {
                return BadRequest();
            }

            var villa = VillaStore.villaDTOList.FirstOrDefault(u => u.Id == id);

            if(villa == null)
            {
                return NotFound();
            }

            return Ok(VillaStore.villaDTOList.FirstOrDefault(i=>i.Id == id));
        }
    }
}
