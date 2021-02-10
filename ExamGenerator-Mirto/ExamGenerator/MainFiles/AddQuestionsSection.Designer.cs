
namespace ExamGenerator.MainFiles
{
    partial class AddQuestionsSection
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
            this.panelQuestions = new System.Windows.Forms.Panel();
            this.panelSubmitButton = new System.Windows.Forms.Panel();
            this.buttonCreateQuestion = new System.Windows.Forms.Button();
            this.panelAllFields = new System.Windows.Forms.Panel();
            this.comboBoxDifficulty = new System.Windows.Forms.ComboBox();
            this.labelDifficulty = new System.Windows.Forms.Label();
            this.comboBoxCorrectAnswer = new System.Windows.Forms.ComboBox();
            this.labelWriteCorrectAnswer = new System.Windows.Forms.Label();
            this.panelPossibleAnswers = new System.Windows.Forms.Panel();
            this.RemoveAnswerButton = new System.Windows.Forms.Button();
            this.AddAnswerButton = new System.Windows.Forms.Button();
            this.richTextBoxAnswer2 = new System.Windows.Forms.RichTextBox();
            this.richTextBoxAnswer1 = new System.Windows.Forms.RichTextBox();
            this.labelWriteAnswers = new System.Windows.Forms.Label();
            this.buttonCreateTag = new System.Windows.Forms.Button();
            this.richTextBoxCreateTag = new System.Windows.Forms.RichTextBox();
            this.labelCreateTag = new System.Windows.Forms.Label();
            this.panelAllTags = new System.Windows.Forms.Panel();
            this.panelLeftTags = new System.Windows.Forms.Panel();
            this.panelRightTags = new System.Windows.Forms.Panel();
            this.labelSelectTags = new System.Windows.Forms.Label();
            this.richTextBoxQuestion = new System.Windows.Forms.RichTextBox();
            this.labelQuestion = new System.Windows.Forms.Label();
            this.panelTop = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelQuestions.SuspendLayout();
            this.panelSubmitButton.SuspendLayout();
            this.panelAllFields.SuspendLayout();
            this.panelPossibleAnswers.SuspendLayout();
            this.panelAllTags.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelQuestions
            // 
            this.panelQuestions.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelQuestions.AutoScroll = true;
            this.panelQuestions.AutoSize = true;
            this.panelQuestions.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelQuestions.Controls.Add(this.panelSubmitButton);
            this.panelQuestions.Controls.Add(this.panelAllFields);
            this.panelQuestions.Location = new System.Drawing.Point(273, 72);
            this.panelQuestions.MinimumSize = new System.Drawing.Size(352, 0);
            this.panelQuestions.Name = "panelQuestions";
            this.panelQuestions.Size = new System.Drawing.Size(352, 602);
            this.panelQuestions.TabIndex = 0;
            // 
            // panelSubmitButton
            // 
            this.panelSubmitButton.Controls.Add(this.buttonCreateQuestion);
            this.panelSubmitButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubmitButton.Location = new System.Drawing.Point(0, 480);
            this.panelSubmitButton.Margin = new System.Windows.Forms.Padding(2);
            this.panelSubmitButton.Name = "panelSubmitButton";
            this.panelSubmitButton.Size = new System.Drawing.Size(352, 122);
            this.panelSubmitButton.TabIndex = 0;
            // 
            // buttonCreateQuestion
            // 
            this.buttonCreateQuestion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(166)))), ((int)(((byte)(243)))));
            this.buttonCreateQuestion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCreateQuestion.FlatAppearance.BorderSize = 0;
            this.buttonCreateQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCreateQuestion.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreateQuestion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(247)))));
            this.buttonCreateQuestion.Location = new System.Drawing.Point(0, 34);
            this.buttonCreateQuestion.Name = "buttonCreateQuestion";
            this.buttonCreateQuestion.Size = new System.Drawing.Size(352, 55);
            this.buttonCreateQuestion.TabIndex = 0;
            this.buttonCreateQuestion.TabStop = false;
            this.buttonCreateQuestion.Text = "Create Question";
            this.buttonCreateQuestion.UseVisualStyleBackColor = false;
            this.buttonCreateQuestion.Click += new System.EventHandler(this.buttonCreateQuestion_Click);
            // 
            // panelAllFields
            // 
            this.panelAllFields.AutoSize = true;
            this.panelAllFields.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelAllFields.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelAllFields.Controls.Add(this.comboBoxDifficulty);
            this.panelAllFields.Controls.Add(this.labelDifficulty);
            this.panelAllFields.Controls.Add(this.comboBoxCorrectAnswer);
            this.panelAllFields.Controls.Add(this.labelWriteCorrectAnswer);
            this.panelAllFields.Controls.Add(this.panelPossibleAnswers);
            this.panelAllFields.Controls.Add(this.labelWriteAnswers);
            this.panelAllFields.Controls.Add(this.buttonCreateTag);
            this.panelAllFields.Controls.Add(this.richTextBoxCreateTag);
            this.panelAllFields.Controls.Add(this.labelCreateTag);
            this.panelAllFields.Controls.Add(this.panelAllTags);
            this.panelAllFields.Controls.Add(this.labelSelectTags);
            this.panelAllFields.Controls.Add(this.richTextBoxQuestion);
            this.panelAllFields.Controls.Add(this.labelQuestion);
            this.panelAllFields.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAllFields.Location = new System.Drawing.Point(0, 0);
            this.panelAllFields.Margin = new System.Windows.Forms.Padding(2);
            this.panelAllFields.MinimumSize = new System.Drawing.Size(352, 2);
            this.panelAllFields.Name = "panelAllFields";
            this.panelAllFields.Size = new System.Drawing.Size(352, 480);
            this.panelAllFields.TabIndex = 0;
            // 
            // comboBoxDifficulty
            // 
            this.comboBoxDifficulty.BackColor = System.Drawing.Color.White;
            this.comboBoxDifficulty.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboBoxDifficulty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDifficulty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxDifficulty.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.comboBoxDifficulty.ForeColor = System.Drawing.SystemColors.WindowText;
            this.comboBoxDifficulty.FormattingEnabled = true;
            this.comboBoxDifficulty.Items.AddRange(new object[] {
            "Easy",
            "Medium",
            "Hard"});
            this.comboBoxDifficulty.Location = new System.Drawing.Point(0, 450);
            this.comboBoxDifficulty.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxDifficulty.Name = "comboBoxDifficulty";
            this.comboBoxDifficulty.Size = new System.Drawing.Size(350, 28);
            this.comboBoxDifficulty.TabIndex = 12;
            // 
            // labelDifficulty
            // 
            this.labelDifficulty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(253)))));
            this.labelDifficulty.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelDifficulty.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.labelDifficulty.Location = new System.Drawing.Point(0, 422);
            this.labelDifficulty.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDifficulty.Name = "labelDifficulty";
            this.labelDifficulty.Size = new System.Drawing.Size(350, 28);
            this.labelDifficulty.TabIndex = 11;
            this.labelDifficulty.Text = "Difficulty";
            this.labelDifficulty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxCorrectAnswer
            // 
            this.comboBoxCorrectAnswer.BackColor = System.Drawing.Color.White;
            this.comboBoxCorrectAnswer.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboBoxCorrectAnswer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCorrectAnswer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxCorrectAnswer.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.comboBoxCorrectAnswer.ForeColor = System.Drawing.SystemColors.WindowText;
            this.comboBoxCorrectAnswer.FormattingEnabled = true;
            this.comboBoxCorrectAnswer.Location = new System.Drawing.Point(0, 394);
            this.comboBoxCorrectAnswer.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxCorrectAnswer.Name = "comboBoxCorrectAnswer";
            this.comboBoxCorrectAnswer.Size = new System.Drawing.Size(350, 28);
            this.comboBoxCorrectAnswer.TabIndex = 15;
            // 
            // labelWriteCorrectAnswer
            // 
            this.labelWriteCorrectAnswer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(253)))));
            this.labelWriteCorrectAnswer.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelWriteCorrectAnswer.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.labelWriteCorrectAnswer.Location = new System.Drawing.Point(0, 366);
            this.labelWriteCorrectAnswer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelWriteCorrectAnswer.Name = "labelWriteCorrectAnswer";
            this.labelWriteCorrectAnswer.Size = new System.Drawing.Size(350, 28);
            this.labelWriteCorrectAnswer.TabIndex = 9;
            this.labelWriteCorrectAnswer.Text = "Select the correct answer";
            this.labelWriteCorrectAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelPossibleAnswers
            // 
            this.panelPossibleAnswers.AutoSize = true;
            this.panelPossibleAnswers.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelPossibleAnswers.Controls.Add(this.RemoveAnswerButton);
            this.panelPossibleAnswers.Controls.Add(this.AddAnswerButton);
            this.panelPossibleAnswers.Controls.Add(this.richTextBoxAnswer2);
            this.panelPossibleAnswers.Controls.Add(this.richTextBoxAnswer1);
            this.panelPossibleAnswers.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPossibleAnswers.Location = new System.Drawing.Point(0, 267);
            this.panelPossibleAnswers.Margin = new System.Windows.Forms.Padding(2);
            this.panelPossibleAnswers.Name = "panelPossibleAnswers";
            this.panelPossibleAnswers.Size = new System.Drawing.Size(350, 99);
            this.panelPossibleAnswers.TabIndex = 8;
            // 
            // RemoveAnswerButton
            // 
            this.RemoveAnswerButton.BackColor = System.Drawing.SystemColors.Window;
            this.RemoveAnswerButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.RemoveAnswerButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RemoveAnswerButton.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.RemoveAnswerButton.Location = new System.Drawing.Point(316, 36);
            this.RemoveAnswerButton.Margin = new System.Windows.Forms.Padding(2);
            this.RemoveAnswerButton.Name = "RemoveAnswerButton";
            this.RemoveAnswerButton.Size = new System.Drawing.Size(24, 26);
            this.RemoveAnswerButton.TabIndex = 0;
            this.RemoveAnswerButton.Text = "-";
            this.RemoveAnswerButton.UseVisualStyleBackColor = false;
            this.RemoveAnswerButton.Visible = false;
            this.RemoveAnswerButton.Click += new System.EventHandler(this.RemoveAnswerButton_Click);
            // 
            // AddAnswerButton
            // 
            this.AddAnswerButton.BackColor = System.Drawing.SystemColors.Window;
            this.AddAnswerButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddAnswerButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.AddAnswerButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.AddAnswerButton.FlatAppearance.BorderSize = 0;
            this.AddAnswerButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.AddAnswerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddAnswerButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.AddAnswerButton.Location = new System.Drawing.Point(0, 66);
            this.AddAnswerButton.Margin = new System.Windows.Forms.Padding(2);
            this.AddAnswerButton.Name = "AddAnswerButton";
            this.AddAnswerButton.Size = new System.Drawing.Size(350, 33);
            this.AddAnswerButton.TabIndex = 0;
            this.AddAnswerButton.Text = "+";
            this.AddAnswerButton.UseVisualStyleBackColor = false;
            this.AddAnswerButton.Click += new System.EventHandler(this.AddAnswerButton_Click);
            // 
            // richTextBoxAnswer2
            // 
            this.richTextBoxAnswer2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxAnswer2.Dock = System.Windows.Forms.DockStyle.Top;
            this.richTextBoxAnswer2.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.richTextBoxAnswer2.Location = new System.Drawing.Point(0, 33);
            this.richTextBoxAnswer2.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBoxAnswer2.Name = "richTextBoxAnswer2";
            this.richTextBoxAnswer2.Size = new System.Drawing.Size(350, 33);
            this.richTextBoxAnswer2.TabIndex = 0;
            this.richTextBoxAnswer2.Text = "2. ";
            this.richTextBoxAnswer2.TextChanged += new System.EventHandler(this.richTextBoxAnswer_TextChanged);
            // 
            // richTextBoxAnswer1
            // 
            this.richTextBoxAnswer1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxAnswer1.Dock = System.Windows.Forms.DockStyle.Top;
            this.richTextBoxAnswer1.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.richTextBoxAnswer1.Location = new System.Drawing.Point(0, 0);
            this.richTextBoxAnswer1.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBoxAnswer1.Name = "richTextBoxAnswer1";
            this.richTextBoxAnswer1.Size = new System.Drawing.Size(350, 33);
            this.richTextBoxAnswer1.TabIndex = 0;
            this.richTextBoxAnswer1.Text = "1. ";
            this.richTextBoxAnswer1.TextChanged += new System.EventHandler(this.richTextBoxAnswer_TextChanged);
            // 
            // labelWriteAnswers
            // 
            this.labelWriteAnswers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(253)))));
            this.labelWriteAnswers.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelWriteAnswers.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.labelWriteAnswers.Location = new System.Drawing.Point(0, 239);
            this.labelWriteAnswers.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelWriteAnswers.Name = "labelWriteAnswers";
            this.labelWriteAnswers.Size = new System.Drawing.Size(350, 28);
            this.labelWriteAnswers.TabIndex = 7;
            this.labelWriteAnswers.Text = "Write ALL the answers";
            this.labelWriteAnswers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonCreateTag
            // 
            this.buttonCreateTag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(215)))), ((int)(((byte)(249)))));
            this.buttonCreateTag.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCreateTag.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonCreateTag.FlatAppearance.BorderSize = 0;
            this.buttonCreateTag.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCreateTag.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreateTag.ForeColor = System.Drawing.SystemColors.WindowText;
            this.buttonCreateTag.Location = new System.Drawing.Point(0, 209);
            this.buttonCreateTag.Name = "buttonCreateTag";
            this.buttonCreateTag.Size = new System.Drawing.Size(350, 30);
            this.buttonCreateTag.TabIndex = 14;
            this.buttonCreateTag.TabStop = false;
            this.buttonCreateTag.Text = "Create Tag";
            this.buttonCreateTag.UseVisualStyleBackColor = false;
            this.buttonCreateTag.Click += new System.EventHandler(this.buttonCreateTag_Click);
            // 
            // richTextBoxCreateTag
            // 
            this.richTextBoxCreateTag.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxCreateTag.Dock = System.Windows.Forms.DockStyle.Top;
            this.richTextBoxCreateTag.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.richTextBoxCreateTag.Location = new System.Drawing.Point(0, 176);
            this.richTextBoxCreateTag.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBoxCreateTag.Multiline = false;
            this.richTextBoxCreateTag.Name = "richTextBoxCreateTag";
            this.richTextBoxCreateTag.Size = new System.Drawing.Size(350, 33);
            this.richTextBoxCreateTag.TabIndex = 6;
            this.richTextBoxCreateTag.Text = "";
            // 
            // labelCreateTag
            // 
            this.labelCreateTag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(253)))));
            this.labelCreateTag.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelCreateTag.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.labelCreateTag.Location = new System.Drawing.Point(0, 148);
            this.labelCreateTag.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCreateTag.Name = "labelCreateTag";
            this.labelCreateTag.Size = new System.Drawing.Size(350, 28);
            this.labelCreateTag.TabIndex = 5;
            this.labelCreateTag.Text = "Add a new tag (Optional)";
            this.labelCreateTag.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelAllTags
            // 
            this.panelAllTags.AutoSize = true;
            this.panelAllTags.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelAllTags.BackColor = System.Drawing.SystemColors.Window;
            this.panelAllTags.Controls.Add(this.panelLeftTags);
            this.panelAllTags.Controls.Add(this.panelRightTags);
            this.panelAllTags.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAllTags.Location = new System.Drawing.Point(0, 120);
            this.panelAllTags.MinimumSize = new System.Drawing.Size(0, 28);
            this.panelAllTags.Name = "panelAllTags";
            this.panelAllTags.Size = new System.Drawing.Size(350, 28);
            this.panelAllTags.TabIndex = 13;
            // 
            // panelLeftTags
            // 
            this.panelLeftTags.AutoSize = true;
            this.panelLeftTags.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelLeftTags.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLeftTags.Location = new System.Drawing.Point(0, 0);
            this.panelLeftTags.MinimumSize = new System.Drawing.Size(175, 28);
            this.panelLeftTags.Name = "panelLeftTags";
            this.panelLeftTags.Padding = new System.Windows.Forms.Padding(30, 0, 10, 0);
            this.panelLeftTags.Size = new System.Drawing.Size(175, 28);
            this.panelLeftTags.TabIndex = 0;
            // 
            // panelRightTags
            // 
            this.panelRightTags.AutoSize = true;
            this.panelRightTags.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelRightTags.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRightTags.Location = new System.Drawing.Point(175, 0);
            this.panelRightTags.MinimumSize = new System.Drawing.Size(175, 28);
            this.panelRightTags.Name = "panelRightTags";
            this.panelRightTags.Padding = new System.Windows.Forms.Padding(30, 0, 10, 0);
            this.panelRightTags.Size = new System.Drawing.Size(175, 28);
            this.panelRightTags.TabIndex = 1;
            // 
            // labelSelectTags
            // 
            this.labelSelectTags.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(253)))));
            this.labelSelectTags.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelSelectTags.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.labelSelectTags.Location = new System.Drawing.Point(0, 92);
            this.labelSelectTags.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSelectTags.Name = "labelSelectTags";
            this.labelSelectTags.Size = new System.Drawing.Size(350, 28);
            this.labelSelectTags.TabIndex = 3;
            this.labelSelectTags.Text = "Select from existing tags";
            this.labelSelectTags.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // richTextBoxQuestion
            // 
            this.richTextBoxQuestion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxQuestion.Dock = System.Windows.Forms.DockStyle.Top;
            this.richTextBoxQuestion.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.richTextBoxQuestion.Location = new System.Drawing.Point(0, 49);
            this.richTextBoxQuestion.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBoxQuestion.Name = "richTextBoxQuestion";
            this.richTextBoxQuestion.Size = new System.Drawing.Size(350, 43);
            this.richTextBoxQuestion.TabIndex = 2;
            this.richTextBoxQuestion.Text = "";
            // 
            // labelQuestion
            // 
            this.labelQuestion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(215)))), ((int)(((byte)(249)))));
            this.labelQuestion.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelQuestion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.labelQuestion.Location = new System.Drawing.Point(0, 0);
            this.labelQuestion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelQuestion.Name = "labelQuestion";
            this.labelQuestion.Size = new System.Drawing.Size(350, 49);
            this.labelQuestion.TabIndex = 1;
            this.labelQuestion.Text = "Question";
            this.labelQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.labelTitle);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Margin = new System.Windows.Forms.Padding(0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(900, 66);
            this.panelTop.TabIndex = 0;
            // 
            // labelTitle
            // 
            this.labelTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTitle.Font = new System.Drawing.Font("Century", 21.75F);
            this.labelTitle.Location = new System.Drawing.Point(0, 0);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(900, 66);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Add Question";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddQuestionsSection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(233)))), ((int)(((byte)(242)))));
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelQuestions);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AddQuestionsSection";
            this.Size = new System.Drawing.Size(900, 680);
            this.panelQuestions.ResumeLayout(false);
            this.panelQuestions.PerformLayout();
            this.panelSubmitButton.ResumeLayout(false);
            this.panelAllFields.ResumeLayout(false);
            this.panelAllFields.PerformLayout();
            this.panelPossibleAnswers.ResumeLayout(false);
            this.panelAllTags.ResumeLayout(false);
            this.panelAllTags.PerformLayout();
            this.panelTop.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelQuestions;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Button buttonCreateQuestion;
        private System.Windows.Forms.Panel panelAllFields;
        private System.Windows.Forms.Label labelQuestion;
        private System.Windows.Forms.Label labelSelectTags;
        private System.Windows.Forms.Label labelDifficulty;
        private System.Windows.Forms.Label labelWriteCorrectAnswer;
        private System.Windows.Forms.Label labelWriteAnswers;
        private System.Windows.Forms.RichTextBox richTextBoxCreateTag;
        private System.Windows.Forms.RichTextBox richTextBoxQuestion;
        private System.Windows.Forms.ComboBox comboBoxDifficulty;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelCreateTag;
        private System.Windows.Forms.Panel panelSubmitButton;
        private System.Windows.Forms.Panel panelPossibleAnswers;
        private System.Windows.Forms.Button RemoveAnswerButton;
        private System.Windows.Forms.Button AddAnswerButton;
        private System.Windows.Forms.RichTextBox richTextBoxAnswer2;
        private System.Windows.Forms.RichTextBox richTextBoxAnswer1;
        private System.Windows.Forms.Panel panelAllTags;
        private System.Windows.Forms.Panel panelRightTags;
        private System.Windows.Forms.Panel panelLeftTags;
        private System.Windows.Forms.Button buttonCreateTag;
        private System.Windows.Forms.ComboBox comboBoxCorrectAnswer;
    }
}
