using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quizzer
{
    public partial class MainForm : Form
    {

        public String QuizFile;
        public String QuizPath;
        public int setTimeDiffVal = 0;
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        
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
            Environment.Exit(0);
        }

        private void Quizzer_Load(object sender, EventArgs e)
        {

        }

        private void DisabledSelection(object sender, EventArgs e)
        {

        }

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Quiz.StartQuiz(this);
        }

        private void panelHeader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void title_Click(object sender, EventArgs e)
        {

        }

        private void panelFooter_Paint(object sender, PaintEventArgs e)
        {

        }

        private void status_Click(object sender, EventArgs e)
        {

        }

        private void btnEditor_Click(object sender, EventArgs e)
        {
            Editor editor = new Editor();
            editor.Show();
        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblQFileName_Click(object sender, EventArgs e)
        {

        }

        private void lblTimeDiffDesc_Click(object sender, EventArgs e)
        {

        }

        private void setFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Quizzer Quiz Packs|*.qp|All Files|*.*";
            file.FilterIndex = 1;
            file.Title = "Quiz Pack Locator";
            file.Multiselect = false;
            if (file.ShowDialog() == DialogResult.OK)
            {
                QuizFile = file.SafeFileName;
                QuizPath = file.FileName;
                lblQFileName.Text = file.SafeFileName;
            }
        }

        private void lblQuizPack_Click(object sender, EventArgs e)
        {

        }

        private void setQuestionsOn_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblEnabledQuestions_Click(object sender, EventArgs e)
        {

        }

        private void lblIncTFCAns_Click(object sender, EventArgs e)
        {

        }

        private void setIncTFCAns_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void setTimeDiff_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (setTimeDiff.Text) {
                case ("Untimed Practice"):
                    lblTimeDiffDesc.Text = "The quiz will not be timed and a timer will not be shown.";
                    setIncTFCAns.Checked = false;
                    setIncTFCAns.Enabled = false;
                    setTimeDiffVal = 0;
                    break;
                case ("Timed Practice"):
                    lblTimeDiffDesc.Text = "The quiz will be timed using a stopwatch.";
                    setIncTFCAns.Enabled = true;
                    setTimeDiffVal = 1;
                    break;
                case ("Easy"):
                    lblTimeDiffDesc.Text = "You will have 5 seconds for each item. You may choose to add 2 seconds per correct answer.";
                    setIncTFCAns.Enabled = true;
                    setTimeDiffVal = 2;
                    break;
                case ("Moderate"):
                    lblTimeDiffDesc.Text = "You will have 3 seconds for each item. You may choose to add 1 seconds per correct answer.";
                    setIncTFCAns.Enabled = true;
                    setTimeDiffVal = 3;
                    break;
                case ("Difficult"):
                    lblTimeDiffDesc.Text = "You will have 1 second for each item. You may choose to add 0.5 seconds per correct answer.";
                    setIncTFCAns.Enabled = true;
                    setTimeDiffVal = 4;
                    break;
                case ("Extreme"):
                    lblTimeDiffDesc.Text = "You will have 0.5 seconds for each item. You may not enable time incrementation.";
                    setIncTFCAns.Enabled = false;
                    setTimeDiffVal = 5;
                    break;
                case ("Untimed Extreme"):
                    lblTimeDiffDesc.Text = "Your score decreases per wrong question. The timer will not be shown.";
                    setIncTFCAns.Checked = false;
                    setIncTFCAns.Enabled = false;
                    setTimeDiffVal = 6;
                    break;
                case ("Custom"):
                    lblTimeDiffDesc.Text = "You may set your own settings. The customization window will open when you press Start.";
                    setIncTFCAns.Enabled = true;
                    setTimeDiffVal = 7;
                    break;
                default:
                    lblTimeDiffDesc.Text = "There was an error processing the description.";
                    break;
            }
        }

        private void lblTimeDiff_Click(object sender, EventArgs e)
        {

        }
    }
}
