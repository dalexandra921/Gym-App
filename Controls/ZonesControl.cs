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
    public partial class ZonesControl : UserControl
    {
        private List<Zone> _zones = new();
        public ZonesControl()
        {
            InitializeComponent();

            gridZones.AutoGenerateColumns = true;

            cmbZoneAccess.Items.Clear();
            cmbZoneAccess.Items.Add("Standard");
            cmbZoneAccess.Items.Add("VIP");
            cmbZoneAccess.SelectedIndex = 0;

            numOpenHour.Minimum = 0; numOpenHour.Maximum = 23;
            numCloseHour.Minimum = 0; numCloseHour.Maximum = 23;

            btnAddZone.Click += (_, __) => AddZone();
            btnUpdateZone.Click += (_, __) => UpdateZone();
            btnDeleteZone.Click += (_, __) => DeleteZone();
            btnRefreshZones.Click += (_, __) => LoadZones();

            gridZones.SelectionChanged += (_, __) => FillFromSelected();

            LoadZones();
        }

        private void LoadZones()
        {
            try
            {
                _zones = JsonFile.Load<Zone>("zones.json")
                    .OrderBy(z => z.Name)
                    .ToList();

                gridZones.DataSource = null;
                gridZones.DataSource = _zones;

                if (gridZones.Columns.Contains("Id"))
                    gridZones.Columns["Id"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la încărcarea zonelor:\n" + ex.Message);
            }
        }

        private Zone? SelectedZone()
            => gridZones.CurrentRow?.DataBoundItem as Zone;

        private void FillFromSelected()
        {
            var z = SelectedZone();
            if (z == null) return;

            txtZoneName.Text = z.Name;
            cmbZoneAccess.SelectedItem = z.AccessLevel;
            if (cmbZoneAccess.SelectedItem == null) cmbZoneAccess.SelectedIndex = 0;

            numOpenHour.Value = z.OpenHour;
            numCloseHour.Value = z.CloseHour;
        }

        private void AddZone()
        {
            try
            {
                var name = txtZoneName.Text.Trim();
                if (string.IsNullOrWhiteSpace(name))
                {
                    MessageBox.Show("Numele zonei nu poate fi gol.");
                    return;
                }

                var open = (int)numOpenHour.Value;
                var close = (int)numCloseHour.Value;
                if (open == close)
                {
                    MessageBox.Show("OpenHour și CloseHour nu pot fi egale.");
                    return;
                }

                _zones.Add(new Zone
                {
                    Id = Guid.NewGuid(),
                    Name = name,
                    AccessLevel = cmbZoneAccess.SelectedItem?.ToString() ?? "Standard",
                    OpenHour = open,
                    CloseHour = close
                });

                JsonFile.Save("zones.json", _zones);
                LoadZones();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la adăugare zonă:\n" + ex.Message);
            }
        }

        private void UpdateZone()
        {
            try
            {
                var z = SelectedZone();
                if (z == null)
                {
                    MessageBox.Show("Selectează o zonă.");
                    return;
                }

                var name = txtZoneName.Text.Trim();
                if (string.IsNullOrWhiteSpace(name))
                {
                    MessageBox.Show("Numele zonei nu poate fi gol.");
                    return;
                }

                var open = (int)numOpenHour.Value;
                var close = (int)numCloseHour.Value;

                z.Name = name;
                z.AccessLevel = cmbZoneAccess.SelectedItem?.ToString() ?? "Standard";
                z.OpenHour = open;
                z.CloseHour = close;

                JsonFile.Save("zones.json", _zones);
                LoadZones();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la modificare zonă:\n" + ex.Message);
            }
        }

        private void DeleteZone()
        {
            try
            {
                var z = SelectedZone();
                if (z == null)
                {
                    MessageBox.Show("Selectează o zonă.");
                    return;
                }

                if (MessageBox.Show("Sigur vrei să ștergi zona?",
                    "Confirmare", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                    return;

                _zones.RemoveAll(x => x.Id == z.Id);
                JsonFile.Save("zones.json", _zones);
                LoadZones();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la ștergere zonă:\n" + ex.Message);
            }
        }
    }
}
