using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.CheckedListBox;

namespace Quizzer
{
    class Quiz
    {
        public static ComboBox ControlTimeDiff;
        public static CheckBox ControlIncrement;
        public static Label ControlTimeDiffDesc;
        public static CheckedListBox ControlEnabledQuestions;
        public static Button ControlFileBrowse;
        public static Label ControlFileName;
        public static Button ControlStartButton;
        public static Label Status;
        public static Label Timer;

        public static String TimeDiff;
        public static int SelectedTimeDiff;
        public static bool IncTFCAns;
        public static CheckedItemCollection EnabledQuestions;
        public static int QuestionSetting;

        public static void StartQuiz(MainForm q)
        {
            ControlTimeDiff = q.setTimeDiff;
            ControlIncrement = q.setIncTFCAns;
            ControlTimeDiffDesc = q.lblTimeDiffDesc;
            ControlEnabledQuestions = q.setQuestionsOn;
            ControlFileBrowse = q.setFile;
            ControlFileName = q.lblQFileName;
            ControlStartButton = q.btnStart;
            Status = q.status;

            TimeDiff = ControlTimeDiff.Text;
            SelectedTimeDiff = q.setTimeDiffVal;
            IncTFCAns = ControlIncrement.Checked;
            EnabledQuestions = ControlEnabledQuestions.CheckedItems;

            bool TimerOn = true;
            bool Countdown = true;
            bool Decrement = false;
            double Length = 0;
            int Type = 0;

            bool go = true;

            if (TimeDiff == "" || EnabledQuestions.Count == 0 || q.QuizFile == String.Empty || q.QuizPath == String.Empty)
            {
                Status.Text = "Quiz settings are not complete.";
                go = false;
            }

            if (EnabledQuestions.Cast<string>().ToList().Count == 0)
            {
                Status.Text = "Select at least one difficulty level.";
                go = false;
            }

            List<String> Enabled = EnabledQuestions.Cast<string>().ToList();
            
            switch (TimeDiff)
            {
                case ("Untimed Practice"):
                    TimerOn = false;
                    break;
                case ("Timed Practice"):
                    TimerOn = true;
                    Countdown = false;
                    break;
                case ("Easy"):
                    TimerOn = true;
                    Countdown = true;
                    Length = 5;
                    break;
                case ("Moderate"):
                    TimerOn = true;
                    Countdown = true;
                    Length = 3;
                    break;
                case ("Difficult"):
                    TimerOn = true;
                    Countdown = true;
                    Length = 1;
                    break;
                case ("Extreme"):
                    TimerOn = true;
                    Countdown = true;
                    Length = 0.5;
                    break;
                case ("Custom"):
                    if (go)
                    {
                        CustomTimeDifficultyCreator ctdc = new CustomTimeDifficultyCreator();
                        if (ctdc.ShowDialog() == DialogResult.OK)
                        {
                            TimerOn = ctdc.timerShow.Checked;
                            if (TimerOn)
                            {
                                if (ctdc.timerCountMode.Checked && !ctdc.timerStopMode.Checked)
                                {
                                    Countdown = true;
                                    Length = Decimal.ToInt64(ctdc.timerDuration.Value);
                                }
                                else if (!ctdc.timerCountMode.Checked && ctdc.timerStopMode.Checked)
                                {
                                    Countdown = false;
                                }
                                else
                                {
                                    Status.Text = "Invalid Custom Time Difficulty Timer Mode.";
                                    go = false;
                                }
                            }
                        }
                        else
                        {
                            Status.Text = "Custom Time Difficulty canceled.";
                            go = false;
                        }
                    }
                    break;
                default:
                    break;
            }
            if (go)
            {
                Status.Text = "Starting quiz.";
                Lock(q);
                QuizBox qb = new QuizBox();
                Status.Text = "Quiz started...";
                qb.RunQuiz(q.QuizPath, q.QuizFile, TimerOn, Countdown, Length, qb.timer, Enabled);
                Unlock(q);
            }
        }

        public static void Lock(MainForm q)
        {
            q.setTimeDiff.Enabled = false;
            q.setIncTFCAns.Enabled = false;
            q.setQuestionsOn.Enabled = false;
            q.setFile.Enabled = false;
            q.btnStart.Enabled = false;
        }

        public static void Unlock(MainForm q)
        {
            q.setTimeDiff.Enabled = true;
            q.setIncTFCAns.Enabled = true;
            q.setQuestionsOn.Enabled = true;
            q.setFile.Enabled = true;
            q.btnStart.Enabled = true;
        }
    }
}
