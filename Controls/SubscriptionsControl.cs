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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.DependencyInjection;

namespace GymApp_final.Controls
{
    public partial class SubscriptionsControl : UserControl
    {
        private readonly string _username;
        private readonly ILogger<SubscriptionsControl> _logger;

        private List<SubscriptionPlan> _plans = new();
        private List<UserSubscription> _subs = new();
        public SubscriptionsControl()
        {
            InitializeComponent();
            _username = "";

            _logger = Program.AppHost.Services.GetRequiredService<ILogger<SubscriptionsControl>>();
        }

        // Constructor pentru runtime
        public SubscriptionsControl(string username) : this()
        {
            _username = username;

            gridPlansClient.AutoGenerateColumns = true;
            gridMySubs.AutoGenerateColumns = true;

            btnBuy.Click += (_, __) => BuySelectedPlan();

            LoadData();
        }

        private void LoadData()
        {
            try
            {
                _plans = JsonFile.Load<SubscriptionPlan>("plans.json");
                _subs = JsonFile.Load<UserSubscription>("subscriptions.json");

                // planuri
                gridPlansClient.DataSource = null;
                gridPlansClient.DataSource = _plans;
                if (gridPlansClient.Columns.Contains("Id"))
                    gridPlansClient.Columns["Id"].Visible = false;

                // abonamentele mele (active + istorice)
                var my = _subs
                    .Where(s => s.Username == _username)
                    .OrderByDescending(s => s.StartDate)
                    .Select(s => new
                    {
                        s.Id,
                        s.StartDate,
                        s.EndDate,

                        DaysLeft = s.EndDate >= DateTime.Now 
                        ? (int)Math.Ceiling((s.EndDate - DateTime.Now).TotalDays) 
                        : 0,

                        Status = s.EndDate >= DateTime.Now ? "Activ" : "Expirat",
                        Plan = _plans.FirstOrDefault(p => p.Id == s.PlanId)?.Name ?? "(plan șters)",
                        AccessLevel = _plans.FirstOrDefault(p => p.Id == s.PlanId)?.AccessLevel ?? "",
                    })
                    .ToList();


                gridMySubs.DataSource = null;
                gridMySubs.DataSource = my;

                if (gridMySubs.Columns.Contains("Id"))
                    gridMySubs.Columns["Id"].Visible = false;

                if (gridMySubs.Columns.Contains("StartDate"))
                    gridMySubs.Columns["StartDate"].DefaultCellStyle.Format = "dd.MM.yyyy";

                if (gridMySubs.Columns.Contains("EndDate"))
                    gridMySubs.Columns["EndDate"].DefaultCellStyle.Format = "dd.MM.yyyy";


            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la încărcare abonamente:\n" + ex.Message);
            }
        }

        private SubscriptionPlan? SelectedPlan()
            => gridPlansClient.CurrentRow?.DataBoundItem as SubscriptionPlan;

        private void BuySelectedPlan()
        {
            try
            {
                var plan = SelectedPlan();
                if (plan == null)
                {
                    MessageBox.Show("Selectează un abonament din listă.");
                    return;
                }

                // dacă are deja unul activ, poți decide:
                // - să permiți cumpărarea (stack)
                // - sau să ceri confirmare
                var hasActive = _subs.Any(s => s.Username == _username && s.EndDate >= DateTime.Now);
                if (hasActive)
                {
                    if (MessageBox.Show("Ai deja un abonament activ. Vrei să cumperi încă unul?",
                        "Confirmare", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                        return;
                }

                var start = DateTime.Now;
                var end = start.AddDays(plan.ValidDays);

                _subs.Add(new UserSubscription
                {
                    Id = Guid.NewGuid(),
                    Username = _username,
                    PlanId = plan.Id,
                    StartDate = start,
                    EndDate = end
                });

                _logger.LogInformation("Subscription bought: user={User}, planId={PlanId}, end={EndDate}",
                    _username, plan.Id, end);


                JsonFile.Save("subscriptions.json", _subs);

                MessageBox.Show($"Abonament cumpărat! Valabil până la {end:dd.MM.yyyy}.");
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la cumpărare:\n" + ex.Message);
                _logger.LogError(ex, "Subscription buy failed: user={User}", _username);
            }

        }
    }
}
