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
    public partial class RoomsControl : UserControl
    {
        private List<Room> _rooms = new();
        private List<Zone> _zones = new();
        public RoomsControl()
        {
            InitializeComponent();

            gridRooms.AutoGenerateColumns = true;

            cmbRoomAccess.Items.Clear();
            cmbRoomAccess.Items.Add("Standard");
            cmbRoomAccess.Items.Add("VIP");
            cmbRoomAccess.SelectedIndex = 0;

            numRoomCapacity.Minimum = 1;
            numRoomCapacity.Maximum = 1000;

            btnAddRoom.Click += (_, __) => AddRoom();
            btnUpdateRoom.Click += (_, __) => UpdateRoom();
            btnDeleteRoom.Click += (_, __) => DeleteRoom();
            btnRefreshRooms.Click += (_, __) => LoadData();

            gridRooms.SelectionChanged += (_, __) => FillFromSelected();

            LoadData();
        }

        public void RefreshZones()
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                _zones = JsonFile.Load<Zone>("zones.json")
                    .OrderBy(z => z.Name)
                    .ToList();

                _rooms = JsonFile.Load<Room>("rooms.json")
                    .OrderBy(r => r.Name)
                    .ToList();

                // combo zones
                cmbRoomZone.DataSource = null;
                cmbRoomZone.DataSource = _zones;
                cmbRoomZone.DisplayMember = "Name";
                cmbRoomZone.ValueMember = "Id";
                if (_zones.Count > 0) cmbRoomZone.SelectedIndex = 0;

                // grid: arătăm și numele zonei
                var rows = _rooms.Select(r => new
                {
                    r.Id,
                    r.Name,
                    Zone = _zones.FirstOrDefault(z => z.Id == r.ZoneId)?.Name ?? "(zonă ștearsă)",
                    r.Capacity,
                    r.AccessLevel,
                    r.ZoneId
                }).ToList();

                gridRooms.DataSource = null;
                gridRooms.DataSource = rows;

                if (gridRooms.Columns.Contains("Id"))
                    gridRooms.Columns["Id"].Visible = false;

                if (gridRooms.Columns.Contains("ZoneId"))
                    gridRooms.Columns["ZoneId"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la încărcare săli:\n" + ex.Message);
            }
        }

        private Guid? SelectedRoomId()
        {
            if (gridRooms.CurrentRow?.Cells["Id"]?.Value is Guid id) return id;
            return null;
        }

        private void FillFromSelected()
        {
            var id = SelectedRoomId();
            if (id == null) return;

            var room = _rooms.FirstOrDefault(r => r.Id == id.Value);
            if (room == null) return;

            txtRoomName.Text = room.Name;
            numRoomCapacity.Value = room.Capacity;

            cmbRoomAccess.SelectedItem = room.AccessLevel;
            if (cmbRoomAccess.SelectedItem == null) cmbRoomAccess.SelectedIndex = 0;

            var zone = _zones.FirstOrDefault(z => z.Id == room.ZoneId);
            if (zone != null) cmbRoomZone.SelectedItem = zone;
        }

        private void AddRoom()
        {
            try
            {
                var name = txtRoomName.Text.Trim();
                if (string.IsNullOrWhiteSpace(name))
                {
                    MessageBox.Show("Numele sălii nu poate fi gol.");
                    return;
                }

                var zone = cmbRoomZone.SelectedItem as Zone;
                if (zone == null)
                {
                    MessageBox.Show("Selectează o zonă.");
                    return;
                }

                _rooms.Add(new Room
                {
                    Id = Guid.NewGuid(),
                    Name = name,
                    ZoneId = zone.Id,
                    Capacity = (int)numRoomCapacity.Value,
                    AccessLevel = cmbRoomAccess.SelectedItem?.ToString() ?? "Standard"
                });

                JsonFile.Save("rooms.json", _rooms);
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la adăugare sală:\n" + ex.Message);
            }
        }

        private void UpdateRoom()
        {
            try
            {
                var id = SelectedRoomId();
                if (id == null)
                {
                    MessageBox.Show("Selectează o sală.");
                    return;
                }

                var room = _rooms.FirstOrDefault(r => r.Id == id.Value);
                if (room == null) return;

                var name = txtRoomName.Text.Trim();
                if (string.IsNullOrWhiteSpace(name))
                {
                    MessageBox.Show("Numele sălii nu poate fi gol.");
                    return;
                }

                var zone = cmbRoomZone.SelectedItem as Zone;
                if (zone == null)
                {
                    MessageBox.Show("Selectează o zonă.");
                    return;
                }

                room.Name = name;
                room.ZoneId = zone.Id;
                room.Capacity = (int)numRoomCapacity.Value;
                room.AccessLevel = cmbRoomAccess.SelectedItem?.ToString() ?? "Standard";

                JsonFile.Save("rooms.json", _rooms);
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la modificare sală:\n" + ex.Message);
            }
        }

        private void DeleteRoom()
        {
            try
            {
                var id = SelectedRoomId();
                if (id == null)
                {
                    MessageBox.Show("Selectează o sală.");
                    return;
                }

                if (MessageBox.Show("Sigur vrei să ștergi sala?",
                    "Confirmare", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                    return;

                _rooms.RemoveAll(r => r.Id == id.Value);
                JsonFile.Save("rooms.json", _rooms);
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la ștergere sală:\n" + ex.Message);
            }
        }
    }
}
