using pokedex.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pokedex.Services
{
    public class PokemonService : IPokemonService
    {
        private readonly List<PokemonCatched> Database;
        public PokemonService(List<PokemonCatched> db)
        {
            Database = db;
        }
        public PokemonCatched Add(PokemonCatched newPokemon)
        {
            Database.Add(newPokemon);
            return newPokemon;
        }
        public IEnumerable<PokemonCatched> GetAllItems()
        {
            return Database;
        }
        public PokemonCatched GetById(int id)
        {
            var pokemon = Database.Find((pokemon) => pokemon.Id == id);
            return pokemon;
        }
        public bool Put(int id, PokemonCatched changedPokemon)
        {
            var pokemon = Database.Find(p => p.Id == id);
            if (pokemon == null) return false;
            var index = Database.IndexOf(pokemon);
            Database[index] = changedPokemon;
            return true;
        }
        public bool Remove(int id)
        {
            var pokemon = Database.Find(p => p.Id == id);
            if (pokemon == null) return false;
            Database.Remove(pokemon);
            return true;
        }
    }
}
