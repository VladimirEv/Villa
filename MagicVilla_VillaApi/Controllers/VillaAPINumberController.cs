using AutoMapper;
using MagicVilla_VillaApi.Models;
using MagicVilla_VillaApi.Repository.IRepository;
using Microsoft.AspNetCore.Mvc;

namespace MagicVilla_VillaApi.Controllers
{
    [Route("api/VillaAPI")]
    [ApiController]
    public class VillaAPINumberController : ControllerBase
    {
        protected APIResponse _response;
        private readonly IVillaNumberRepository _dbVillaNumber;
        private readonly IMapper _mapper;

        public VillaAPINumberController(IVillaNumberRepository dbVillaNumber, IMapper mapper)
        {
            this._response = new ();
            _dbVillaNumber = dbVillaNumber;
            _mapper = mapper;
        }

        //public IActionResult Index()
        //{
        //    return View();
        //}
    }
}
