using AutoMapper;
using MagicVilla_Utility;
using MagicVilla_Web.Models;
using MagicVilla_Web.Models.Models.DTO.VillaDTO;
using MagicVilla_Web.Models.Models.DTO.VillaNumberDTO;
using MagicVilla_Web.Models.ViewModels;
using MagicVilla_Web.Services.IServices;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using System.Data;

namespace MagicVilla_Web.Controllers
{
	public class VillaNumberController : Controller
    {
		private readonly IVillaService _villaService;
		private readonly IVillaNumberService _villaNumberService;
        private readonly IMapper _mapper;


		public VillaNumberController(IVillaNumberService villaNumberService, IMapper mapper, IVillaService villaService)
        {
            _villaNumberService = villaNumberService;
            _mapper = mapper;
			_villaService = villaService;
        }

        [HttpGet]
        public async Task<IActionResult> IndexVillaNumber()
        {
            List<VillaNumberDTO> list = new();

            var responce = await _villaNumberService.GetAllAsync<APIResponse>(HttpContext.Session.GetString(SD.SessionToken));
            if (responce != null && responce.IsSuccess)
            {
                list = JsonConvert.DeserializeObject<List<VillaNumberDTO>>(Convert.ToString(responce.Result));
            }
            return View(list);
        }

        [Authorize(Roles = "admin")]
        [HttpGet]
		public async Task<IActionResult> CreateVillaNumber()
		{
			VillaNumberCreateVM villaNumberCreateVM = new VillaNumberCreateVM();
			var responce = await _villaService.GetAllAsync<APIResponse>(HttpContext.Session.GetString(SD.SessionToken));
			if (responce != null && responce.IsSuccess)
			{
				villaNumberCreateVM.VillasSelectList = JsonConvert.DeserializeObject<List<VillaDTO>>(Convert.ToString(responce.Result)).Select(
					i=> new SelectListItem 
					{
					Text = i.Name,
					Value = i.Id.ToString()
					});
			}
			return View(villaNumberCreateVM);
		}
        [Authorize(Roles = "admin")]
        [HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> CreateVillaNumber(VillaNumberCreateVM model)
		{
			if (ModelState.IsValid)
			{
				var responce = await _villaNumberService.CreateAsync<APIResponse>(model.VillaNumberCreateWeb, 
                                                         HttpContext.Session.GetString(SD.SessionToken));
				if (responce != null && responce.IsSuccess)
				{
					return RedirectToAction(nameof(IndexVillaNumber));
				}
				else
				{
					if(responce.ErrorMessages.Count > 0)
					{
						ModelState.AddModelError("ErrorMessages", responce.ErrorMessages.FirstOrDefault());
					}
				}
			}

            var resp = await _villaService.GetAllAsync<APIResponse>(HttpContext.Session.GetString(SD.SessionToken));
            if (resp != null && resp.IsSuccess)
            {
                model.VillasSelectList = JsonConvert.DeserializeObject<List<VillaDTO>>(Convert.ToString(resp.Result)).Select(
                    i => new SelectListItem
                    {
                        Text = i.Name,
                        Value = i.Id.ToString()
                    });
            }

            return View(model);
		}


        [Authorize(Roles = "admin")]
        [HttpGet]
        public async Task<IActionResult> UpdateVillaNumber(int villaId)
        {
            VillaNumberUpdateVM villaNumberUpdateVM = new VillaNumberUpdateVM();

            var responce = await _villaNumberService.GetAsync<APIResponse>(villaId, HttpContext.Session.GetString(SD.SessionToken));
            if (responce != null && responce.IsSuccess)
            {
                //дессериализуем объект в объект типа VillaDTO			
                VillaNumberDTO model = JsonConvert.DeserializeObject<VillaNumberDTO>(Convert.ToString(responce.Result));
                villaNumberUpdateVM.VillaNumberUpdateWeb = _mapper.Map<VillaNumberUpdateDTO>(model);
            }

            responce = await _villaService.GetAllAsync<APIResponse>(HttpContext.Session.GetString(SD.SessionToken));
            if (responce != null && responce.IsSuccess)
            {
                villaNumberUpdateVM.VillasSelectList = JsonConvert.DeserializeObject<List<VillaDTO>>(Convert.ToString(responce.Result)).Select(
                    i => new SelectListItem
                    {
                        Text = i.Name,
                        Value = i.Id.ToString()
                    });
                return View(villaNumberUpdateVM);
            }
            return NotFound();
        }
        [Authorize(Roles = "admin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> UpdateVillaNumber(VillaNumberUpdateVM model)
        {
            if (ModelState.IsValid)
            {
                var responce = await _villaNumberService.UpdateAsync<APIResponse>(model.VillaNumberUpdateWeb, HttpContext.Session.GetString(SD.SessionToken));
                if (responce != null && responce.IsSuccess)
                {
                    return RedirectToAction(nameof(IndexVillaNumber));
                }
                else
                {
                    if (responce.ErrorMessages.Count > 0)
                    {
                        ModelState.AddModelError("ErrorMessages", responce.ErrorMessages.FirstOrDefault());
                    }
                }
            }

            var resp = await _villaService.GetAllAsync<APIResponse>(HttpContext.Session.GetString(SD.SessionToken));
            if (resp != null && resp.IsSuccess)
            {
                model.VillasSelectList = JsonConvert.DeserializeObject<List<VillaDTO>>(Convert.ToString(resp.Result)).Select(
                    i => new SelectListItem
                    {
                        Text = i.Name,
                        Value = i.Id.ToString()
                    });
            }

            return View(model);
        }

        [Authorize(Roles = "admin")]
        [HttpGet]
        public async Task<IActionResult> DeleteVillaNumber(int villaId)
        {
            VillaNumberDeleteVM villaNumberDeleteVM = new VillaNumberDeleteVM();

            var responce = await _villaNumberService.GetAsync<APIResponse>(villaId, HttpContext.Session.GetString(SD.SessionToken));
            if (responce != null && responce.IsSuccess)
            {
                //дессериализуем объект в объект типа VillaDTO			
                VillaNumberDTO model = JsonConvert.DeserializeObject<VillaNumberDTO>(Convert.ToString(responce.Result));
                villaNumberDeleteVM.VillaNumberDeleteWeb = _mapper.Map<VillaNumberDTO>(model);
            }

            responce = await _villaService.GetAllAsync<APIResponse>(HttpContext.Session.GetString(SD.SessionToken));
            if (responce != null && responce.IsSuccess)
            {
                villaNumberDeleteVM.VillasSelectList = JsonConvert.DeserializeObject<List<VillaDTO>>(Convert.ToString(responce.Result)).Select(
                    i => new SelectListItem
                    {
                        Text = i.Name,
                        Value = i.Id.ToString()
                    });
                return View(villaNumberDeleteVM);
            }
            return NotFound();
        }
        [Authorize(Roles = "admin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteVillaNumber(VillaNumberDeleteVM model)
        {
            var responce = await _villaNumberService.DeleteAsync<APIResponse>(model.VillaNumberDeleteWeb.VillaNo, 
                                                                              HttpContext.Session.GetString(SD.SessionToken));
            if (responce != null && responce.IsSuccess)
            {
                return RedirectToAction(nameof(IndexVillaNumber));
            }
            return View(model);
        }

    }
}
