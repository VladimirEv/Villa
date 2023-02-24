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
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<IEnumerable<VillaDTO>> GetVillas()
        {
            return Ok(VillaStore.villaDTOList);
        }
         
        [HttpGet("{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        //[ProducesResponseType(200, Type = typeof(VillaDTO))]
        //[ProducesResponseType(400)]
        //[ProducesResponseType(404)]
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
