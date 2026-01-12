using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymApp_final.Models
{
    public class FitnessClass
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Title { get; set; } = "";      
        public string Trainer { get; set; } = "";    
        public int DurationMinutes { get; set; }     
        public int Capacity { get; set; }           
        public DateTime StartTime { get; set; }      
    }
}
