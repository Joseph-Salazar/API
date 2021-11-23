using System;
using System.Collections.Generic;

#nullable disable

namespace Supermarket.API.Models
{
    public partial class City
    {
        public City()
        {
            Users = new HashSet<User>();
        }

        public int Ccity { get; set; }
        public string Ncity { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}
