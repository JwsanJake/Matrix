using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Matrix.Models
{
    public class UnitManagement
    {
        //public UnitManagement()
        //{
        //    this.Actors = new HashSet<Actor>();
        //}

        //[Key]
        //public int UnitManagementId { get; set; }
        //public string UnitManagementName { get; set; }

        //public int GroupManagementId { get; set; }
        //public GroupManagement GroupManagement { get; set; }

        //public virtual ICollection<Actor> Actors { get; set; }


        [Key]
        public int UnitManagementId { get; set; }
        public string UnitManagementName { get; set; }

        public int GroupManagementId { get; set; }
        public GroupManagement GroupManagement { get; set; }

        public List<Actor> Actors { get; set; } = new List<Actor>();
    }
}
