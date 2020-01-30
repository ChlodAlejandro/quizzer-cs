using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quizzer
{
    public partial class Editor : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public static String QuizFilePath;

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

        public Editor()
        {
            InitializeComponent();
            add.Enabled = false;
            reset.Enabled = false;
            refresh.Enabled = false;
            UpdateQuestions();
        }

        public String QuizFile;
        public void ReopenDatabase()
        {
            string connString = "Data Source=" + QuizFile + ";";

            using (SQLiteConnection sqlConn = new SQLiteConnection(connString))
            {
                string sqlQuery = @"SELECT * from questions";
                SQLiteCommand cmd = new SQLiteCommand(sqlQuery, sqlConn);
                SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
                DataTable table = new DataTable();
                da.Fill(table);
                file.DataSource = new BindingSource(table, null);
            }
            add.Enabled = true;
            reset.Enabled = true;
            refresh.Enabled = true;
            foreach (DataGridViewRow r in file.Rows)
            {
                foreach (DataGridViewCell c in r.Cells)
                {
                    c.Style.ForeColor = Color.Black;
                }
            }
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
                QuizFile = file.FileName;
                QuizFilePath = file.FileName;
                lblFilePath.Text = file.FileName;
            } else
            {
                return;
            }
            if (QuizFile != string.Empty)
            {
                ReopenDatabase();
            }
        }
        public static bool reupdatequestions = false;
        public async void UpdateQuestions() {
            while (true)
            {
                if (reupdatequestions && QuizFile != string.Empty)
                {
                    ReopenDatabase();
                    reupdatequestions = false;
                }
                await Task.Delay(100);
            }
        }

        private void newfile_Click(object sender, EventArgs e)
        {
            SaveFileDialog file = new SaveFileDialog();
            file.Filter = "Quizzer Quiz Packs|*.qp|All Files|*.*";
            file.FilterIndex = 1;
            file.Title = "Quiz Pack Locator";
            if (file.ShowDialog() == DialogResult.OK)
            {
                QuizFile = file.FileName;
                QuizFilePath = file.FileName;
                lblFilePath.Text = file.FileName;
            } else
            {
                return;
            }
            if (QuizFile != String.Empty)
            {

                SQLiteConnection.CreateFile(file.FileName);
                string connString = "Data Source=" + QuizFile + ";";
                SQLiteConnection sqlConn = new SQLiteConnection(connString);
                sqlConn.Open();
                string sqlQuery = @"CREATE TABLE questions (
                `id` INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
                `question` CHAR(255) NOT NULL,`A` CHAR(255) NOT NULL,`B` CHAR(255) NOT NULL,
                `C` CHAR(255) NOT NULL,`D` CHAR(255) NOT NULL, `correct` INT NOT NULL, `difficulty` INT NOT NULL)";
                SQLiteCommand cmd = new SQLiteCommand(sqlQuery, sqlConn);
                cmd.ExecuteNonQuery();
                string q2 = @"INSERT INTO questions (id, question, A, B, C, D, correct, difficulty) VALUES (-1, 'Question', 'Choice A', 'Choice B', 'Choice C', 'Choice D', 'Correct Choice', 'Difficulty')";
                SQLiteCommand cmd2 = new SQLiteCommand(q2, sqlConn);
                //cmd2.ExecuteNonQuery();
                sqlConn.Close();
                ReopenDatabase();
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            AddQuestion aq = new AddQuestion();
            aq.Show();
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            ReopenDatabase();
        }

        private void reqs_Click(object sender, EventArgs e)
        {
            Requirements r = new Requirements();
            r.ShowDialog();
        }

        private void btnEditQuestion_Click(object sender, EventArgs e)
        {
            EditQuestion eq = new EditQuestion();
            eq.Show();
        }
    }
}
