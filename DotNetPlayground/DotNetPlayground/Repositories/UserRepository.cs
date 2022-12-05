using DotNetPlayground.Data;
using DotNetPlayground.Interfaces;
using DotNetPlayground.Models;
using Microsoft.EntityFrameworkCore;

namespace DotNetPlayground.Repositories;

public class UserRepository : IUserRepository
{
    private readonly Baza _baza;

    public UserRepository(Baza baza)
    {
        _baza = baza;
    }

    public async Task<List<User>> GetAllUsers()
    {
        var users = await _baza.Users.ToListAsync();

        return users;
    }
}
