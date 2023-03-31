using AutoMapper;
using MagicVilla_Web.Models;
using MagicVilla_Web.Models.Models.DTO.VillaDTO;
using MagicVilla_Web.Services.IServices;
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

            var responce = await _villaService.GetAllAsync<APIResponse>();
            if(responce != null && responce.IsSuccess)
            {
                list = JsonConvert.DeserializeObject<List<VillaDTO>>(Convert.ToString(responce.Result));
            }
            return View(list);
        }


        [HttpGet]
		public async Task<IActionResult> CreateVilla()
		{
			return View();
		}
        [HttpPost]
        [ValidateAntiForgeryToken]
		public async Task<IActionResult> CreateVilla(VillaCreateDTO villaCreateDTO)
		{
            if(ModelState.IsValid) 
            {
				var responce = await _villaService.CreateAsync<APIResponse>(villaCreateDTO);
				if (responce != null && responce.IsSuccess)
                {
                    TempData["success"] = "Villa created successfully";
                    return RedirectToAction(nameof(IndexVilla));
				}
			}
            TempData["error"] = "Error encountered.";
            return View(villaCreateDTO);
		}

        [HttpGet]
        public async Task<IActionResult> UpdateVilla(int villaId)
        {
			var responce = await _villaService.GetAsync<APIResponse>(villaId);
			if (responce != null && responce.IsSuccess)
			{
				//дессериализуем объект в объект типа VillaDTO			
			    VillaDTO model = JsonConvert.DeserializeObject<VillaDTO>(Convert.ToString(responce.Result));
                return View (_mapper.Map<VillaUpdateDTO>(model));
			}
			return NotFound();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> UpdateVilla(VillaUpdateDTO villaUpdateDTO)
        {
            if (ModelState.IsValid)
            {
                TempData["success"] = "Villa updated successfully";
                var responce = await _villaService.UpdateAsync<APIResponse>(villaUpdateDTO);
                if (responce != null && responce.IsSuccess)
                {
                    return RedirectToAction(nameof(IndexVilla));
                }
            }
            TempData["error"] = "Error encountered.";
            return View(villaUpdateDTO);
        }

        [HttpGet]
        public async Task<IActionResult> DeleteVilla(int villaId)
        {
            var responce = await _villaService.GetAsync<APIResponse>(villaId);
            if (responce != null && responce.IsSuccess)
            {
                //дессериализуем объект в объект типа VillaDTO			
                VillaDTO model = JsonConvert.DeserializeObject<VillaDTO>(Convert.ToString(responce.Result));
                return View(model);
            }
            return NotFound();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteVilla(VillaDTO villaDTO)
        {

                var responce = await _villaService.DeleteAsync<APIResponse>(villaDTO.Id);
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
