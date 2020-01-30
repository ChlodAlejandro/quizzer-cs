using System.Windows.Forms;

namespace Quizzer
{
    partial class CustomTimeDifficultyCreator
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
            this.panelHeader = new System.Windows.Forms.Panel();
            this.title = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Label();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.panelMain = new System.Windows.Forms.Panel();
            this.ok = new System.Windows.Forms.Button();
            this.timerDuration = new System.Windows.Forms.NumericUpDown();
            this.lblLength = new System.Windows.Forms.Label();
            this.timerStopMode = new System.Windows.Forms.RadioButton();
            this.timerCountMode = new System.Windows.Forms.RadioButton();
            this.lblMode = new System.Windows.Forms.Label();
            this.timerShow = new System.Windows.Forms.CheckBox();
            this.lblTimerShow = new System.Windows.Forms.Label();
            this.panelHeader.SuspendLayout();
            this.panelFooter.SuspendLayout();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timerDuration)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.Controls.Add(this.title);
            this.panelHeader.Controls.Add(this.btnExit);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(253, 30);
            this.panelHeader.TabIndex = 8;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Location = new System.Drawing.Point(12, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(42, 13);
            this.title.TabIndex = 1;
            this.title.Text = "Quizzer";
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
            this.btnExit.Location = new System.Drawing.Point(227, 0);
            this.btnExit.Margin = new System.Windows.Forms.Padding(0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(26, 30);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "U";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // timer
            // 
            this.timer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.timer.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timer.Location = new System.Drawing.Point(0, 0);
            this.timer.Name = "timer";
            this.timer.Size = new System.Drawing.Size(253, 14);
            this.timer.TabIndex = 0;
            this.timer.Text = "0.00s";
            this.timer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelFooter
            // 
            this.panelFooter.AutoScroll = true;
            this.panelFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panelFooter.Controls.Add(this.timer);
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(0, 158);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(253, 14);
            this.panelFooter.TabIndex = 9;
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.ok);
            this.panelMain.Controls.Add(this.timerDuration);
            this.panelMain.Controls.Add(this.lblLength);
            this.panelMain.Controls.Add(this.timerStopMode);
            this.panelMain.Controls.Add(this.timerCountMode);
            this.panelMain.Controls.Add(this.lblMode);
            this.panelMain.Controls.Add(this.timerShow);
            this.panelMain.Controls.Add(this.lblTimerShow);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 30);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(253, 128);
            this.panelMain.TabIndex = 10;
            // 
            // ok
            // 
            this.ok.ForeColor = System.Drawing.Color.Black;
            this.ok.Location = new System.Drawing.Point(4, 102);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(246, 23);
            this.ok.TabIndex = 9;
            this.ok.Text = "Start Quiz";
            this.ok.UseVisualStyleBackColor = true;
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // timerDuration
            // 
            this.timerDuration.Location = new System.Drawing.Point(174, 58);
            this.timerDuration.Maximum = new decimal(new int[] {
            86400,
            0,
            0,
            0});
            this.timerDuration.Name = "timerDuration";
            this.timerDuration.Size = new System.Drawing.Size(76, 20);
            this.timerDuration.TabIndex = 6;
            this.timerDuration.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Location = new System.Drawing.Point(4, 60);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(112, 13);
            this.lblLength.TabIndex = 5;
            this.lblLength.Text = "Seconds per Question";
            // 
            // timerStopMode
            // 
            this.timerStopMode.AutoSize = true;
            this.timerStopMode.Location = new System.Drawing.Point(174, 37);
            this.timerStopMode.Name = "timerStopMode";
            this.timerStopMode.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.timerStopMode.Size = new System.Drawing.Size(76, 17);
            this.timerStopMode.TabIndex = 4;
            this.timerStopMode.TabStop = true;
            this.timerStopMode.Text = "Stopwatch";
            this.timerStopMode.UseVisualStyleBackColor = true;
            // 
            // timerCountMode
            // 
            this.timerCountMode.AutoSize = true;
            this.timerCountMode.Checked = true;
            this.timerCountMode.Location = new System.Drawing.Point(171, 19);
            this.timerCountMode.Name = "timerCountMode";
            this.timerCountMode.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.timerCountMode.Size = new System.Drawing.Size(79, 17);
            this.timerCountMode.TabIndex = 3;
            this.timerCountMode.TabStop = true;
            this.timerCountMode.Text = "Countdown";
            this.timerCountMode.UseVisualStyleBackColor = true;
            // 
            // lblMode
            // 
            this.lblMode.AutoSize = true;
            this.lblMode.Location = new System.Drawing.Point(3, 32);
            this.lblMode.Name = "lblMode";
            this.lblMode.Size = new System.Drawing.Size(34, 13);
            this.lblMode.TabIndex = 2;
            this.lblMode.Text = "Mode";
            // 
            // timerShow
            // 
            this.timerShow.AutoSize = true;
            this.timerShow.Checked = true;
            this.timerShow.CheckState = System.Windows.Forms.CheckState.Checked;
            this.timerShow.Location = new System.Drawing.Point(206, 3);
            this.timerShow.Name = "timerShow";
            this.timerShow.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.timerShow.Size = new System.Drawing.Size(44, 17);
            this.timerShow.TabIndex = 1;
            this.timerShow.Text = "Yes";
            this.timerShow.UseVisualStyleBackColor = true;
            // 
            // lblTimerShow
            // 
            this.lblTimerShow.AutoSize = true;
            this.lblTimerShow.Location = new System.Drawing.Point(3, 4);
            this.lblTimerShow.Name = "lblTimerShow";
            this.lblTimerShow.Size = new System.Drawing.Size(63, 13);
            this.lblTimerShow.TabIndex = 0;
            this.lblTimerShow.Text = "Show Timer";
            // 
            // CustomTimeDifficultyCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(253, 172);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelFooter);
            this.Controls.Add(this.panelHeader);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomTimeDifficultyCreator";
            this.Text = "CustomTimeDifficultyCreator";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelFooter.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timerDuration)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public Panel panelHeader;
        public Label title;
        public Button btnExit;
        public Label timer;
        public Panel panelFooter;
        private Panel panelMain;
        private Label lblLength;
        private Label lblMode;
        private Label lblTimerShow;
        private Button ok;
        public NumericUpDown timerDuration;
        public RadioButton timerStopMode;
        public RadioButton timerCountMode;
        public CheckBox timerShow;
    }
}