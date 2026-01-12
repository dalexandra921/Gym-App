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
    public partial class PlansControl : UserControl
    {
        private List<SubscriptionPlan> _plans = new();
        public PlansControl()
        {
            InitializeComponent();
            gridPlans.AutoGenerateColumns = true;

            btnAddPlan.Click += (_, __) => AddPlan();
            btnUpdatePlan.Click += (_, __) => UpdatePlan();
            btnDeletePlan.Click += (_, __) => DeletePlan();
            btnRefreshPlans.Click += (_, __) => LoadPlans();

            gridPlans.SelectionChanged += (_, __) => FillInputsFromSelected();

            LoadPlans();
        }

        private void LoadPlans()
        {
            _plans = JsonFile.Load<SubscriptionPlan>("plans.json");
            gridPlans.DataSource = null;
            gridPlans.DataSource = _plans;
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
        }

        private void AddPlan()
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
                Description = txtPlanDesc.Text.Trim()
            });

            JsonFile.Save("plans.json", _plans);
            LoadPlans();
        }

        private void UpdatePlan()
        {
            var selected = SelectedPlan();
            if (selected == null)
            {
                MessageBox.Show("Selectează un abonament din listă.");
                return;
            }

            selected.Name = txtPlanName.Text.Trim();
            selected.Price = numPlanPrice.Value;
            selected.Description = txtPlanDesc.Text.Trim();

            JsonFile.Save("plans.json", _plans);
            LoadPlans();
        }

        private void DeletePlan()
        {
            var selected = SelectedPlan();
            if (selected == null)
            {
                MessageBox.Show("Selectează un abonament din listă.");
                return;
            }

            _plans.RemoveAll(p => p.Id == selected.Id);
            JsonFile.Save("plans.json", _plans);
            LoadPlans();
        }
    }
}
