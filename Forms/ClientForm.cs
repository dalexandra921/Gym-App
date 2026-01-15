using GymApp_final.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GymApp_final.Controls;

namespace GymApp_final
{
    public partial class ClientForm : Form
    {
        private readonly Account _account;
        public ClientForm(Account account)
        {
            InitializeComponent();

            _account = account;
            this.Text = $"Client - {_account.Username}";

            var schedule = new ClientScheduleControl(_account.Username);
            schedule.Dock = DockStyle.Fill;
            tabSchedule.Controls.Add(schedule);

            var myBookings = new MyBookingsControl(_account.Username);
            myBookings.Dock = DockStyle.Fill;
            tabMyBookings.Controls.Add(myBookings);

            var subs = new SubscriptionsControl(_account.Username);
            subs.Dock = DockStyle.Fill;
            tabSubscriptions.Controls.Add(subs);

            var rooms = new ClientRoomsControl(_account.Username);
            rooms.Dock = DockStyle.Fill;
            tabRooms.Controls.Add(rooms);

        }
    }
}
