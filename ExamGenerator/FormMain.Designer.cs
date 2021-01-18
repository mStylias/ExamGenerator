namespace ExamGenerator
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panelTopSection = new System.Windows.Forms.Panel();
            this.panelTitlebar = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelSearchQuestions = new System.Windows.Forms.Panel();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.panelAppTitle = new System.Windows.Forms.Panel();
            this.labelAppTitle = new System.Windows.Forms.Label();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.pictureBoxSearch = new System.Windows.Forms.PictureBox();
            this.panelMenuButtons = new System.Windows.Forms.Panel();
            this.radioMenuAuto = new System.Windows.Forms.RadioButton();
            this.radioMenuManual = new System.Windows.Forms.RadioButton();
            this.radioMenuAddQuestions = new System.Windows.Forms.RadioButton();
            this.radioMenuQuestions = new System.Windows.Forms.RadioButton();
            this.panelAutoActive = new System.Windows.Forms.Panel();
            this.panelManualActive = new System.Windows.Forms.Panel();
            this.panelAddQuestionActive = new System.Windows.Forms.Panel();
            this.panelQuestionsActive = new System.Windows.Forms.Panel();
            this.panelTopSection.SuspendLayout();
            this.panelTitlebar.SuspendLayout();
            this.panelSearchQuestions.SuspendLayout();
            this.panelAppTitle.SuspendLayout();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSearch)).BeginInit();
            this.panelMenuButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTopSection
            // 
            this.panelTopSection.BackColor = System.Drawing.Color.White;
            this.panelTopSection.Controls.Add(this.panelTitlebar);
            this.panelTopSection.Controls.Add(this.panelAppTitle);
            this.panelTopSection.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopSection.Location = new System.Drawing.Point(0, 0);
            this.panelTopSection.Name = "panelTopSection";
            this.panelTopSection.Size = new System.Drawing.Size(1093, 54);
            this.panelTopSection.TabIndex = 0;
            // 
            // panelTitlebar
            // 
            this.panelTitlebar.Controls.Add(this.panel1);
            this.panelTitlebar.Controls.Add(this.panelSearchQuestions);
            this.panelTitlebar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTitlebar.Location = new System.Drawing.Point(195, 0);
            this.panelTitlebar.Name = "panelTitlebar";
            this.panelTitlebar.Size = new System.Drawing.Size(898, 54);
            this.panelTitlebar.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(732, 0);
            this.panel1.MinimumSize = new System.Drawing.Size(170, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(170, 54);
            this.panel1.TabIndex = 1;
            // 
            // panelSearchQuestions
            // 
            this.panelSearchQuestions.Controls.Add(this.textBoxSearch);
            this.panelSearchQuestions.Controls.Add(this.pictureBoxSearch);
            this.panelSearchQuestions.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.panelSearchQuestions.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSearchQuestions.Location = new System.Drawing.Point(0, 0);
            this.panelSearchQuestions.Name = "panelSearchQuestions";
            this.panelSearchQuestions.Size = new System.Drawing.Size(732, 54);
            this.panelSearchQuestions.TabIndex = 0;
            this.panelSearchQuestions.Click += new System.EventHandler(this.searchArea_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSearch.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearch.Location = new System.Drawing.Point(54, 16);
            this.textBoxSearch.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(678, 22);
            this.textBoxSearch.TabIndex = 1;
            // 
            // panelAppTitle
            // 
            this.panelAppTitle.Controls.Add(this.labelAppTitle);
            this.panelAppTitle.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelAppTitle.Location = new System.Drawing.Point(0, 0);
            this.panelAppTitle.Name = "panelAppTitle";
            this.panelAppTitle.Size = new System.Drawing.Size(195, 54);
            this.panelAppTitle.TabIndex = 0;
            // 
            // labelAppTitle
            // 
            this.labelAppTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelAppTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelAppTitle.Font = new System.Drawing.Font("Pristina", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAppTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(166)))), ((int)(((byte)(243)))));
            this.labelAppTitle.Location = new System.Drawing.Point(0, 0);
            this.labelAppTitle.Name = "labelAppTitle";
            this.labelAppTitle.Size = new System.Drawing.Size(195, 54);
            this.labelAppTitle.TabIndex = 0;
            this.labelAppTitle.Text = "Exam Generator";
            this.labelAppTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.White;
            this.panelMenu.Controls.Add(this.panelMenuButtons);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 54);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Padding = new System.Windows.Forms.Padding(0, 60, 0, 0);
            this.panelMenu.Size = new System.Drawing.Size(195, 627);
            this.panelMenu.TabIndex = 1;
            // 
            // pictureBoxSearch
            // 
            this.pictureBoxSearch.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBoxSearch.Image = global::ExamGenerator.Properties.Resources.search_54px;
            this.pictureBoxSearch.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxSearch.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBoxSearch.Name = "pictureBoxSearch";
            this.pictureBoxSearch.Size = new System.Drawing.Size(54, 54);
            this.pictureBoxSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxSearch.TabIndex = 0;
            this.pictureBoxSearch.TabStop = false;
            this.pictureBoxSearch.Click += new System.EventHandler(this.searchArea_Click);
            // 
            // panelMenuButtons
            // 
            this.panelMenuButtons.Controls.Add(this.panelAutoActive);
            this.panelMenuButtons.Controls.Add(this.radioMenuAuto);
            this.panelMenuButtons.Controls.Add(this.panelManualActive);
            this.panelMenuButtons.Controls.Add(this.panelAddQuestionActive);
            this.panelMenuButtons.Controls.Add(this.radioMenuManual);
            this.panelMenuButtons.Controls.Add(this.panelQuestionsActive);
            this.panelMenuButtons.Controls.Add(this.radioMenuAddQuestions);
            this.panelMenuButtons.Controls.Add(this.radioMenuQuestions);
            this.panelMenuButtons.Location = new System.Drawing.Point(0, 63);
            this.panelMenuButtons.Name = "panelMenuButtons";
            this.panelMenuButtons.Size = new System.Drawing.Size(195, 232);
            this.panelMenuButtons.TabIndex = 0;
            // 
            // radioMenuAuto
            // 
            this.radioMenuAuto.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioMenuAuto.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioMenuAuto.Dock = System.Windows.Forms.DockStyle.Top;
            this.radioMenuAuto.FlatAppearance.BorderSize = 0;
            this.radioMenuAuto.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.radioMenuAuto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioMenuAuto.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioMenuAuto.Image = global::ExamGenerator.Properties.Resources.artificial_intelligence_25px;
            this.radioMenuAuto.Location = new System.Drawing.Point(0, 174);
            this.radioMenuAuto.Margin = new System.Windows.Forms.Padding(0);
            this.radioMenuAuto.Name = "radioMenuAuto";
            this.radioMenuAuto.Padding = new System.Windows.Forms.Padding(25, 0, 0, 5);
            this.radioMenuAuto.Size = new System.Drawing.Size(195, 58);
            this.radioMenuAuto.TabIndex = 11;
            this.radioMenuAuto.Text = "Auto\r\nGeneration";
            this.radioMenuAuto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioMenuAuto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.radioMenuAuto.UseVisualStyleBackColor = true;
            // 
            // radioMenuManual
            // 
            this.radioMenuManual.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioMenuManual.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioMenuManual.Dock = System.Windows.Forms.DockStyle.Top;
            this.radioMenuManual.FlatAppearance.BorderSize = 0;
            this.radioMenuManual.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.radioMenuManual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioMenuManual.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioMenuManual.Image = global::ExamGenerator.Properties.Resources.manual_25px;
            this.radioMenuManual.Location = new System.Drawing.Point(0, 116);
            this.radioMenuManual.Margin = new System.Windows.Forms.Padding(0);
            this.radioMenuManual.Name = "radioMenuManual";
            this.radioMenuManual.Padding = new System.Windows.Forms.Padding(23, 0, 0, 5);
            this.radioMenuManual.Size = new System.Drawing.Size(195, 58);
            this.radioMenuManual.TabIndex = 10;
            this.radioMenuManual.Text = "Manual Generation";
            this.radioMenuManual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioMenuManual.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.radioMenuManual.UseVisualStyleBackColor = true;
            // 
            // radioMenuAddQuestions
            // 
            this.radioMenuAddQuestions.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioMenuAddQuestions.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioMenuAddQuestions.Dock = System.Windows.Forms.DockStyle.Top;
            this.radioMenuAddQuestions.FlatAppearance.BorderSize = 0;
            this.radioMenuAddQuestions.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.radioMenuAddQuestions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioMenuAddQuestions.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioMenuAddQuestions.Image = global::ExamGenerator.Properties.Resources.add_25px;
            this.radioMenuAddQuestions.Location = new System.Drawing.Point(0, 58);
            this.radioMenuAddQuestions.Margin = new System.Windows.Forms.Padding(0);
            this.radioMenuAddQuestions.Name = "radioMenuAddQuestions";
            this.radioMenuAddQuestions.Padding = new System.Windows.Forms.Padding(20, 0, 0, 5);
            this.radioMenuAddQuestions.Size = new System.Drawing.Size(195, 58);
            this.radioMenuAddQuestions.TabIndex = 9;
            this.radioMenuAddQuestions.Text = "Add\r\nQuestions";
            this.radioMenuAddQuestions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioMenuAddQuestions.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.radioMenuAddQuestions.UseVisualStyleBackColor = true;
            // 
            // radioMenuQuestions
            // 
            this.radioMenuQuestions.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioMenuQuestions.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioMenuQuestions.Checked = true;
            this.radioMenuQuestions.Dock = System.Windows.Forms.DockStyle.Top;
            this.radioMenuQuestions.FlatAppearance.BorderSize = 0;
            this.radioMenuQuestions.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.radioMenuQuestions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioMenuQuestions.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioMenuQuestions.Image = global::ExamGenerator.Properties.Resources.questions_25px;
            this.radioMenuQuestions.Location = new System.Drawing.Point(0, 0);
            this.radioMenuQuestions.Margin = new System.Windows.Forms.Padding(0);
            this.radioMenuQuestions.Name = "radioMenuQuestions";
            this.radioMenuQuestions.Padding = new System.Windows.Forms.Padding(0, 0, 13, 5);
            this.radioMenuQuestions.Size = new System.Drawing.Size(195, 58);
            this.radioMenuQuestions.TabIndex = 8;
            this.radioMenuQuestions.TabStop = true;
            this.radioMenuQuestions.Text = "Questions";
            this.radioMenuQuestions.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radioMenuQuestions.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.radioMenuQuestions.UseVisualStyleBackColor = true;
            this.radioMenuQuestions.Click += new System.EventHandler(this.radioMenuQuestions_Click);
            // 
            // panelAutoActive
            // 
            this.panelAutoActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(68)))), ((int)(((byte)(77)))));
            this.panelAutoActive.Location = new System.Drawing.Point(190, 174);
            this.panelAutoActive.Name = "panelAutoActive";
            this.panelAutoActive.Size = new System.Drawing.Size(5, 58);
            this.panelAutoActive.TabIndex = 7;
            this.panelAutoActive.Visible = false;
            // 
            // panelManualActive
            // 
            this.panelManualActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(68)))), ((int)(((byte)(77)))));
            this.panelManualActive.Location = new System.Drawing.Point(190, 116);
            this.panelManualActive.Name = "panelManualActive";
            this.panelManualActive.Size = new System.Drawing.Size(5, 58);
            this.panelManualActive.TabIndex = 6;
            this.panelManualActive.Visible = false;
            // 
            // panelAddQuestionActive
            // 
            this.panelAddQuestionActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(68)))), ((int)(((byte)(77)))));
            this.panelAddQuestionActive.Location = new System.Drawing.Point(190, 58);
            this.panelAddQuestionActive.Name = "panelAddQuestionActive";
            this.panelAddQuestionActive.Size = new System.Drawing.Size(5, 58);
            this.panelAddQuestionActive.TabIndex = 5;
            this.panelAddQuestionActive.Visible = false;
            // 
            // panelQuestionsActive
            // 
            this.panelQuestionsActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(68)))), ((int)(((byte)(77)))));
            this.panelQuestionsActive.Location = new System.Drawing.Point(190, 0);
            this.panelQuestionsActive.Name = "panelQuestionsActive";
            this.panelQuestionsActive.Size = new System.Drawing.Size(5, 58);
            this.panelQuestionsActive.TabIndex = 4;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 681);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelTopSection);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1050, 700);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exam Generator";
            this.panelTopSection.ResumeLayout(false);
            this.panelTitlebar.ResumeLayout(false);
            this.panelSearchQuestions.ResumeLayout(false);
            this.panelSearchQuestions.PerformLayout();
            this.panelAppTitle.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSearch)).EndInit();
            this.panelMenuButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTopSection;
        private System.Windows.Forms.Panel panelTitlebar;
        private System.Windows.Forms.Panel panelAppTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelSearchQuestions;
        private System.Windows.Forms.Label labelAppTitle;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.PictureBox pictureBoxSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Panel panelMenuButtons;
        private System.Windows.Forms.RadioButton radioMenuAuto;
        private System.Windows.Forms.RadioButton radioMenuManual;
        private System.Windows.Forms.RadioButton radioMenuAddQuestions;
        private System.Windows.Forms.RadioButton radioMenuQuestions;
        private System.Windows.Forms.Panel panelAutoActive;
        private System.Windows.Forms.Panel panelManualActive;
        private System.Windows.Forms.Panel panelAddQuestionActive;
        private System.Windows.Forms.Panel panelQuestionsActive;
    }
}