using System;
using System.Collections.Generic;

#nullable disable

namespace Supermarket.API.Models
{
    public partial class User
    {
        public User()
        {
            Posts = new HashSet<Post>();
            ProjectClients = new HashSet<Project>();
            ProjectContractors = new HashSet<Project>();
        }

        public int Cuser { get; set; }
        public string Nuser { get; set; }
        public int Cpassword { get; set; }
        public string Temail { get; set; }
        public int Cdni { get; set; }
        public string Nname { get; set; }
        public string Nlastname { get; set; }
        public int IsAdmin { get; set; }
        public int TipoDeUsuario { get; set; }
        public string ClientTbio { get; set; }
        public string Taddress { get; set; }
        public int? CityId { get; set; }
        public int? Ccontractor { get; set; }
        public string Tbio { get; set; }
        public string Neducation { get; set; }
        public int? Numphone { get; set; }

        public virtual City City { get; set; }
        public virtual ICollection<Post> Posts { get; set; }
        public virtual ICollection<Project> ProjectClients { get; set; }
        public virtual ICollection<Project> ProjectContractors { get; set; }
    }
}
