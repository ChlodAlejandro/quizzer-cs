using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quizzer
{
    public partial class Results : Form
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

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();

        public bool debug = true;
        private List<QAResult> qna = new List<QAResult>();
        public Results()
        {
            InitializeComponent();
            if (debug) AllocConsole();
            DataTable dt = new DataTable();
            foreach (QAResult qa in qna)
            {
                dt.Columns.Clear();
                foreach(DataColumn dc in resultsTable.Columns)
                {
                    dt.Columns.Add(dc);
                }
                DataRow row = dt.NewRow();

                row["ID"] = qa.Question.ID;
                row["Q"] = qa.Question.Q;
                row["A"] = qa.Question.A;
                row["B"] = qa.Question.B;
                row["C"] = qa.Question.C;
                row["D"] = qa.Question.D;
                switch(qa.Question.Correct)
                {
                    case 0:
                        row["Correct Choice"] = "A";
                        break;
                    case 1:
                        row["Correct Choice"] = "B";
                        break;
                    case 2:
                        row["Correct Choice"] = "C";
                        break;
                    case 3:
                        row["Correct Choice"] = "D";
                        break;
                }
                row["Difficulty"] = qa.Question.Difficulty;
                row["Answer"] = qa.Answer.A;
                switch (qa.Answer.Correct)
                {
                    case true:
                        row["Correct"] = "Yes";
                        break;
                    case false:
                        row["Correct"] = "No";
                        break;
                }
                row["Time"] = qa.Answer.TimeMiliseconds / 1000;
            }
        }

        
        private void newfile_Click(object sender, EventArgs e)
        {
            SaveFileDialog file = new SaveFileDialog();
            file.Filter = "Quizzer Result File|*.qrf|All Files|*.*";
            file.FilterIndex = 1;
            file.Title = "Quizzer Results Saver";
            DialogResult dr = file.ShowDialog();
            if (dr != DialogResult.OK) return;
            SQLiteConnection.CreateFile(file.FileName);
            string connString = "Data Source=" + file.FileName + ";";
            SQLiteConnection sqlConn = new SQLiteConnection(connString);
            sqlConn.Open();
            string sqlQuery = @"CREATE TABLE answers (";
            foreach (DataGridViewColumn col in resultsTable.Columns)
            {
                sqlQuery += "`" + col.Name + "` CHAR(255) NOT NULL, ";
            }
            sqlQuery += "`numid` INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT)";
            SQLiteCommand cmd = new SQLiteCommand(sqlQuery, sqlConn);
            cmd.ExecuteNonQuery();
            string RowBuild = "INSERT INTO answers (";
            foreach (DataGridViewRow row in resultsTable.Rows)
            {
                foreach (DataGridViewColumn col in resultsTable.Columns)
                {
                    RowBuild += "[" + col.Name + "], ";
                }
                RowBuild += "[numid]) VALUES (";
                foreach (DataGridViewCell cell in row.Cells)
                {
                    RowBuild += "\"" + cell.Value + "\", ";
                }
                RowBuild += "null)";
            }
            Console.WriteLine(RowBuild);
            SQLiteCommand insertcmd = new SQLiteCommand(RowBuild, sqlConn);
            insertcmd.ExecuteNonQuery();
            sqlConn.Close();
        }
    }
}
