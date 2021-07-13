using System;
using System.Collections.Generic;

#nullable disable

namespace animaliasAPI.Models
{
    public partial class Product
    {
        public Product()
        {
            Users = new HashSet<User>();
        }

        public int IdProduct { get; set; }
        public string Name { get; set; }
        public decimal? Precio { get; set; }
        public string PhotoId { get; set; }
        public string Description { get; set; }
        public int? Cantidad { get; set; }
        public int? IdBrand { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}
