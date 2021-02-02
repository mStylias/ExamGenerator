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
            this.panelUserSettings = new System.Windows.Forms.Panel();
            this.panelSearchQuestions = new System.Windows.Forms.Panel();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.pictureBoxSearch = new System.Windows.Forms.PictureBox();
            this.panelAppTitle = new System.Windows.Forms.Panel();
            this.labelAppTitle = new System.Windows.Forms.Label();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.labelSubjectsList = new System.Windows.Forms.Label();
            this.panelMenuButtons = new System.Windows.Forms.Panel();
            this.panelAutoActive = new ExamGenerator.CustomControls.TogglablePanel();
            this.panelAddQuestionsActive = new ExamGenerator.CustomControls.TogglablePanel();
            this.panelManualActive = new ExamGenerator.CustomControls.TogglablePanel();
            this.radioMenuAuto = new System.Windows.Forms.RadioButton();
            this.radioMenuManual = new System.Windows.Forms.RadioButton();
            this.radioMenuAddQuestions = new System.Windows.Forms.RadioButton();
            this.autoSection1 = new ExamGenerator.AutoSection();
            this.manualSection = new ExamGenerator.MainFiles.ManualSection();
            this.addQuestionsSection1 = new ExamGenerator.MainFiles.AddQuestionsSection();
            this.panelTopSection.SuspendLayout();
            this.panelTitlebar.SuspendLayout();
            this.panelSearchQuestions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSearch)).BeginInit();
            this.panelAppTitle.SuspendLayout();
            this.panelMenu.SuspendLayout();
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
            this.panelTopSection.Size = new System.Drawing.Size(1095, 54);
            this.panelTopSection.TabIndex = 0;
            // 
            // panelTitlebar
            // 
            this.panelTitlebar.Controls.Add(this.panelUserSettings);
            this.panelTitlebar.Controls.Add(this.panelSearchQuestions);
            this.panelTitlebar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTitlebar.Location = new System.Drawing.Point(195, 0);
            this.panelTitlebar.Name = "panelTitlebar";
            this.panelTitlebar.Size = new System.Drawing.Size(900, 54);
            this.panelTitlebar.TabIndex = 1;
            // 
            // panelUserSettings
            // 
            this.panelUserSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelUserSettings.Location = new System.Drawing.Point(732, 0);
            this.panelUserSettings.MinimumSize = new System.Drawing.Size(170, 0);
            this.panelUserSettings.Name = "panelUserSettings";
            this.panelUserSettings.Size = new System.Drawing.Size(170, 54);
            this.panelUserSettings.TabIndex = 1;
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
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
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
            this.panelMenu.Controls.Add(this.labelSubjectsList);
            this.panelMenu.Controls.Add(this.panelMenuButtons);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 54);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Padding = new System.Windows.Forms.Padding(0, 60, 0, 0);
            this.panelMenu.Size = new System.Drawing.Size(195, 700);
            this.panelMenu.TabIndex = 1;
            // 
            // labelSubjectsList
            // 
            this.labelSubjectsList.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelSubjectsList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelSubjectsList.Font = new System.Drawing.Font("Pristina", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSubjectsList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(166)))), ((int)(((byte)(243)))));
            this.labelSubjectsList.Location = new System.Drawing.Point(0, 276);
            this.labelSubjectsList.Name = "labelSubjectsList";
            this.labelSubjectsList.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.labelSubjectsList.Size = new System.Drawing.Size(195, 72);
            this.labelSubjectsList.TabIndex = 1;
            this.labelSubjectsList.Text = "Subjects";
            this.labelSubjectsList.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelMenuButtons
            // 
            this.panelMenuButtons.Controls.Add(this.panelAutoActive);
            this.panelMenuButtons.Controls.Add(this.panelAddQuestionsActive);
            this.panelMenuButtons.Controls.Add(this.panelManualActive);
            this.panelMenuButtons.Controls.Add(this.radioMenuAuto);
            this.panelMenuButtons.Controls.Add(this.radioMenuManual);
            this.panelMenuButtons.Controls.Add(this.radioMenuAddQuestions);
            this.panelMenuButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenuButtons.Location = new System.Drawing.Point(0, 60);
            this.panelMenuButtons.Name = "panelMenuButtons";
            this.panelMenuButtons.Size = new System.Drawing.Size(195, 216);
            this.panelMenuButtons.TabIndex = 0;
            // 
            // panelAutoActive
            // 
            this.panelAutoActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(68)))), ((int)(((byte)(77)))));
            this.panelAutoActive.Location = new System.Drawing.Point(190, 116);
            this.panelAutoActive.Name = "panelAutoActive";
            this.panelAutoActive.Size = new System.Drawing.Size(5, 58);
            this.panelAutoActive.TabIndex = 7;
            this.panelAutoActive.Visible = false;
            // 
            // panelAddQuestionsActive
            // 
            this.panelAddQuestionsActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(68)))), ((int)(((byte)(77)))));
            this.panelAddQuestionsActive.Location = new System.Drawing.Point(190, 0);
            this.panelAddQuestionsActive.Name = "panelAddQuestionsActive";
            this.panelAddQuestionsActive.Size = new System.Drawing.Size(5, 58);
            this.panelAddQuestionsActive.TabIndex = 5;
            // 
            // panelManualActive
            // 
            this.panelManualActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(68)))), ((int)(((byte)(77)))));
            this.panelManualActive.Location = new System.Drawing.Point(190, 58);
            this.panelManualActive.Name = "panelManualActive";
            this.panelManualActive.Size = new System.Drawing.Size(5, 58);
            this.panelManualActive.TabIndex = 6;
            this.panelManualActive.Visible = false;
            // 
            // radioMenuAuto
            // 
            this.radioMenuAuto.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioMenuAuto.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioMenuAuto.Dock = System.Windows.Forms.DockStyle.Top;
            this.radioMenuAuto.FlatAppearance.BorderSize = 0;
            this.radioMenuAuto.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(253)))));
            this.radioMenuAuto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(253)))));
            this.radioMenuAuto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(253)))));
            this.radioMenuAuto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioMenuAuto.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioMenuAuto.Image = global::ExamGenerator.Properties.Resources.artificial_intelligence_25px;
            this.radioMenuAuto.Location = new System.Drawing.Point(0, 116);
            this.radioMenuAuto.Margin = new System.Windows.Forms.Padding(0);
            this.radioMenuAuto.Name = "radioMenuAuto";
            this.radioMenuAuto.Padding = new System.Windows.Forms.Padding(25, 0, 0, 5);
            this.radioMenuAuto.Size = new System.Drawing.Size(195, 58);
            this.radioMenuAuto.TabIndex = 11;
            this.radioMenuAuto.Text = "Auto\r\nGeneration";
            this.radioMenuAuto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioMenuAuto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.radioMenuAuto.UseVisualStyleBackColor = true;
            this.radioMenuAuto.Click += new System.EventHandler(this.radioMenuAuto_Click);
            // 
            // radioMenuManual
            // 
            this.radioMenuManual.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioMenuManual.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioMenuManual.Dock = System.Windows.Forms.DockStyle.Top;
            this.radioMenuManual.FlatAppearance.BorderSize = 0;
            this.radioMenuManual.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(253)))));
            this.radioMenuManual.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(253)))));
            this.radioMenuManual.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(253)))));
            this.radioMenuManual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioMenuManual.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioMenuManual.Image = global::ExamGenerator.Properties.Resources.manual_25px;
            this.radioMenuManual.Location = new System.Drawing.Point(0, 58);
            this.radioMenuManual.Margin = new System.Windows.Forms.Padding(0);
            this.radioMenuManual.Name = "radioMenuManual";
            this.radioMenuManual.Padding = new System.Windows.Forms.Padding(23, 0, 0, 5);
            this.radioMenuManual.Size = new System.Drawing.Size(195, 58);
            this.radioMenuManual.TabIndex = 10;
            this.radioMenuManual.Text = "Manual Generation";
            this.radioMenuManual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioMenuManual.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.radioMenuManual.UseVisualStyleBackColor = true;
            this.radioMenuManual.Click += new System.EventHandler(this.radioMenuManual_Click);
            // 
            // radioMenuAddQuestions
            // 
            this.radioMenuAddQuestions.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioMenuAddQuestions.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioMenuAddQuestions.Checked = true;
            this.radioMenuAddQuestions.Dock = System.Windows.Forms.DockStyle.Top;
            this.radioMenuAddQuestions.FlatAppearance.BorderSize = 0;
            this.radioMenuAddQuestions.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(253)))));
            this.radioMenuAddQuestions.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(253)))));
            this.radioMenuAddQuestions.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(253)))));
            this.radioMenuAddQuestions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioMenuAddQuestions.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioMenuAddQuestions.Image = global::ExamGenerator.Properties.Resources.add_25px;
            this.radioMenuAddQuestions.Location = new System.Drawing.Point(0, 0);
            this.radioMenuAddQuestions.Margin = new System.Windows.Forms.Padding(0);
            this.radioMenuAddQuestions.Name = "radioMenuAddQuestions";
            this.radioMenuAddQuestions.Padding = new System.Windows.Forms.Padding(20, 0, 0, 5);
            this.radioMenuAddQuestions.Size = new System.Drawing.Size(195, 58);
            this.radioMenuAddQuestions.TabIndex = 9;
            this.radioMenuAddQuestions.TabStop = true;
            this.radioMenuAddQuestions.Text = "Add\r\nQuestions";
            this.radioMenuAddQuestions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioMenuAddQuestions.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.radioMenuAddQuestions.UseVisualStyleBackColor = true;
            this.radioMenuAddQuestions.Click += new System.EventHandler(this.radioMenuAddQuestions_Click);
            // 
            // autoSection1
            // 
            this.autoSection1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(233)))), ((int)(((byte)(242)))));
            this.autoSection1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.autoSection1.Location = new System.Drawing.Point(195, 54);
            this.autoSection1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.autoSection1.Name = "autoSection1";
            this.autoSection1.Size = new System.Drawing.Size(900, 700);
            this.autoSection1.TabIndex = 4;
            // 
            // manualSection
            // 
            this.manualSection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(233)))), ((int)(((byte)(242)))));
            this.manualSection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.manualSection.Location = new System.Drawing.Point(195, 54);
            this.manualSection.Name = "manualSection";
            this.manualSection.Padding = new System.Windows.Forms.Padding(60, 0, 60, 0);
            this.manualSection.Size = new System.Drawing.Size(900, 700);
            this.manualSection.TabIndex = 4;
            // 
            // addQuestionsSection1
            // 
            this.addQuestionsSection1.AutoScroll = true;
            this.addQuestionsSection1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(233)))), ((int)(((byte)(242)))));
            this.addQuestionsSection1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addQuestionsSection1.Location = new System.Drawing.Point(195, 54);
            this.addQuestionsSection1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addQuestionsSection1.Name = "addQuestionsSection1";
            this.addQuestionsSection1.Size = new System.Drawing.Size(900, 700);
            this.addQuestionsSection1.TabIndex = 3;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 754);
            this.Controls.Add(this.manualSection);
            this.Controls.Add(this.addQuestionsSection1);
            this.Controls.Add(this.autoSection1);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelTopSection);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1111, 793);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exam Generator";
            this.ResizeEnd += new System.EventHandler(this.FormMain_ResizeEnd);
            this.Resize += new System.EventHandler(this.FormMain_Resize);
            this.panelTopSection.ResumeLayout(false);
            this.panelTitlebar.ResumeLayout(false);
            this.panelSearchQuestions.ResumeLayout(false);
            this.panelSearchQuestions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSearch)).EndInit();
            this.panelAppTitle.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            this.panelMenuButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTopSection;
        private System.Windows.Forms.Panel panelTitlebar;
        private System.Windows.Forms.Panel panelAppTitle;
        private System.Windows.Forms.Panel panelUserSettings;
        private System.Windows.Forms.Panel panelSearchQuestions;
        private System.Windows.Forms.Label labelAppTitle;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.PictureBox pictureBoxSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Panel panelMenuButtons;
        private System.Windows.Forms.RadioButton radioMenuAuto;
        private System.Windows.Forms.RadioButton radioMenuManual;
        private System.Windows.Forms.RadioButton radioMenuAddQuestions;
        private ExamGenerator.CustomControls.TogglablePanel panelAutoActive;
        private ExamGenerator.CustomControls.TogglablePanel panelManualActive;
        private ExamGenerator.CustomControls.TogglablePanel panelAddQuestionsActive;
        private System.Windows.Forms.Label labelSubjectsList;
        private MainFiles.AddQuestionsSection addQuestionsSection1;
        private MainFiles.ManualSection manualSection;
        private AutoSection autoSection1;
    }
}