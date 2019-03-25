using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace aoe2_server.Models
{
    public class Group
    {
        [Key]
        public long ID { get; set; }

        public string Name { get; set; }

        public long[] PlayerIDs { get; set; }

        public ICollection<Player> Players { get; set; }
    }
}
