using System.ComponentModel.DataAnnotations;

namespace MagicVilla_VillaApi.Models.Models.DTO
{
    public class VillaDTO //date transfer object
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        public string Name { get; set; }
    }
}
