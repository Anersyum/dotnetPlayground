namespace DotNetPlayground.RSI.Models;

public sealed class Opstina
{
    public int Id { get; set; }
    public string Naziv { get; set; }
    public int DrzavaId { get; set; }
    public Drzava Drzava { get; set; }
}
