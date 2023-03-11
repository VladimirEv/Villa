﻿using AutoMapper;
using MagicVilla_Web.Models;
using MagicVilla_Web.Models.VillaDTO;
using MagicVilla_Web.Services.IServices;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;

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
                    return RedirectToAction(nameof(IndexVilla));
				}
			}
			return View("IndexVilla");
		}

        [HttpGet]
        public async Task<IActionResult> UpdateVilla()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> UpdateVilla(VillaUpdateDTO villaUpdateDTO)
        {
            if (ModelState.IsValid)
            {
                var responce = await _villaService.CreateAsync<APIResponse>(villaUpdateDTO);
                if (responce != null && responce.IsSuccess)
                {
                    return RedirectToAction(nameof(IndexVilla));
                }
            }
            return View("IndexVilla");
        }
    }
}
