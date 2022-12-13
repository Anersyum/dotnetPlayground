using DotNetPlayground.Data;
using DotNetPlayground.Interfaces;
using DotNetPlayground.Models;
using Microsoft.EntityFrameworkCore;

namespace DotNetPlayground.Repositories;

public sealed class UserRepositoryNew : IUserRepository
{
    private readonly Baza _baza;

    public UserRepositoryNew(Baza baza)
    {
        _baza = baza;
    }

    public async Task<List<User>> GetAllUsers()
    {
        var users = await _baza.Users.ToListAsync();

        foreach (var user in users)
        {
            user.FavouriteFood += ", ali bosanska verzija!";
        }

        return users;
    }
}
