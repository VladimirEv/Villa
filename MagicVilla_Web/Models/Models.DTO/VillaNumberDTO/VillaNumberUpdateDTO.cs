using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MagicVilla_Web.Models.VillaNumberDTO
{
    public class VillaNumberUpdateDTO 
    {
        [Required]
        public int VillaNo { get; set; }

        [Required]
        public int VillaID { get; set; }
 

        public string SpecialDetails { get; set; }
    }
}
