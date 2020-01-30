namespace Quizzer
{
    partial class Editor
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.refresh = new System.Windows.Forms.Button();
            this.newfile = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblFilePath = new System.Windows.Forms.Label();
            this.browse = new System.Windows.Forms.Button();
            this.file = new System.Windows.Forms.DataGridView();
            this.reqs = new System.Windows.Forms.Button();
            this.btnEditQuestion = new System.Windows.Forms.Button();
            this.panelHeader.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.file)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.Controls.Add(this.title);
            this.panelHeader.Controls.Add(this.btnExit);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(843, 30);
            this.panelHeader.TabIndex = 10;
            this.panelHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Draggable_MouseDown);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Location = new System.Drawing.Point(12, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(72, 13);
            this.title.TabIndex = 1;
            this.title.Text = "Quizzer Editor";
            this.title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Draggable_MouseDown);
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
            this.btnExit.Location = new System.Drawing.Point(817, 0);
            this.btnExit.Margin = new System.Windows.Forms.Padding(0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(26, 30);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "U";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.file);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(843, 588);
            this.panel1.TabIndex = 11;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnEditQuestion);
            this.panel3.Controls.Add(this.reqs);
            this.panel3.Controls.Add(this.refresh);
            this.panel3.Controls.Add(this.newfile);
            this.panel3.Controls.Add(this.reset);
            this.panel3.Controls.Add(this.add);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 559);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(843, 29);
            this.panel3.TabIndex = 4;
            // 
            // refresh
            // 
            this.refresh.ForeColor = System.Drawing.Color.Black;
            this.refresh.Location = new System.Drawing.Point(3, 3);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(75, 23);
            this.refresh.TabIndex = 4;
            this.refresh.Text = "Refresh";
            this.refresh.UseVisualStyleBackColor = true;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // newfile
            // 
            this.newfile.ForeColor = System.Drawing.Color.Black;
            this.newfile.Location = new System.Drawing.Point(765, 3);
            this.newfile.Name = "newfile";
            this.newfile.Size = new System.Drawing.Size(75, 23);
            this.newfile.TabIndex = 3;
            this.newfile.Text = "New Pack";
            this.newfile.UseVisualStyleBackColor = true;
            this.newfile.Click += new System.EventHandler(this.newfile_Click);
            // 
            // reset
            // 
            this.reset.ForeColor = System.Drawing.Color.Black;
            this.reset.Location = new System.Drawing.Point(254, 3);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(80, 23);
            this.reset.TabIndex = 1;
            this.reset.Text = "Reset Table";
            this.reset.UseVisualStyleBackColor = true;
            // 
            // add
            // 
            this.add.ForeColor = System.Drawing.Color.Black;
            this.add.Location = new System.Drawing.Point(84, 3);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(80, 23);
            this.add.TabIndex = 0;
            this.add.Text = "Add Question";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblFilePath);
            this.panel2.Controls.Add(this.browse);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(843, 30);
            this.panel2.TabIndex = 3;
            // 
            // lblFilePath
            // 
            this.lblFilePath.Location = new System.Drawing.Point(86, 3);
            this.lblFilePath.Name = "lblFilePath";
            this.lblFilePath.Size = new System.Drawing.Size(544, 23);
            this.lblFilePath.TabIndex = 3;
            this.lblFilePath.Text = "Select a file...";
            this.lblFilePath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // browse
            // 
            this.browse.ForeColor = System.Drawing.Color.Black;
            this.browse.Location = new System.Drawing.Point(4, 3);
            this.browse.Name = "browse";
            this.browse.Size = new System.Drawing.Size(75, 23);
            this.browse.TabIndex = 2;
            this.browse.Text = "Browse...";
            this.browse.UseVisualStyleBackColor = true;
            this.browse.Click += new System.EventHandler(this.setFile_Click);
            // 
            // file
            // 
            this.file.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.file.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.file.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.file.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.file.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.file.Location = new System.Drawing.Point(0, 29);
            this.file.Name = "file";
            this.file.ReadOnly = true;
            this.file.Size = new System.Drawing.Size(843, 527);
            this.file.TabIndex = 2;
            // 
            // reqs
            // 
            this.reqs.ForeColor = System.Drawing.Color.Black;
            this.reqs.Location = new System.Drawing.Point(675, 3);
            this.reqs.Name = "reqs";
            this.reqs.Size = new System.Drawing.Size(84, 23);
            this.reqs.TabIndex = 5;
            this.reqs.Text = "Requirements";
            this.reqs.UseVisualStyleBackColor = true;
            this.reqs.Click += new System.EventHandler(this.reqs_Click);
            // 
            // btnEditQuestion
            // 
            this.btnEditQuestion.ForeColor = System.Drawing.Color.Black;
            this.btnEditQuestion.Location = new System.Drawing.Point(170, 3);
            this.btnEditQuestion.Name = "btnEditQuestion";
            this.btnEditQuestion.Size = new System.Drawing.Size(78, 23);
            this.btnEditQuestion.TabIndex = 6;
            this.btnEditQuestion.Text = "Edit Question";
            this.btnEditQuestion.UseVisualStyleBackColor = true;
            this.btnEditQuestion.Click += new System.EventHandler(this.btnEditQuestion_Click);
            // 
            // Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(843, 618);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelHeader);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Editor";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.file)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panelHeader;
        public System.Windows.Forms.Label title;
        public System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblFilePath;
        private System.Windows.Forms.Button browse;
        private System.Windows.Forms.DataGridView file;
        private System.Windows.Forms.Button newfile;
        private System.Windows.Forms.Button refresh;
        private System.Windows.Forms.Button reqs;
        private System.Windows.Forms.Button btnEditQuestion;
    }
}