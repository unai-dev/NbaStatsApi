using Microsoft.AspNetCore.Mvc;
using NbaStatsApi.Features.Auth.DTOs;
using NbaStatsApi.Features.Auth.Services;
using NbaStatsApi.Tools.Exceptions;

namespace NbaStatsApi.Features.Auth.Controllers;

[ApiController]
[Route("api/auth/")]
public class AuthController : ControllerBase
{
    private readonly IAuthService _authService;

    public AuthController(IAuthService authService)
    {
        this._authService = authService;
    }

    [HttpPost("login")]
    public async Task<ActionResult<AuthResponse>> Login([FromBody] AuthCredentials credentials)
    {
        try
        {
            var result = await _authService.Login(credentials);
            return Ok(result);
        }
        catch (BadRequestException ex)
        {
            Console.WriteLine(ex.StackTrace);
            return BadRequest(ex.Message);
        }
        catch (NotFoundException ex)
        {
            Console.WriteLine(ex.StackTrace);
            return NotFound(ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.StackTrace);
            return StatusCode(500);
        }
    }
    [HttpPost("register")]
    public async Task<ActionResult<AuthResponse>> Register([FromBody] AuthCredentials credentials)
    {
        try
        {
            var result = await _authService.Register(credentials);
            return Ok(result);
        }
        catch (BadRequestException ex)
        {
            Console.WriteLine(ex.ToString());
            return BadRequest(ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.StackTrace);
            return StatusCode(500);
        }
    }

}
