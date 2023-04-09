using MagicVilla_Web.Models;
using MagicVilla_Web.Models.Models.DTO.VillaNumberDTO;
using MagicVilla_Web.Services.IServices;
using static MagicVilla_Utility.SD;

namespace MagicVilla_Web.Services
{
    public class VillaNumberService : BaseService, IVillaNumberService
    {
        private readonly IHttpClientFactory _clientFactory;
        private string villaUrl;

        public VillaNumberService(IHttpClientFactory clientFactory, IConfiguration configuration) : base(clientFactory)
        {
            _clientFactory = clientFactory;
            villaUrl = configuration.GetValue<string>("ServiceUrls:VillaAPI"); // "ServiceUrls:VillaAPI" из appsettings.json
        }

        public Task<T> CreateAsync<T>(VillaNumberCreateDTO dto, string token)
        {
            return SendAsync<T>(new APIRequest()
            {
                APIType = APIType.POST,
                Data = dto,
                Url = villaUrl + "/api/VillaAPINumber",
                Token = token
            });
        }

        public Task<T> DeleteAsync<T>(int id, string token)
        {
            return SendAsync<T>(new APIRequest()
            {
                APIType = APIType.DELETE,
                Url = villaUrl + "/api/VillaAPINumber/" + id,
                Token = token   
            });
        }

        public Task<T> GetAllAsync<T>(string token)
        {
            return SendAsync<T>(new APIRequest()
            {
                APIType = APIType.GET,
                Url = villaUrl + "/api/VillaAPINumber",
                Token = token
            });
        }

        public Task<T> GetAsync<T>(int id, string token)
        {
            return SendAsync<T>(new APIRequest()
            {
                APIType = APIType.GET,
                Url = villaUrl + "/api/VillaAPINumber/" + id,
                Token = token
            });
        }

        public Task<T> UpdateAsync<T>(VillaNumberUpdateDTO dto, string token)
        {
            return SendAsync<T>(new APIRequest()
            {
                APIType = APIType.PUT,
                Data = dto,
                Url = villaUrl + "/api/VillaAPINumber/" + dto.VillaNo,
                Token = token
            });
        }
    }
}
