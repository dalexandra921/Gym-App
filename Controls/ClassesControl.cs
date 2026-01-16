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
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace GymApp_final.Controls
{
    public partial class ClassesControl : UserControl
    {
        private List<FitnessClass> _classes = new();
        private List<Trainer> _trainers = new();
        private readonly ILogger<ClassesControl> _logger;

        public ClassesControl()
        {
            InitializeComponent();
            _logger = Program.AppHost.Services.GetRequiredService<ILogger<ClassesControl>>();

            cmbRequiredAccessLevel.Items.Clear();
            cmbRequiredAccessLevel.Items.Add("Standard");
            cmbRequiredAccessLevel.Items.Add("VIP");
            cmbRequiredAccessLevel.SelectedIndex = 0;

            gridClasses.AutoGenerateColumns = true;

            btnAddClass.Click += (_, __) => AddClass();
            btnUpdateClass.Click += (_, __) => UpdateClass();
            btnDeleteClass.Click += (_, __) => DeleteClass();
            btnRefreshClasses.Click += (_, __) => LoadClasses();

            gridClasses.SelectionChanged += (_, __) => FillInputsFromSelected();

            LoadTrainersIntoCombo();
            LoadClasses();
        }

        public void RefreshTrainers()
        {
            LoadTrainersIntoCombo();
        }

        private void LoadClasses()
        {
            try
            {
                _classes = JsonFile.Load<FitnessClass>("classes.json");
                gridClasses.DataSource = null;
                gridClasses.DataSource = _classes;

                if (gridClasses.Columns.Contains("Id"))
                    gridClasses.Columns["Id"].Visible = false;


            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la încărcarea claselor:\n" + ex.Message);
            }
        }

        private FitnessClass? SelectedClass()
            => gridClasses.CurrentRow?.DataBoundItem as FitnessClass;

        private void FillInputsFromSelected()
        {
            var c = SelectedClass();
            if (c == null) return;

            txtClassTitle.Text = c.Title;
            var match = _trainers.FirstOrDefault(t => t.FullName == c.Trainer);
            if (match != null)
                cmbTrainer.SelectedItem = match;
            numDuration.Value = c.DurationMinutes;
            numCapacity.Value = c.Capacity;
            dtpStartTime.Value = c.StartTime == default ? DateTime.Now : c.StartTime;
            cmbRequiredAccessLevel.SelectedItem = c.RequiredAccessLevel;

            if (cmbRequiredAccessLevel.SelectedItem == null)
                cmbRequiredAccessLevel.SelectedIndex = 0;

        }

        private void AddClass()
        {
            try
            {
                var title = txtClassTitle.Text.Trim();
                if (string.IsNullOrWhiteSpace(title))
                {
                    MessageBox.Show("Titlul nu poate fi gol.");
                    return;
                }

                var trainer = cmbTrainer.SelectedItem as Trainer;
                if (trainer == null)
                {
                    MessageBox.Show("Selectează un antrenor.");
                    return;
                }

                _classes.Add(new FitnessClass
                {
                    Id = Guid.NewGuid(),
                    Title = title,
                    Trainer = trainer.FullName,
                    DurationMinutes = (int)numDuration.Value,
                    Capacity = (int)numCapacity.Value,
                    StartTime = dtpStartTime.Value,
                    RequiredAccessLevel = cmbRequiredAccessLevel.SelectedItem?.ToString() ?? "Standard",
                });

                JsonFile.Save("classes.json", _classes);
                _logger.LogInformation("Class added: {Title} trainer={Trainer}", title, trainer.FullName);
                LoadClasses();

                txtClassTitle.Clear();
                if (_trainers.Count > 0) cmbTrainer.SelectedIndex = 0;
                numDuration.Value = numDuration.Minimum;
                numCapacity.Value = numCapacity.Minimum;
                dtpStartTime.Value = DateTime.Now;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la adăugarea clasei:\n" + ex.Message);
            }
        }

        private void UpdateClass()
        {
            try
            {
                var selected = SelectedClass();
                if (selected == null)
                {
                    MessageBox.Show("Selectează o clasă din listă.");
                    return;
                }

                var title = txtClassTitle.Text.Trim();
                if (string.IsNullOrWhiteSpace(title))
                {
                    MessageBox.Show("Titlul nu poate fi gol.");
                    return;
                }

                var trainer = cmbTrainer.SelectedItem as Trainer;
                if (trainer == null)
                {
                    MessageBox.Show("Selectează un antrenor.");
                    return;
                }

                selected.Title = title;
                selected.Trainer = trainer.FullName;
                selected.DurationMinutes = (int)numDuration.Value;
                selected.Capacity = (int)numCapacity.Value;
                selected.StartTime = dtpStartTime.Value;
                selected.RequiredAccessLevel = cmbRequiredAccessLevel.SelectedItem?.ToString() ?? "Standard";

                JsonFile.Save("classes.json", _classes);
                _logger.LogInformation("Class updated: id={Id}", selected.Id);
                LoadClasses();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la modificarea clasei:\n" + ex.Message);
            }
        }

        private void DeleteClass()
        {
            try
            {
                var selected = SelectedClass();
                if (selected == null)
                {
                    MessageBox.Show("Selectează o clasă din listă.");
                    return;
                }

                if (MessageBox.Show("Sigur vrei să ștergi clasa?",
                    "Confirmare", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                    return;

                _classes.RemoveAll(c => c.Id == selected.Id);
                JsonFile.Save("classes.json", _classes);
                _logger.LogWarning("Class deleted: id={Id}", selected.Id);
                LoadClasses();

                txtClassTitle.Clear();
                if (_trainers.Count > 0) cmbTrainer.SelectedIndex = 0;
                numDuration.Value = numDuration.Minimum;
                numCapacity.Value = numCapacity.Minimum;
                dtpStartTime.Value = DateTime.Now;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la ștergerea clasei:\n" + ex.Message);
            }
        }

        private void LoadTrainersIntoCombo()
        {
            try
            {
                _trainers = JsonFile.Load<Trainer>("trainers.json")
                    .OrderBy(t => t.FullName)
                    .ToList();

                cmbTrainer.DataSource = null;
                cmbTrainer.DataSource = _trainers;
                cmbTrainer.DisplayMember = "FullName";
                cmbTrainer.ValueMember = "Id";

                if (_trainers.Count > 0)
                    cmbTrainer.SelectedIndex = 0;
            }
            catch
            {
                cmbTrainer.DataSource = null;
            }
        }

    }
}
