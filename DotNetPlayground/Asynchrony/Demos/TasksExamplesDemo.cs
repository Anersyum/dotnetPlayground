using System.Net.Http.Json;
using Asynchrony.Helpers;

namespace Asynchrony.Demos;

public class TasksExamplesDemo
{
    private Dictionary<string, PokemonData> _pokemonCache = new();
    
    public async Task RunTask()
    {
        await TaskExample1Bad();
        await TaskExample1Good();
        // try
        // {
        //     TaskExample2Bad();
        // }
        // catch (Exception e)
        // {
        //     Console.WriteLine(e.Message);
        // }
        
        try
        {
            await TaskExample2Good();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }

        List<PokemonData> pokemonDataList = new()
        {
            await GetPokemonData("espeon"),
            await GetPokemonData("espeon"),
            await GetPokemonData("pikachu")
        };
        
        PokemonTableGenerator.GeneratePokemonTable(pokemonDataList);
    }
    
    // don't do this
    private static async Task TaskExample1Bad()
    {
        await Task.Delay(TimeSpan.FromSeconds(1));
    }
    
    // do this instead
    private static Task TaskExample1Good()
    {
        return Task.Delay(TimeSpan.FromSeconds(1));
    }

    // don't do async void (exception aren't caught)
    private static async void TaskExample2Bad()
    {
        await Task.Run(() => Thread.Sleep(TimeSpan.FromSeconds(3)));

        throw new Exception("Exception is thrown");
    }
    
    private static async Task TaskExample2Good()
    {
        await Task.Run(() => Thread.Sleep(TimeSpan.FromSeconds(3)));
        
        throw new Exception("Exception is thrown");
    }
    
    private async ValueTask<PokemonData> GetPokemonData(string pokemonName)
    {
        if (_pokemonCache.TryGetValue(pokemonName, out PokemonData pokemon))
        {
            return pokemon;
        }

        using HttpClient httpClient = new()
        {
            BaseAddress = new Uri("https://pokeapi.co/api/v2/pokemon")
        };

        PokemonData? fetchedPokemon = await httpClient.GetFromJsonAsync<PokemonData>(httpClient.BaseAddress + $"/{pokemonName}");

        if (fetchedPokemon is null)
        {
            throw new Exception("Pokemon doesn't exist");
        }

        return fetchedPokemon;
    }
}