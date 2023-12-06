using System.Net.Http.Json;
using Asynchrony.Helpers;

namespace Asynchrony.Demos;

internal static class WhenAllDemo
{
    public static async Task Run(HttpClient httpClient)
    {
        try
        {
            Console.WriteLine("Task one started:");
            Task<PokemonData?> espeon = GetPokemonData("golduck");

            Console.WriteLine("Task two started:");
            Task<PokemonData?> arcanine = GetPokemonData("arcanine");

            Console.WriteLine("Awaiting all to finish:");
            await Task.WhenAll(new Task[] { espeon, arcanine });
            Console.WriteLine("All finished.");

            PokemonData?[] data = { espeon.Result, arcanine.Result };
            PokemonTableGenerator.GeneratePokemonTable(data);
        }
        catch
        {
            Console.WriteLine("Error");
        }

        Task<PokemonData?> GetPokemonData(string pokemonName)
        {
            return Task.Run(() =>
            {
                Thread.Sleep(Random.Shared.Next(3000, 6000));
                return httpClient.GetFromJsonAsync<PokemonData>(httpClient.BaseAddress + $"/{pokemonName}");
            });
        }
    }
}