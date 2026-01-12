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
    public partial class MyBookingsControl : UserControl
    {
        private readonly string _username;
        private List<Booking> _bookings = new();
        private List<FitnessClass> _classes = new();

        public MyBookingsControl(string username)
        {
            InitializeComponent();
            _username = username;

            gridMyBookings.AutoGenerateColumns = true;
            btnCancel.Click += (_, __) => CancelBooking();
            btnRefresh.Click += (_, __) => LoadData();

            LoadData();
        }

        private void LoadData()
        {
            try
            {
                _classes = JsonFile.Load<FitnessClass>("classes.json");
                _bookings = JsonFile.Load<Booking>("bookings.json");

                var my = _bookings
                    .Where(b => b.Username == _username)
                    .Join(_classes,
                        b => b.ClassId,
                        c => c.Id,
                        (b, c) => new
                        {
                            BookingId = b.Id,
                            c.Title,
                            c.Trainer,
                            c.StartTime,
                            c.DurationMinutes,
                            CreatedAt = b.CreatedAt
                        })
                    .OrderBy(x => x.StartTime)
                    .ToList();

                gridMyBookings.DataSource = null;
                gridMyBookings.DataSource = my;

                if (gridMyBookings.Columns.Contains("BookingId"))
                    gridMyBookings.Columns["BookingId"].Visible = false;

                if (gridMyBookings.Columns.Contains("StartTime"))
                    gridMyBookings.Columns["StartTime"].DefaultCellStyle.Format = "dd.MM.yyyy HH:mm";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la încărcarea rezervărilor:\n" + ex.Message);
            }
        }

        private Guid? SelectedBookingId()
        {
            if (gridMyBookings.CurrentRow?.DataBoundItem == null) return null;
            var prop = gridMyBookings.CurrentRow.DataBoundItem.GetType().GetProperty("BookingId");
            return prop?.GetValue(gridMyBookings.CurrentRow.DataBoundItem) as Guid?;
        }

        private void CancelBooking()
        {
            try
            {
                var bookingId = SelectedBookingId();
                if (bookingId == null)
                {
                    MessageBox.Show("Selectează o rezervare.");
                    return;
                }

                if (MessageBox.Show("Sigur vrei să anulezi rezervarea?",
                    "Confirmare", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                    return;

                _bookings.RemoveAll(b => b.Id == bookingId.Value && b.Username == _username);
                JsonFile.Save("bookings.json", _bookings);
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la anulare:\n" + ex.Message);
            }
        }
    }
}
