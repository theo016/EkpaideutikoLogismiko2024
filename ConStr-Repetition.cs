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
    public partial class ConStr_Repetition : Form
    {
        public ConStr_Repetition()
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

        private void buttonOutputFor_Click(object sender, EventArgs e)
        {
            MessageBox.Show("2, 4, 7, 1, 6, 4,\r\n\r\n" +
                "0, 1, 2, 3, 4, 5, 6, 7, 8, 9,",
                "For Loop Output", MessageBoxButtons.OK);
        }

        private void buttonOutputWhile_Click(object sender, EventArgs e)
        {
            MessageBox.Show("2 3 4 5 6 7 8 While loop is completed", "While Loop Output", MessageBoxButtons.OK);
        }
    }
}
