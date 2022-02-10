using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Matrix.Models
{
    public class Process
    {
        [Key]
        public int ProcessId { get; set; }
        public string ProcessName { get; set; }

        public int MatrixId { get; set; }
        public Matrixx Matrix { get; set; }

        public ICollection<SubProcess> SubProcesses { get; set; }
    }
}
