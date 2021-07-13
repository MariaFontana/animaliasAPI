using System;
using System.Collections.Generic;

#nullable disable

namespace animaliasAPI.Models
{
    public partial class User
    {
        public User()
        {
            Updatenotifications = new HashSet<Updatenotification>();
        }

        public int IdUser { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Telephone { get; set; }
        public string Pet { get; set; }
        public string Mail { get; set; }
        public string DateStart { get; set; }
        public string Password { get; set; }
        public int IdProduct { get; set; }
        public int IdBreed { get; set; }
        public int IdBrand { get; set; }

        public virtual Brand IdBrandNavigation { get; set; }
        public virtual Breed IdBreedNavigation { get; set; }
        public virtual Product IdProductNavigation { get; set; }
        public virtual ICollection<Updatenotification> Updatenotifications { get; set; }
    }
}
