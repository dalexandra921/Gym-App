using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GymApp_final.Data;
using GymApp_final.Models;

namespace GymApp_final.Controls
{
    public partial class ClientScheduleControl : UserControl
    {
        private string _username = "";
        private List<FitnessClass> _classes = new();
        private List<Booking> _bookings = new();

        public ClientScheduleControl()
        {
            InitializeComponent();

            gridSchedule.AutoGenerateColumns = true;
            btnReserve.Click += (_, __) => Reserve();

            LoadData(); 
        }

        public ClientScheduleControl(string username) : this()
        {
            _username = username; // doar setează userul
        }

        private void LoadData()
        {
            try
            {
                _classes = JsonFile.Load<FitnessClass>("classes.json")
                    .OrderBy(c => c.StartTime)
                    .ToList();

                _bookings = JsonFile.Load<Booking>("bookings.json");

                gridSchedule.DataSource = null;
                gridSchedule.DataSource = _classes;

                if (gridSchedule.Columns.Contains("Id"))
                    gridSchedule.Columns["Id"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la încărcare:\n" + ex.Message);
            }
        }

        private FitnessClass? SelectedClass()
            => gridSchedule.CurrentRow?.DataBoundItem as FitnessClass;

        private void Reserve()
        {
            if (string.IsNullOrWhiteSpace(_username))
            {
                MessageBox.Show("Eroare: utilizatorul nu este setat.");
                return;
            }

            try
            {
                var c = SelectedClass();
                if (c == null)
                {
                    MessageBox.Show("Selectează o clasă.");
                    return;
                }

                // deja rezervat?
                if (_bookings.Any(b => b.Username == _username && b.ClassId == c.Id))
                {
                    MessageBox.Show("Ai deja rezervare la această clasă.");
                    return;
                }

                // capacitate
                var reservedCount = _bookings.Count(b => b.ClassId == c.Id);
                if (reservedCount >= c.Capacity)
                {
                    MessageBox.Show("Nu mai sunt locuri disponibile.");
                    return;
                }

                _bookings.Add(new Booking
                {
                    Id = Guid.NewGuid(),
                    Username = _username,
                    ClassId = c.Id,
                    CreatedAt = DateTime.Now
                });

                JsonFile.Save("bookings.json", _bookings);
                MessageBox.Show("Rezervare efectuată!");
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la rezervare:\n" + ex.Message);
            }
        }

    }
}
