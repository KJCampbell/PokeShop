using System;
using System.Collections.Generic;

namespace PokeShop.DATA.EF.Models
{
    public partial class Product
    {
        public Product()
        {
            OrderProducts = new HashSet<OrderProduct>();
        }

        public int ProductId { get; set; }
        public decimal PokemonPrice { get; set; }
        public short UnitsInStock { get; set; }
        public short UnitsOnOrder { get; set; }
        public bool IsDiscontinued { get; set; }
        public int PokedexId { get; set; }
        public int? SupplierId { get; set; }
        public string? ProductImg { get; set; }

        public virtual Pokedex Pokedex { get; set; } = null!;
        public virtual Supplier? Supplier { get; set; }
        public virtual ICollection<OrderProduct> OrderProducts { get; set; }
    }
}
