using NbaStatsApi.DTOs;

namespace NbaStatsApi.Services;

public interface IAuthService
{
    Task<AuthResponse> Login(AuthCredentials authCredentials);
    Task<AuthResponse> Register(AuthCredentials authCredentials);
}