using System;
using System.Collections.Generic;

#nullable disable

namespace Supermarket.API.Models
{
    public partial class Budget
    {
        public Budget()
        {
            Projects = new HashSet<Project>();
        }

        public int Cbudget { get; set; }
        public string Tdescription { get; set; }
        public float Mmonto { get; set; }
        public DateTime Dfecha { get; set; }

        public virtual ICollection<Project> Projects { get; set; }
    }
}
