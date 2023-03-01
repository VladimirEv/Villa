using AutoMapper;
using MagicVilla_VillaApi.Models;
using MagicVilla_VillaApi.Models.Models.DTO.VillaDTO.VillaDTO;

namespace MagicVilla_VillaApi
{
    public class MappingConfig : Profile
    {
        public MappingConfig()
        {
            CreateMap<Villa, VillaNumberCreateDTO>().ReverseMap();

            CreateMap<Villa, VillaCreateDTO>().ReverseMap();
            CreateMap<Villa, VillaUpdateDTO>().ReverseMap();
            CreateMap<VillaNumberCreateDTO, VillaCreateDTO>().ReverseMap();
            CreateMap<VillaNumberCreateDTO, VillaUpdateDTO>().ReverseMap();
        }
    }
}
