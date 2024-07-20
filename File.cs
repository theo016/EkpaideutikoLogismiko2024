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
    public partial class File : Form
    {
        public File()
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

        private void open_read_Click(object sender, EventArgs e)
        {
            this.Hide();
            var File_OpenRead = new File_OpenRead();
            File_OpenRead.Closed += (s, args) => this.Close();
            File_OpenRead.Show();
        }

        private void labelCreate_Click(object sender, EventArgs e)
        {
            this.Hide();
            var File_CreateWrite = new File_CreateWrite();
            File_CreateWrite.Closed += (s, args) => this.Close();
            File_CreateWrite.Show();
        }

        private void labelDel_Click(object sender, EventArgs e)
        {
            this.Hide();
            var File_Delete = new File_Delete();
            File_Delete.Closed += (s, args) => this.Close();
            File_Delete.Show();
        }
    }
}
