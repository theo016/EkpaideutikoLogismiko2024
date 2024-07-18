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
    public partial class DataStr : Form
    {
        public DataStr()
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

        private void intro_and_setup_Click(object sender, EventArgs e)
        {
            this.Hide();
            var DataStr_SequenceTypes = new DataStr_SequenceTypes();
            DataStr_SequenceTypes.Closed += (s, args) => this.Close();
            DataStr_SequenceTypes.Show();
        }

        private void labelBasicSyntax_Click(object sender, EventArgs e)
        {
            this.Hide();
            var DataStr_MappingTypes = new DataStr_MappingTypes();
            DataStr_MappingTypes.Closed += (s, args) => this.Close();
            DataStr_MappingTypes.Show();
        }

        private void labelRunAndDeb_Click(object sender, EventArgs e)
        {
            this.Hide();
            var DataStr_SetTypes = new DataStr_SetTypes();
            DataStr_SetTypes.Closed += (s, args) => this.Close();
            DataStr_SetTypes.Show();
        }
    }
}
