using MagicVilla_VillaApi.Models;
using MagicVilla_VillaApi.Models.Models.DTO.UserDTO;

namespace MagicVilla_VillaApi.Repository.IRepository
{
    public interface IUserRepository
    {
        bool IsUniqueUser (string username);

        Task <LoginResponceDTO> Login (LoginRequestDTO loginRequestDTO);

        Task<LocalUser> Register(RegistrationRequestDTO registrationRequestDTO);
    }
}
