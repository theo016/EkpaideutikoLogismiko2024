namespace EkpaideutikoLogismiko2024
{
    partial class Quiz
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.quizUnit = new System.Windows.Forms.Label();
            this.questionLabel = new System.Windows.Forms.Label();
            this.answer1 = new System.Windows.Forms.Button();
            this.answer2 = new System.Windows.Forms.Button();
            this.answer3 = new System.Windows.Forms.Button();
            this.giannis = new System.Windows.Forms.Label();
            this.tester = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // quizUnit
            // 
            this.quizUnit.AutoSize = true;
            this.quizUnit.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quizUnit.Location = new System.Drawing.Point(506, 9);
            this.quizUnit.Name = "quizUnit";
            this.quizUnit.Size = new System.Drawing.Size(83, 34);
            this.quizUnit.TabIndex = 0;
            this.quizUnit.Text = "label";
            // 
            // questionLabel
            // 
            this.questionLabel.AutoSize = true;
            this.questionLabel.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionLabel.Location = new System.Drawing.Point(56, 199);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(71, 25);
            this.questionLabel.TabIndex = 1;
            this.questionLabel.Text = "label1";
            // 
            // answer1
            // 
            this.answer1.Location = new System.Drawing.Point(61, 407);
            this.answer1.Name = "answer1";
            this.answer1.Size = new System.Drawing.Size(209, 75);
            this.answer1.TabIndex = 2;
            this.answer1.Text = "button1";
            this.answer1.UseVisualStyleBackColor = true;
            this.answer1.Click += new System.EventHandler(this.answer1_Click);
            // 
            // answer2
            // 
            this.answer2.Location = new System.Drawing.Point(463, 407);
            this.answer2.Name = "answer2";
            this.answer2.Size = new System.Drawing.Size(209, 75);
            this.answer2.TabIndex = 3;
            this.answer2.Text = "button2";
            this.answer2.UseVisualStyleBackColor = true;
            // 
            // answer3
            // 
            this.answer3.Location = new System.Drawing.Point(840, 407);
            this.answer3.Name = "answer3";
            this.answer3.Size = new System.Drawing.Size(209, 75);
            this.answer3.TabIndex = 4;
            this.answer3.Text = "button3";
            this.answer3.UseVisualStyleBackColor = true;
            // 
            // giannis
            // 
            this.giannis.AutoSize = true;
            this.giannis.Location = new System.Drawing.Point(61, 618);
            this.giannis.Name = "giannis";
            this.giannis.Size = new System.Drawing.Size(35, 13);
            this.giannis.TabIndex = 5;
            this.giannis.Text = "label1";
            // 
            // tester
            // 
            this.tester.AutoSize = true;
            this.tester.Location = new System.Drawing.Point(64, 647);
            this.tester.Name = "tester";
            this.tester.Size = new System.Drawing.Size(35, 13);
            this.tester.TabIndex = 6;
            this.tester.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1123, 343);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "label1";
            // 
            // Quiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1159, 687);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tester);
            this.Controls.Add(this.giannis);
            this.Controls.Add(this.answer3);
            this.Controls.Add(this.answer2);
            this.Controls.Add(this.answer1);
            this.Controls.Add(this.questionLabel);
            this.Controls.Add(this.quizUnit);
            this.Name = "Quiz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quiz";
            this.Load += new System.EventHandler(this.Quiz_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label quizUnit;
        private System.Windows.Forms.Label questionLabel;
        private System.Windows.Forms.Button answer1;
        private System.Windows.Forms.Button answer2;
        private System.Windows.Forms.Button answer3;
        private System.Windows.Forms.Label giannis;
        private System.Windows.Forms.Label tester;
        private System.Windows.Forms.Label label1;
    }
}