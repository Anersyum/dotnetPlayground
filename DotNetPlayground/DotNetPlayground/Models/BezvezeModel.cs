using System.ComponentModel.DataAnnotations.Schema;

namespace DotNetPlayground.Models;

//[Table("nananana")]
public sealed class BezvezeModel
{
    public int Id { get; set; }
    public string Name { get; set; }
}
