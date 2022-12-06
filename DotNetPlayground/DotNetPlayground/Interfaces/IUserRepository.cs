using DotNetPlayground.Models;

namespace DotNetPlayground.Interfaces;

public interface IUserRepository
{
    Task<List<User>> GetAllUsers(); 
}
