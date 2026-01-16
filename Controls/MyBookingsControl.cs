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
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.DependencyInjection;

namespace GymApp_final.Controls
{
    public partial class MyBookingsControl : UserControl
    {
        private readonly string _username;
        private readonly ILogger<MyBookingsControl> _logger;
        private List<Booking> _bookings = new();
        private List<FitnessClass> _classes = new();

        public MyBookingsControl(string username)
        {
            InitializeComponent();
            _username = username;

            _logger = Program.AppHost.Services.GetRequiredService<ILogger<MyBookingsControl>>();

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

                var now = DateTime.Now;

                var my = _bookings
                    .Where(b => b.Username == _username)
                    .Select(b =>
                    {
                        var c = _classes.FirstOrDefault(x => x.Id == b.ClassId);

                        DateTime? start = c?.StartTime;

                        var status =
                            start == null ? "Clasă ștearsă" :
                            start.Value < now ? "Trecută" :
                            "Viitoare";

                        return new
                        {
                            b.Id,
                            ClassTitle = c?.Title ?? "(clasă ștearsă)",
                            StartTime = start,
                            Trainer = c?.Trainer ?? "",
                            Status = status,
                            b.CreatedAt
                        };
                    })
                    // pune întâi viitoare, apoi trecute
                    .OrderBy(x => x.Status == "Viitoare" ? 0 : 1)
                    .ThenBy(x => x.StartTime ?? DateTime.MaxValue)
                    .ToList();

                gridMyBookings.DataSource = null;
                gridMyBookings.DataSource = my;

                if (gridMyBookings.Columns.Contains("StartTime"))
                    gridMyBookings.Columns["StartTime"].DefaultCellStyle.Format = "dd.MM.yyyy HH:mm";

                if (gridMyBookings.Columns.Contains("Id"))
                    gridMyBookings.Columns["Id"].Visible = false;

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
            try
            {
                if (gridMyBookings.CurrentRow == null) return null;

                var cell = gridMyBookings.CurrentRow.Cells["Id"]?.Value;
                if (cell is Guid id) return id;

                return null;
            }
            catch
            {
                return null;
            }
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

                // caută rezervarea
                var booking = _bookings.FirstOrDefault(b => b.Id == bookingId.Value && b.Username == _username);
                if (booking == null)
                {
                    MessageBox.Show("Rezervarea nu mai există.");
                    LoadData();
                    return;
                }

                // caută clasa rezervată
                var cls = _classes.FirstOrDefault(c => c.Id == booking.ClassId);

                _logger.LogInformation("Cancel attempt: user={User}, bookingId={BookingId}", _username, bookingId.Value);

                // dacă clasa a fost ștearsă, permiți anularea rezervării
                if (cls == null)
                {
                    if (MessageBox.Show("Clasa a fost ștearsă. Șterg rezervarea din istoric?",
                        "Confirmare", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                        return;

                    _logger.LogInformation("Booking cancelled: user={User}, bookingId={BookingId}", _username, bookingId.Value);

                    _bookings.RemoveAll(b => b.Id == booking.Id && b.Username == _username);
                    JsonFile.Save("bookings.json", _bookings);
                    MessageBox.Show("Rezervarea a fost anulată.");
                    LoadData();
                    return;
                }

                // REGULA: nu pot anula cu mai putin de 2 ore inainte de inceperea clasei
                var diff = cls.StartTime - DateTime.Now;
                if (diff.TotalHours < 2)
                {
                    MessageBox.Show("Nu poți anula cu mai puțin de 2 ore înainte de începerea clasei.");
                    return;
                }

                if (diff.TotalMinutes <= 0)
                {
                    MessageBox.Show("Clasa a început deja / s-a terminat. Nu mai poți anula.");
                    return;
                }

                if (MessageBox.Show("Sigur vrei să anulezi rezervarea?",
                    "Confirmare", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                    return;

                _bookings.RemoveAll(b => b.Id == booking.Id && b.Username == _username);
                JsonFile.Save("bookings.json", _bookings);

                MessageBox.Show("Rezervarea a fost anulată.");
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la anulare:\n" + ex.Message);
                _logger.LogError(ex, "Cancel failed: user={User}", _username);
            }
        }

    }
}
