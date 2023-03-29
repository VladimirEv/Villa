using AutoMapper;
using MagicVilla_Web.Models;
using MagicVilla_Web.Models.Models.DTO.VillaDTO;
using MagicVilla_Web.Models.Models.DTO.VillaNumberDTO;
using MagicVilla_Web.Models.ViewModels;
using MagicVilla_Web.Services.IServices;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;

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

            var responce = await _villaNumberService.GetAllAsync<APIResponse>();
            if (responce != null && responce.IsSuccess)
            {
                list = JsonConvert.DeserializeObject<List<VillaNumberDTO>>(Convert.ToString(responce.Result));
            }
            return View(list);
        }

		[HttpGet]
		public async Task<IActionResult> CreateVillaNumber()
		{
			VillaNumberCreateVM villaNumberCreateVM = new VillaNumberCreateVM();
			var responce = await _villaService.GetAllAsync<APIResponse>();
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
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> CreateVillaNumber(VillaNumberCreateVM model)
		{
			if (ModelState.IsValid)
			{
				var responce = await _villaNumberService.CreateAsync<APIResponse>(model.VillaNumberCreateWeb);
				if (responce != null && responce.IsSuccess)
				{
					return RedirectToAction(nameof(IndexVillaNumber));
				}
			}
			return View(model);
		}
	}
}
