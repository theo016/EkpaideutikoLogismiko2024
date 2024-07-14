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
    public partial class ConStr : Form
    {
        public ConStr()
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

        private void labelConIntro_Click(object sender, EventArgs e)
        {
            this.Hide();
            var ConStr_ConStrInPython = new ConStr_ConStrInPython();
            ConStr_ConStrInPython.Closed += (s, args) => this.Close();
            ConStr_ConStrInPython.Show();
        }

        private void labelSequential_Click(object sender, EventArgs e)
        {
            this.Hide();
            var ConStr_Sequential = new ConStr_Sequential();
            ConStr_Sequential.Closed += (s, args) => this.Close();
            ConStr_Sequential.Show();
        }

        private void labelSelection_Click(object sender, EventArgs e)
        {
            this.Hide();
            var ConStr_Selection = new ConStr_Selection();
            ConStr_Selection.Closed += (s, args) => this.Close();
            ConStr_Selection.Show();
        }

        private void labelRepetition_Click(object sender, EventArgs e)
        {
            this.Hide();
            var ConStr_Repetition = new ConStr_Repetition();
            ConStr_Repetition.Closed += (s, args) => this.Close();
            ConStr_Repetition.Show();
        }
    }
}
