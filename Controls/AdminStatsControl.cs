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
        private List<UserSubscription> _subs = new();
        private List<Booking> _bookings = new();
        private List<FitnessClass> _classes = new();

        public AdminStatsControl()
        {
            InitializeComponent();

            gridClassStats.AutoGenerateColumns = true;
            btnRefreshStats.Click += (_, __) => LoadStats();

            LoadStats();
        }

        private void LoadStats()
        {
            try
            {
                // citește datele
                _subs = JsonFile.Load<UserSubscription>("subscriptions.json");
                _bookings = JsonFile.Load<Booking>("bookings.json");
                _classes = JsonFile.Load<FitnessClass>("classes.json");

                var now = DateTime.Now;

                // 1) Abonamente active
                var activeSubs = _subs.Count(s => s.EndDate >= now);
                lblActiveSubs.Text = $"Abonamente active: {activeSubs}";

                // 2) Rezervări totale
                lblTotalBookings.Text = $"Rezervări totale: {_bookings.Count}";

                // 3) Top client (cele mai multe rezervări)
                var top = _bookings
                    .GroupBy(b => b.Username)
                    .Select(g => new { Username = g.Key, Count = g.Count() })
                    .OrderByDescending(x => x.Count)
                    .FirstOrDefault();

                lblTopClient.Text = top == null
                    ? "Top client: -"
                    : $"Top client: {top.Username} ({top.Count} rezervări)";

                // 4) Ocupare pe clase
                var rows = _classes
                    .OrderBy(c => c.StartTime)
                    .Select(c =>
                    {
                        var reserved = _bookings.Count(b => b.ClassId == c.Id);
                        var cap = c.Capacity <= 0 ? 1 : c.Capacity;
                        var occ = (int)Math.Round(100.0 * reserved / cap);

                        return new
                        {
                            Titlu = c.Title,
                            DataOra = c.StartTime,
                            Capacitate = c.Capacity,
                            Rezervate = reserved,
                            Ocupare = occ + "%"
                        };
                    })
                    .ToList();

                gridClassStats.DataSource = null;
                gridClassStats.DataSource = rows;

                if (gridClassStats.Columns.Contains("DataOra"))
                    gridClassStats.Columns["DataOra"].DefaultCellStyle.Format = "dd.MM.yyyy HH:mm";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la statistici:\n" + ex.Message);
            }
        }
    }
}
