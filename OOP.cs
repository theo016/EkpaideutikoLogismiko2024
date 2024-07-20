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
    public partial class OOP : Form
    {
        public OOP()
        {
            InitializeComponent();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Menu = new Menu();
            Menu.Closed += (s, args) => this.Close();
            Menu.Show();
        }

        private void basics_Click(object sender, EventArgs e)
        {
            this.Hide();
            var OOP_Basics = new OOP_Basics();
            OOP_Basics.Closed += (s, args) => this.Close();
            OOP_Basics.Show();
        }

        private void advanced_Click(object sender, EventArgs e)
        {
            this.Hide();
            var OOP_Advanced = new OOP_Advanced();
            OOP_Advanced.Closed += (s, args) => this.Close();
            OOP_Advanced.Show();
        }

        private void bestPractices_Click(object sender, EventArgs e)
        {
            this.Hide();
            var OOP_BestPractices = new OOP_BestPractices();
            OOP_BestPractices.Closed += (s, args) => this.Close();
            OOP_BestPractices.Show();
        }
    }
}
