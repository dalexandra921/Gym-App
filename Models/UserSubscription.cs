using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymApp_final.Models
{
    public class UserSubscription
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Username { get; set; } = "";
        public Guid PlanId { get; set; }
        public DateTime StartDate { get; set; } = DateTime.Now;
        public DateTime EndDate { get; set; }
    }
}
