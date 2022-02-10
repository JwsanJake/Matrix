using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Matrix.Models
{
    public class ActorCommentary
    {
        public int ActorId { get; set; }
        public Actor Actor { get; set; }

        public int CommentaryId { get; set; }
        public Commentary Commentary { get; set; }
    }
}
