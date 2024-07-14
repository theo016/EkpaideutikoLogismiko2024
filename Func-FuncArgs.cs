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
    public partial class Func_FuncArgs : Form
    {
        public Func_FuncArgs()
        {
            InitializeComponent();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Functions = new Functions();
            Functions.Closed += (s, args) => this.Close();
            Functions.Show();
        }

        private void buttonArgs_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Emil Refsnes\r\n" +
                            "Tobias Refsnes\r\n" +
                            "Linus Refsnes", 
                            "Arguments Output", MessageBoxButtons.OK);
        }

        private void buttonNumOfArgs_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Emil Refsnes", "Number of Arguments Output", MessageBoxButtons.OK);
        }

        private void buttonArbArgs_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The youngest child is Linus", "Arbitrary Arguments '*args' Output", MessageBoxButtons.OK);
        }
    }
}
