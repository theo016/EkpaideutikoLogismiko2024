using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EkpaideutikoLogismiko2024
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Successful Login!", "Status", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Hide();
            var Menu = new Menu();
            Menu.Closed += (s, args) => this.Close();
            Menu.Show();
        }

        private void labelSignUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            var SignUp = new SignUp();
            SignUp.Closed += (s, args) => this.Close();
            SignUp.Show();
        }

        private void labelSignUp_MouseEnter(object sender, EventArgs e)
        {
            labelSignUp.Font = new Font(labelSignUp.Font, FontStyle.Underline);
        }

        private void labelSignUp_MouseLeave(object sender, EventArgs e)
        {
            labelSignUp.Font = new Font(labelSignUp.Font, FontStyle.Regular);
        }
    }
}
