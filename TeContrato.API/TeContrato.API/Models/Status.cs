using System;
using System.Collections.Generic;

#nullable disable

namespace Supermarket.API.Models
{
    public partial class Status
    {
        public Status()
        {
            Projectcontrols = new HashSet<Projectcontrol>();
        }

        public int Cstatus { get; set; }
        public string Nstatus { get; set; }
        public int ProjectControlId { get; set; }

        public virtual ICollection<Projectcontrol> Projectcontrols { get; set; }
    }
}
