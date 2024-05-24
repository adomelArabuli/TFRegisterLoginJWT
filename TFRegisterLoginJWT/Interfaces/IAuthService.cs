using TFRegisterLoginJWT.Data;
using TFRegisterLoginJWT.Data.DTO;

namespace TFRegisterLoginJWT.Interfaces
{
	public interface IAuthService
	{
		Task<ServiceResponse<int>> Register(UserRegisterDTO model);
		Task<ServiceResponse<string>> Login(UserLoginDTO model);
	}
}
