using System;
using System.Collections.Generic;

#nullable disable

namespace Supermarket.API.Models
{
    public partial class Taskprojectcontrol
    {
        public int TaskCtask { get; set; }
        public int ProjectControlId { get; set; }
        public int EmployeesId { get; set; }
        public int TtaskId { get; set; }

        public virtual Employee Employees { get; set; }
        public virtual Projectcontrol ProjectControl { get; set; }
        public virtual Task Ttask { get; set; }
    }
}
