using MagicVilla_Web.Models;
using MagicVilla_Web.Models.Models.DTO.VillaDTO;
using MagicVilla_Web.Services.IServices;
using static MagicVilla_Utility.SD;

namespace MagicVilla_Web.Services
{
    public class VillaService : BaseService, IVillaService
    {
        private readonly IHttpClientFactory _clientFactory;
        private string villaUrl;

        public VillaService(IHttpClientFactory clientFactory, IConfiguration configuration) : base(clientFactory)
        {
            _clientFactory = clientFactory;
            villaUrl = configuration.GetValue<string>("ServiceUrls:VillaAPI"); // "ServiceUrls:VillaAPI" из appsettings.json
        }

        public Task<T> CreateAsync<T>(VillaCreateDTO dto, string token)
        {
            return SendAsync<T>(new APIRequest()
            {
                APIType = APIType.POST,
                Data = dto,
                Url = villaUrl + "/api/VillaAPI",
                Token = token
            });
        }

        public Task<T> DeleteAsync<T>(int id, string token)
        {
            return SendAsync<T>(new APIRequest()
            {
                APIType = APIType.DELETE,
                Url = villaUrl + "/api/VillaAPI/" + id,
                Token= token
            });
        }

        public Task<T> GetAllAsync<T>(string token)
        {
            return SendAsync<T>(new APIRequest()
            {
                APIType = APIType.GET,
                Url = villaUrl + "/api/VillaAPI",
                Token= token
            });
        }

        public Task<T> GetAsync<T>(int id, string token)
        {
            return SendAsync<T>(new APIRequest()
            {
                APIType = APIType.GET,
                Url = villaUrl + "/api/VillaAPI/" + id,
                Token = token
            });
        }

        public Task<T> UpdateAsync<T>(VillaUpdateDTO dto, string token)
        {
            return SendAsync<T>(new APIRequest()
            {
                APIType = APIType.PUT,
                Data = dto,
                Url = villaUrl + "/api/VillaAPI/" + dto.Id,
                Token= token
            });
        }
    }
}
