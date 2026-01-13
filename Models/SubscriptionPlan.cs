using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymApp_final.Models
{
    public class SubscriptionPlan
    {
        public Guid Id { get; set; }// = Guid.NewGuid();
        public string Name { get; set; } = "";
        public decimal Price { get; set; }
        public string Description { get; set; } = "";

        public int ValidDays { get; set; } = 30;  
        public string AccessLevel { get; set; } = "Standard";
    }
}
