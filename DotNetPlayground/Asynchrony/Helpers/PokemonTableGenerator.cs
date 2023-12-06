namespace Asynchrony.Helpers;

public static class PokemonTableGenerator
{
    public static void GeneratePokemonTable(IEnumerable<PokemonData?> pokemonData)
    {
        foreach (PokemonData? pokemon in pokemonData)
        {
            if (pokemon is null)
            {
                continue;
            }

            Console.WriteLine("-------------------");
            Console.WriteLine($"Pokemon Id: {pokemon.Id}");
            Console.WriteLine($"Pokemon: {pokemon.Name}");

            foreach (TypeData typeData in pokemon.Types)
            {
                Console.WriteLine($"Type {typeData.Slot}: {typeData.Type.Name}");
            }

            Console.WriteLine("-------------------");
        }
    }
}