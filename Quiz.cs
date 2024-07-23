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
        private int currentUnitID;

        public Quiz(string username, int currentUnitID)
        {
            InitializeComponent();
            this.username = username;
            this.currentUnitID = currentUnitID;
        }

        private void Quiz_Load(object sender, EventArgs e)
        {
            StartQuiz();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-9RR5NNA6\MSSQLSERVER01;Initial Catalog=Learn;Integrated Security=True;");

        private int currentQuestionId = 0;
        public int questioncounter = 1;


        private void StartQuiz()
        {
            currentQuestionId = 1; // Start with the first question
            LoadQuestion(currentQuestionId);
        }

        private void LoadQuestion(int questionId)
        {
            string queryQuestions = "SELECT QuestionText,QuestionID,UnitID FROM Questions " +
                                    "WHERE QuestionID = @QuestionID AND UnitID='"+currentUnitID+"'";

            SqlCommand command = new SqlCommand(queryQuestions, conn);
            command.Parameters.AddWithValue("@QuestionID", questionId);

            try
            {
                conn.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    // Display the question
                    quizUnit.Text = "Unit " + reader["UnitId"];
                    questionLabel.Text = reader["QuestionText"].ToString();
                }
                else
                {
                    MessageBox.Show("No more questions.");

                    conn.Close();

                    this.Hide();
                    var Menu = new Menu(username);
                    Menu.Closed += (s, args) => this.Close();
                    Menu.Show();
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error retrieving question: {ex.Message}");
            }
            finally
            {
                conn.Close();
            }

            
            string queryAnswers = "SELECT AnswerID,AnswerText FROM QuestionsAnswers WHERE QuestionID = @QuestionID";

            SqlCommand command2 = new SqlCommand(queryAnswers, conn);
            command2.Parameters.AddWithValue("@QuestionID", questionId);

            try
            {
                conn.Open();
                SqlDataReader reader2 = command2.ExecuteReader();

                while (reader2.Read())
                {
                    if (reader2["AnswerId"].ToString().Equals("1"))
                    {
                        command2.Parameters.AddWithValue("AnswerText", buttonAnswer1.Text);
                        buttonAnswer1.Text = reader2["AnswerText"].ToString();
                    }
                    if (reader2["AnswerId"].ToString().Equals("2"))
                    {
                        command2.Parameters.AddWithValue("AnswerText", buttonAnswer2.Text);
                        buttonAnswer2.Text = reader2["AnswerText"].ToString();
                    }
                    if (reader2["AnswerId"].ToString().Equals("3"))
                    {
                        command2.Parameters.AddWithValue("AnswerText", buttonAnswer3.Text);
                        buttonAnswer3.Text = reader2["AnswerText"].ToString();
                    }
                }

                reader2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error retrieving question: {ex.Message}");
            }
            finally
            {
                conn.Close();
            }

        }

        private void buttonAnswer1_Click(object sender, EventArgs e)
        {
            ShowNextQuestion();
        }

        private void buttonAnswer2_Click(object sender, EventArgs e)
        {
            ShowNextQuestion();
        }

        private void buttonAnswer3_Click(object sender, EventArgs e)
        {
            ShowNextQuestion();
        }

        private void ShowNextQuestion()
        {
            // Increment question ID to load the next question
            currentQuestionId++;
            LoadQuestion(currentQuestionId);
        }
    }
}