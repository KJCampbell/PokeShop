using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations; //Added for access to Data Annotations

namespace PokeShop.DATA.EF.Models//.Metadata
{
    //internal class Metadata
    //{
    //}
    public class OrderProductMetadata
    {
        public int OrderProductId { get; set; }
        public int ProductId { get; set; }
        public int OrderId { get; set; }
        public short? Quantity { get; set; }
        public decimal? ProductPrice { get; set; }
    }
    

    public class OrderMetadata
    {
        public int OrderId { get; set; }
        public string UserId { get; set; } = null!;
        public DateTime OrderDate { get; set; }
        public string ShipToName { get; set; } = null!;
        public string ShipCity { get; set; } = null!;
        public string ShipRegion { get; set; } = null!;
    }

    public class ProductMetadata
    {
        public int ProductId { get; set; }
        public decimal PokemonPrice { get; set; }
        public short UnitsInStock { get; set; }
        public short UnitsOnOrder { get; set; }
        public bool IsDiscontinued { get; set; }
        public int PokedexId { get; set; }
        public int? SupplierId { get; set; }
        public string? ProductImg { get; set; }
    }

    public class SupplierMetadata
    {
        public int SupplierId { get; set; }
        public string SupplierName { get; set; } = null!;
        public string Address { get; set; } = null!;
        public string? City { get; set; }
        public int? RegionId { get; set; }
        public string? Phone { get; set; }
    }

    public class PokedexMetadata
    {
        public int PokedexId { get; set; }
        public string PokemonName { get; set; } = null!;
        public string Type { get; set; } = null!;
        public string? SecondaryType { get; set; }
        public int RegionId { get; set; }
        public int? PkmNum { get; set; }
        public string? Description { get; set; }
    }

    public class RegionMetadata
    {
        public int RegionId { get; set; }
        public string RegionName { get; set; } = null!;
        public string? Description { get; set; }
    }

    public class UserDetailMetadata
    {
        public string UserId { get; set; } = null!;
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string City { get; set; } = null!;
    }
}
