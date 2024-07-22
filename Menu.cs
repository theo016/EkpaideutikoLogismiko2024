using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace EkpaideutikoLogismiko2024
{
    public partial class Menu : Form
    {
        String username;

        public Menu(string username)
        {
            InitializeComponent();
            this.username = username;
        }


        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-9RR5NNA6\MSSQLSERVER01;Initial Catalog=Learn;Integrated Security=True;");


        private void Introduction_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Introduction = new Introduction(username);
            Introduction.Closed += (s, args) => this.Close();
            Introduction.Show();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Successful Log Out!", "Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
            var Login = new Login();
            Login.Closed += (s, args) => this.Close();
            Login.Show();
        }

        private void labelVarsAndDataTypes_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Vars = new Vars(username);
            Vars.Closed += (s, args) => this.Close();
            Vars.Show();
        }

        private void labelControlStructures_Click(object sender, EventArgs e)
        {
            this.Hide();
            var ConStr = new ConStr(username);
            ConStr.Closed += (s, args) => this.Close();
            ConStr.Show();
        }

        private void labelFunctions_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Functions = new Functions(username);
            Functions.Closed += (s, args) => this.Close();
            Functions.Show();
        }

        private void labelDataStructures_Click(object sender, EventArgs e)
        {
            this.Hide();
            var DataStr = new DataStr(username);
            DataStr.Closed += (s, args) => this.Close();
            DataStr.Show();
        }

        private void labelFileHandling_Click(object sender, EventArgs e)
        {
            this.Hide();
            var File = new File(username);
            File.Closed += (s, args) => this.Close();
            File.Show();
        }

        private void labelOOP_Click(object sender, EventArgs e)
        {
            this.Hide();
            var OOP = new OOP(username);
            OOP.Closed += (s, args) => this.Close();
            OOP.Show();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            string query = "SELECT UnitID, SUM(Clicks) AS TotalClicks FROM Clicks WHERE Username = @username GROUP BY UnitID";
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            sda.SelectCommand.Parameters.AddWithValue("@username", (object)username ?? DBNull.Value);

            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                // Δημιουργούμε ένα StringBuilder για να συγκεντρώσουμε τα clicks ανά UnitID
                StringBuilder clicksInfo = new StringBuilder();
                foreach (DataRow row in dt.Rows)
                {
                    int unitID = Convert.ToInt32(row["UnitID"]);
                    int totalClicks = Convert.ToInt32(row["TotalClicks"]);
                    clicksInfo.AppendLine($"Unit {unitID}: {totalClicks} clicks");
                }
                labelClicks.Text = clicksInfo.ToString();
            }
            else
            {
                labelClicks.Text = "No clicks found for the user.";
            }

            conn.Close();

            label7.Text = username;
        }

        private void IntroQuiz_Click(object sender, EventArgs e)
        {

            this.Hide();
            var Quiz = new Quiz(username);
            Quiz.Closed += (s, args) => this.Close();
            Quiz.Show();

        }
    }
}
