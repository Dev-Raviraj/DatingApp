using API.Entities;
using API.Services;

namespace API.Interfaces
{
    public interface ITokenService
    {
         string CreateToken(AppUser user);
    }
}