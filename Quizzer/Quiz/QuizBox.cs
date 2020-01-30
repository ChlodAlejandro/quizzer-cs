using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quizzer
{
    public partial class QuizBox : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public static Stopwatch stopwatch = new Stopwatch();
        public static bool running = false;

        private void Draggable_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            HandleExit();
        }

        public void HandleExit()
        {
            this.Close();
        }

        public QuizBox()
        {
            InitializeComponent();
            panelAnswers.Top = (this.ClientSize.Height - panelAnswers.Height) / 2;
            choiceA.Left = (this.ClientSize.Width - choiceA.Width) / 2;
        }

        public int answerable = 0;
        public int answered = 0;
        public int correctQs = 0;
        public bool Easy = false;
        public bool Moderate = false;
        public bool Difficult = false;
        private List<Question> questionsList = new List<Question>();

        public bool closing = false;
        public async void RunQuiz(String pathToQuizFile, String quizFile, bool timerOn, bool countdownMode, double durationSeconds, Label timer, List<string> EnabledQuestions)
        {

            SQLiteConnection quizDB;
            quizDB = new SQLiteConnection("Data Source=" + pathToQuizFile + ";");
            quizDB.Open();
            string sql = "select * from questions";
            SQLiteCommand command = new SQLiteCommand(sql, quizDB);
            SQLiteDataReader reader = command.ExecuteReader();
            Random randomizer = new Random();
            while (reader.Read())
            {
                questionsList.Add(new Question(Int32.Parse(reader["id"].ToString()), reader["question"].ToString(), reader["A"].ToString(), reader["B"].ToString(), reader["C"].ToString(), reader["D"].ToString(), Int16.Parse(reader["correct"].ToString()), Int16.Parse(reader["difficulty"].ToString())));
            }
            quizDB.Close();
            if (questionsList.Count < 5)
            {
                DialogResult alert = MessageBox.Show("The pack has less than 5 questions. It cannot be used. Please consult the creator of the pack.", "Quiz Pack Reader", MessageBoxButtons.OK);
                return;
            }
            durationSeconds = durationSeconds * questionsList.Count;
            if (EnabledQuestions.Contains("Easy")) Easy = true;
            if (EnabledQuestions.Contains("Moderate")) Moderate = true;
            if (EnabledQuestions.Contains("Difficult")) Difficult = true;
            foreach (Question q in questionsList)
            {
                if ((q.Difficulty == 0 && Easy) || (q.Difficulty == 1 && Moderate) || (q.Difficulty == 2 && Difficult))
                {
                    answerable++;
                }
            }
            Show();
            foreach (Control c in Controls)
            {
                c.Visible = true;
            }
            stopwatch.Reset();
            running = true;
            if (timerOn)
            {
                timer.Visible = true;
                if (countdownMode)
                {
                    RunTimer(durationSeconds, timer);
                }
                else
                {
                    RunStopwatch(timer);
                }
            }
            else timer.Visible = false;
            choiceA.Visible = true;
            choiceB.Visible = true;
            choiceC.Visible = true;
            choiceD.Visible = true;
            submit.Visible = true;
            await Question();
            lblQuestion.Text = "Done!";            
            choiceA.Visible = false;
            choiceB.Visible = false;
            choiceC.Visible = false;
            choiceD.Visible = false;
            submit.Visible = false;
            Results r = new Results();
            foreach (QAResult qa in results)
            {
                String CorrectChoice = "A";
                switch (qa.Question.Correct)
                {
                    case 0:
                        CorrectChoice = "A";
                        break;
                    case 1:
                        CorrectChoice = "B";
                        break;
                    case 2:
                        CorrectChoice = "C";
                        break;
                    case 3:
                        CorrectChoice = "D";
                        break;
                }
                String Difficulty = "Easy";
                switch (qa.Question.Difficulty)
                {
                    case 0:
                        Difficulty = "Easy";
                        break;
                    case 1:
                        Difficulty = "Moderate";
                        break;
                    case 2:
                        Difficulty = "Difficult";
                        break;
                }
                double time = qa.Answer.TimeMiliseconds / 1000.0;
                r.resultsTable.Rows.Add(qa.Question.ID, qa.Question.Q, Difficulty, qa.Answer.A, qa.Answer.Correct ? "Yes" : "No", CorrectChoice, time + "s",
                    qa.Question.A, qa.Question.B, qa.Question.C, qa.Question.D);
            }
            r.resultsTable.Rows.Add();
            r.resultsTable.Rows.Add("", "Correct", correctQs + " out of " + answered, "", "", "", "", "", "", "", "");
            double totaltime = stopwatch.ElapsedMilliseconds / 1000.0;
            r.resultsTable.Rows.Add("", "Total", correctQs + " out of " + answerable, "", correct == answerable ? "No" : "Yes", "", totaltime, "", "", "");
            foreach (DataGridViewRow ro in r.resultsTable.Rows) 
            {
                foreach (DataGridViewCell c in ro.Cells) c.Style.ForeColor = System.Drawing.Color.Black;
            }
            stopwatch.Stop();
            r.ShowDialog();
            Close();
        }

        static async void RunTimer(double seconds, Label Timer)
        {
            Timer.Text = "Starting...";
            stopwatch.Start();
            while ((((seconds * 1000) - (stopwatch.ElapsedMilliseconds)) / 1000) > 0)
            {

                Timer.Text = String.Format("{0:0.000}", ((seconds * 1000) - (stopwatch.ElapsedMilliseconds)) / 1000);
                await Task.Delay(10);
            }
            running = false;
            stopwatch.Stop();
        }

        static async void RunStopwatch(Label Timer)
        {
            Timer.Text = "Starting...";
            stopwatch.Start();
            while (running == true)
            {
                double preciseTime = stopwatch.ElapsedMilliseconds / 1000.0;
                Timer.Text = String.Format("{0:0.000}", preciseTime);
                await Task.Delay(10);
            }
            stopwatch.Stop();
        }

        public bool newQuestion = true;
        public int correct = 0;
        private Question que;
        public Stopwatch questionTimer = new Stopwatch();
        private async Task Question()
        {
            foreach (Question q in questionsList)
            {
                newQuestion = false;
                questionTimer.Restart();
                if ((q.Difficulty == 0 && Easy) || (q.Difficulty == 1 && Moderate) || (q.Difficulty == 2 && Difficult))
                {
                    remain.Text = "Question " + (answered + 1) + " out of " + answerable;
                    lblQuestion.Text = q.Q;
                    choiceA.Text = q.A;
                    choiceB.Text = q.B;
                    choiceC.Text = q.C;
                    choiceD.Text = q.D;
                    correct = q.Correct;
                    que = q;
                    questionTimer.Start();
                } else
                {
                    newQuestion = true;
                    questionTimer.Restart();
                }
                while (!newQuestion && running) {
                    await Task.Delay(50);
                }
                if (!running) break;
            }
            running = false;
        }
        List<QAResult> results = new List<QAResult>();
        private void SubmitAnswer(object sender, EventArgs e)
        {
            if (closing)
            {
                Close();
                return;
            }
            String ans = string.Empty;
            if (choiceA.Checked) ans = choiceA.Text;
            if (choiceB.Checked) ans = choiceB.Text;
            if (choiceC.Checked) ans = choiceC.Text;
            if (choiceD.Checked) ans = choiceD.Text;
            bool c = false;
            switch(correct)
            {
                case 0:
                    if (choiceA.Checked) c = true;
                    break;
                case 1:
                    if (choiceB.Checked) c = true;
                    break;
                case 2:
                    if (choiceC.Checked) c = true;
                    break;
                case 3:
                    if (choiceD.Checked) c = true;
                    break;
            }
            if (c) correctQs++;
            Answer qa = new Answer(que, ans, c, questionTimer.ElapsedMilliseconds);
            questionTimer.Restart();
            results.Add(new QAResult(que, qa));
            answered++;
            newQuestion = true;
            choiceA.Checked = false;
            choiceB.Checked = false;
            choiceC.Checked = false;
            choiceD.Checked = false;
        }
    }

}