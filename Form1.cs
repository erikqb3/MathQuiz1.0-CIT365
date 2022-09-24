using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace MathQuiz1._0
{
    public partial class Form1 : Form
    {
        //Create a Random object called Randomizer to generate random numbers
        Random randomizer = new Random();
        string[] opperators = { "+", "-", "x", "/" };
        int timeLeft;


        public void StartQuiz()
        {
            
            randomizeSigns();

            string[] signs = getSigns();
            for (int i = 0; i < signs.Length; i++)
            {
                switch (signs[i])
                {
                    case "+":
                        additionProblem(i);
                        break;
                    case "-":
                        subtractionProblem(i);
                        break;
                    case "x":
                        multiplicationProblem(i);
                        break;
                    case "/":
                        divisionProblem(i);
                        break;
                }
            }

            //additionProblem();
            //subtractionProblem();
            //multiplicationProblem();
            //divisionProblem();


            timeLeft = 30;
            timeLabel.Text = "30 seconds";
            timer1.Start();
        }
        private void answer_Enter(object sender, EventArgs e)
        {
            NumericUpDown answerBox = sender as NumericUpDown;
            if (answer1 != null)
            {
                int lengthOfAnswer = answerBox.Value.ToString().Length;
                answerBox.Select(0, lengthOfAnswer);
            }
        }
        private void startBtn_Click(object sender, EventArgs e)
        {
            StartQuiz();
            startBtn.Enabled = false;
        }

        public void randomizeSigns()
        {
            sign1.Text = opperators[randomizer.Next(4)];
            sign2.Text = opperators[randomizer.Next(4)];
            sign3.Text = opperators[randomizer.Next(4)];
            sign4.Text = opperators[randomizer.Next(4)];
        }
        public string[] getSigns()
        {
            string Q1Sign, Q2Sign, Q3Sign, Q4Sign;
            Q1Sign = sign1.Text;
            Q2Sign = sign2.Text;
            Q3Sign = sign3.Text;
            Q4Sign = sign4.Text;
            string[] signs = { Q1Sign, Q2Sign, Q3Sign, Q4Sign };

            return signs;
        }

        public void additionProblem(int i)
        {
            int leftNumb = randomizer.Next(51);
            int rightNumb = randomizer.Next(51);

            switch (i)
            {
                case 0:
                    Q1_LeftLabel.Text = leftNumb.ToString();
                    Q1_RightLabel.Text = rightNumb.ToString();
                    break;
                case 1:
                    Q2_LeftLabel.Text = leftNumb.ToString();
                    Q2_RightLabel.Text = rightNumb.ToString();
                    break;
                case 2:
                    Q3_LeftLabel.Text = leftNumb.ToString();
                    Q3_RightLabel.Text = rightNumb.ToString();
                    break;
                case 3:
                    Q4_LeftLabel.Text = leftNumb.ToString();
                    Q4_RightLabel.Text = rightNumb.ToString();
                    break;

            }

            answer1.Value = 0;

            return;
        }

        public void subtractionProblem(int i)
        {
            int leftNumb = randomizer.Next(1, 101);
            int rightNumb = randomizer.Next(1, leftNumb);

            switch (i)
            {
                case 0:
                    Q1_LeftLabel.Text = leftNumb.ToString();
                    Q1_RightLabel.Text = rightNumb.ToString();
                    break;
                case 1:
                    Q2_LeftLabel.Text = leftNumb.ToString();
                    Q2_RightLabel.Text = rightNumb.ToString();
                    break;
                case 2:
                    Q3_LeftLabel.Text = leftNumb.ToString();
                    Q3_RightLabel.Text = rightNumb.ToString();
                    break;
                case 3:
                    Q4_LeftLabel.Text = leftNumb.ToString();
                    Q4_RightLabel.Text = rightNumb.ToString();
                    break;

            }

            answer2.Value = 0;

            return;
        }

        public void multiplicationProblem(int i)
        {
            int leftNumb = randomizer.Next(2, 11);
            int rightNumb = randomizer.Next(2, 11);

            switch (i)
            {
                case 0:
                    Q1_LeftLabel.Text = leftNumb.ToString();
                    Q1_RightLabel.Text = rightNumb.ToString();
                    break;
                case 1:
                    Q2_LeftLabel.Text = leftNumb.ToString();
                    Q2_RightLabel.Text = rightNumb.ToString();
                    break;
                case 2:
                    Q3_LeftLabel.Text = leftNumb.ToString();
                    Q3_RightLabel.Text = rightNumb.ToString();
                    break;
                case 3:
                    Q4_LeftLabel.Text = leftNumb.ToString();
                    Q4_RightLabel.Text = rightNumb.ToString();
                    break;

            }

            answer3.Value = 0;

            return;
        }

        public void divisionProblem(int i)
        {
            int temporaryQuotient = randomizer.Next(2, 11);

            int rightNumb = randomizer.Next(2, 11);
            int leftNumb = rightNumb * temporaryQuotient;

            switch (i)
            {
                case 0:
                    Q1_LeftLabel.Text = leftNumb.ToString();
                    Q1_RightLabel.Text = rightNumb.ToString();
                    break;
                case 1:
                    Q2_LeftLabel.Text = leftNumb.ToString();
                    Q2_RightLabel.Text = rightNumb.ToString();
                    break;
                case 2:
                    Q3_LeftLabel.Text = leftNumb.ToString();
                    Q3_RightLabel.Text = rightNumb.ToString();
                    break;
                case 3:
                    Q4_LeftLabel.Text = leftNumb.ToString();
                    Q4_RightLabel.Text = rightNumb.ToString();
                    break;

            }

            answer4.Value = 0;

            return;
        }

        private bool CheckTheAnswer()
        {

            if (problemSolved(int.Parse(Q1_LeftLabel.Text), int.Parse(Q1_RightLabel.Text), answer1.Value)
                && problemSolved(int.Parse(Q2_LeftLabel.Text), int.Parse(Q2_RightLabel.Text), answer2.Value)
                && problemSolved(int.Parse(Q3_LeftLabel.Text), int.Parse(Q3_RightLabel.Text), answer3.Value)
                && problemSolved(int.Parse(Q4_LeftLabel.Text), int.Parse(Q4_RightLabel.Text), answer4.Value))
                return true;
            else
                return false;
        }

        private bool problemSolved(int A, int B, decimal answer)
        {
            string[] signs = getSigns();
            bool correct = false;
            for (int i = 0; i < signs.Length; i++)
            {
                switch (signs[i])
                {
                    case "+":
                        if (A + B == answer)
                        {
                            correct = true;
                            return correct;
                        }
                        break;
                    case "-":
                        if (A - B == answer)
                        {
                            correct = true;
                            return correct;
                        }
                        break;
                    case "x":
                        if (A * B == answer)
                        {
                            correct = true;
                            return correct;
                        }
                        break;
                    case "/":
                        if (A / B == answer)
                        {
                            correct = true;
                            return correct;
                        }
                        break;
                }
            }


            return correct;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (CheckTheAnswer())
            {
                timer1.Stop();
                MessageBox.Show("You got all the answers right!",
                                "Contratulations!");
                startBtn.Enabled = true;
            }
            else if (timeLeft > 0)
            {
                timeLeft = timeLeft - 1;
                timeLabel.Text = timeLeft + " seconds";
                if (timeLeft < 5)
                {
                    timeLabel.BackColor = Color.Red;
                }
            }
            else
            {
                timer1.Stop();
                timeLabel.Text = "BOOM!!!";
                MessageBox.Show("You failed and died!", "The End!");
                SoundPlayer simpleSound = new SoundPlayer(@"c:\Windows\Media\chime.wav");
                simpleSound.Play();
                startBtn.Enabled = true;
            }
        }


        public Form1()
        {
            InitializeComponent();
        }

        public void successNotification(int questionIndex, int left, int right, decimal answer) 
        {
            string[] signs = getSigns();
            bool success = false;
            switch (signs[questionIndex])
            {
                case "+":
                    if (left + right == answer)
                    {
                        success = true;
                    }
                    break;
                case "-":
                    if (left - right == answer)
                    {
                        success = true;
                    }
                    break;
                case "x":
                    if (left * right == answer)
                    {
                        success = true;
                    }
                    break;
                case "/":
                    if (left / right == answer)
                    {
                        success = true;
                    }
                    break;
            }

            if (success == true)
            {
                SoundPlayer simpleSound = new SoundPlayer(@"c:\Windows\Media\chimes.wav");
                simpleSound.Play();
            }

        }
        private void answer1_ValueChanged(object sender, EventArgs e)
        {
            int questionIndex = 0;
            successNotification(questionIndex, int.Parse(Q1_LeftLabel.Text), int.Parse(Q1_RightLabel.Text), answer1.Value);

        }

        private void answer2_ValueChanged(object sender, EventArgs e)
        {
            int questionIndex = 1;
            successNotification(questionIndex, int.Parse(Q2_LeftLabel.Text), int.Parse(Q2_RightLabel.Text), answer2.Value);
        }

        private void answer3_ValueChanged(object sender, EventArgs e)
        {
            int questionIndex = 2;
            successNotification(questionIndex, int.Parse(Q3_LeftLabel.Text), int.Parse(Q3_RightLabel.Text), answer3.Value);
        }

        private void answer4_ValueChanged(object sender, EventArgs e)
        {
            int questionIndex = 3;
            successNotification(questionIndex, int.Parse(Q4_LeftLabel.Text), int.Parse(Q4_RightLabel.Text), answer4.Value);
        }
    }
}
