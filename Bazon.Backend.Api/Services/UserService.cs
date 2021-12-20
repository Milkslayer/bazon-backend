using Bazon.Backend.Api.Models;

namespace Bazon.Backend.Api.Services;

public class UserService : IUserService
{
    public Task<User> CreateUser(UserCreateDto userCreateDto)
    {
        throw new NotImplementedException();
    }

    public Task<User> UpdateUser(UserUpdateDto userUpdateDto)
    {
        throw new NotImplementedException();
    }

    public Task<User> DeleteUser(int userId)
    {
        throw new NotImplementedException();
    }
}