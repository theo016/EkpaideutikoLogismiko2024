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
    public partial class ConStr_Sequential : Form
    {
        public ConStr_Sequential()
        {
            InitializeComponent();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            var ConStr = new ConStr();
            ConStr.Closed += (s, args) => this.Close();
            ConStr.Show();
        }
    }
}
