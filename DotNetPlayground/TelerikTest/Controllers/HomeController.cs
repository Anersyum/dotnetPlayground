using DotNetPlayground.Models;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;

namespace TelerikTest.Controllers;

public class HomeController : Controller
{
    private readonly IEnumerable<User> _users = new List<User>
    {
        new()
        {
            Id = 1,
            FirstName = "Amor",
            LastName = "Osmic",
            FavouriteFood = "Carbonara",
            DateOfBirth = DateTime.Parse("1995-12-18"),
            DateOfBirthTypeOfDateTimeOffset = DateTimeOffset.Parse("1995-12-18"),
            HiddenField = "Telerik is interesting tbh"
        },
        new()
        {
            Id = 2,
            FirstName = "Domagoj",
            LastName = "Kristov",
            FavouriteFood = "Pizza",
            DateOfBirth = DateTime.Parse("1992-03-06"),
            DateOfBirthTypeOfDateTimeOffset = DateTimeOffset.Parse("1992-03-06"),
            HiddenField = "I'm going to drive a car!"
        },
        new()
        {
            Id = 3,
            FirstName = "Saman",
            LastName = "Qaydi",
            FavouriteFood = "Sirnica/burek sa sirom (I think that it's the same)",
            DateOfBirth = DateTime.Parse("1992-03-06"),
            DateOfBirthTypeOfDateTimeOffset = DateTimeOffset.Parse("1992-03-06"),
            HiddenField = "My dog calls me! I need to go for a walk!"
        },
        new()
        {
            Id = 4,
            FirstName = "Our",
            LastName = "Pets",
            FavouriteFood = "Just food",
            DateOfBirth = DateTime.Parse("1980-02-08"),
            DateOfBirthTypeOfDateTimeOffset = DateTimeOffset.Parse("1980-02-08"),
            HiddenField = "Wuff or Meow or something"
        }
    };
    private readonly IMemoryCache _cache;

    public HomeController(IMemoryCache memoryCache)
    {
        _cache = memoryCache;
        if (_cache.Get("users") is null)
        {
            _cache.Set("users", _users);
        }

        if (_cache.Get("specialData") is null)
        {
            List<User> randomlyGeneratedUsers = new();

            for (int i = 0; i < 100; ++i)
            {
                DateTime dateOfBirth = Faker.Identification.DateOfBirth();
                User user = new()
                {
                    FirstName = Faker.Name.First(),
                    LastName = Faker.Name.Last(),
                    FavouriteFood = Faker.Lorem.Sentence(),
                    DateOfBirth = dateOfBirth,
                    DateOfBirthTypeOfDateTimeOffset = DateTimeOffset.Parse(dateOfBirth.ToString())
                };

                randomlyGeneratedUsers.Add(user);
            }

            _cache.Set("specialData", randomlyGeneratedUsers);
        }

    }

    [HttpGet]
    public IActionResult Index()
    {
        ViewData["Title"] = "Meho";

        return View();
    }

    [HttpPost]
    public IActionResult IndexReadData([DataSourceRequest] DataSourceRequest dataSourceRequest)
    {
        var ds = _users.ToDataSourceResult(dataSourceRequest);
        return Json(ds);
    }

    [HttpGet]
    public IActionResult DatePicker()
    {
        ViewData["Title"] = "Meho date picker";

        return View();
    }

    [HttpGet]
    public IActionResult ComboBox()
    {
        ViewData["Title"] = "Meho combo box";

        return View();
    }

    [HttpGet]
    public IActionResult ComboBoxReadData()
    {
        return Json(_users);
    }

    [HttpGet]
    public IActionResult Grid()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Grid_ReadData([DataSourceRequest] DataSourceRequest dataSourceRequest)
    {
        return Json(_users.ToDataSourceResult(dataSourceRequest));
    }

    [HttpPost]
    public IActionResult Grid_ReadCacheData([DataSourceRequest] DataSourceRequest dataSourceRequest)
    {
        List<User> usersCacheData = GetFromCache<List<User>>("users");

        return Json(usersCacheData.ToDataSourceResult(dataSourceRequest));
    }

    [HttpPost]
    public async Task<IActionResult> GridHidden_ReadData([DataSourceRequest] DataSourceRequest dataSourceRequest, int userId)
    {
        var hiddenField = _users.Where(u => u.Id == userId)
            .Select(u => new Field
            {
                HiddenField = u.HiddenField,
                FavouriteFood = u.FavouriteFood
            })
            .ToDataSourceResult(dataSourceRequest);

        return await Task.FromResult(Json(hiddenField));
    }

    [HttpGet]
    public async Task<IActionResult> RandomNumber(string firstName, string lastName)
    {
        UserAccess user = new()
        {
            FullName = $"{firstName} {lastName}"
        };

        return await Task.FromResult(View(user));
    }

    [HttpPost]
    public IActionResult Grid_ReadSpecialData([DataSourceRequest] DataSourceRequest request)
    {
        List<User> randomlyGeneratedUsers = GetFromCache<List<User>>("specialData");

        return Json(randomlyGeneratedUsers.ToDataSourceResult(request));
    }

    //Grid_ReadSpecialData
    [HttpPost]
    public async Task<IActionResult> Grid_UpdateCacheData(
        [DataSourceRequest] DataSourceRequest dataSourceRequest, 
        User user)
    {
        UpdateUser(user);

        return await Task.FromResult(Json(new[] { user }.ToDataSourceResult(dataSourceRequest)));
    }

    [HttpPost]
    public async Task<IActionResult> Grid_UpdateCacheDataBatch(
        [DataSourceRequest] DataSourceRequest dataSourceRequest,
        [Bind(Prefix = "models")] IEnumerable<User> users)
    {
        UpdateUsers(users);

        return await Task.FromResult(Json(users.ToDataSourceResult(dataSourceRequest)));
    }

    private T GetFromCache<T>(string key)
    {
        T cacheData;
        _cache.TryGetValue(key, out cacheData);

        return cacheData;
    }

    private void UpdateUser(User user)
    {
        List<User> usersCacheData = GetFromCache<List<User>>("users");

        foreach (var u in usersCacheData)
        {
            if (u.Id == user.Id)
            {
                u.FavouriteFood = user.FavouriteFood;
                u.DateOfBirth = user.DateOfBirth;
            }
        }

        _cache.Set("users", usersCacheData);
    }

    private void UpdateUsers(IEnumerable<User> users)
    {
        var usersCache = GetFromCache<List<User>>("users");

        foreach (var userCached in usersCache)
        {
            foreach (var user in users)
            {
                if (user.Id == userCached.Id)
                {
                    userCached.FavouriteFood = user.FavouriteFood;
                    userCached.DateOfBirth = user.DateOfBirth;
                }
            }
        }

        _cache.Set("users", usersCache);
    }
}

public class Field
{
    public string HiddenField { get; set; }
    public string FavouriteFood { get; set; }
}

public class UserAccess
{
    public string FullName { get; set; }
}