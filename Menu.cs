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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Introduction_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Introduction = new Introduction();
            Introduction.Closed += (s, args) => this.Close();
            Introduction.Show();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Successful Log Out!", "Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
            var Login = new Login();
            Login.Closed += (s, args) => this.Close();
            Login.Show();
        }

        private void labelVarsAndDataTypes_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Vars = new Vars();
            Vars.Closed += (s, args) => this.Close();
            Vars.Show();
        }

        private void labelControlStructures_Click(object sender, EventArgs e)
        {
            this.Hide();
            var ConStr = new ConStr();
            ConStr.Closed += (s, args) => this.Close();
            ConStr.Show();
        }

        private void labelFunctions_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Functions = new Functions();
            Functions.Closed += (s, args) => this.Close();
            Functions.Show();
        }

        private void labelDataStructures_Click(object sender, EventArgs e)
        {
            this.Hide();
            var DataStr = new DataStr();
            DataStr.Closed += (s, args) => this.Close();
            DataStr.Show();
        }

        private void labelFileHandling_Click(object sender, EventArgs e)
        {
            this.Hide();
            var File = new File();
            File.Closed += (s, args) => this.Close();
            File.Show();
        }

        private void labelOOP_Click(object sender, EventArgs e)
        {
            this.Hide();
            var OOP = new OOP();
            OOP.Closed += (s, args) => this.Close();
            OOP.Show();
        }
    }
}
