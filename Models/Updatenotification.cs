using System;
using System.Collections.Generic;

#nullable disable

namespace animaliasAPI.Models
{
    public partial class Updatenotification
    {
        public int IdUpdatenotification { get; set; }
        public DateTime? DateUpdate { get; set; }
        public int? CountDays { get; set; }
        public int IdUser { get; set; }

        public virtual User IdUserNavigation { get; set; }
    }
}
