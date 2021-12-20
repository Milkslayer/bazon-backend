using Bazon.Backend.Api.Models;

namespace Bazon.Backend.Api.Services;

public interface IUserService
{
    Task<User> CreateUser(UserCreateDto userCreateDto);
    Task<User> UpdateUser(UserUpdateDto userUpdateDto);
    Task<User> DeleteUser(int userId);
}