using System.ComponentModel.DataAnnotations;
using VLDTO = MagicVilla_VillaApi.Models.Models.DTO.VillaDTO;
namespace MagicVilla_VillaApi.Models.Models.DTO.VillaNumberDTO
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
