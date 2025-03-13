using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    class Game
    {
        public Guid Game_Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public byte AgeMin { get; set; }
        public byte AgeMax { get; set; }
        public byte NbPlayersMin { get; set; }
        public byte NbPlayersMax { get; set; }
        public int? PlayingTime { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
