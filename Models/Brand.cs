using System;
using System.Collections.Generic;

#nullable disable

namespace animaliasAPI.Models
{
    public partial class Brand
    {
        public Brand()
        {
            Users = new HashSet<User>();
        }

        public int Idbrand { get; set; }
        public string Name { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}
