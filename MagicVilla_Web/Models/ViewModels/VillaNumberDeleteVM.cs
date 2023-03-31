using MagicVilla_Web.Models.Models.DTO.VillaNumberDTO;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MagicVilla_Web.Models.ViewModels
{
	public class VillaNumberDeleteVM
    {
		public VillaNumberDeleteVM()
		{
			VillaNumberDeleteWeb = new VillaNumberDTO();
        }

		[ValidateNever]
        public IEnumerable<SelectListItem> VillasSelectList { get; set; }

		public VillaNumberDTO VillaNumberDeleteWeb { get; set; }
	}
}
