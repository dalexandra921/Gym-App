using GymApp_final.Data;
using GymApp_final.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymApp_final.Controls
{
    public partial class AdminStatsControl : UserControl
    {
        public AdminStatsControl()
        {
            InitializeComponent();

            gridClassOccupancy.AutoGenerateColumns = true;
            btnRefreshStats.Click += (_, __) => LoadStats();

            LoadStats();
        }

        private void LoadStats()
        {
            try
            {
             
                var bookings = JsonFile.Load<Booking>("bookings.json");

                var classes = JsonFile.Load<FitnessClass>("classes.json")
                    .OrderBy(c => c.StartTime)
                    .ToList();

                // subscriptions (abonamente cumpărate)
               var subs = JsonFile.Load<UserSubscription>("subscriptions.json");

                // 1) Abonamente active
                var activeSubs = subs.Count(s => s.EndDate >= DateTime.Now);
                lblActiveSubs.Text = $"Abonamente active: {activeSubs}";

                // 2) Rezervări totale
                lblTotalBookings.Text = $"Rezervări totale: {bookings.Count}";

                // 3) Top client după rezervări
                var top = bookings
                    .GroupBy(b => b.Username)
                    .Select(g => new { Username = g.Key, Count = g.Count() })
                    .OrderByDescending(x => x.Count)
                    .FirstOrDefault();

                lblTopClient.Text = top == null
                    ? "Top client: -"
                    : $"Top client: {top.Username} ({top.Count} rezervări)";

                // 4) Ocupare pe clase
                var rows = classes.Select(c =>
                {
                    var reserved = bookings.Count(b => b.ClassId == c.Id);
                    var capacity = c.Capacity;

                    var percent = capacity > 0
                        ? (int)Math.Round((double)reserved / capacity * 100)
                        : 0;

                    return new
                    {
                        Titlu = c.Title,
                        DataOra = c.StartTime,
                        Capacitate = capacity,
                        Rezervate = reserved,
                        Ocupare = percent + "%"
                    };
                }).ToList();

                gridClassOccupancy.DataSource = null;
                gridClassOccupancy.DataSource = rows;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la statistici:\n" + ex.Message);
            }
        }
    }
}
