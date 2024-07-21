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
    public partial class Func_FuncArgs : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-9RR5NNA6\MSSQLSERVER01;Initial Catalog=Learn;Integrated Security=True;");

        String username;

        public Func_FuncArgs(string username)
        {
            InitializeComponent();
            this.username = username;  
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Functions = new Functions(username);
            Functions.Closed += (s, args) => this.Close();
            Functions.Show();
        }

        private void buttonArgs_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Emil Refsnes\r\n" +
                            "Tobias Refsnes\r\n" +
                            "Linus Refsnes", 
                            "Arguments Output", MessageBoxButtons.OK);
        }

        private void buttonNumOfArgs_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Emil Refsnes", "Number of Arguments Output", MessageBoxButtons.OK);
        }

        private void buttonArbArgs_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The youngest child is Linus", "Arbitrary Arguments '*args' Output", MessageBoxButtons.OK);
        }

        private void Func_FuncArgs_Load(object sender, EventArgs e)
        {
            String query = "SELECT * FROM Clicks WHERE Username ='" + username + "' AND UnitID ='" + 4 + "' " +
                         "AND SubunitID ='" + 2 + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                conn.Open();
                String updateQuery = "UPDATE Clicks SET Clicks = Clicks + 1 " +
                                     "WHERE Username ='" + username + "' AND UnitID ='" + 4 + "' " +
                                     "AND SubunitID ='" + 2 + "'";
                SqlCommand cmd = new SqlCommand(updateQuery, conn);
                cmd.ExecuteNonQuery();
            }
            else
            {
                conn.Open();
                String insertQuery = "INSERT INTO Clicks VALUES (@Username, @UnitID, @SubunitID, @Clicks)";
                SqlCommand cmd = new SqlCommand(insertQuery, conn);
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@UnitID", 4);
                cmd.Parameters.AddWithValue("@SubunitID", 2);
                cmd.Parameters.AddWithValue("@Clicks", 1);
                cmd.ExecuteNonQuery();
            }

            conn.Close();
        }
    }
}
