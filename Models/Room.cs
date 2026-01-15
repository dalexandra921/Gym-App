using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymApp_final.Models
{
    public class Room
    {
        public Guid Id { get; set; }
        public Guid ZoneId { get; set; }

        public string Name { get; set; } = "";
        public int Capacity { get; set; } = 20;

        //sală VIP separată de zona
        public string AccessLevel { get; set; } = "Standard";
    }
}
