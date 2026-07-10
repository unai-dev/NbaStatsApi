using NbaStatsApi.Features.Auth.DTOs;

namespace NbaStatsApi.Features.Auth.Services
{
    public interface IAuthService
    {
        Task<AuthResponse> Login(AuthCredentials authCredentials);
        Task<AuthResponse> Register(AuthCredentials authCredentials);
    }
}