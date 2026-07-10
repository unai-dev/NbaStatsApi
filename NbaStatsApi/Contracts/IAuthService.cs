using NbaStatsApi.DTOs;

namespace NbaStatsApi.Contracts;

public interface IAuthService
{
    Task<AuthResponse> Login(AuthCredentials authCredentials);
    Task<AuthResponse> Register(AuthCredentials authCredentials);
}