using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Matrix.Models
{
    public class SubProcess
    {
        //public SubProcess()
        //{
        //    this.Actors = new HashSet<Actor>();
        //}

        //[Key]
        //public int SubProcessId { get; set; }
        //public string SubProcessName { get; set; }


        //public int ProcessId { get; set; }
        //public Process Process { get; set; }

        //public virtual ICollection<Actor> Actors { get; set; }

        [Key]
        public int SubProcessId { get; set; }
        public string SubProcessName { get; set; }

        [ForeignKey("ProcessId")]
        public int ProcessId { get; set; }
        public Process Process { get; set; }

        public List<Actor> Actors { get; set; } = new List<Actor>();
    }
}
