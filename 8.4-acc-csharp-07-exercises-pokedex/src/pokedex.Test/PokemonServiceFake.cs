using Microsoft.AspNetCore.Mvc;
using pokedex.Models;
using pokedex.Services;
using System;
using System.Collections.Generic;
using System.Linq;

namespace pokemon.Test
{
    public class PokemonServiceFake : IPokemonService
    {
        private readonly List<PokemonCatched> _pokemon;
        public PokemonServiceFake()
        {
            _pokemon = new List<PokemonCatched>()
            {
                new PokemonCatched(0, "pikachu"),
                new PokemonCatched(1, "eeve"),

            };
        }

        public PokemonCatched Add(PokemonCatched newPokemon)
        {
            _pokemon.Add(newPokemon);
            return newPokemon;
        }

        public IEnumerable<PokemonCatched> GetAllItems()
        {
            return _pokemon;
        }

        public PokemonCatched GetById(int id)
        {
            var pokemon = _pokemon.Find((pokemon) => pokemon.Id == id);
            return pokemon;
        }

        public bool Put(int id, PokemonCatched changedPokemon)
        {
            var pokemon = _pokemon.Find(p => p.Id == id);
            if (pokemon == null) return false;
            var index = _pokemon.IndexOf(pokemon);
            _pokemon[index] = changedPokemon;
            return true;
        }

        public bool Remove(int id)
        {
            var pokemon = _pokemon.Find(p => p.Id == id);
            if (pokemon == null) return false;
            _pokemon.Remove(pokemon);
            return true;
        }
    }
}