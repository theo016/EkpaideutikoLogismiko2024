﻿using System;
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
    public partial class Intro_BasicSyntax : Form
    {
        public Intro_BasicSyntax()
        {
            InitializeComponent();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Introduction = new Introduction();
            Introduction.Closed += (s, args) => this.Close();
            Introduction.Show();
        }
    }
}
