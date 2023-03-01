using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MagicVilla_VillaApi.Models.Models.DTO.VillaDTO.VillaNumberDTO
{
    public class VillaNumberDTO 
    {
        [Required] 
        public int VillaNo { get; set; }

        public string SpecialDetails { get; set; }
    }
}
