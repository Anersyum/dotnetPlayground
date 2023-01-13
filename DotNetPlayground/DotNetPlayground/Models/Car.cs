using System.ComponentModel.DataAnnotations.Schema;

namespace DotNetPlayground.Models
{
    [Table("Cars")]
    public class Car
    {
        public int Id { get; set; }
        public string Tip { get; set; }
        public string Marka { get; set; }
        public string ? DatumKreiranja { get; set; }
    }
}
