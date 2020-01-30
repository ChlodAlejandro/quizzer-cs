namespace Quizzer
{
    partial class MainForm
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
            this.btnExit = new System.Windows.Forms.Button();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.title = new System.Windows.Forms.Label();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.status = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.btnEditor = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblQFileName = new System.Windows.Forms.Label();
            this.lblTimeDiffDesc = new System.Windows.Forms.Label();
            this.setFile = new System.Windows.Forms.Button();
            this.lblQuizPack = new System.Windows.Forms.Label();
            this.setQuestionsOn = new System.Windows.Forms.CheckedListBox();
            this.lblEnabledQuestions = new System.Windows.Forms.Label();
            this.lblIncTFCAns = new System.Windows.Forms.Label();
            this.setIncTFCAns = new System.Windows.Forms.CheckBox();
            this.setTimeDiff = new System.Windows.Forms.ComboBox();
            this.lblTimeDiff = new System.Windows.Forms.Label();
            this.panelHeader.SuspendLayout();
            this.panelFooter.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Wingdings 2", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(291, 0);
            this.btnExit.Margin = new System.Windows.Forms.Padding(0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(26, 30);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "U";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panelHeader
            // 
            this.panelHeader.Controls.Add(this.title);
            this.panelHeader.Controls.Add(this.btnExit);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(317, 30);
            this.panelHeader.TabIndex = 4;
            this.panelHeader.Paint += new System.Windows.Forms.PaintEventHandler(this.panelHeader_Paint);
            this.panelHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Draggable_MouseDown);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Location = new System.Drawing.Point(12, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(42, 13);
            this.title.TabIndex = 1;
            this.title.Text = "Quizzer";
            this.title.Click += new System.EventHandler(this.title_Click);
            // 
            // panelFooter
            // 
            this.panelFooter.AutoScroll = true;
            this.panelFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panelFooter.Controls.Add(this.status);
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(0, 472);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(317, 14);
            this.panelFooter.TabIndex = 5;
            this.panelFooter.Paint += new System.Windows.Forms.PaintEventHandler(this.panelFooter_Paint);
            // 
            // status
            // 
            this.status.Dock = System.Windows.Forms.DockStyle.Fill;
            this.status.Location = new System.Drawing.Point(0, 0);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(317, 14);
            this.status.TabIndex = 0;
            this.status.Text = "Ready.";
            this.status.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.status.Click += new System.EventHandler(this.status_Click);
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.btnEditor);
            this.panelMain.Controls.Add(this.btnStart);
            this.panelMain.Controls.Add(this.lblQFileName);
            this.panelMain.Controls.Add(this.lblTimeDiffDesc);
            this.panelMain.Controls.Add(this.setFile);
            this.panelMain.Controls.Add(this.lblQuizPack);
            this.panelMain.Controls.Add(this.setQuestionsOn);
            this.panelMain.Controls.Add(this.lblEnabledQuestions);
            this.panelMain.Controls.Add(this.lblIncTFCAns);
            this.panelMain.Controls.Add(this.setIncTFCAns);
            this.panelMain.Controls.Add(this.setTimeDiff);
            this.panelMain.Controls.Add(this.lblTimeDiff);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 30);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(317, 442);
            this.panelMain.TabIndex = 6;
            this.panelMain.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMain_Paint);
            // 
            // btnEditor
            // 
            this.btnEditor.ForeColor = System.Drawing.Color.Black;
            this.btnEditor.Location = new System.Drawing.Point(4, 416);
            this.btnEditor.Name = "btnEditor";
            this.btnEditor.Size = new System.Drawing.Size(310, 23);
            this.btnEditor.TabIndex = 12;
            this.btnEditor.Text = "Open Quiz Editor";
            this.btnEditor.UseVisualStyleBackColor = true;
            this.btnEditor.Click += new System.EventHandler(this.btnEditor_Click);
            // 
            // btnStart
            // 
            this.btnStart.ForeColor = System.Drawing.Color.Black;
            this.btnStart.Location = new System.Drawing.Point(4, 182);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(310, 23);
            this.btnStart.TabIndex = 11;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblQFileName
            // 
            this.lblQFileName.Location = new System.Drawing.Point(4, 164);
            this.lblQFileName.Name = "lblQFileName";
            this.lblQFileName.Size = new System.Drawing.Size(310, 14);
            this.lblQFileName.TabIndex = 10;
            this.lblQFileName.Text = "Select a file...";
            this.lblQFileName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblQFileName.Click += new System.EventHandler(this.lblQFileName_Click);
            // 
            // lblTimeDiffDesc
            // 
            this.lblTimeDiffDesc.Location = new System.Drawing.Point(4, 46);
            this.lblTimeDiffDesc.Name = "lblTimeDiffDesc";
            this.lblTimeDiffDesc.Size = new System.Drawing.Size(310, 34);
            this.lblTimeDiffDesc.TabIndex = 9;
            this.lblTimeDiffDesc.Text = "Select a time difficulty to get its description.";
            this.lblTimeDiffDesc.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblTimeDiffDesc.Click += new System.EventHandler(this.lblTimeDiffDesc_Click);
            // 
            // setFile
            // 
            this.setFile.ForeColor = System.Drawing.Color.Black;
            this.setFile.Location = new System.Drawing.Point(152, 134);
            this.setFile.Name = "setFile";
            this.setFile.Size = new System.Drawing.Size(162, 23);
            this.setFile.TabIndex = 8;
            this.setFile.Text = "Browse...";
            this.setFile.UseVisualStyleBackColor = true;
            this.setFile.Click += new System.EventHandler(this.setFile_Click);
            // 
            // lblQuizPack
            // 
            this.lblQuizPack.AutoSize = true;
            this.lblQuizPack.Location = new System.Drawing.Point(1, 134);
            this.lblQuizPack.Name = "lblQuizPack";
            this.lblQuizPack.Size = new System.Drawing.Size(56, 13);
            this.lblQuizPack.TabIndex = 7;
            this.lblQuizPack.Text = "Quiz Pack";
            this.lblQuizPack.Click += new System.EventHandler(this.lblQuizPack_Click);
            // 
            // setQuestionsOn
            // 
            this.setQuestionsOn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.setQuestionsOn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.setQuestionsOn.CheckOnClick = true;
            this.setQuestionsOn.ForeColor = System.Drawing.Color.White;
            this.setQuestionsOn.FormattingEnabled = true;
            this.setQuestionsOn.Items.AddRange(new object[] {
            "Easy",
            "Moderate",
            "Difficult"});
            this.setQuestionsOn.Location = new System.Drawing.Point(152, 83);
            this.setQuestionsOn.Name = "setQuestionsOn";
            this.setQuestionsOn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.setQuestionsOn.Size = new System.Drawing.Size(162, 45);
            this.setQuestionsOn.TabIndex = 6;
            this.setQuestionsOn.SelectedIndexChanged += new System.EventHandler(this.setQuestionsOn_SelectedIndexChanged);
            // 
            // lblEnabledQuestions
            // 
            this.lblEnabledQuestions.AutoSize = true;
            this.lblEnabledQuestions.Location = new System.Drawing.Point(1, 101);
            this.lblEnabledQuestions.Name = "lblEnabledQuestions";
            this.lblEnabledQuestions.Size = new System.Drawing.Size(96, 13);
            this.lblEnabledQuestions.TabIndex = 5;
            this.lblEnabledQuestions.Text = "Enabled Questions";
            this.lblEnabledQuestions.Click += new System.EventHandler(this.lblEnabledQuestions_Click);
            // 
            // lblIncTFCAns
            // 
            this.lblIncTFCAns.AutoSize = true;
            this.lblIncTFCAns.Location = new System.Drawing.Point(1, 26);
            this.lblIncTFCAns.Name = "lblIncTFCAns";
            this.lblIncTFCAns.Size = new System.Drawing.Size(172, 13);
            this.lblIncTFCAns.TabIndex = 3;
            this.lblIncTFCAns.Text = "Increase Time For Correct Answers";
            this.lblIncTFCAns.Click += new System.EventHandler(this.lblIncTFCAns_Click);
            // 
            // setIncTFCAns
            // 
            this.setIncTFCAns.AutoSize = true;
            this.setIncTFCAns.Location = new System.Drawing.Point(270, 26);
            this.setIncTFCAns.Name = "setIncTFCAns";
            this.setIncTFCAns.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.setIncTFCAns.Size = new System.Drawing.Size(44, 17);
            this.setIncTFCAns.TabIndex = 2;
            this.setIncTFCAns.Text = "Yes";
            this.setIncTFCAns.UseVisualStyleBackColor = true;
            this.setIncTFCAns.CheckedChanged += new System.EventHandler(this.setIncTFCAns_CheckedChanged);
            // 
            // setTimeDiff
            // 
            this.setTimeDiff.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.setTimeDiff.FormattingEnabled = true;
            this.setTimeDiff.Items.AddRange(new object[] {
            "Untimed Practice",
            "Timed Practice",
            "Easy",
            "Moderate",
            "Difficult",
            "Extreme",
            "Custom"});
            this.setTimeDiff.Location = new System.Drawing.Point(152, 3);
            this.setTimeDiff.Name = "setTimeDiff";
            this.setTimeDiff.Size = new System.Drawing.Size(162, 21);
            this.setTimeDiff.TabIndex = 1;
            this.setTimeDiff.SelectedIndexChanged += new System.EventHandler(this.setTimeDiff_SelectedIndexChanged);
            // 
            // lblTimeDiff
            // 
            this.lblTimeDiff.AutoSize = true;
            this.lblTimeDiff.Location = new System.Drawing.Point(1, 3);
            this.lblTimeDiff.Name = "lblTimeDiff";
            this.lblTimeDiff.Size = new System.Drawing.Size(73, 13);
            this.lblTimeDiff.TabIndex = 0;
            this.lblTimeDiff.Text = "Time Difficulty";
            this.lblTimeDiff.Click += new System.EventHandler(this.lblTimeDiff_Click);
            // 
            // MainForm
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(317, 486);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelFooter);
            this.Controls.Add(this.panelHeader);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "Quizzer";
            this.Load += new System.EventHandler(this.Quizzer_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelFooter.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button btnExit;
        public System.Windows.Forms.Panel panelHeader;
        public System.Windows.Forms.Panel panelFooter;
        public System.Windows.Forms.Panel panelMain;
        public System.Windows.Forms.Button setFile;
        public System.Windows.Forms.Label lblQuizPack;
        public System.Windows.Forms.CheckedListBox setQuestionsOn;
        public System.Windows.Forms.Label lblEnabledQuestions;
        public System.Windows.Forms.Label lblIncTFCAns;
        public System.Windows.Forms.CheckBox setIncTFCAns;
        public System.Windows.Forms.ComboBox setTimeDiff;
        public System.Windows.Forms.Label lblTimeDiff;
        public System.Windows.Forms.Label title;
        public System.Windows.Forms.Label status;
        public System.Windows.Forms.Label lblQFileName;
        public System.Windows.Forms.Label lblTimeDiffDesc;
        public System.Windows.Forms.Button btnEditor;
        public System.Windows.Forms.Button btnStart;
    }
}

