using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pokedex.Models
{
    public class PokemonCatched
    {
        public int? Id { get; set; }
        public string? Name { get; set; }

        public PokemonCatched(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public PokemonCatched(string name) { Name = name; }
    }
}
