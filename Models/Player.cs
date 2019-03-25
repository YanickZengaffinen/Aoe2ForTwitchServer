using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace aoe2_server.Models
{
    public class Player
    {
        [Key]
        public long ID { get; set; }

        public string Name { get; set; }
        public short Age { get; set; }
    }
}
