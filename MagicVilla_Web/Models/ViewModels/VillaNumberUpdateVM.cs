using MagicVilla_Web.Models.Models.DTO.VillaDTO;
using MagicVilla_Web.Models.Models.DTO.VillaNumberDTO;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MagicVilla_Web.Models.ViewModels
{
	public class VillaNumberUpdateVM
    {
		public VillaNumberUpdateVM()
		{
            VillaNumberUpdateWeb = new VillaNumberUpdateDTO();
        }

		[ValidateNever]
        public IEnumerable<SelectListItem> VillasSelectList { get; set; }

		public VillaNumberUpdateDTO VillaNumberUpdateWeb { get; set; }
	}
}
