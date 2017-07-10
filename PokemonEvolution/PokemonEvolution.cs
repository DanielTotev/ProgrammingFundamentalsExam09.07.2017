using System;
using System.Collections.Generic;
using System.Linq;

namespace PokemonEvolution
{

    public class Pokemon
    {
        public string Name { get; set; }
        public List<KeyValuePair<string, int>> Evolutions { get; set; }
    }
    public class PokemonEvolution
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var pokemons = new List<Pokemon>();
            while (input != "wubbalubbadubdub")
            {
                var tokens = input.Split(new[] { '-', ' ', '>' }, StringSplitOptions.RemoveEmptyEntries);
                if (tokens.Length == 1)
                {
                    var name = tokens[0];
                    if (pokemons.Any(p => p.Name == name))
                    {
                        var dublicatePokemon = pokemons.Find(p => p.Name == name);
                        Console.WriteLine($"# {dublicatePokemon.Name}");
                        foreach (var kvp in dublicatePokemon.Evolutions)
                        {
                            var evType = kvp.Key;
                            var evIndex = kvp.Value;
                            Console.WriteLine($"{evType} <-> {evIndex}");
                        }
                    }
                    input = Console.ReadLine();
                    continue;
                }
                var pokemonName = tokens[0];
                var evolutionType = tokens[1];
                var evolutionIndex = int.Parse(tokens[2]);
                //var currentEvolution = new Dictionary<string, int>();
                //currentEvolution[evolutionType] = evolutionIndex;
                if (pokemons.Any(p => p.Name == pokemonName))
                {
                    var dublicatePokemon = pokemons.Find(p => p.Name == pokemonName);
                    dublicatePokemon.Evolutions.Add(new KeyValuePair<string, int>(evolutionType, evolutionIndex));
                }
                else
                {
                    var currentPokemon = new Pokemon()
                    {
                        Name = pokemonName,
                        Evolutions = new List<KeyValuePair<string, int>>()
                    };
                   

                    currentPokemon.Evolutions.Add(new KeyValuePair<string, int>(evolutionType, evolutionIndex));
                    pokemons.Add(currentPokemon);
                }
                input = Console.ReadLine();
            }
            foreach (var pokemon in pokemons)
            {
                var pokemonName = pokemon.Name;
                var evolutions = pokemon.Evolutions;
                Console.WriteLine($"# {pokemonName}");
                foreach (var evolution in evolutions.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"{evolution.Key} <-> {evolution.Value}");
                }
            }
        }
    }
}
