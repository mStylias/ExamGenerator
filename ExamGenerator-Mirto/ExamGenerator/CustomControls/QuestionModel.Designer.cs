namespace ExamGenerator.CustomControls
{
    partial class QuestionModel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelQuestion = new System.Windows.Forms.Label();
            this.labelTagsTitle = new System.Windows.Forms.Label();
            this.labelTags = new System.Windows.Forms.Label();
            this.labelAnswersTitle = new System.Windows.Forms.Label();
            this.labelAnswers = new System.Windows.Forms.Label();
            this.labelCorrectAnswerTitle = new System.Windows.Forms.Label();
            this.labelCorrectAnswer = new System.Windows.Forms.Label();
            this.labelDifficultyTitle = new System.Windows.Forms.Label();
            this.labelDifficulty = new System.Windows.Forms.Label();
            this.checkBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // labelQuestion
            // 
            this.labelQuestion.AutoEllipsis = true;
            this.labelQuestion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(215)))), ((int)(((byte)(249)))));
            this.labelQuestion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelQuestion.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelQuestion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuestion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(28)))), ((int)(((byte)(32)))));
            this.labelQuestion.Location = new System.Drawing.Point(1, 1);
            this.labelQuestion.Name = "labelQuestion";
            this.labelQuestion.Size = new System.Drawing.Size(248, 50);
            this.labelQuestion.TabIndex = 3;
            this.labelQuestion.Text = "Question";
            this.labelQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelQuestion.Click += new System.EventHandler(this.AllControlsCheck_Click);
            // 
            // labelTagsTitle
            // 
            this.labelTagsTitle.AutoEllipsis = true;
            this.labelTagsTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(253)))));
            this.labelTagsTitle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelTagsTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelTagsTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelTagsTitle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTagsTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(28)))), ((int)(((byte)(32)))));
            this.labelTagsTitle.Location = new System.Drawing.Point(1, 51);
            this.labelTagsTitle.Name = "labelTagsTitle";
            this.labelTagsTitle.Size = new System.Drawing.Size(248, 23);
            this.labelTagsTitle.TabIndex = 4;
            this.labelTagsTitle.Text = "Tags";
            this.labelTagsTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelTagsTitle.Click += new System.EventHandler(this.AllControlsCheck_Click);
            // 
            // labelTags
            // 
            this.labelTags.AutoEllipsis = true;
            this.labelTags.BackColor = System.Drawing.Color.White;
            this.labelTags.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelTags.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelTags.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelTags.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTags.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(28)))), ((int)(((byte)(32)))));
            this.labelTags.Location = new System.Drawing.Point(1, 74);
            this.labelTags.Name = "labelTags";
            this.labelTags.Size = new System.Drawing.Size(248, 25);
            this.labelTags.TabIndex = 5;
            this.labelTags.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelTags.Click += new System.EventHandler(this.AllControlsCheck_Click);
            // 
            // labelAnswersTitle
            // 
            this.labelAnswersTitle.AutoEllipsis = true;
            this.labelAnswersTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(253)))));
            this.labelAnswersTitle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelAnswersTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelAnswersTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelAnswersTitle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAnswersTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(28)))), ((int)(((byte)(32)))));
            this.labelAnswersTitle.Location = new System.Drawing.Point(1, 99);
            this.labelAnswersTitle.Name = "labelAnswersTitle";
            this.labelAnswersTitle.Size = new System.Drawing.Size(248, 23);
            this.labelAnswersTitle.TabIndex = 6;
            this.labelAnswersTitle.Text = "Answers";
            this.labelAnswersTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelAnswersTitle.Click += new System.EventHandler(this.AllControlsCheck_Click);
            // 
            // labelAnswers
            // 
            this.labelAnswers.AutoEllipsis = true;
            this.labelAnswers.BackColor = System.Drawing.Color.White;
            this.labelAnswers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelAnswers.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelAnswers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelAnswers.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAnswers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(28)))), ((int)(((byte)(32)))));
            this.labelAnswers.Location = new System.Drawing.Point(1, 122);
            this.labelAnswers.Name = "labelAnswers";
            this.labelAnswers.Size = new System.Drawing.Size(248, 25);
            this.labelAnswers.TabIndex = 7;
            this.labelAnswers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelAnswers.Click += new System.EventHandler(this.AllControlsCheck_Click);
            // 
            // labelCorrectAnswerTitle
            // 
            this.labelCorrectAnswerTitle.AutoEllipsis = true;
            this.labelCorrectAnswerTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(253)))));
            this.labelCorrectAnswerTitle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelCorrectAnswerTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelCorrectAnswerTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelCorrectAnswerTitle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCorrectAnswerTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(28)))), ((int)(((byte)(32)))));
            this.labelCorrectAnswerTitle.Location = new System.Drawing.Point(1, 147);
            this.labelCorrectAnswerTitle.Name = "labelCorrectAnswerTitle";
            this.labelCorrectAnswerTitle.Size = new System.Drawing.Size(248, 23);
            this.labelCorrectAnswerTitle.TabIndex = 8;
            this.labelCorrectAnswerTitle.Text = "Correct answer";
            this.labelCorrectAnswerTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelCorrectAnswerTitle.Click += new System.EventHandler(this.AllControlsCheck_Click);
            // 
            // labelCorrectAnswer
            // 
            this.labelCorrectAnswer.AutoEllipsis = true;
            this.labelCorrectAnswer.BackColor = System.Drawing.Color.White;
            this.labelCorrectAnswer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelCorrectAnswer.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelCorrectAnswer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelCorrectAnswer.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCorrectAnswer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(28)))), ((int)(((byte)(32)))));
            this.labelCorrectAnswer.Location = new System.Drawing.Point(1, 170);
            this.labelCorrectAnswer.Name = "labelCorrectAnswer";
            this.labelCorrectAnswer.Size = new System.Drawing.Size(248, 25);
            this.labelCorrectAnswer.TabIndex = 9;
            this.labelCorrectAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelCorrectAnswer.Click += new System.EventHandler(this.AllControlsCheck_Click);
            // 
            // labelDifficultyTitle
            // 
            this.labelDifficultyTitle.AutoEllipsis = true;
            this.labelDifficultyTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(253)))));
            this.labelDifficultyTitle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelDifficultyTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelDifficultyTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelDifficultyTitle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDifficultyTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(28)))), ((int)(((byte)(32)))));
            this.labelDifficultyTitle.Location = new System.Drawing.Point(1, 195);
            this.labelDifficultyTitle.Name = "labelDifficultyTitle";
            this.labelDifficultyTitle.Size = new System.Drawing.Size(248, 23);
            this.labelDifficultyTitle.TabIndex = 10;
            this.labelDifficultyTitle.Text = "Difficulty";
            this.labelDifficultyTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelDifficultyTitle.Click += new System.EventHandler(this.AllControlsCheck_Click);
            // 
            // labelDifficulty
            // 
            this.labelDifficulty.AutoEllipsis = true;
            this.labelDifficulty.BackColor = System.Drawing.Color.White;
            this.labelDifficulty.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelDifficulty.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelDifficulty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelDifficulty.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDifficulty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(28)))), ((int)(((byte)(32)))));
            this.labelDifficulty.Location = new System.Drawing.Point(1, 218);
            this.labelDifficulty.Name = "labelDifficulty";
            this.labelDifficulty.Size = new System.Drawing.Size(248, 25);
            this.labelDifficulty.TabIndex = 11;
            this.labelDifficulty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelDifficulty.Click += new System.EventHandler(this.AllControlsCheck_Click);
            // 
            // checkBox
            // 
            this.checkBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(253)))));
            this.checkBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.checkBox.FlatAppearance.BorderSize = 0;
            this.checkBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.checkBox.Location = new System.Drawing.Point(1, 243);
            this.checkBox.Name = "checkBox";
            this.checkBox.Padding = new System.Windows.Forms.Padding(82, 0, 0, 0);
            this.checkBox.Size = new System.Drawing.Size(248, 23);
            this.checkBox.TabIndex = 12;
            this.checkBox.Text = "Selected";
            this.checkBox.UseVisualStyleBackColor = false;
            this.checkBox.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // QuestionModel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.checkBox);
            this.Controls.Add(this.labelDifficulty);
            this.Controls.Add(this.labelDifficultyTitle);
            this.Controls.Add(this.labelCorrectAnswer);
            this.Controls.Add(this.labelCorrectAnswerTitle);
            this.Controls.Add(this.labelAnswers);
            this.Controls.Add(this.labelAnswersTitle);
            this.Controls.Add(this.labelTags);
            this.Controls.Add(this.labelTagsTitle);
            this.Controls.Add(this.labelQuestion);
            this.MinimumSize = new System.Drawing.Size(250, 0);
            this.Name = "QuestionModel";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.Size = new System.Drawing.Size(250, 267);
            this.Load += new System.EventHandler(this.QuestionModel_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label labelQuestion;
        private System.Windows.Forms.Label labelTagsTitle;
        private System.Windows.Forms.Label labelTags;
        private System.Windows.Forms.Label labelAnswersTitle;
        private System.Windows.Forms.Label labelAnswers;
        private System.Windows.Forms.Label labelCorrectAnswerTitle;
        private System.Windows.Forms.Label labelCorrectAnswer;
        private System.Windows.Forms.Label labelDifficultyTitle;
        private System.Windows.Forms.Label labelDifficulty;
        private System.Windows.Forms.CheckBox checkBox;
    }
}
