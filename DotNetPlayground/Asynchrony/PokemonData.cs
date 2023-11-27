namespace Asynchrony;

public sealed record PokemonData
{
    public int Id { get; set; }
    public string Name { get; set; }
    public IEnumerable<TypeData> Types { get; set; }
}

public sealed record TypeData
{
    public int Slot { get; set; }
    public Type Type { get; set; }
}

public sealed record Type
{
    public string Name { get; set; }
    public string Url { get; set; }
}