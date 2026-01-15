using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymApp_final.Models
{
    public class Zone
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = "";

        public string AccessLevel { get; set; } = "Standard";

        public int OpenHour { get; set; } = 8;   // 0..23
        public int CloseHour { get; set; } = 22; // 0..23
    }
}
