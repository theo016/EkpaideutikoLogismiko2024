using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace EkpaideutikoLogismiko2024
{
    public partial class QuizTest : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-9RR5NNA6\MSSQLSERVER01;Initial Catalog=Learn;Integrated Security=True;");

        private int currentQuestionId;
        String username;

        public QuizTest(string username)
        {
            InitializeComponent();

            this.username = username;

            // Form properties
            this.Text = "Quiz";
            this.BackColor = Color.Lavender;
            this.Font = new Font("Microsoft Sans Serif", 8.25F);
            this.Size = new Size(1175, 726);
            this.StartPosition = FormStartPosition.CenterScreen;

            //Create and add label
            Label titleLabel = new Label
            {
                Text = "Welcome to the Quiz!",
                AutoSize = true,
                Font = new Font("Microsoft Sans Serif", 16, FontStyle.Bold),
                Location = new Point((this.ClientSize.Width - 200) / 2, 20)
            };
            this.Controls.Add(titleLabel);

            // Create and add buttons
            AddButton("button1", 1);
            AddButton("button2", 2);
            AddButton("button3", 3);
        }

        private void AddButton(string text, int buttonNumber)
        {
            Button button = new Button
            {
                Text = text,
                Name = $"button{buttonNumber}",
                Size = new Size(100, 50),
                Location = new Point((this.ClientSize.Width / 4) * (buttonNumber - 1) + (this.ClientSize.Width / 4) - 50, (this.ClientSize.Height / 2) + 100)
            };
            button.Click += Button_Click;
            this.Controls.Add(button);
        }

        private void Button_Click(object sender, EventArgs e)
        {
            CreateQuizForm();
        }

        private void CreateQuizForm()
        {
            Form quizForm = new Form
            {
                Text = "Quiz",
                BackColor = Color.Lavender,
                Font = new Font("Microsoft Sans Serif", 8.25F),
                Size = new Size(1175, 726),
                StartPosition = FormStartPosition.CenterScreen
            };

            // Create and add labels
            AddLabel(quizForm, "label", 12, new Point((quizForm.ClientSize.Width - 60) / 2, 20));
            AddLabel(quizForm, "label1", 12, new Point(50, 100));
            AddLabel(quizForm, "label1", 12, new Point(50, quizForm.ClientSize.Height - 50));
            AddLabel(quizForm, "label1", 12, new Point(quizForm.ClientSize.Width - 60, quizForm.ClientSize.Height - 50));

            // Create and add buttons
            AddFormButton(quizForm, "button1", 1);
            AddFormButton(quizForm, "button2", 2);
            AddFormButton(quizForm, "button3", 3);

            quizForm.Show();
        }

        private void AddLabel(Form form, string text, float fontSize, Point location)
        {
            Label label = new Label
            {
                Text = text,
                AutoSize = true,
                Font = new Font("Microsoft Sans Serif", fontSize),
                Location = location
            };
            form.Controls.Add(label);
        }

        private void AddFormButton(Form form, string text, int buttonNumber)
        {
            Button button = new Button
            {
                Text = text,
                Size = new Size(100, 50),
                Location = new Point((form.ClientSize.Width / 3) * (buttonNumber - 1) + (form.ClientSize.Width / 3 - 50), (form.ClientSize.Height / 2) - 25)
            };
            form.Controls.Add(button);
        }
    }
}
