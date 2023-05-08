using System;
using System.Collections.Generic;

namespace PokeShop.DATA.EF.Models
{
    public partial class Region
    {
        public Region()
        {
            Pokedices = new HashSet<Pokedex>();
            Suppliers = new HashSet<Supplier>();
        }

        public int RegionId { get; set; }
        public string RegionName { get; set; } = null!;
        public string? Description { get; set; }

        public virtual ICollection<Pokedex> Pokedices { get; set; }
        public virtual ICollection<Supplier> Suppliers { get; set; }
    }
}
