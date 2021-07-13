using System;
using System.Collections.Generic;

#nullable disable

namespace animaliasAPI.Models
{
    public partial class Promotion
    {
        public int IdPromo { get; set; }
        public string Name { get; set; }
        public DateTime? StarPromo { get; set; }
        public DateTime? FinishPromo { get; set; }
        public string Image { get; set; }
    }
}
