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
    public partial class AdminBookingsViewControl : UserControl
    {
        private List<FitnessClass> _classes = new();
        private List<Booking> _bookings = new();
        private List<Account> _users = new(); //verific userii din users.json

        public AdminBookingsViewControl()
        {
            InitializeComponent();

            gridClassesAdmin.AutoGenerateColumns = true;
            gridBookingsAdmin.AutoGenerateColumns = true;

            // events
            gridClassesAdmin.SelectionChanged += (_, __) => LoadBookingsForSelectedClass();

            btnRefreshAdminBookings.Click += (_, __) => LoadData();
            btnDeleteBookingAdmin.Click += (_, __) => DeleteSelectedBooking();

            LoadData();
        }

        
        public void LoadData()
        {
            try
            {
                _classes = JsonFile.Load<FitnessClass>("classes.json")
                    .OrderBy(c => c.StartTime)
                    .ToList();

                _bookings = JsonFile.Load<Booking>("bookings.json");

                gridClassesAdmin.DataSource = null;

                var classRows = _classes.Select(c => new
                {
                    c.Id,
                    c.Title,
                    c.Trainer,
                    StartTime = c.StartTime,
                    c.Capacity,
                    Reserved = _bookings.Count(b => b.ClassId == c.Id)
                })
                .ToList();

                gridClassesAdmin.DataSource = classRows;

                if (gridClassesAdmin.Columns.Contains("Id"))
                    gridClassesAdmin.Columns["Id"].Visible = false;

                if (gridClassesAdmin.Columns.Contains("StartTime"))
                    gridClassesAdmin.Columns["StartTime"].DefaultCellStyle.Format = "dd.MM.yyyy HH:mm";

                // reset rezervări
                lblSelectedClass.Text = "Rezervări pentru: (nimic selectat)";
                gridBookingsAdmin.DataSource = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la încărcare date admin rezervări:\n" + ex.Message);
            }
        }

        private Guid? SelectedClassId()
        {
            try
            {
                if (gridClassesAdmin.CurrentRow == null) return null;
                var cell = gridClassesAdmin.CurrentRow.Cells["Id"]?.Value;
                if (cell is Guid id) return id;
                return null;
            }
            catch
            {
                return null;
            }
        }

        private void LoadBookingsForSelectedClass()
        {
            try
            {
                var classId = SelectedClassId();
                if (classId == null)
                {
                    lblSelectedClass.Text = "Rezervări pentru: (nimic selectat)";
                    gridBookingsAdmin.DataSource = null;
                    return;
                }

                var cls = _classes.FirstOrDefault(c => c.Id == classId.Value);
                if (cls == null)
                {
                    lblSelectedClass.Text = "Rezervări pentru: (clasă ștearsă)";
                    gridBookingsAdmin.DataSource = null;
                    return;
                }

                lblSelectedClass.Text = $"Rezervări pentru: {cls.Title} ({cls.StartTime:dd.MM.yyyy HH:mm})";

                var rows = _bookings
                    .Where(b => b.ClassId == classId.Value)
                    .OrderBy(b => b.CreatedAt)
                    .Select(b => new
                    {
                        b.Id,
                        b.Username,
                        b.CreatedAt
                    })
                    .ToList();

                gridBookingsAdmin.DataSource = null;
                gridBookingsAdmin.DataSource = rows;

                if (gridBookingsAdmin.Columns.Contains("Id"))
                    gridBookingsAdmin.Columns["Id"].Visible = false;

                if (gridBookingsAdmin.Columns.Contains("CreatedAt"))
                    gridBookingsAdmin.Columns["CreatedAt"].DefaultCellStyle.Format = "dd.MM.yyyy HH:mm";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la încărcare rezervări:\n" + ex.Message);
            }
        }

        private Guid? SelectedBookingId()
        {
            try
            {
                if (gridBookingsAdmin.CurrentRow == null) return null;
                var cell = gridBookingsAdmin.CurrentRow.Cells["Id"]?.Value;
                if (cell is Guid id) return id;
                return null;
            }
            catch
            {
                return null;
            }
        }

        private void DeleteSelectedBooking()
        {
            try
            {
                var bookingId = SelectedBookingId();
                if (bookingId == null)
                {
                    MessageBox.Show("Selectează o rezervare din listă.");
                    return;
                }

                if (MessageBox.Show("Sigur vrei să ștergi rezervarea?",
                    "Confirmare", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                    return;

                _bookings.RemoveAll(b => b.Id == bookingId.Value);
                JsonFile.Save("bookings.json", _bookings);

                // refresh view
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la ștergere rezervare:\n" + ex.Message);
            }
        }

    }
}
