using System.ComponentModel.DataAnnotations;

namespace DotNetPlayground.Models;

public sealed class User
{
    public int Id { get; set; }
    [Required]
    public string FirstName { get; set; } = "";
    public string LastName { get; set; } = "";
    public string FavouriteFood { get; set; } = ""; 
}
