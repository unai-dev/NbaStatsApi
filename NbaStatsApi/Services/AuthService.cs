using Azure;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using NbaStatsApi.Contracts;
using NbaStatsApi.DTOs;
using NbaStatsApi.Entities;
using NbaStatsApi.Exceptions;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace NbaStatsApi.Services;

public class AuthService : IAuthService
{
    private readonly SignInManager<User> _signInManager;
    private readonly UserManager<User> _userManager;
    private readonly IConfiguration _configuration;

    public AuthService(SignInManager<User> signInManager, UserManager<User> userManager, IConfiguration configuration)
    {
        this._signInManager = signInManager;
        this._userManager = userManager;
        this._configuration = configuration;
    }

    public async Task<AuthResponse> Register(AuthCredentials authCredentials)
    {
        var user = new User
        {
            Email = authCredentials.Email,
            UserName = authCredentials.Email
        };

        var result = await _userManager.CreateAsync(user, authCredentials.Password);

        if (!result.Succeeded)
        {
            throw new BadRequestException("Fallo al registrar el usuario");
        }

        var response = await GenerateJwtToken(authCredentials.Email);

        if (response.Token is null)
        {
            throw new Exception("Error interno del servidor");
        }

        return response;

    }

    public async Task<AuthResponse> Login(AuthCredentials authCredentials)
    {
        var user = await _userManager.FindByEmailAsync(authCredentials.Email);

        if (user is null)
        {
            throw new NotFoundException("Usuario no encontrado");
        }

        var result = await _signInManager.CheckPasswordSignInAsync(user, authCredentials.Password, false);

        if (!result.Succeeded)
        {
            throw new BadRequestException("Fallo al iniciar sesión. Credenciales inválidas.");
        }

        var response = await GenerateJwtToken(authCredentials.Email);
        if (response.Token is null)
        {
            throw new Exception("Error interno del servidor");
        }

        return response;
    }

    private async Task<AuthResponse> GenerateJwtToken(string email)
    {
        var claims = new List<Claim>()
        {
            new Claim("email", email)
        };

        var user = await _userManager.FindByEmailAsync(email);
        var claimsDB = await _userManager.GetClaimsAsync(user!);

        claims.AddRange(claimsDB);

        var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JWT_KEY"]!));
        var credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
        var expiration = DateTime.UtcNow.AddHours(1);

        var securityToken = new JwtSecurityToken(
            issuer: null, audience: null, claims: claims, expires: expiration, signingCredentials: credentials
            );


        return new AuthResponse
        {
            Token = new JwtSecurityTokenHandler().WriteToken(securityToken),
            Expiration = DateTime.UtcNow.AddHours(1)
        };
    }
}
