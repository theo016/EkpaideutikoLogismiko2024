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
    public partial class Functions : Form
    {
        public Functions()
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

        private void labelFuncIntro_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Func_FuncIntro = new Func_FuncIntro();
            Func_FuncIntro.Closed += (s, args) => this.Close();
            Func_FuncIntro.Show();
        }

        private void labelFuncArgs_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Func_FuncArgs = new Func_FuncArgs();
            Func_FuncArgs.Closed += (s, args) => this.Close();
            Func_FuncArgs.Show();
        }

        private void labelKeyArgs_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Func_KeyArgs = new Func_KeyArgs();
            Func_KeyArgs.Closed += (s, args) => this.Close();
            Func_KeyArgs.Show();
        }

        private void labelAdvFunc_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Func_AdvFunc = new Func_AdvFunc();
            Func_AdvFunc.Closed += (s, args) => this.Close();
            Func_AdvFunc.Show();
        }
    }
}
