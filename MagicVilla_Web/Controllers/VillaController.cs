using AutoMapper;
using MagicVilla_Utility;
using MagicVilla_Web.Models;
using MagicVilla_Web.Models.Models.DTO.VillaDTO;
using MagicVilla_Web.Services.IServices;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace MagicVilla_Web.Controllers
{
    public class VillaController : Controller
    {
        private readonly IVillaService _villaService;
        private readonly IMapper _mapper;

        public VillaController(IVillaService villaService, IMapper mapper)
        {
            _villaService = villaService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> IndexVilla()
        {
            List<VillaDTO> list = new();

            var responce = await _villaService.GetAllAsync<APIResponse>(HttpContext.Session.GetString(SD.SessionToken));
            if(responce != null && responce.IsSuccess)
            {
                list = JsonConvert.DeserializeObject<List<VillaDTO>>(Convert.ToString(responce.Result));
            }
            return View(list);
        }

        [Authorize(Roles ="admin")]
        [HttpGet]
		public async Task<IActionResult> CreateVilla()
		{
			return View();
		}
        [Authorize(Roles = "admin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
		public async Task<IActionResult> CreateVilla(VillaCreateDTO villaCreateDTO)
		{
            if(ModelState.IsValid) 
            {
				var responce = await _villaService.CreateAsync<APIResponse>(villaCreateDTO, HttpContext.Session.GetString(SD.SessionToken));
				if (responce != null && responce.IsSuccess)
                {
                    TempData["success"] = "Villa created successfully";
                    return RedirectToAction(nameof(IndexVilla));
				}
			}
            TempData["error"] = "Error encountered.";
            return View(villaCreateDTO);
		}

        [Authorize(Roles = "admin")]
        [HttpGet]
        public async Task<IActionResult> UpdateVilla(int villaId)
        {
			var responce = await _villaService.GetAsync<APIResponse>(villaId, HttpContext.Session.GetString(SD.SessionToken));
			if (responce != null && responce.IsSuccess)
			{
				//дессериализуем объект в объект типа VillaDTO			
			    VillaDTO model = JsonConvert.DeserializeObject<VillaDTO>(Convert.ToString(responce.Result));
                return View (_mapper.Map<VillaUpdateDTO>(model));
			}
			return NotFound();
        }
        [Authorize(Roles = "admin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> UpdateVilla(VillaUpdateDTO villaUpdateDTO)
        {
            if (ModelState.IsValid)
            {
                TempData["success"] = "Villa updated successfully";
                var responce = await _villaService.UpdateAsync<APIResponse>(villaUpdateDTO, HttpContext.Session.GetString(SD.SessionToken));
                if (responce != null && responce.IsSuccess)
                {
                    return RedirectToAction(nameof(IndexVilla));
                }
            }
            TempData["error"] = "Error encountered.";
            return View(villaUpdateDTO);
        }

        [Authorize(Roles = "admin")]
        [HttpGet]
        public async Task<IActionResult> DeleteVilla(int villaId)
        {
            var responce = await _villaService.GetAsync<APIResponse>(villaId, HttpContext.Session.GetString(SD.SessionToken));
            if (responce != null && responce.IsSuccess)
            {
                //дессериализуем объект в объект типа VillaDTO			
                VillaDTO model = JsonConvert.DeserializeObject<VillaDTO>(Convert.ToString(responce.Result));
                return View(model);
            }
            return NotFound();
        }
        [Authorize(Roles = "admin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteVilla(VillaDTO villaDTO)
        {

                var responce = await _villaService.DeleteAsync<APIResponse>(villaDTO.Id, HttpContext.Session.GetString(SD.SessionToken));
                if (responce != null && responce.IsSuccess)
                {
                     TempData["success"] = "Villa deleted successfully";
                     return RedirectToAction(nameof(IndexVilla));
                }
            TempData["error"] = "Error encountered.";
            return View(villaDTO);
        }
    }
}
