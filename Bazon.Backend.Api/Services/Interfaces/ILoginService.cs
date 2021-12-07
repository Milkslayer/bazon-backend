namespace Bazon.Backend.Api.Services;

public interface ILoginService
{
    Task<bool> Authorize(string email, string passwordHash);
}