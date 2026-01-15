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
    public partial class ClientRoomsControl : UserControl
    {
        private readonly string _username;

        private List<Zone> _zones = new();
        private List<Room> _rooms = new();
        private List<UserSubscription> _subs = new();
        private List<SubscriptionPlan> _plans = new();

        public ClientRoomsControl()
        {
            InitializeComponent();
            _username = "";
        }

        public ClientRoomsControl(string username) : this()
        {
            _username = username;

            gridRoomsClient.AutoGenerateColumns = true;

            btnRefreshRooms.Click += (_, __) => LoadData();
            chkOnlyOpen.CheckedChanged += (_, __) => LoadData();

            LoadData();
        }

        private void LoadData()
        {
            try
            {
                _zones = JsonFile.Load<Zone>("zones.json");
                _rooms = JsonFile.Load<Room>("rooms.json");
                _subs = JsonFile.Load<UserSubscription>("subscriptions.json");
                _plans = JsonFile.Load<SubscriptionPlan>("plans.json");

                var now = DateTime.Now;

                // abonament activ + plan (ca să aflăm dacă e VIP)
                var activeSub = _subs
                    .Where(s => s.Username == _username && s.EndDate >= now)
                    .OrderByDescending(s => s.EndDate)
                    .FirstOrDefault();

                var activePlan = activeSub == null
                    ? null
                    : _plans.FirstOrDefault(p => p.Id == activeSub.PlanId);

                var userAccess = activePlan?.AccessLevel ?? "Standard"; // dacă nu are abonament, considerăm Standard

                bool onlyOpen = chkOnlyOpen.Checked;

                // construim rows pentru grid
                var rows = _rooms
                    .Select(r =>
                    {
                        var z = _zones.FirstOrDefault(x => x.Id == r.ZoneId);
                        var zoneName = z?.Name ?? "(zonă ștearsă)";
                        var zoneAccess = z?.AccessLevel ?? "Standard";

                        var isOpen = z != null && IsOpenNow(z, now);
                        var status = isOpen ? "Deschis" : "Închis";

                        // condiție VIP: dacă zona sau sala e VIP -> trebuie VIP
                        var requiresVip = zoneAccess == "VIP" || r.AccessLevel == "VIP";

                        return new
                        {
                            r.Id,
                            Sala = r.Name,
                            Zona = zoneName,
                            Capacitate = r.Capacity,
                            Acces = requiresVip ? "VIP" : "Standard",
                            Status = status,
                            IsOpen = isOpen,
                            RequiresVip = requiresVip
                        };
                    })
                    // filtrare VIP
                    .Where(x => !x.RequiresVip || userAccess == "VIP")
                    // filtrare "doar deschise"
                    .Where(x => !onlyOpen || x.IsOpen)
                    .OrderBy(x => x.Zona)
                    .ThenBy(x => x.Sala)
                    .ToList();

                gridRoomsClient.DataSource = null;
                gridRoomsClient.DataSource = rows;

                // ascundem coloane interne
                if (gridRoomsClient.Columns.Contains("Id"))
                    gridRoomsClient.Columns["Id"].Visible = false;
                if (gridRoomsClient.Columns.Contains("IsOpen"))
                    gridRoomsClient.Columns["IsOpen"].Visible = false;
                if (gridRoomsClient.Columns.Contains("RequiresVip"))
                    gridRoomsClient.Columns["RequiresVip"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la încărcarea sălilor:\n" + ex.Message);
            }
        }

        private bool IsOpenNow(Zone z, DateTime now)
        {
            // interval normal (ex 8..22)
            if (z.OpenHour < z.CloseHour)
                return now.Hour >= z.OpenHour && now.Hour < z.CloseHour;

            // interval peste miezul nopții (ex 22..6)
            return now.Hour >= z.OpenHour || now.Hour < z.CloseHour;
        }
    }

}