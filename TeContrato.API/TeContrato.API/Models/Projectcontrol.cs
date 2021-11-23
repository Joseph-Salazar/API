using System;
using System.Collections.Generic;

#nullable disable

namespace Supermarket.API.Models
{
    public partial class Projectcontrol
    {
        public Projectcontrol()
        {
            Controlemployees = new HashSet<Controlemployee>();
            Taskprojectcontrols = new HashSet<Taskprojectcontrol>();
        }

        public int Ccontrol { get; set; }
        public string Nproject { get; set; }
        public int CstatusId { get; set; }
        public DateTime Dlastedited { get; set; }
        public int Qemployees { get; set; }
        public int Mbudget { get; set; }
        public int Qprogress { get; set; }
        public int ProjectId { get; set; }

        public virtual Status Cstatus { get; set; }
        public virtual Project Project { get; set; }
        public virtual ICollection<Controlemployee> Controlemployees { get; set; }
        public virtual ICollection<Taskprojectcontrol> Taskprojectcontrols { get; set; }
    }
}
