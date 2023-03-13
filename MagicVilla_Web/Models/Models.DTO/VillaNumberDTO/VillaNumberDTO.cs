using System.ComponentModel.DataAnnotations;
using VLDTO = MagicVilla_Web.Models.VillaDTO;

namespace MagicVilla_Web.Models.VillaNumberDTO
{
    public class VillaNumberDTO 
    {
        [Required] 
        public int VillaNo { get; set; }

        [Required]
        public int VillaID { get; set; }  

        public string SpecialDetails { get; set; }

		public VLDTO.VillaDTO Villa { get; set; }

	}
}
