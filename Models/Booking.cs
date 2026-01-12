using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymApp_final.Models
{
    public class Booking
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Username { get; set; } = "";   // cine a rezervat
        public Guid ClassId { get; set; }            // la ce clasă
        public DateTime CreatedAt { get; set; } = DateTime.Now;

    }
}
