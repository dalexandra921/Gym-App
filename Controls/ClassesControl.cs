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
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace GymApp_final.Controls
{
    public partial class ClassesControl : UserControl
    {
        private List<FitnessClass> _classes = new();
        public ClassesControl()
        {
            InitializeComponent();

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

            LoadClasses();
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
            txtTrainer.Text = c.Trainer;
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

                var trainer = txtTrainer.Text.Trim();
                if (string.IsNullOrWhiteSpace(trainer))
                {
                    MessageBox.Show("Antrenorul nu poate fi gol.");
                    return;
                }

                _classes.Add(new FitnessClass
                {
                    Id = Guid.NewGuid(),
                    Title = title,
                    Trainer = trainer,
                    DurationMinutes = (int)numDuration.Value,
                    Capacity = (int)numCapacity.Value,
                    StartTime = dtpStartTime.Value,
                    RequiredAccessLevel = cmbRequiredAccessLevel.SelectedItem?.ToString() ?? "Standard",
                });

                JsonFile.Save("classes.json", _classes);
                LoadClasses();

                txtClassTitle.Clear();
                txtTrainer.Clear();
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

                var trainer = txtTrainer.Text.Trim();
                if (string.IsNullOrWhiteSpace(trainer))
                {
                    MessageBox.Show("Antrenorul nu poate fi gol.");
                    return;
                }

                selected.Title = title;
                selected.Trainer = trainer;
                selected.DurationMinutes = (int)numDuration.Value;
                selected.Capacity = (int)numCapacity.Value;
                selected.StartTime = dtpStartTime.Value;
                selected.RequiredAccessLevel = cmbRequiredAccessLevel.SelectedItem?.ToString() ?? "Standard";

                JsonFile.Save("classes.json", _classes);
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
                LoadClasses();

                txtClassTitle.Clear();
                txtTrainer.Clear();
                numDuration.Value = numDuration.Minimum;
                numCapacity.Value = numCapacity.Minimum;
                dtpStartTime.Value = DateTime.Now;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la ștergerea clasei:\n" + ex.Message);
            }
        }
    }
}
