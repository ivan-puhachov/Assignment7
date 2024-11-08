using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace assignment7
{
    public partial class Form1 : Form
    {
        private readonly char[] correctAnswers = { 'B', 'D', 'A', 'A', 'C', 'A', 'B', 'A', 'C', 'D', 'B', 'C', 'D', 'A', 'D', 'C', 'C', 'B', 'D', 'A' };
        private char[] studentAnswers;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoadAnswers_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Files|*.txt";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                studentAnswers = File.ReadAllText(openFileDialog.FileName).ToCharArray();

                if (studentAnswers.Length != correctAnswers.Length)
                {
                    MessageBox.Show("The number of answers in the file does not match the required 20 answers.");
                    return;
                }

                int correctCount = 0;
                var incorrectQuestions = new System.Collections.Generic.List<int>();

                for (int i = 0; i < correctAnswers.Length; i++)
                {
                    if (studentAnswers[i] == correctAnswers[i])
                    {
                        correctCount++;
                    }
                    else
                    {
                        incorrectQuestions.Add(i + 1); // Store question number
                    }
                }
                lblResult.Text = correctCount >= 15 ? "Passed" : "Failed";
                lblCorrectCount.Text = $"Correct Answers: {correctCount}";
                lblIncorrectCount.Text = $"Incorrect Answers: {20 - correctCount}";
                txtIncorrectQuestions.Text = "Incorrect Questions: " + string.Join(", ", incorrectQuestions);
            }
        }

        private void lblResult_Click(object sender, EventArgs e)
        {

        }

        private void lblIncorrectCount_Click(object sender, EventArgs e)
        {

        }

        private void lblCorrectCount_Click(object sender, EventArgs e)
        {

        }
    }
}
    