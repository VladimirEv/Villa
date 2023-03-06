using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MagicVilla_VillaApi.Models.Models.DTO.VillaNumberDTO
{
    public class VillaNumberDTO 
    {
        [Required] 
        public int VillaNo { get; set; }

        [Required]
        public int VillaID { get; set; }  

        public string SpecialDetails { get; set; }

        public DateTime CreatedDate { get; set; }   
        public DateTime UpdatedDate { get; set;}
    }
}
