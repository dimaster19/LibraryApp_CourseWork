
using LibraryApp.Services;
using System;
using Serilog;
using System.Windows.Forms;


namespace LibraryApp.View
{
    public partial class Authorization : Form
    {
        private IAuthService _authService = new AuthService();
        public Authorization()
        {
            InitializeComponent();
            designPictureBox.BackColor = System.Drawing.Color.FromArgb(255, 76, 183, 173);
            design2PictureBox.BackColor = System.Drawing.Color.FromArgb(255, 0, 151, 137);
            authButton.BackColor = System.Drawing.Color.FromArgb(255, 76, 183, 173);
            regButton.BackColor = System.Drawing.Color.FromArgb(255, 76, 183, 173);
            closeButton.BackColor = System.Drawing.Color.FromArgb(255, 0, 151, 137);
            designLabel.BackColor = System.Drawing.Color.FromArgb(255, 76, 183, 173);

        }

        private void authButton_Click(object sender, EventArgs e)
        {
            if (_authService.Authorize(loginTextBox.Text.ToString(), passwordTextBox.Text.ToString()) == true)
            {
                if (Status.Value)
                {
                    MessageBox.Show("Вы авторизовались как администратор", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Вы авторизовались как пользователь", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                Status.Enter = true;
                Status.User = loginTextBox.Text.ToString();
                Log.Information($"Пользователь {Status.User} вошел в сеть.");
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Wrong login or password!");
            }
        }

        private void regButton_Click(object sender, EventArgs e)
        {
            Registration reg = new Registration();
            reg.ShowDialog();
            loginTextBox.Text = reg.loginTextBox.Text;
            passwordTextBox.Text = reg.password1TextBox.Text;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (passwordCheckBox.Checked)
            {
                passwordTextBox.PasswordChar = (char)0;
            }
            else
            {
                passwordTextBox.PasswordChar = '*';
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
