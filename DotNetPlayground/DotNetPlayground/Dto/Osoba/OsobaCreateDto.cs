using System.ComponentModel.DataAnnotations;

namespace DotNetPlayground.Dto.Osoba
{
    public class OsobaCreateDto
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
