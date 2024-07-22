using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EkpaideutikoLogismiko2024
{
    public partial class Quiz : Form
    {
        String username;

        public Quiz(string username)
        {

            InitializeComponent();
            this.username = username;
            
        }

        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-9RR5NNA6\MSSQLSERVER01;Initial Catalog=Learn;Integrated Security=True;");

        private void Quiz_Load(object sender, EventArgs e)
        {
            
            try
            {

                conn.Open();
                SqlCommand cmd = new SqlCommand("Select QuestionText,QuestionId from Questions where UnitId=1", conn);


                cmd.Parameters.AddWithValue("QuestionText", questionLabel.Text);


                SqlDataReader reader1;

                reader1 = cmd.ExecuteReader();

                if (reader1.Read())
                {
                    questionLabel.Text = reader1["QuestionText"].ToString();




                }
                else
                {
                    MessageBox.Show("Den antexw allo");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("help me");
                questionLabel.Text = ex.Message;


            }
            finally
            {
                conn.Close();
            }
            try
            {

                conn.Open();
                SqlCommand cmd2 = new SqlCommand("Select QuestionId,AnswerId,AnswerText from QuestionsAnswers ", conn);

                cmd2.Parameters.AddWithValue("AnswerId", giannis.Text);






                SqlDataReader reader2;

                reader2 = cmd2.ExecuteReader();

                if (reader2.Read())
                {
                    giannis.Text = reader2["AnswerId"].ToString();
                    if (giannis.Text == "1")
                    {
                        cmd2.Parameters.AddWithValue("AnswerText", answer1.Text);
                        answer1.Text = reader2["AnswerText"].ToString();
                    }
                    if (giannis.Text == "2")
                    {

                        cmd2.Parameters.AddWithValue("AnswerText", answer2.Text);
                        answer2.Text = reader2["AnswerText"].ToString();
                    }
                     if(giannis.Text == "3")
                    {
                        cmd2.Parameters.AddWithValue("AnswerText", answer3.Text);
                        answer3.Text = reader2["AnswerText"].ToString();
                    }



                }
                else
                {
                    MessageBox.Show("Den antexw allo");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("help me");
                questionLabel.Text = ex.Message;


            }
            finally
            {
                conn.Close();
            }
        }
    }
}