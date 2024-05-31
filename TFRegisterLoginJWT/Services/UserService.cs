using Microsoft.EntityFrameworkCore;
using TFRegisterLoginJWT.Data;
using TFRegisterLoginJWT.Data.Models;
using TFRegisterLoginJWT.Interfaces;

namespace TFRegisterLoginJWT.Services
{
	public class UserService : IUserService
	{
		private readonly ApplicationDbContext _db;
		public UserService(ApplicationDbContext db)
		{
			_db = db;
		}

		public async Task<ServiceResponse<List<User>>> GetUsers()
		{
			var users = await _db.Users.ToListAsync();
			return new() { Data = users, Success = true};
		}
	}
}
