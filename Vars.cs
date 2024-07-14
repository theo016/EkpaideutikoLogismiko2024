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
    public partial class Vars : Form
    {
        public Vars()
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

        private void labelDataTypes_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Vars_DataTypes = new Vars_DataTypes();
            Vars_DataTypes.Closed += (s, args) => this.Close();
            Vars_DataTypes.Show();
        }

        private void labelVariables_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Vars_Variables = new Vars_Variables();
            Vars_Variables.Closed += (s, args) => this.Close();
            Vars_Variables.Show();
        }

        private void labelVarAndAss_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Vars_VarNamesAndAssignment = new Vars_VarNamesAndAssignment();
            Vars_VarNamesAndAssignment.Closed += (s, args) => this.Close();
            Vars_VarNamesAndAssignment.Show();
        }

        private void labelGlobalVariables_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Vars_GlobalVars = new Vars_GlobalVars();
            Vars_GlobalVars.Closed += (s, args) => this.Close();
            Vars_GlobalVars.Show();
        }
    }
}
