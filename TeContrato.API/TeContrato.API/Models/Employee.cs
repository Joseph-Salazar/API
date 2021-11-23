using System;
using System.Collections.Generic;

#nullable disable

namespace Supermarket.API.Models
{
    public partial class Employee
    {
        public Employee()
        {
            Controlemployees = new HashSet<Controlemployee>();
            Taskprojectcontrols = new HashSet<Taskprojectcontrol>();
        }

        public int Cemployee { get; set; }
        public string Nemployee { get; set; }
        public string Tposition { get; set; }
        public int Mpayment { get; set; }
        public string Tworks { get; set; }
        public int JobId { get; set; }

        public virtual Job Job { get; set; }
        public virtual ICollection<Controlemployee> Controlemployees { get; set; }
        public virtual ICollection<Taskprojectcontrol> Taskprojectcontrols { get; set; }
    }
}
