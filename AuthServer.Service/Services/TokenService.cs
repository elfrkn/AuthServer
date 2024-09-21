using AuthServer.Core.Configuration;
using AuthServer.Core.DTOs;
using AuthServer.Core.Models;
using AuthServer.Core.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using SharedLibrary.Configurations;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AuthServer.Service.Services
{
    public class TokenService : ITokenService
    {
        private readonly UserManager<UserApp> _userApp;
        private readonly CustomTokenOption _tokenOption;

        public TokenService(UserManager<UserApp> userApp, IOptions<CustomTokenOption> options)
        {
            _userApp = userApp;
            _tokenOption = options.Value;
        }


        //Random refresh token dönecek
        private string CreateRefreshToken()
        {
            var numberByte = new Byte[32];
            using var rnd = RandomNumberGenerator.Create();
            rnd.GetBytes(numberByte);
            return Convert.ToBase64String(numberByte);
           
        }


        private IEnumerable<Claim> GetClaim(UserApp userApp,List<String> audiences)
        {
            var userList = new List<Claim>
            {
                 new Claim(ClaimTypes.NameIdentifier,userApp.Id),
                 new Claim(JwtRegisteredClaimNames.Email,userApp.Email),
                 new Claim(ClaimTypes.Name,userApp.UserName),
                 new Claim(JwtRegisteredClaimNames.Jti,Guid.NewGuid().ToString()) //Json i kimliklendirecek.
            };

            //Bir apiye istek yapıldığında bu tokenın audience bakıp gerçekten istek yapılmaya uygun mu kontrol edecek.Değilse geri çevirecek.
            userList.AddRange(audiences.Select(x => new Claim(JwtRegisteredClaimNames.Aud, x)));
            return userList;
        }

        public TokenDto CreateToken(UserApp userApp)
        {
            throw new NotImplementedException();
        }

        public ClientTokenDto CreateTokenByClient(Client client)
        {
            throw new NotImplementedException();
        }
    }
}
