﻿using System.ComponentModel.DataAnnotations;

namespace MagicVilla_VillaApi.Models.Models.DTO.VillaDTO.VillaNumberDTO
{
    public class VillaNumberCreateDTO 
    {
        [Required]
        public int VillaNo { get; set; }

        public string SpecialDetails { get; set; }
    }
}
