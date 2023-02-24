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
         
        [HttpGet("{id:int}", Name = "GetVilla")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        //[ProducesResponseType(200, Type = typeof(VillaDTO))]
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

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<VillaDTO> CreateVilla([FromBody] VillaDTO villaDTO)
        {
            //if(!ModelState.IsValid)
            //{
            //    return BadRequest(ModelState);
            //}

            if (villaDTO == null) 
            {
                return BadRequest(villaDTO);
            }

            if(villaDTO.Id > 0) 
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }

            villaDTO.Id = VillaStore.villaDTOList.OrderByDescending(u => u.Id).FirstOrDefault().Id + 1;

            VillaStore.villaDTOList.Add(villaDTO);

            return CreatedAtRoute("GetVilla", new { id = villaDTO.Id}, villaDTO);
        }
    }
}
