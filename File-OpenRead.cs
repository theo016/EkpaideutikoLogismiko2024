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
    public partial class File_OpenRead : Form
    {
        public File_OpenRead()
        {
            InitializeComponent();
        }

        private void buttonExampleOpen_Click(object sender, EventArgs e)
        {
            MessageBox.Show("f = open(\"demofile.txt\", \"r\")\r\nprint(f.read()) ", "Open and Read a file", MessageBoxButtons.OK);
        }
    }
}
