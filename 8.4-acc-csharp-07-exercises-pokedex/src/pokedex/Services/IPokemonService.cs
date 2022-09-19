using Microsoft.AspNetCore.Mvc;
using pokedex.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pokedex.Services
{
    public interface IPokemonService
    {
        PokemonCatched Add(PokemonCatched element);
        IEnumerable<PokemonCatched> GetAllItems();
        PokemonCatched GetById(int id);
        bool Put(int id, PokemonCatched changedPokemon);
        bool Remove(int id);
    }
}
