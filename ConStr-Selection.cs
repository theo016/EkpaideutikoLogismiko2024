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
    public partial class ConStr_Selection : Form
    {
        public ConStr_Selection()
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

        private void buttonOutputIf_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The initial value of v is 5 and that of t is 4\r\n" +
                "5 is bigger than 4\r\n" +
                "The new value of v is 3 and the t is 4\r\n" +
                "3 is smaller than 4\r\n" +
                "the new value of v is\r\n" +
                "4\r\n" +
                "The value of v,\r\n" +
                "4 and t, 4, are equal\r\n",
                "If Output", MessageBoxButtons.OK);
        }

        private void buttonIfElse_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The value of v is 4 and that of t is 5\r\n" + "v is less than t", 
                "If-Else Output", MessageBoxButtons.OK);
        }
    }
}
