using MagicVilla_VillaApi.Models.Models.DTO;

namespace MagicVilla_VillaApi.Data
{
    public static class VillaStore
    {
        public static List<VillaDTO> villaDTOList = new List<VillaDTO>
            {
                new VillaDTO{Id = 1, Name = "Pool View"},
                new VillaDTO{Id = 2, Name = "Beach View"}
            };
    }
}
