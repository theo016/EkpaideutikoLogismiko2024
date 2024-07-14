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
    public partial class Func_AdvFunc : Form
    {
        public Func_AdvFunc()
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

        private void buttonPassList_Click(object sender, EventArgs e)
        {
            MessageBox.Show("apple\r\n" +
                            "banana\r\n" +
                            "cherry", 
                            "Passing a List as an Argument Output", MessageBoxButtons.OK);
        }

        private void buttonReturnVals_Click(object sender, EventArgs e)
        {
            MessageBox.Show("15\r\n" +
                            "25\r\n" +
                            "45", 
                            "Return Values Output", MessageBoxButtons.OK);
        }

        private void buttonRecursion_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Recursion Example Results\r\n" +
                            "1\r\n" +
                            "3\r\n" +
                            "6\r\n" +
                            "10\r\n" +
                            "15\r\n" +
                            "21", 
                            "Recursion Output", MessageBoxButtons.OK);
        }

        private void buttonOnlyArgs_Click(object sender, EventArgs e)
        {
            MessageBox.Show("3\r\n" +
                            "3\r\n",
                            "Positional-Only and Keyword-Only Arguments Output", MessageBoxButtons.OK);
        }
    }
}
