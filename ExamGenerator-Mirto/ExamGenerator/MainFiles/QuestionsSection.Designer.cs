namespace ExamGenerator.MainFiles
{
    partial class QuestionsSection
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
            this.labelSectionTitle = new System.Windows.Forms.Label();
            this.panelTop = new System.Windows.Forms.Panel();
            this.panelFilters = new System.Windows.Forms.Panel();
            this.labelFilters = new System.Windows.Forms.Label();
            this.panelSortTags = new System.Windows.Forms.Panel();
            this.labelTagsArrow = new System.Windows.Forms.Button();
            this.buttonSortTags = new System.Windows.Forms.Button();
            this.panelBarrier1 = new System.Windows.Forms.Panel();
            this.panelSortDifficulty = new System.Windows.Forms.Panel();
            this.labelDifficultyArrow = new System.Windows.Forms.Button();
            this.buttonSortDifficulty = new System.Windows.Forms.Button();
            this.panelQuestions = new System.Windows.Forms.Panel();
            this.panelControlQuestions = new System.Windows.Forms.Panel();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonForward = new System.Windows.Forms.Button();
            this.togglePanelDifficulty = new ExamGenerator.CustomControls.TogglablePanel();
            this.checkBoxHard = new System.Windows.Forms.RadioButton();
            this.radioDifficultyMedium = new System.Windows.Forms.RadioButton();
            this.radioDifficultyEasy = new System.Windows.Forms.RadioButton();
            this.radioDifficultyAny = new System.Windows.Forms.RadioButton();
            this.togglePanelTags = new ExamGenerator.CustomControls.TogglablePanel();
            this.panelTop.SuspendLayout();
            this.panelFilters.SuspendLayout();
            this.panelSortTags.SuspendLayout();
            this.panelSortDifficulty.SuspendLayout();
            this.panelQuestions.SuspendLayout();
            this.panelControlQuestions.SuspendLayout();
            this.togglePanelDifficulty.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelSectionTitle
            // 
            this.labelSectionTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelSectionTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelSectionTitle.Font = new System.Drawing.Font("Century", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSectionTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(28)))), ((int)(((byte)(32)))));
            this.labelSectionTitle.Location = new System.Drawing.Point(20, 25);
            this.labelSectionTitle.Name = "labelSectionTitle";
            this.labelSectionTitle.Size = new System.Drawing.Size(280, 41);
            this.labelSectionTitle.TabIndex = 1;
            this.labelSectionTitle.Text = "Questions";
            this.labelSectionTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.labelSectionTitle);
            this.panelTop.Controls.Add(this.panelFilters);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(60, 0);
            this.panelTop.Margin = new System.Windows.Forms.Padding(0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Padding = new System.Windows.Forms.Padding(20, 25, 0, 0);
            this.panelTop.Size = new System.Drawing.Size(780, 66);
            this.panelTop.TabIndex = 2;
            // 
            // panelFilters
            // 
            this.panelFilters.Controls.Add(this.labelFilters);
            this.panelFilters.Controls.Add(this.panelSortTags);
            this.panelFilters.Controls.Add(this.panelBarrier1);
            this.panelFilters.Controls.Add(this.panelSortDifficulty);
            this.panelFilters.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelFilters.Location = new System.Drawing.Point(300, 25);
            this.panelFilters.Name = "panelFilters";
            this.panelFilters.Size = new System.Drawing.Size(480, 41);
            this.panelFilters.TabIndex = 2;
            // 
            // labelFilters
            // 
            this.labelFilters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelFilters.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelFilters.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFilters.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(28)))), ((int)(((byte)(32)))));
            this.labelFilters.Location = new System.Drawing.Point(0, 0);
            this.labelFilters.Name = "labelFilters";
            this.labelFilters.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.labelFilters.Size = new System.Drawing.Size(192, 41);
            this.labelFilters.TabIndex = 8;
            this.labelFilters.Text = "Filters:";
            this.labelFilters.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panelSortTags
            // 
            this.panelSortTags.BackColor = System.Drawing.Color.White;
            this.panelSortTags.Controls.Add(this.labelTagsArrow);
            this.panelSortTags.Controls.Add(this.buttonSortTags);
            this.panelSortTags.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelSortTags.Location = new System.Drawing.Point(192, 0);
            this.panelSortTags.Name = "panelSortTags";
            this.panelSortTags.Size = new System.Drawing.Size(128, 41);
            this.panelSortTags.TabIndex = 7;
            // 
            // labelTagsArrow
            // 
            this.labelTagsArrow.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelTagsArrow.FlatAppearance.BorderSize = 0;
            this.labelTagsArrow.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.labelTagsArrow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.labelTagsArrow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelTagsArrow.Font = new System.Drawing.Font("Marlett", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.labelTagsArrow.Location = new System.Drawing.Point(101, 0);
            this.labelTagsArrow.Name = "labelTagsArrow";
            this.labelTagsArrow.Size = new System.Drawing.Size(27, 41);
            this.labelTagsArrow.TabIndex = 0;
            this.labelTagsArrow.Text = "6";
            this.labelTagsArrow.Click += new System.EventHandler(this.Tags_Click);
            this.labelTagsArrow.MouseEnter += new System.EventHandler(this.buttonSort_MouseEnter);
            this.labelTagsArrow.MouseLeave += new System.EventHandler(this.buttonSort_MouseLeave);
            // 
            // buttonSortTags
            // 
            this.buttonSortTags.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSortTags.FlatAppearance.BorderSize = 0;
            this.buttonSortTags.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonSortTags.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonSortTags.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSortTags.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSortTags.Location = new System.Drawing.Point(0, 0);
            this.buttonSortTags.Name = "buttonSortTags";
            this.buttonSortTags.Size = new System.Drawing.Size(128, 41);
            this.buttonSortTags.TabIndex = 6;
            this.buttonSortTags.Text = "Tags";
            this.buttonSortTags.UseVisualStyleBackColor = true;
            this.buttonSortTags.Click += new System.EventHandler(this.Tags_Click);
            this.buttonSortTags.MouseEnter += new System.EventHandler(this.buttonSort_MouseEnter);
            this.buttonSortTags.MouseLeave += new System.EventHandler(this.buttonSort_MouseLeave);
            // 
            // panelBarrier1
            // 
            this.panelBarrier1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelBarrier1.Location = new System.Drawing.Point(320, 0);
            this.panelBarrier1.Name = "panelBarrier1";
            this.panelBarrier1.Size = new System.Drawing.Size(32, 41);
            this.panelBarrier1.TabIndex = 5;
            // 
            // panelSortDifficulty
            // 
            this.panelSortDifficulty.BackColor = System.Drawing.Color.White;
            this.panelSortDifficulty.Controls.Add(this.labelDifficultyArrow);
            this.panelSortDifficulty.Controls.Add(this.buttonSortDifficulty);
            this.panelSortDifficulty.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelSortDifficulty.Location = new System.Drawing.Point(352, 0);
            this.panelSortDifficulty.Name = "panelSortDifficulty";
            this.panelSortDifficulty.Size = new System.Drawing.Size(128, 41);
            this.panelSortDifficulty.TabIndex = 6;
            // 
            // labelDifficultyArrow
            // 
            this.labelDifficultyArrow.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelDifficultyArrow.FlatAppearance.BorderSize = 0;
            this.labelDifficultyArrow.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.labelDifficultyArrow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.labelDifficultyArrow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelDifficultyArrow.Font = new System.Drawing.Font("Marlett", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.labelDifficultyArrow.Location = new System.Drawing.Point(101, 0);
            this.labelDifficultyArrow.Name = "labelDifficultyArrow";
            this.labelDifficultyArrow.Size = new System.Drawing.Size(27, 41);
            this.labelDifficultyArrow.TabIndex = 0;
            this.labelDifficultyArrow.Text = "6";
            this.labelDifficultyArrow.Click += new System.EventHandler(this.Difficulty_Click);
            this.labelDifficultyArrow.MouseEnter += new System.EventHandler(this.buttonSort_MouseEnter);
            this.labelDifficultyArrow.MouseLeave += new System.EventHandler(this.buttonSort_MouseLeave);
            // 
            // buttonSortDifficulty
            // 
            this.buttonSortDifficulty.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSortDifficulty.FlatAppearance.BorderSize = 0;
            this.buttonSortDifficulty.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonSortDifficulty.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonSortDifficulty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSortDifficulty.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSortDifficulty.Location = new System.Drawing.Point(0, 0);
            this.buttonSortDifficulty.Name = "buttonSortDifficulty";
            this.buttonSortDifficulty.Size = new System.Drawing.Size(128, 41);
            this.buttonSortDifficulty.TabIndex = 6;
            this.buttonSortDifficulty.Text = "Difficulty";
            this.buttonSortDifficulty.UseVisualStyleBackColor = true;
            this.buttonSortDifficulty.Click += new System.EventHandler(this.Difficulty_Click);
            this.buttonSortDifficulty.MouseEnter += new System.EventHandler(this.buttonSort_MouseEnter);
            this.buttonSortDifficulty.MouseLeave += new System.EventHandler(this.buttonSort_MouseLeave);
            // 
            // panelQuestions
            // 
            this.panelQuestions.Controls.Add(this.panelControlQuestions);
            this.panelQuestions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelQuestions.Location = new System.Drawing.Point(60, 66);
            this.panelQuestions.Name = "panelQuestions";
            this.panelQuestions.Size = new System.Drawing.Size(780, 594);
            this.panelQuestions.TabIndex = 12;
            // 
            // panelControlQuestions
            // 
            this.panelControlQuestions.Controls.Add(this.buttonBack);
            this.panelControlQuestions.Controls.Add(this.buttonForward);
            this.panelControlQuestions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControlQuestions.Location = new System.Drawing.Point(0, 550);
            this.panelControlQuestions.Name = "panelControlQuestions";
            this.panelControlQuestions.Padding = new System.Windows.Forms.Padding(0, 0, 0, 14);
            this.panelControlQuestions.Size = new System.Drawing.Size(780, 44);
            this.panelControlQuestions.TabIndex = 9;
            // 
            // buttonBack
            // 
            this.buttonBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBack.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonBack.FlatAppearance.BorderSize = 0;
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.Image = global::ExamGenerator.Properties.Resources.left_25px;
            this.buttonBack.Location = new System.Drawing.Point(0, 0);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(5, 5, 0, 12);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(30, 30);
            this.buttonBack.TabIndex = 8;
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Visible = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonForward
            // 
            this.buttonForward.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonForward.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonForward.FlatAppearance.BorderSize = 0;
            this.buttonForward.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonForward.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonForward.Image = global::ExamGenerator.Properties.Resources.right_25px;
            this.buttonForward.Location = new System.Drawing.Point(750, 0);
            this.buttonForward.Margin = new System.Windows.Forms.Padding(5, 5, 0, 12);
            this.buttonForward.Name = "buttonForward";
            this.buttonForward.Size = new System.Drawing.Size(30, 30);
            this.buttonForward.TabIndex = 7;
            this.buttonForward.UseVisualStyleBackColor = true;
            this.buttonForward.Visible = false;
            this.buttonForward.Click += new System.EventHandler(this.buttonForward_Click);
            // 
            // togglePanelDifficulty
            // 
            this.togglePanelDifficulty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.togglePanelDifficulty.AutoSize = true;
            this.togglePanelDifficulty.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.togglePanelDifficulty.BackColor = System.Drawing.Color.White;
            this.togglePanelDifficulty.Controls.Add(this.checkBoxHard);
            this.togglePanelDifficulty.Controls.Add(this.radioDifficultyMedium);
            this.togglePanelDifficulty.Controls.Add(this.radioDifficultyEasy);
            this.togglePanelDifficulty.Controls.Add(this.radioDifficultyAny);
            this.togglePanelDifficulty.Location = new System.Drawing.Point(712, 66);
            this.togglePanelDifficulty.Margin = new System.Windows.Forms.Padding(0);
            this.togglePanelDifficulty.MinimumSize = new System.Drawing.Size(128, 136);
            this.togglePanelDifficulty.Name = "togglePanelDifficulty";
            this.togglePanelDifficulty.Size = new System.Drawing.Size(128, 136);
            this.togglePanelDifficulty.TabIndex = 4;
            this.togglePanelDifficulty.Visible = false;
            // 
            // checkBoxHard
            // 
            this.checkBoxHard.Dock = System.Windows.Forms.DockStyle.Top;
            this.checkBoxHard.FlatAppearance.BorderSize = 0;
            this.checkBoxHard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxHard.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxHard.Location = new System.Drawing.Point(0, 102);
            this.checkBoxHard.Name = "checkBoxHard";
            this.checkBoxHard.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.checkBoxHard.Size = new System.Drawing.Size(128, 34);
            this.checkBoxHard.TabIndex = 3;
            this.checkBoxHard.Text = "Hard";
            this.checkBoxHard.UseVisualStyleBackColor = true;
            this.checkBoxHard.Click += new System.EventHandler(this.radioDifficultyAll_Click);
            // 
            // radioDifficultyMedium
            // 
            this.radioDifficultyMedium.Dock = System.Windows.Forms.DockStyle.Top;
            this.radioDifficultyMedium.FlatAppearance.BorderSize = 0;
            this.radioDifficultyMedium.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioDifficultyMedium.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioDifficultyMedium.Location = new System.Drawing.Point(0, 68);
            this.radioDifficultyMedium.Name = "radioDifficultyMedium";
            this.radioDifficultyMedium.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.radioDifficultyMedium.Size = new System.Drawing.Size(128, 34);
            this.radioDifficultyMedium.TabIndex = 2;
            this.radioDifficultyMedium.Text = "Medium";
            this.radioDifficultyMedium.UseVisualStyleBackColor = true;
            this.radioDifficultyMedium.Click += new System.EventHandler(this.radioDifficultyAll_Click);
            // 
            // radioDifficultyEasy
            // 
            this.radioDifficultyEasy.Dock = System.Windows.Forms.DockStyle.Top;
            this.radioDifficultyEasy.FlatAppearance.BorderSize = 0;
            this.radioDifficultyEasy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioDifficultyEasy.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioDifficultyEasy.Location = new System.Drawing.Point(0, 34);
            this.radioDifficultyEasy.Name = "radioDifficultyEasy";
            this.radioDifficultyEasy.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.radioDifficultyEasy.Size = new System.Drawing.Size(128, 34);
            this.radioDifficultyEasy.TabIndex = 1;
            this.radioDifficultyEasy.Text = "Easy";
            this.radioDifficultyEasy.UseVisualStyleBackColor = true;
            this.radioDifficultyEasy.Click += new System.EventHandler(this.radioDifficultyAll_Click);
            // 
            // radioDifficultyAny
            // 
            this.radioDifficultyAny.Checked = true;
            this.radioDifficultyAny.Dock = System.Windows.Forms.DockStyle.Top;
            this.radioDifficultyAny.FlatAppearance.BorderSize = 0;
            this.radioDifficultyAny.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioDifficultyAny.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioDifficultyAny.Location = new System.Drawing.Point(0, 0);
            this.radioDifficultyAny.Name = "radioDifficultyAny";
            this.radioDifficultyAny.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.radioDifficultyAny.Size = new System.Drawing.Size(128, 34);
            this.radioDifficultyAny.TabIndex = 4;
            this.radioDifficultyAny.TabStop = true;
            this.radioDifficultyAny.Text = "Any";
            this.radioDifficultyAny.UseVisualStyleBackColor = true;
            this.radioDifficultyAny.Click += new System.EventHandler(this.radioDifficultyAll_Click);
            // 
            // togglePanelTags
            // 
            this.togglePanelTags.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.togglePanelTags.AutoScroll = true;
            this.togglePanelTags.AutoSize = true;
            this.togglePanelTags.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.togglePanelTags.BackColor = System.Drawing.Color.White;
            this.togglePanelTags.Location = new System.Drawing.Point(552, 66);
            this.togglePanelTags.Margin = new System.Windows.Forms.Padding(0);
            this.togglePanelTags.MaximumSize = new System.Drawing.Size(128, 136);
            this.togglePanelTags.MinimumSize = new System.Drawing.Size(128, 34);
            this.togglePanelTags.Name = "togglePanelTags";
            this.togglePanelTags.Size = new System.Drawing.Size(128, 34);
            this.togglePanelTags.TabIndex = 3;
            this.togglePanelTags.Visible = false;
            // 
            // QuestionsSection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(233)))), ((int)(((byte)(242)))));
            this.Controls.Add(this.togglePanelDifficulty);
            this.Controls.Add(this.togglePanelTags);
            this.Controls.Add(this.panelQuestions);
            this.Controls.Add(this.panelTop);
            this.DoubleBuffered = true;
            this.Name = "QuestionsSection";
            this.Padding = new System.Windows.Forms.Padding(60, 0, 60, 0);
            this.Size = new System.Drawing.Size(900, 660);
            this.panelTop.ResumeLayout(false);
            this.panelFilters.ResumeLayout(false);
            this.panelSortTags.ResumeLayout(false);
            this.panelSortDifficulty.ResumeLayout(false);
            this.panelQuestions.ResumeLayout(false);
            this.panelControlQuestions.ResumeLayout(false);
            this.togglePanelDifficulty.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSectionTitle;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelFilters;
        private System.Windows.Forms.Panel panelSortTags;
        private System.Windows.Forms.Button buttonSortTags;
        private System.Windows.Forms.Button labelTagsArrow;
        private System.Windows.Forms.Panel panelBarrier1;
        private System.Windows.Forms.Panel panelSortDifficulty;
        private System.Windows.Forms.Button buttonSortDifficulty;
        private System.Windows.Forms.Button labelDifficultyArrow;
        private System.Windows.Forms.Label labelFilters;
        private CustomControls.TogglablePanel togglePanelTags;
        private CustomControls.TogglablePanel togglePanelDifficulty;
        private System.Windows.Forms.Panel panelQuestions;
        private System.Windows.Forms.Button buttonForward;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Panel panelControlQuestions;
        private System.Windows.Forms.RadioButton checkBoxHard;
        private System.Windows.Forms.RadioButton radioDifficultyMedium;
        private System.Windows.Forms.RadioButton radioDifficultyEasy;
        private System.Windows.Forms.RadioButton radioDifficultyAny;
    }
}
