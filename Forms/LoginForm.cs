using System.Text.Json;
using GymApp_final.Models;
using System.Linq;

namespace GymApp_final
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var username = txtUsername.Text.Trim();
            var password = txtPassword.Text;

            var path = Path.Combine(AppContext.BaseDirectory, "users.json");
            var json = File.ReadAllText(path);

            var accounts = JsonSerializer.Deserialize<List<Account>>(json)
                           ?? new List<Account>();

            var acc = accounts.FirstOrDefault(a =>
                string.Equals(a.Username, username, StringComparison.OrdinalIgnoreCase) &&
                a.Password == password);

            if (acc == null)
            {
                MessageBox.Show("User/parolă greșite.", "Eroare",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (acc.Role == "Admin")
            {
                var f = new AdminForm();
                f.FormClosed += (_, __) => this.Close();
                f.Show();
                this.Hide();
            }
            else
            {
                var f = new ClientForm(acc);
                f.FormClosed += (_, __) => this.Close();
                f.Show();
                this.Hide();
            }
        }

    }
}
