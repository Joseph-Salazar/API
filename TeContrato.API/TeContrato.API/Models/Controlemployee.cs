using System;
using System.Collections.Generic;

#nullable disable

namespace Supermarket.API.Models
{
    public partial class Controlemployee
    {
        public int ProjectControlId { get; set; }
        public int EmployeeId { get; set; }
        public int ControlEmployeesId { get; set; }

        public virtual Employee Employee { get; set; }
        public virtual Projectcontrol ProjectControl { get; set; }
    }
}
