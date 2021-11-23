using System;
using System.Collections.Generic;

#nullable disable

namespace Supermarket.API.Models
{
    public partial class Job
    {
        public Job()
        {
            Employees = new HashSet<Employee>();
        }

        public int Cjob { get; set; }
        public string Njob { get; set; }
        public string Tdescription { get; set; }
        public int EmployeeId { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
    }
}
