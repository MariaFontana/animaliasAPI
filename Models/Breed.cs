using System;
using System.Collections.Generic;

#nullable disable

namespace animaliasAPI.Models
{
    public partial class Breed
    {
        public Breed()
        {
            Users = new HashSet<User>();
        }

        public int IdBreed { get; set; }
        public string Name { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}
