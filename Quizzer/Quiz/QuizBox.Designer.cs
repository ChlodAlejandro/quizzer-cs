namespace Quizzer
{
    partial class QuizBox
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
            this.timer = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelQA = new System.Windows.Forms.Panel();
            this.submit = new System.Windows.Forms.Button();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.panelAnswers = new System.Windows.Forms.Panel();
            this.choiceD = new System.Windows.Forms.RadioButton();
            this.choiceC = new System.Windows.Forms.RadioButton();
            this.choiceB = new System.Windows.Forms.RadioButton();
            this.choiceA = new System.Windows.Forms.RadioButton();
            this.panelQuestion = new System.Windows.Forms.Panel();
            this.question = new System.Windows.Forms.Label();
            this.remain = new System.Windows.Forms.Label();
            this.panelHeader.SuspendLayout();
            this.panelFooter.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.panelQA.SuspendLayout();
            this.panelAnswers.SuspendLayout();
            this.panelQuestion.SuspendLayout();
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
            this.btnExit.Location = new System.Drawing.Point(275, 0);
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
            this.panelHeader.Size = new System.Drawing.Size(301, 30);
            this.panelHeader.TabIndex = 7;
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
            this.title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Draggable_MouseDown);
            // 
            // panelFooter
            // 
            this.panelFooter.AutoScroll = true;
            this.panelFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panelFooter.Controls.Add(this.remain);
            this.panelFooter.Controls.Add(this.timer);
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(0, 419);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(301, 28);
            this.panelFooter.TabIndex = 8;
            // 
            // timer
            // 
            this.timer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.timer.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timer.Location = new System.Drawing.Point(0, 14);
            this.timer.Name = "timer";
            this.timer.Size = new System.Drawing.Size(301, 14);
            this.timer.TabIndex = 0;
            this.timer.Text = "0.00s";
            this.timer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.panelQA);
            this.panelMain.Controls.Add(this.panelQuestion);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 30);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(301, 389);
            this.panelMain.TabIndex = 9;
            // 
            // panelQA
            // 
            this.panelQA.Controls.Add(this.submit);
            this.panelQA.Controls.Add(this.lblQuestion);
            this.panelQA.Controls.Add(this.panelAnswers);
            this.panelQA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelQA.Location = new System.Drawing.Point(0, 0);
            this.panelQA.Name = "panelQA";
            this.panelQA.Size = new System.Drawing.Size(301, 389);
            this.panelQA.TabIndex = 1;
            // 
            // submit
            // 
            this.submit.ForeColor = System.Drawing.Color.Black;
            this.submit.Location = new System.Drawing.Point(-3, 275);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(304, 23);
            this.submit.TabIndex = 2;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.SubmitAnswer);
            // 
            // lblQuestion
            // 
            this.lblQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.Location = new System.Drawing.Point(0, 78);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(301, 98);
            this.lblQuestion.TabIndex = 1;
            this.lblQuestion.Text = "Question";
            this.lblQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelAnswers
            // 
            this.panelAnswers.AutoSize = true;
            this.panelAnswers.Controls.Add(this.choiceD);
            this.panelAnswers.Controls.Add(this.choiceC);
            this.panelAnswers.Controls.Add(this.choiceB);
            this.panelAnswers.Controls.Add(this.choiceA);
            this.panelAnswers.Location = new System.Drawing.Point(0, 176);
            this.panelAnswers.Name = "panelAnswers";
            this.panelAnswers.Size = new System.Drawing.Size(304, 103);
            this.panelAnswers.TabIndex = 0;
            // 
            // choiceD
            // 
            this.choiceD.Location = new System.Drawing.Point(3, 72);
            this.choiceD.Name = "choiceD";
            this.choiceD.Size = new System.Drawing.Size(295, 17);
            this.choiceD.TabIndex = 3;
            this.choiceD.TabStop = true;
            this.choiceD.Text = "Choice D";
            this.choiceD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.choiceD.UseVisualStyleBackColor = true;
            // 
            // choiceC
            // 
            this.choiceC.Location = new System.Drawing.Point(3, 49);
            this.choiceC.Name = "choiceC";
            this.choiceC.Size = new System.Drawing.Size(298, 17);
            this.choiceC.TabIndex = 2;
            this.choiceC.TabStop = true;
            this.choiceC.Text = "Choice C";
            this.choiceC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.choiceC.UseVisualStyleBackColor = true;
            // 
            // choiceB
            // 
            this.choiceB.Location = new System.Drawing.Point(3, 26);
            this.choiceB.Name = "choiceB";
            this.choiceB.Size = new System.Drawing.Size(298, 17);
            this.choiceB.TabIndex = 1;
            this.choiceB.TabStop = true;
            this.choiceB.Text = "Choice B";
            this.choiceB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.choiceB.UseVisualStyleBackColor = true;
            // 
            // choiceA
            // 
            this.choiceA.Location = new System.Drawing.Point(3, 3);
            this.choiceA.Name = "choiceA";
            this.choiceA.Size = new System.Drawing.Size(298, 17);
            this.choiceA.TabIndex = 0;
            this.choiceA.TabStop = true;
            this.choiceA.Text = "Choice A";
            this.choiceA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.choiceA.UseVisualStyleBackColor = true;
            // 
            // panelQuestion
            // 
            this.panelQuestion.Controls.Add(this.question);
            this.panelQuestion.Location = new System.Drawing.Point(0, 62);
            this.panelQuestion.Name = "panelQuestion";
            this.panelQuestion.Size = new System.Drawing.Size(301, 207);
            this.panelQuestion.TabIndex = 1;
            // 
            // question
            // 
            this.question.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.question.Location = new System.Drawing.Point(0, 2);
            this.question.Name = "question";
            this.question.Size = new System.Drawing.Size(301, 84);
            this.question.TabIndex = 1;
            this.question.Text = "Question";
            this.question.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // remain
            // 
            this.remain.Dock = System.Windows.Forms.DockStyle.Top;
            this.remain.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remain.Location = new System.Drawing.Point(0, 0);
            this.remain.Name = "remain";
            this.remain.Size = new System.Drawing.Size(301, 14);
            this.remain.TabIndex = 1;
            this.remain.Text = "Answer / Answerable Questions";
            this.remain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // QuizBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(301, 447);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelFooter);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "QuizBox";
            this.Text = "Quizzer - Quiz";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelFooter.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            this.panelQA.ResumeLayout(false);
            this.panelQA.PerformLayout();
            this.panelAnswers.ResumeLayout(false);
            this.panelQuestion.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button btnExit;
        public System.Windows.Forms.Panel panelHeader;
        public System.Windows.Forms.Label title;
        public System.Windows.Forms.Panel panelFooter;
        public System.Windows.Forms.Label timer;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.RadioButton choiceA;
        private System.Windows.Forms.Panel panelQuestion;
        private System.Windows.Forms.Label question;
        private System.Windows.Forms.Panel panelAnswers;
        private System.Windows.Forms.RadioButton choiceD;
        private System.Windows.Forms.RadioButton choiceC;
        private System.Windows.Forms.RadioButton choiceB;
        private System.Windows.Forms.Panel panelQA;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Button submit;
        public System.Windows.Forms.Label remain;
    }
}