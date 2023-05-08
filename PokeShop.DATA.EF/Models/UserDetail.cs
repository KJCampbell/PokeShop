using System;
using System.Collections.Generic;

namespace PokeShop.DATA.EF.Models
{
    public partial class UserDetail
    {
        public UserDetail()
        {
            Orders = new HashSet<Order>();
        }

        public string UserId { get; set; } = null!;
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string City { get; set; } = null!;

        public virtual ICollection<Order> Orders { get; set; }
    }
}
