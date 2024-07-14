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
    public partial class Func_FuncIntro : Form
    {
        public Func_FuncIntro()
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
    }
}
