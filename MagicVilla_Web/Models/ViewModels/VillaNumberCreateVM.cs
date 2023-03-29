using MagicVilla_Web.Models.Models.DTO.VillaDTO;
using MagicVilla_Web.Models.Models.DTO.VillaNumberDTO;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MagicVilla_Web.Models.ViewModels
{
	public class VillaNumberCreateVM
	{
		public VillaNumberCreateVM()
		{
			VillaNumberCreateWeb = new VillaNumberCreateDTO();
        }

		[ValidateNever]
        public IEnumerable<SelectListItem> VillasSelectList { get; set; }

		public VillaNumberCreateDTO VillaNumberCreateWeb { get; set; }
	}
}
