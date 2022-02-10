using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Matrix.Models
{
    public class Matrixx
    {
        [Key]
        public int MatrixId { get; set; }
        public string MatrixName { get; set; }

        public ICollection<Process> Processes { get; set; }
    }
}
