using System;
using System.Collections.Generic;

namespace PokeShop.DATA.EF.Models
{
    public partial class Supplier
    {
        public Supplier()
        {
            Products = new HashSet<Product>();
        }

        public int SupplierId { get; set; }
        public string SupplierName { get; set; } = null!;
        public string Address { get; set; } = null!;
        public string? City { get; set; }
        public int? RegionId { get; set; }
        public string? Phone { get; set; }

        public virtual Region? Region { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
