using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using RequiredAttribute = System.ComponentModel.DataAnnotations.RequiredAttribute;

namespace DotNetPlayground.Models
{
    [Table("Osoba")]
    public class Osoba
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Ime { get; set; }
        [Required]
        public string Prezime { get; set; }
        [EmailAddress]
        [Required]
        public string Email { get; set; }
        [Required]
        public DateTime? DatumRodjenja { get; set; }
        public DateTime? DatumKreiranja { get; set; }
        public string NajdrazaHrana { get; set; }
    }
}
