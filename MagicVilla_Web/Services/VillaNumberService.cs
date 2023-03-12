using MagicVilla_Utility;
using MagicVilla_Web.Models;
using MagicVilla_Web.Models.VillaDTO;
using MagicVilla_Web.Services.IServices;
using Microsoft.AspNetCore.Mvc;
using static MagicVilla_Utility.SD;
using System;
using MagicVilla_Web.Models.VillaNumberDTO;

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

        public Task<T> CreateAsync<T>(VillaNumberCreateDTO dto)
        {
            return SendAsync<T>(new APIRequest()
            {
                APIType = APIType.POST,
                Data = dto,
                Url = villaUrl + "/api/VillaAPINumber"
            });
        }

        public Task<T> DeleteAsync<T>(int id)
        {
            return SendAsync<T>(new APIRequest()
            {
                APIType = APIType.DELETE,
                Url = villaUrl + "/api/VillaAPINumber/" + id
            });
        }

        public Task<T> GetAllAsync<T>()
        {
            return SendAsync<T>(new APIRequest()
            {
                APIType = APIType.GET,
                Url = villaUrl + "/api/VillaAPINumber"
            });
        }

        public Task<T> GetAsync<T>(int id)
        {
            return SendAsync<T>(new APIRequest()
            {
                APIType = APIType.GET,
                Url = villaUrl + "/api/VillaAPINumber/" + id
            });
        }

        public Task<T> UpdateAsync<T>(VillaNumberUpdateDTO dto)
        {
            return SendAsync<T>(new APIRequest()
            {
                APIType = APIType.PUT,
                Data = dto,
                Url = villaUrl + "/api/VillaAPINumber/" + dto.VillaNo
            });
        }
    }
}
