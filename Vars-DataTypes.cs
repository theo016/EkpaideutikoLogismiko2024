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
    public partial class Vars_DataTypes : Form
    {
        public Vars_DataTypes()
        {
            InitializeComponent();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Vars = new Vars();
            Vars.Closed += (s, args) => this.Close();
            Vars.Show();
        }
    }
}
