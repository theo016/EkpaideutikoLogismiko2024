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
    public partial class DataStr_SequenceTypes : Form
    {
        public DataStr_SequenceTypes()
        {
            InitializeComponent();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            var DataStr = new DataStr();
            DataStr.Closed += (s, args) => this.Close();
            DataStr.Show();
        }
    }
}
