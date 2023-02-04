using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;

namespace DotNetPlayground.RSI.Models;

public sealed class Student
{
    public int Id { get; set; }
    public string Ime { get; set; }
    public string Prezime { get; set; }
    public string BrojIndeksa { get; set; }
    [ForeignKey("Drzava")]
    public int DrzavaRodjenjaId { get; set; }
    public Drzava DrzavaRodjenja { get; set; }
    [ForeignKey("Opstina")]
    public string OpstinaRodjenjaId { get; set; }
    public Opstina OpstinaRodjenja { get; set; }
    public DateTime DatumDodavanja { get; set; }
    public byte[] ProfilnaSlika { get; set; }
}
