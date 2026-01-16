using GymApp_final.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymApp_final
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();

            tabRooms.Enter += tabRooms_Enter;
            tabBookings.Enter += tabBookings_Enter;

            tabMain.SelectedIndexChanged += (_, __) =>
            {
                if (tabMain.SelectedTab == tabClasses)
                {
                    var cc = tabClasses.Controls.OfType<ClassesControl>().FirstOrDefault();
                    cc?.RefreshTrainers();
                }
            };
        }


        private void tabBookings_Enter(object sender, EventArgs e)
        {
            var view = tabBookings.Controls.OfType<AdminBookingsViewControl>().FirstOrDefault();
            view?.LoadData();
        }

        private void tabRooms_Enter(object sender, EventArgs e)
        {
            var rooms = tabRooms.Controls.OfType<RoomsControl>().FirstOrDefault();
            rooms?.RefreshZones();
        }

    }
}
