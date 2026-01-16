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
    public partial class TrainersControl : UserControl
    {
        private List<Trainer> _trainers = new();
        private readonly ILogger<TrainersControl> _logger;
        public TrainersControl()
        {
            InitializeComponent();
            _logger = Program.AppHost.Services.GetRequiredService<ILogger<TrainersControl>>();

            gridTrainers.AutoGenerateColumns = true;

            btnAddTrainer.Click += (_, __) => AddTrainer();
            btnUpdateTrainer.Click += (_, __) => UpdateTrainer();
            btnDeleteTrainer.Click += (_, __) => DeleteTrainer();
            gridTrainers.SelectionChanged += (_, __) => FillInputsFromSelected();

            LoadTrainers();
        }

        private void LoadTrainers()
        {
            _trainers = JsonFile.Load<Trainer>("trainers.json");

            gridTrainers.DataSource = null;
            gridTrainers.DataSource = _trainers;

            if (gridTrainers.Columns.Contains("Id"))
                gridTrainers.Columns["Id"].Visible = false;
        }

        private Trainer? SelectedTrainer()
            => gridTrainers.CurrentRow?.DataBoundItem as Trainer;

        private void FillInputsFromSelected()
        {
            var t = SelectedTrainer();
            if (t == null) return;

            txtTrainerName.Text = t.FullName;
            txtTrainerSpec.Text = t.Specialty;
        }

        private void AddTrainer()
        {
            var name = txtTrainerName.Text.Trim();
            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Numele nu poate fi gol.");
                return;
            }

            _trainers.Add(new Trainer
            {
                Id = Guid.NewGuid(),
                FullName = name,
                Specialty = txtTrainerSpec.Text.Trim()
            });

            JsonFile.Save("trainers.json", _trainers);
            _logger.LogInformation("Trainer added: {Name}", name);
            LoadTrainers();

            txtTrainerName.Clear();
            txtTrainerSpec.Clear();
        }

        private void UpdateTrainer()
        {
            var selected = SelectedTrainer();
            if (selected == null)
            {
                MessageBox.Show("Selectează un antrenor.");
                return;
            }

            var name = txtTrainerName.Text.Trim();
            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Numele nu poate fi gol.");
                return;
            }

            selected.FullName = name;
            selected.Specialty = txtTrainerSpec.Text.Trim();

            JsonFile.Save("trainers.json", _trainers);
            LoadTrainers();
        }

        private void DeleteTrainer()
        {
            var selected = SelectedTrainer();
            if (selected == null)
            {
                MessageBox.Show("Selectează un antrenor.");
                return;
            }

            if (MessageBox.Show("Sigur vrei să ștergi antrenorul?",
                "Confirmare", MessageBoxButtons.YesNo) != DialogResult.Yes)
                return;

            _trainers.RemoveAll(t => t.Id == selected.Id);
            JsonFile.Save("trainers.json", _trainers);
            _logger.LogWarning("Trainer deleted: id={Id}", selected.Id);
            LoadTrainers();
        }
    }
}