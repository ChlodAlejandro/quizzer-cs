using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quizzer
{
    public partial class AddQuestion : Form
    {
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
            this.Close();
        }

        public AddQuestion()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (Editor.QuizFilePath == string.Empty)
            {
                DialogResult r = MessageBox.Show("Please open a question file using the Editor first.", "Quizzer Question Adder", MessageBoxButtons.OK);
                return;
            }

            string connString = "Data Source=" + Editor.QuizFilePath + ";";
            SQLiteConnection sqlConn = new SQLiteConnection(connString);
            sqlConn.Open();

            string checkExists = @"SELECT COUNT(*) FROM questions WHERE question = @Question";
            SQLiteCommand existscmd = new SQLiteCommand(checkExists, sqlConn);
            existscmd.Parameters.Add("@Question", DbType.String);
            existscmd.Parameters["@Question"].Value = txtQuestion.Text;
            int count = Convert.ToInt32(existscmd.ExecuteScalar());

            if (count != 0)
            {
                DialogResult r = MessageBox.Show("Quizzer Question Adder", "Please open a question file using the Editor first.", MessageBoxButtons.OKCancel);
                if (r == DialogResult.Cancel)
                {
                    return;
                }
            }

            Int16 difficulty = 0;
            if (diffEasy.Checked) difficulty = 0;
            else if (diffMod.Checked) difficulty = 1;
            else if (diffDiff.Checked) difficulty = 2;

            Int16 correct = 0;
            if (rdoA.Checked) correct = 0;
            else if (rdoB.Checked) correct = 1;
            else if (rdoC.Checked) correct = 2;
            else if (rdoD.Checked) correct = 3;
            
            string addIntoSQL = @"INSERT INTO questions (id, question, A, B, C, D, correct, difficulty) VALUES (null, @Question, @A, @B, @C, @D, @Correct, @Difficulty)";
            SQLiteCommand cmd = new SQLiteCommand(addIntoSQL, sqlConn);

            cmd.Parameters.Add("@Question", DbType.String);
            cmd.Parameters["@Question"].Value = txtQuestion.Text;
            cmd.Parameters.Add("@A", DbType.String);
            cmd.Parameters["@A"].Value = txtA.Text;
            cmd.Parameters.Add("@B", DbType.String);
            cmd.Parameters["@B"].Value = txtB.Text;
            cmd.Parameters.Add("@C", DbType.String);
            cmd.Parameters["@C"].Value = txtC.Text;
            cmd.Parameters.Add("@D", DbType.String);
            cmd.Parameters["@D"].Value = txtD.Text;
            cmd.Parameters.Add("@Correct", DbType.Int32);
            cmd.Parameters["@Correct"].Value = correct;
            cmd.Parameters.Add("@Difficulty", DbType.Int32);
            cmd.Parameters["@Difficulty"].Value = difficulty;

            cmd.ExecuteNonQuery();
            Editor.reupdatequestions = true;
            sqlConn.Close();
            status.Text = "Added question: \"" + txtQuestion.Text + "\"";
        }
    }
}