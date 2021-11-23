using System;
using System.Collections.Generic;

#nullable disable

namespace Supermarket.API.Models
{
    public partial class Task
    {
        public Task()
        {
            Taskprojectcontrols = new HashSet<Taskprojectcontrol>();
        }

        public int TtaskId { get; set; }
        public string TtaskName { get; set; }
        public int TaskProjectControlId { get; set; }

        public virtual ICollection<Taskprojectcontrol> Taskprojectcontrols { get; set; }
    }
}
