using System;
using System.Collections.Generic;

namespace PokeShop.DATA.EF.Models
{
    public partial class Pokedex
    {
        public Pokedex()
        {
            Products = new HashSet<Product>();
        }

        public int PokedexId { get; set; }
        public string PokemonName { get; set; } = null!;
        public string Type { get; set; } = null!;
        public string? SecondaryType { get; set; }
        public int RegionId { get; set; }
        public int? PkmNum { get; set; }
        public string? Description { get; set; }

        public virtual Region Region { get; set; } = null!;
        public virtual ICollection<Product> Products { get; set; }
    }
}
