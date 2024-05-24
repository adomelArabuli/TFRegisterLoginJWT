using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Diagnostics;
using TFRegisterLoginJWT.Data;
using TFRegisterLoginJWT.Data.DTO;
using TFRegisterLoginJWT.Interfaces;

namespace TFRegisterLoginJWT.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class AuthController : ControllerBase
	{
		private readonly IAuthService _authService;

		public AuthController(IAuthService authService)
		{
			_authService = authService;
		}

		[HttpPost("Register")]
		public async Task<ActionResult<ServiceResponse<int>>> Register(UserRegisterDTO userRegisterDTO)
		{
			var result = await _authService.Register(userRegisterDTO);
			if(!result.Success)
				return BadRequest(result);
			return Ok(result);
		}

		[HttpPost("Login")]
		public async Task<ActionResult<ServiceResponse<string>>> Login(UserLoginDTO userLoginDTO)
		{
			var result = await _authService.Login(userLoginDTO);
			if (!result.Success)
				return BadRequest(result);
			return Ok(result);
		}
	}
}
