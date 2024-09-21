using AuthServer.Core.DTOs;
using SharedLibrary.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthServer.Core.Services
{
    public interface IAuthenticationService
    {
        Task<Response<TokenDto>> CreateTokenAsync(LoginDto loginDto);
        Task<Response<TokenDto>> CreateTokenByRefreshAsync(string refreshToken);
        Task<Response<NoDataDto>> RevokeRefrehToken(string refreshToken);// refresh tokenı kırmak için,nulla çevirmek için
        Task<Response<ClientTokenDto>> CreateTokenByClient(ClientTokenDto clientTokenDto);
    }
}
