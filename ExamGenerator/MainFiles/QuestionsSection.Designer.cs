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
            this.labelTagsArrow = new System.Windows.Forms.Label();
            this.buttonSortTags = new System.Windows.Forms.Button();
            this.panelBarrier1 = new System.Windows.Forms.Panel();
            this.panelSortDifficulty = new System.Windows.Forms.Panel();
            this.labelDifficultyArrow = new System.Windows.Forms.Label();
            this.buttonSortDifficulty = new System.Windows.Forms.Button();
            this.panelQuestions = new System.Windows.Forms.Panel();
            this.panelControlQuestions = new System.Windows.Forms.Panel();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonForward = new System.Windows.Forms.Button();
            this.togglePanelDifficulty = new ExamGenerator.CustomControls.TogglablePanel();
            this.radioDifficultyItem = new System.Windows.Forms.RadioButton();
            this.togglePanelTags = new ExamGenerator.CustomControls.TogglablePanel();
            this.radioTagsItem = new System.Windows.Forms.RadioButton();
            this.panelTop.SuspendLayout();
            this.panelFilters.SuspendLayout();
            this.panelSortTags.SuspendLayout();
            this.panelSortDifficulty.SuspendLayout();
            this.panelQuestions.SuspendLayout();
            this.panelControlQuestions.SuspendLayout();
            this.togglePanelDifficulty.SuspendLayout();
            this.togglePanelTags.SuspendLayout();
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
            this.labelTagsArrow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelTagsArrow.Font = new System.Drawing.Font("Marlett", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.labelTagsArrow.Location = new System.Drawing.Point(101, 0);
            this.labelTagsArrow.Name = "labelTagsArrow";
            this.labelTagsArrow.Size = new System.Drawing.Size(27, 41);
            this.labelTagsArrow.TabIndex = 0;
            this.labelTagsArrow.Text = "6";
            this.labelTagsArrow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonSortTags
            // 
            this.buttonSortTags.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSortTags.FlatAppearance.BorderSize = 0;
            this.buttonSortTags.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSortTags.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSortTags.Location = new System.Drawing.Point(0, 0);
            this.buttonSortTags.Name = "buttonSortTags";
            this.buttonSortTags.Size = new System.Drawing.Size(128, 41);
            this.buttonSortTags.TabIndex = 6;
            this.buttonSortTags.Text = "Tags";
            this.buttonSortTags.UseVisualStyleBackColor = true;
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
            this.labelDifficultyArrow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelDifficultyArrow.Font = new System.Drawing.Font("Marlett", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.labelDifficultyArrow.Location = new System.Drawing.Point(101, 0);
            this.labelDifficultyArrow.Name = "labelDifficultyArrow";
            this.labelDifficultyArrow.Size = new System.Drawing.Size(27, 41);
            this.labelDifficultyArrow.TabIndex = 0;
            this.labelDifficultyArrow.Text = "6";
            this.labelDifficultyArrow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonSortDifficulty
            // 
            this.buttonSortDifficulty.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSortDifficulty.FlatAppearance.BorderSize = 0;
            this.buttonSortDifficulty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSortDifficulty.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSortDifficulty.Location = new System.Drawing.Point(0, 0);
            this.buttonSortDifficulty.Name = "buttonSortDifficulty";
            this.buttonSortDifficulty.Size = new System.Drawing.Size(128, 41);
            this.buttonSortDifficulty.TabIndex = 6;
            this.buttonSortDifficulty.Text = "Difficulty";
            this.buttonSortDifficulty.UseVisualStyleBackColor = true;
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
            this.togglePanelDifficulty.BackColor = System.Drawing.Color.White;
            this.togglePanelDifficulty.Controls.Add(this.radioDifficultyItem);
            this.togglePanelDifficulty.Location = new System.Drawing.Point(712, 66);
            this.togglePanelDifficulty.Margin = new System.Windows.Forms.Padding(0);
            this.togglePanelDifficulty.MaximumSize = new System.Drawing.Size(128, 170);
            this.togglePanelDifficulty.Name = "togglePanelDifficulty";
            this.togglePanelDifficulty.Size = new System.Drawing.Size(128, 170);
            this.togglePanelDifficulty.TabIndex = 4;
            this.togglePanelDifficulty.Visible = false;
            // 
            // radioDifficultyItem
            // 
            this.radioDifficultyItem.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioDifficultyItem.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioDifficultyItem.Checked = true;
            this.radioDifficultyItem.Dock = System.Windows.Forms.DockStyle.Top;
            this.radioDifficultyItem.FlatAppearance.BorderSize = 0;
            this.radioDifficultyItem.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(253)))));
            this.radioDifficultyItem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(253)))));
            this.radioDifficultyItem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(253)))));
            this.radioDifficultyItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioDifficultyItem.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioDifficultyItem.Location = new System.Drawing.Point(0, 0);
            this.radioDifficultyItem.Margin = new System.Windows.Forms.Padding(0);
            this.radioDifficultyItem.Name = "radioDifficultyItem";
            this.radioDifficultyItem.Padding = new System.Windows.Forms.Padding(0, 0, 13, 5);
            this.radioDifficultyItem.Size = new System.Drawing.Size(128, 34);
            this.radioDifficultyItem.TabIndex = 10;
            this.radioDifficultyItem.TabStop = true;
            this.radioDifficultyItem.Text = "Questions";
            this.radioDifficultyItem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioDifficultyItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.radioDifficultyItem.UseVisualStyleBackColor = true;
            // 
            // togglePanelTags
            // 
            this.togglePanelTags.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.togglePanelTags.AutoScroll = true;
            this.togglePanelTags.BackColor = System.Drawing.Color.White;
            this.togglePanelTags.Controls.Add(this.radioTagsItem);
            this.togglePanelTags.Location = new System.Drawing.Point(552, 66);
            this.togglePanelTags.Margin = new System.Windows.Forms.Padding(0);
            this.togglePanelTags.MaximumSize = new System.Drawing.Size(128, 170);
            this.togglePanelTags.Name = "togglePanelTags";
            this.togglePanelTags.Size = new System.Drawing.Size(128, 170);
            this.togglePanelTags.TabIndex = 3;
            this.togglePanelTags.Visible = false;
            // 
            // radioTagsItem
            // 
            this.radioTagsItem.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioTagsItem.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioTagsItem.Checked = true;
            this.radioTagsItem.Dock = System.Windows.Forms.DockStyle.Top;
            this.radioTagsItem.FlatAppearance.BorderSize = 0;
            this.radioTagsItem.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(253)))));
            this.radioTagsItem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(253)))));
            this.radioTagsItem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(253)))));
            this.radioTagsItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioTagsItem.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioTagsItem.Location = new System.Drawing.Point(0, 0);
            this.radioTagsItem.Margin = new System.Windows.Forms.Padding(0);
            this.radioTagsItem.Name = "radioTagsItem";
            this.radioTagsItem.Padding = new System.Windows.Forms.Padding(0, 0, 13, 5);
            this.radioTagsItem.Size = new System.Drawing.Size(128, 34);
            this.radioTagsItem.TabIndex = 9;
            this.radioTagsItem.TabStop = true;
            this.radioTagsItem.Text = "Questions";
            this.radioTagsItem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioTagsItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.radioTagsItem.UseVisualStyleBackColor = true;
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
            this.Load += new System.EventHandler(this.QuestionsSection_Load);
            this.panelTop.ResumeLayout(false);
            this.panelFilters.ResumeLayout(false);
            this.panelSortTags.ResumeLayout(false);
            this.panelSortDifficulty.ResumeLayout(false);
            this.panelQuestions.ResumeLayout(false);
            this.panelControlQuestions.ResumeLayout(false);
            this.togglePanelDifficulty.ResumeLayout(false);
            this.togglePanelTags.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelSectionTitle;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelFilters;
        private System.Windows.Forms.Panel panelSortTags;
        private System.Windows.Forms.Button buttonSortTags;
        private System.Windows.Forms.Label labelTagsArrow;
        private System.Windows.Forms.Panel panelBarrier1;
        private System.Windows.Forms.Panel panelSortDifficulty;
        private System.Windows.Forms.Button buttonSortDifficulty;
        private System.Windows.Forms.Label labelDifficultyArrow;
        private System.Windows.Forms.Label labelFilters;
        private CustomControls.TogglablePanel togglePanelTags;
        private CustomControls.TogglablePanel togglePanelDifficulty;
        private System.Windows.Forms.RadioButton radioTagsItem;
        private System.Windows.Forms.RadioButton radioDifficultyItem;
        private System.Windows.Forms.Panel panelQuestions;
        private System.Windows.Forms.Button buttonForward;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Panel panelControlQuestions;
    }
}
