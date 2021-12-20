namespace Bazon.Backend.Api.Services;

public class LoginService: ILoginService
{
    public Task<bool> Authorize(string email, string passwordHash)
    {
        throw new NotImplementedException();
    }
}