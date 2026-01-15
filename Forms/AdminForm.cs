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

            tabMain.SelectedIndexChanged += (_, __) =>
            {
                if (tabMain.SelectedTab != null && tabMain.SelectedTab == tabClasses)
                {
                    ClassesControl.RefreshTrainers();
                }
            };

        }

        private void tabBookings_Enter(object sender, EventArgs e)
        {
            // găsește controlul din tab și dă refresh
            var view = tabBookings.Controls.OfType<AdminBookingsViewControl>().FirstOrDefault();
            view?.LoadData();
        }

    }
}
