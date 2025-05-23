﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EkpaideutikoLogismiko2024
{
    public partial class File_Delete : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-9RR5NNA6\MSSQLSERVER01;Initial Catalog=Learn;Integrated Security=True;");

        String username;

        public File_Delete(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            var File = new File(username);
            File.Closed += (s, args) => this.Close();
            File.Show();
        }

        private void File_Delete_Load(object sender, EventArgs e)
        {
            String query = "SELECT * FROM Clicks WHERE Username ='" + username + "' AND UnitID ='" + 6 + "' " +
                                     "AND SubunitID ='" + 3 + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                conn.Open();
                String updateQuery = "UPDATE Clicks SET Clicks = Clicks + 1 " +
                                     "WHERE Username ='" + username + "' AND UnitID ='" + 6 + "' " +
                                     "AND SubunitID ='" + 3 + "'";
                SqlCommand cmd = new SqlCommand(updateQuery, conn);
                cmd.ExecuteNonQuery();
            }
            else
            {
                conn.Open();
                String insertQuery = "INSERT INTO Clicks VALUES (@Username, @UnitID, @SubunitID, @Clicks)";
                SqlCommand cmd = new SqlCommand(insertQuery, conn);
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@UnitID", 6);
                cmd.Parameters.AddWithValue("@SubunitID", 3);
                cmd.Parameters.AddWithValue("@Clicks", 1);
                cmd.ExecuteNonQuery();
            }

            conn.Close();
        }
    }
}
