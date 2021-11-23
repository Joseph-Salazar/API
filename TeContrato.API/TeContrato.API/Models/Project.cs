using System;
using System.Collections.Generic;

#nullable disable

namespace Supermarket.API.Models
{
    public partial class Project
    {
        public int Cproject { get; set; }
        public string Nproject { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Tdescription { get; set; }
        public int ContractorId { get; set; }
        public int ClientId { get; set; }
        public int Mbudget { get; set; }
        public int BudgetId { get; set; }

        public virtual Budget Budget { get; set; }
        public virtual User Client { get; set; }
        public virtual User Contractor { get; set; }
        public virtual Projectcontrol Projectcontrol { get; set; }
    }
}
