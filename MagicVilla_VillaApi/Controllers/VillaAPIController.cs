using MagicVilla_VillaApi.Data;
using MagicVilla_VillaApi.Logging;
using MagicVilla_VillaApi.Models.Models.DTO;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http.Json;

namespace MagicVilla_VillaApi.Controllers
{
    //[Route("api/[controller]")]    
    //[Route("api/[controller]/[action]")]
    [Route("api/VillaAPI")]
    [ApiController]
    public class VillaAPIController : ControllerBase
    {
        public readonly ILogging _logger;

        public VillaAPIController(ILogging logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<IEnumerable<VillaDTO>> GetVillas()
        {
            _logger.Log("Get all villas.", "");
            return Ok(VillaStore.villaDTOList);
        }
         
        [HttpGet("{id:int}", Name = "GetVilla")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<VillaDTO> GetVilla(int id)
        {
            if(id==0)
            {
                _logger.Log("Get villa Error with Id" + " " + id, "error");
                return BadRequest();
            }

            var villa = VillaStore.villaDTOList.FirstOrDefault(u => u.Id == id);

            if(villa == null)
            {
                _logger.Log("Get villa Error - villa = null", "error");
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

            if(VillaStore.villaDTOList.FirstOrDefault(i=>i.Name.ToLower() == villaDTO.Name.ToLower()) != null)
            {
                ModelState.AddModelError("CustomError", "Villa already Exists!");
                return BadRequest(ModelState);
            }

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

        [HttpDelete ("{id:int}", Name = "DeleteVilla")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult DeleteVilla (int id)
        {
            if(id == 0)
            {
                return BadRequest();
            }

            var villa = VillaStore.villaDTOList.FirstOrDefault(i => i.Id == id);

            if (villa == null)
            {
                return NotFound();
            }

            VillaStore.villaDTOList.Remove(villa);

            return NoContent();
        }


        [HttpPut("{id:int}", Name = "UpdateVilla")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult UpdateVilla (int id, [FromBody] VillaDTO villaDTO)
        {
            if(villaDTO == null || id != villaDTO.Id)
            {
                return BadRequest();
            }

            var villa = VillaStore.villaDTOList.FirstOrDefault(i => i.Id == id);

            villa.Name = villaDTO.Name;
            villa.Occupancy = villaDTO.Occupancy;
            villa.Sqft = villaDTO.Sqft;

            return NoContent();
        }


        [HttpPatch("{id:int}", Name = "UpdatePartialVilla")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult UpdatePartialVilla(int id, JsonPatchDocument<VillaDTO> patchDTO)
        {
            if(patchDTO == null || id == 0)
            {
                return BadRequest();
            }

            var villa = VillaStore.villaDTOList.FirstOrDefault(i => i.Id == id);

            if(villa == null)
            {
                return BadRequest();
            }

            patchDTO.ApplyTo(villa);

            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            return NoContent();
        }
    }
}
