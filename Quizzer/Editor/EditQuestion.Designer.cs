namespace Quizzer
{
    partial class EditQuestion
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
            this.Edit = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.status = new System.Windows.Forms.Label();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.txtQuestion = new System.Windows.Forms.TextBox();
            this.lblA = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.lblB = new System.Windows.Forms.Label();
            this.txtB = new System.Windows.Forms.TextBox();
            this.lblC = new System.Windows.Forms.Label();
            this.txtC = new System.Windows.Forms.TextBox();
            this.lblD = new System.Windows.Forms.Label();
            this.txtD = new System.Windows.Forms.TextBox();
            this.lblDefaultInfo = new System.Windows.Forms.Label();
            this.rdoA = new System.Windows.Forms.RadioButton();
            this.rdoB = new System.Windows.Forms.RadioButton();
            this.rdoC = new System.Windows.Forms.RadioButton();
            this.rdoD = new System.Windows.Forms.RadioButton();
            this.panelDifficulties = new System.Windows.Forms.Panel();
            this.diffEasy = new System.Windows.Forms.RadioButton();
            this.diffMod = new System.Windows.Forms.RadioButton();
            this.diffDiff = new System.Windows.Forms.RadioButton();
            this.lblDiff = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.numID = new System.Windows.Forms.ComboBox();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelHeader.SuspendLayout();
            this.panelFooter.SuspendLayout();
            this.panelDifficulties.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.Controls.Add(this.Edit);
            this.panelHeader.Controls.Add(this.btnExit);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(432, 30);
            this.panelHeader.TabIndex = 10;
            this.panelHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Draggable_MouseDown);
            // 
            // Edit
            // 
            this.Edit.AutoSize = true;
            this.Edit.Location = new System.Drawing.Point(12, 9);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(71, 13);
            this.Edit.TabIndex = 1;
            this.Edit.Text = "Add Question";
            this.Edit.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Draggable_MouseDown);
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
            this.btnExit.Location = new System.Drawing.Point(406, 0);
            this.btnExit.Margin = new System.Windows.Forms.Padding(0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(26, 30);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "U";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panelFooter
            // 
            this.panelFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panelFooter.Controls.Add(this.status);
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(0, 287);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(432, 16);
            this.panelFooter.TabIndex = 12;
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Location = new System.Drawing.Point(3, 0);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(41, 13);
            this.status.TabIndex = 0;
            this.status.Text = "Ready.";
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Location = new System.Drawing.Point(3, 30);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(49, 13);
            this.lblQuestion.TabIndex = 0;
            this.lblQuestion.Text = "Question";
            // 
            // txtQuestion
            // 
            this.txtQuestion.Location = new System.Drawing.Point(58, 27);
            this.txtQuestion.MaxLength = 255;
            this.txtQuestion.Name = "txtQuestion";
            this.txtQuestion.Size = new System.Drawing.Size(371, 20);
            this.txtQuestion.TabIndex = 1;
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(3, 72);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(14, 13);
            this.lblA.TabIndex = 2;
            this.lblA.Text = "A";
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(23, 69);
            this.txtA.MaxLength = 255;
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(386, 20);
            this.txtA.TabIndex = 3;
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Location = new System.Drawing.Point(3, 98);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(14, 13);
            this.lblB.TabIndex = 4;
            this.lblB.Text = "B";
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(23, 95);
            this.txtB.MaxLength = 255;
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(386, 20);
            this.txtB.TabIndex = 5;
            // 
            // lblC
            // 
            this.lblC.AutoSize = true;
            this.lblC.Location = new System.Drawing.Point(3, 124);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(14, 13);
            this.lblC.TabIndex = 6;
            this.lblC.Text = "C";
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(23, 121);
            this.txtC.MaxLength = 255;
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(386, 20);
            this.txtC.TabIndex = 7;
            // 
            // lblD
            // 
            this.lblD.AutoSize = true;
            this.lblD.Location = new System.Drawing.Point(3, 150);
            this.lblD.Name = "lblD";
            this.lblD.Size = new System.Drawing.Size(15, 13);
            this.lblD.TabIndex = 8;
            this.lblD.Text = "D";
            // 
            // txtD
            // 
            this.txtD.Location = new System.Drawing.Point(24, 147);
            this.txtD.MaxLength = 255;
            this.txtD.Name = "txtD";
            this.txtD.Size = new System.Drawing.Size(385, 20);
            this.txtD.TabIndex = 9;
            // 
            // lblDefaultInfo
            // 
            this.lblDefaultInfo.AutoSize = true;
            this.lblDefaultInfo.Location = new System.Drawing.Point(3, 53);
            this.lblDefaultInfo.Name = "lblDefaultInfo";
            this.lblDefaultInfo.Size = new System.Drawing.Size(189, 13);
            this.lblDefaultInfo.TabIndex = 10;
            this.lblDefaultInfo.Text = "Select the circle of the correct answer.";
            // 
            // rdoA
            // 
            this.rdoA.AutoSize = true;
            this.rdoA.Checked = true;
            this.rdoA.Location = new System.Drawing.Point(415, 72);
            this.rdoA.Name = "rdoA";
            this.rdoA.Size = new System.Drawing.Size(14, 13);
            this.rdoA.TabIndex = 11;
            this.rdoA.TabStop = true;
            this.rdoA.UseVisualStyleBackColor = true;
            // 
            // rdoB
            // 
            this.rdoB.AutoSize = true;
            this.rdoB.Location = new System.Drawing.Point(415, 98);
            this.rdoB.Name = "rdoB";
            this.rdoB.Size = new System.Drawing.Size(14, 13);
            this.rdoB.TabIndex = 12;
            this.rdoB.TabStop = true;
            this.rdoB.UseVisualStyleBackColor = true;
            // 
            // rdoC
            // 
            this.rdoC.AutoSize = true;
            this.rdoC.Location = new System.Drawing.Point(415, 124);
            this.rdoC.Name = "rdoC";
            this.rdoC.Size = new System.Drawing.Size(14, 13);
            this.rdoC.TabIndex = 13;
            this.rdoC.TabStop = true;
            this.rdoC.UseVisualStyleBackColor = true;
            // 
            // rdoD
            // 
            this.rdoD.AutoSize = true;
            this.rdoD.Location = new System.Drawing.Point(415, 150);
            this.rdoD.Name = "rdoD";
            this.rdoD.Size = new System.Drawing.Size(14, 13);
            this.rdoD.TabIndex = 14;
            this.rdoD.TabStop = true;
            this.rdoD.UseVisualStyleBackColor = true;
            // 
            // panelDifficulties
            // 
            this.panelDifficulties.Controls.Add(this.diffDiff);
            this.panelDifficulties.Controls.Add(this.diffMod);
            this.panelDifficulties.Controls.Add(this.diffEasy);
            this.panelDifficulties.Location = new System.Drawing.Point(56, 173);
            this.panelDifficulties.Name = "panelDifficulties";
            this.panelDifficulties.Size = new System.Drawing.Size(78, 71);
            this.panelDifficulties.TabIndex = 16;
            // 
            // diffEasy
            // 
            this.diffEasy.AutoSize = true;
            this.diffEasy.Checked = true;
            this.diffEasy.Location = new System.Drawing.Point(4, 4);
            this.diffEasy.Name = "diffEasy";
            this.diffEasy.Size = new System.Drawing.Size(48, 17);
            this.diffEasy.TabIndex = 0;
            this.diffEasy.TabStop = true;
            this.diffEasy.Text = "Easy";
            this.diffEasy.UseVisualStyleBackColor = true;
            // 
            // diffMod
            // 
            this.diffMod.AutoSize = true;
            this.diffMod.Location = new System.Drawing.Point(4, 27);
            this.diffMod.Name = "diffMod";
            this.diffMod.Size = new System.Drawing.Size(70, 17);
            this.diffMod.TabIndex = 1;
            this.diffMod.Text = "Moderate";
            this.diffMod.UseVisualStyleBackColor = true;
            // 
            // diffDiff
            // 
            this.diffDiff.AutoSize = true;
            this.diffDiff.Location = new System.Drawing.Point(4, 50);
            this.diffDiff.Name = "diffDiff";
            this.diffDiff.Size = new System.Drawing.Size(60, 17);
            this.diffDiff.TabIndex = 2;
            this.diffDiff.Text = "Difficult";
            this.diffDiff.UseVisualStyleBackColor = true;
            // 
            // lblDiff
            // 
            this.lblDiff.AutoSize = true;
            this.lblDiff.Location = new System.Drawing.Point(3, 200);
            this.lblDiff.Name = "lblDiff";
            this.lblDiff.Size = new System.Drawing.Size(47, 13);
            this.lblDiff.TabIndex = 17;
            this.lblDiff.Text = "Difficulty";
            // 
            // btnEdit
            // 
            this.btnEdit.ForeColor = System.Drawing.Color.Black;
            this.btnEdit.Location = new System.Drawing.Point(303, 173);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(126, 23);
            this.btnEdit.TabIndex = 18;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClose
            // 
            this.btnClose.ForeColor = System.Drawing.Color.Black;
            this.btnClose.Location = new System.Drawing.Point(303, 229);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(126, 23);
            this.btnClose.TabIndex = 19;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(3, 5);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 13);
            this.lblID.TabIndex = 24;
            this.lblID.Text = "ID";
            // 
            // btnDelete
            // 
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.Location = new System.Drawing.Point(303, 200);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(126, 23);
            this.btnDelete.TabIndex = 26;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // numID
            // 
            this.numID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.numID.FormattingEnabled = true;
            this.numID.Location = new System.Drawing.Point(58, 3);
            this.numID.Name = "numID";
            this.numID.Size = new System.Drawing.Size(371, 21);
            this.numID.TabIndex = 27;
            this.numID.SelectedIndexChanged += new System.EventHandler(this.update);
            this.numID.SelectedValueChanged += new System.EventHandler(this.update);
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.numID);
            this.panelMain.Controls.Add(this.btnDelete);
            this.panelMain.Controls.Add(this.lblID);
            this.panelMain.Controls.Add(this.btnClose);
            this.panelMain.Controls.Add(this.btnEdit);
            this.panelMain.Controls.Add(this.lblDiff);
            this.panelMain.Controls.Add(this.panelDifficulties);
            this.panelMain.Controls.Add(this.rdoD);
            this.panelMain.Controls.Add(this.rdoC);
            this.panelMain.Controls.Add(this.rdoB);
            this.panelMain.Controls.Add(this.rdoA);
            this.panelMain.Controls.Add(this.lblDefaultInfo);
            this.panelMain.Controls.Add(this.txtD);
            this.panelMain.Controls.Add(this.lblD);
            this.panelMain.Controls.Add(this.txtC);
            this.panelMain.Controls.Add(this.lblC);
            this.panelMain.Controls.Add(this.txtB);
            this.panelMain.Controls.Add(this.lblB);
            this.panelMain.Controls.Add(this.txtA);
            this.panelMain.Controls.Add(this.lblA);
            this.panelMain.Controls.Add(this.txtQuestion);
            this.panelMain.Controls.Add(this.lblQuestion);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 30);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(432, 273);
            this.panelMain.TabIndex = 11;
            // 
            // EditQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(432, 303);
            this.Controls.Add(this.panelFooter);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelHeader);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditQuestion";
            this.Text = "Template";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelFooter.ResumeLayout(false);
            this.panelFooter.PerformLayout();
            this.panelDifficulties.ResumeLayout(false);
            this.panelDifficulties.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panelHeader;
        public System.Windows.Forms.Label Edit;
        public System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.TextBox txtQuestion;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Label lblC;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.Label lblD;
        private System.Windows.Forms.TextBox txtD;
        private System.Windows.Forms.Label lblDefaultInfo;
        private System.Windows.Forms.RadioButton rdoA;
        private System.Windows.Forms.RadioButton rdoB;
        private System.Windows.Forms.RadioButton rdoC;
        private System.Windows.Forms.RadioButton rdoD;
        private System.Windows.Forms.Panel panelDifficulties;
        private System.Windows.Forms.RadioButton diffDiff;
        private System.Windows.Forms.RadioButton diffMod;
        private System.Windows.Forms.RadioButton diffEasy;
        private System.Windows.Forms.Label lblDiff;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ComboBox numID;
        private System.Windows.Forms.Panel panelMain;
    }
}