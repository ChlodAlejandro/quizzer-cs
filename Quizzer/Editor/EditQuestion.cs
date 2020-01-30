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
    public partial class EditQuestion : Form
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

        public EditQuestion()
        {
            InitializeComponent();
            txtQuestion.Enabled = false;
            txtA.Enabled = false;
            txtB.Enabled = false;
            txtC.Enabled = false;
            txtD.Enabled = false;
            rdoA.Enabled = false;
            rdoB.Enabled = false;
            rdoC.Enabled = false;
            rdoD.Enabled = false;
            diffDiff.Enabled = false;
            diffEasy.Enabled = false;
            diffMod.Enabled = false;
            Edit.Enabled = false;
            refreshValues();
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

            string delete = @"DELETE FROM questions WHERE id = @ID";
            SQLiteCommand deletion = new SQLiteCommand(delete, sqlConn);
            deletion.Parameters.Add("@ID", DbType.Int32);
            deletion.Parameters["@ID"].Value = Int32.Parse(numID.SelectedItem.ToString());
            deletion.ExecuteNonQuery();

            Int16 difficulty = 0;
            if (diffEasy.Checked) difficulty = 0;
            else if (diffMod.Checked) difficulty = 1;
            else if (diffDiff.Checked) difficulty = 2;

            Int16 correct = 0;
            if (rdoA.Checked) correct = 0;
            else if (rdoB.Checked) correct = 1;
            else if (rdoC.Checked) correct = 2;
            else if (rdoD.Checked) correct = 3;
            
            string addIntoSQL = @"INSERT INTO questions (id, question, A, B, C, D, correct, difficulty) VALUES (@ID, @Question, @A, @B, @C, @D, @Correct, @Difficulty)";
            SQLiteCommand cmd = new SQLiteCommand(addIntoSQL, sqlConn);

            cmd.Parameters.Add("@ID", DbType.Int32);
            cmd.Parameters["@ID"].Value = Int32.Parse(numID.SelectedItem.ToString());
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
            status.Text = "Edited question: \"" + txtQuestion.Text + "\"";
            refreshValues();
        }

        private void refreshValues()
        {
            if (Editor.QuizFilePath == string.Empty)
            {
                DialogResult r = MessageBox.Show("Please open a question file using the Editor first.", "Quizzer Question Adder", MessageBoxButtons.OK);
                return;
            }

            string connString = "Data Source=" + Editor.QuizFilePath + ";";
            SQLiteConnection sqlConn = new SQLiteConnection(connString);
            sqlConn.Open();

            string findAllIDS = @"SELECT `id` FROM questions";
            SQLiteCommand allIDS = new SQLiteCommand(findAllIDS, sqlConn);
            SQLiteDataReader reader = allIDS.ExecuteReader();
            List<int> IDs = new List<int>();
            while (reader.Read()) IDs.Add(Int32.Parse(reader["id"].ToString()));
            if (IDs.Count != 0)
            {
                IDs.OrderBy(i => i);
                numID.Items.Clear();
                foreach (int i in IDs) numID.Items.Add(i);
            }
        }

        private void update(Object sender, EventArgs e)
        {
            if (Editor.QuizFilePath == string.Empty)
            {
                DialogResult r = MessageBox.Show("Please open a question file using the Editor first.", "Quizzer Question Adder", MessageBoxButtons.OK);
                return;
            }

            string connString = "Data Source=" + Editor.QuizFilePath + ";";
            SQLiteConnection sqlConn = new SQLiteConnection(connString);
            sqlConn.Open();

            string findAllIDS = @"SELECT * FROM questions WHERE id = @ID";
            SQLiteCommand allIDS = new SQLiteCommand(findAllIDS, sqlConn);
            allIDS.Parameters.Add("@ID", DbType.Int32);
            allIDS.Parameters["@ID"].Value = Int32.Parse(numID.SelectedItem.ToString());
            SQLiteDataReader reader = allIDS.ExecuteReader();
            status.Text = "Writing previous values...";
            while (reader.Read())
            {
                txtQuestion.Enabled = true;
                txtA.Enabled = true;
                txtB.Enabled = true;
                txtC.Enabled = true;
                txtD.Enabled = true;
                rdoA.Enabled = true;
                rdoB.Enabled = true;
                rdoC.Enabled = true;
                rdoD.Enabled = true;
                diffDiff.Enabled = true;
                diffEasy.Enabled = true;
                diffMod.Enabled = true;
                Edit.Enabled = true;
                rdoA.Checked = false;
                rdoB.Checked = false;
                rdoC.Checked = false;
                rdoD.Checked = false;
                diffDiff.Checked = false;
                diffEasy.Checked = false;
                diffMod.Checked = false;
                txtQuestion.Text = reader["question"].ToString();
                txtA.Text = reader["A"].ToString();
                txtB.Text = reader["B"].ToString();
                txtC.Text = reader["C"].ToString();
                txtD.Text = reader["D"].ToString();
                switch (Int32.Parse(reader["correct"].ToString())) {
                    case 0:
                        rdoA.Checked = true;
                        break;
                    case 1:
                        rdoB.Checked = true;
                        break;
                    case 2:
                        rdoC.Checked = true;
                        break;
                    case 3:
                        rdoD.Checked = true;
                        break;
                }
                switch (Int32.Parse(reader["difficulty"].ToString()))
                {
                    case 0:
                        diffEasy.Checked = true;
                        break;
                    case 1:
                        diffMod.Checked = true;
                        break;
                    case 2:
                        diffDiff.Checked = true;
                        break;
                }
                Edit.Enabled = true;
            }
            status.Text = "Ready.";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (Editor.QuizFilePath == string.Empty)
            {
                DialogResult r = MessageBox.Show("Please open a question file using the Editor first.", "Quizzer Question Adder", MessageBoxButtons.OK);
                return;
            }

            string connString = "Data Source=" + Editor.QuizFilePath + ";";
            SQLiteConnection sqlConn = new SQLiteConnection(connString);
            sqlConn.Open();

            string delete = @"DELETE FROM questions WHERE id = @ID";
            SQLiteCommand deletion = new SQLiteCommand(delete, sqlConn);
            deletion.Parameters.Add("@ID", DbType.Int32);
            deletion.Parameters["@ID"].Value = Int32.Parse(numID.SelectedItem.ToString());
            deletion.ExecuteNonQuery();
            Editor.reupdatequestions = true;
            sqlConn.Close();
            status.Text = "Deleted question: \"" + txtQuestion.Text + "\"";
            refreshValues();
        }
    }
}