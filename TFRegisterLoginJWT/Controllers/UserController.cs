using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TFRegisterLoginJWT.Data;
using TFRegisterLoginJWT.Data.Models;
using TFRegisterLoginJWT.Interfaces;

namespace TFRegisterLoginJWT.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class UserController : ControllerBase
	{
		private readonly IUserService _userService;

		public UserController(IUserService userService)
		{
			_userService = userService;
		}

		[HttpGet]
		[Authorize]
		public async Task<ServiceResponse<List<User>>> GetUsers()
		{
			return await _userService.GetUsers();
		}
	}
}
