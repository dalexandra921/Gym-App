using GymApp_final.Data;
using GymApp_final.Models;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
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
    public partial class PlansControl : UserControl
    {
        private List<SubscriptionPlan> _plans = new();
        private readonly ILogger<PlansControl> _logger;
        public PlansControl()
        {
            InitializeComponent();

            _logger = Program.AppHost.Services.GetRequiredService<ILogger<PlansControl>>();

            gridPlans.AutoGenerateColumns = true;

            btnAddPlan.Click += (_, __) => AddPlan();
            btnUpdatePlan.Click += (_, __) => UpdatePlan();
            btnDeletePlan.Click += (_, __) => DeletePlan();
            btnRefreshPlans.Click += (_, __) => LoadPlans();

            cmbPlanAccess.Items.Clear();
            cmbPlanAccess.Items.Add("Standard");
            cmbPlanAccess.Items.Add("VIP");
            cmbPlanAccess.SelectedIndex = 0;

            gridPlans.SelectionChanged += (_, __) => FillInputsFromSelected();

            LoadPlans();
        }

        private void LoadPlans()
        {
            try
            {
                _plans = JsonFile.Load<SubscriptionPlan>("plans.json");
                gridPlans.DataSource = null;
                gridPlans.DataSource = _plans;

                if (gridPlans.Columns.Contains("Id"))
                    gridPlans.Columns["Id"].Visible = false; //ascunzi id-u;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la încărcarea abonamentelor:\n" + ex.Message);
            }
        }

        private SubscriptionPlan? SelectedPlan()
            => gridPlans.CurrentRow?.DataBoundItem as SubscriptionPlan;

        private void FillInputsFromSelected()
        {
            var p = SelectedPlan();
            if (p == null) return;

            txtPlanName.Text = p.Name;
            numPlanPrice.Value = p.Price;
            txtPlanDesc.Text = p.Description;

            cmbPlanAccess.SelectedItem = p.AccessLevel;
            if (cmbPlanAccess.SelectedItem == null)
                cmbPlanAccess.SelectedIndex = 0;

            numValidDays.Value = p.ValidDays <= 0 ? 30 : p.ValidDays;
        }

        private void AddPlan()
        {
            try
            {
                var name = txtPlanName.Text.Trim();
                if (string.IsNullOrWhiteSpace(name))
                {
                    MessageBox.Show("Numele nu poate fi gol.");
                    return;
                }

                _plans.Add(new SubscriptionPlan
                {
                    Id = Guid.NewGuid(),
                    Name = name,
                    Price = numPlanPrice.Value,
                    Description = txtPlanDesc.Text.Trim(),
                    AccessLevel = cmbPlanAccess.SelectedItem?.ToString() ?? "Standard",
                    ValidDays = (int)numValidDays.Value,
                });

                JsonFile.Save("plans.json", _plans);

                _logger.LogInformation("Plan added: {Name} access={Access} days={Days}",
                    name, cmbPlanAccess.SelectedItem?.ToString(), (int)numValidDays.Value);

                LoadPlans();

                txtPlanName.Clear();
                numPlanPrice.Value = 0;
                txtPlanDesc.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la adăugare:\n" + ex.Message);
            }

        }

        private void UpdatePlan()
        {
            try
            {
                var selected = SelectedPlan();
                if (selected == null)
                {
                    MessageBox.Show("Selectează un abonament din listă.");
                    return;
                }

                var name = txtPlanName.Text.Trim();
                if (string.IsNullOrWhiteSpace(name))
                {
                    MessageBox.Show("Numele nu poate fi gol.");
                    return;
                }

                selected.Name = name;
                selected.Price = numPlanPrice.Value;
                selected.Description = txtPlanDesc.Text.Trim();
                selected.AccessLevel = cmbPlanAccess.SelectedItem?.ToString() ?? "Standard";
                selected.ValidDays = (int)numValidDays.Value;
                _logger.LogInformation("Plan updated: id={Id}", selected.Id);

                JsonFile.Save("plans.json", _plans);
                LoadPlans();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la modificare:\n" + ex.Message);
            }

        }


        private void DeletePlan()
        {
            try
            {
                var selected = SelectedPlan();
                if (selected == null)
                {
                    MessageBox.Show("Selectează un abonament din listă.");
                    return;
                }

                if (MessageBox.Show("Sigur vrei să ștergi abonamentul?",
                    "Confirmare", MessageBoxButtons.YesNo) != DialogResult.Yes)
                    return;

                _plans.RemoveAll(p => p.Id == selected.Id);
                JsonFile.Save("plans.json", _plans);
                _logger.LogWarning("Plan deleted: id={Id}", selected.Id);
                LoadPlans();

                txtPlanName.Clear();
                numPlanPrice.Value = 0;
                txtPlanDesc.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la ștergere:\n" + ex.Message);
            }
        }

    }
}
