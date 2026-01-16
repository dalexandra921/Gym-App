using GymApp_final.Models;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System.Linq;
using System.Security.Principal;
using System.Text.Json;

namespace GymApp_final
{
    public partial class LoginForm : Form
    {
        private readonly ILogger<LoginForm> _logger;

        public LoginForm(ILogger<LoginForm> logger)
        {
            InitializeComponent();
            _logger = logger;

            _logger.LogInformation("LoginForm opened");
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var username = txtUsername.Text.Trim();
            var password = txtPassword.Text;

            _logger.LogInformation("Login attempt: {Username}", username); //citesc cu hosting

            try
            {
                var path = Path.Combine(AppContext.BaseDirectory, "users.json");

                if (!File.Exists(path))
                {
                    _logger.LogError("users.json missing at {Path}", path);
                    MessageBox.Show("Fișierul users.json lipsește.", "Eroare",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var json = File.ReadAllText(path);

                var accounts = JsonSerializer.Deserialize<List<Account>>(json)
                               ?? new List<Account>();

                var acc = accounts.FirstOrDefault(a =>
                    string.Equals(a.Username, username, StringComparison.OrdinalIgnoreCase) &&
                    a.Password == password);

                if (acc == null)
                {
                    _logger.LogWarning("Login failed for: {Username}", username);

                    MessageBox.Show("User/parolă greșite.", "Eroare",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                _logger.LogInformation("Login success for: {Username}, role={Role}", acc.Username, acc.Role);

                if (acc.Role == "Admin")
                {
                    var f = new AdminForm();
                    f.FormClosed += (_, __) => this.Close();
                    f.Show();
                    this.Hide();
                }
                else
                {
                    // ia logger-ul pentru ClientForm din DI
                    var clientLogger = Program.AppHost.Services.GetRequiredService<ILogger<ClientForm>>();

                    var f = new ClientForm(acc, clientLogger);
                    f.FormClosed += (_, __) => this.Close();
                    f.Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error during login for {Username}", username);

                MessageBox.Show("Eroare la login:\n" + ex.Message, "Eroare",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
