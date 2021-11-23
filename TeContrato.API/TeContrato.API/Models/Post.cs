using System;
using System.Collections.Generic;

#nullable disable

namespace Supermarket.API.Models
{
    public partial class Post
    {
        public int Cposts { get; set; }
        public string Ntitle { get; set; }
        public string Tbody { get; set; }
        public DateTime CreatedAt { get; set; }
        public int Mbudget { get; set; }
        public int Views { get; set; }
        public int Pic { get; set; }
        public int UserId { get; set; }

        public virtual User User { get; set; }
    }
}
