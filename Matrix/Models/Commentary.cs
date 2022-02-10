using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Matrix.Models
{
    public class Commentary
    {
        //public Commentary()
        //{
        //    this.Actors = new HashSet<Actor>();
        //}


        //[Key]
        //public int CommentaryId { get; set; }
        //public string CommentaryContent { get; set; }

        //public virtual ICollection<Actor> Actors { get; set; }

        [Key]
        public int CommentaryId { get; set; }
        public string CommentaryContent { get; set; }

        //public List<Actor> Actors { get; set; } = new List<Actor>();
        public virtual ICollection<ActorCommentary> ActorCommentaries { get; set; }
    }
}
