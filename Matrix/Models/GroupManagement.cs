using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Matrix.Models
{
    public class GroupManagement
    {
        [Key]
        public int GroupManagementId { get; set; }
        public string GroupManagementName { get; set; }

        public ICollection<UnitManagement> UnitManagements { get; set; }
    }
}
