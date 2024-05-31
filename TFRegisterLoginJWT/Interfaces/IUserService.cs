using TFRegisterLoginJWT.Data;
using TFRegisterLoginJWT.Data.Models;

namespace TFRegisterLoginJWT.Interfaces
{
	public interface IUserService
	{
		Task<ServiceResponse<List<User>>> GetUsers();
	}
}
