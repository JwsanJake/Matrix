using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Matrix.Models
{
    public class Actor
    {
        //public Actor()
        //{
        //    this.SubProcesses = new HashSet<SubProcess>();
        //    this.UnitManagements = new HashSet<UnitManagement>();
        //    this.Commentaries = new HashSet<Commentary>();
        //}

        //[Key]
        //public int ActorId { get; set; }
        //public string ActorName { get; set; }


        //public virtual ICollection<SubProcess> SubProcesses { get; set; }
        //public virtual ICollection<UnitManagement> UnitManagements { get; set; }
        //public virtual ICollection<Commentary> Commentaries { get; set; }


        [Key]
        public int ActorId { get; set; }
        public string ActorName { get; set; }

        public List<SubProcess> SubProcesses { get; set; } = new List<SubProcess>();
        public List<UnitManagement> UnitManagements { get; set; } = new List<UnitManagement>();

        //public List<Commentary> Commentaries { get; set; } = new List<Commentary>();
        public virtual ICollection<ActorCommentary> ActorCommentaries { get; set; }
    }
}
