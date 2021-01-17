namespace ExamGenerator
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.panelLogin = new System.Windows.Forms.Panel();
            this.textBoxSubject = new ExamGenerator.ModernTextbox();
            this.labelMakeSubject = new System.Windows.Forms.Label();
            this.panelDropdownList = new System.Windows.Forms.Panel();
            this.dropdownListSubjects = new System.Windows.Forms.ComboBox();
            this.labelSelectSubject = new System.Windows.Forms.Label();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.textboxUsername = new ExamGenerator.ModernTextbox();
            this.labelSignIn = new System.Windows.Forms.Label();
            this.panelWelcomeText = new System.Windows.Forms.Panel();
            this.labelOrganization = new System.Windows.Forms.Label();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.panelBankImage = new System.Windows.Forms.Panel();
            this.buttonMinimize = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.panelLogin.SuspendLayout();
            this.panelDropdownList.SuspendLayout();
            this.panelWelcomeText.SuspendLayout();
            this.panelBankImage.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLogin
            // 
            this.panelLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(247)))));
            this.panelLogin.Controls.Add(this.textBoxSubject);
            this.panelLogin.Controls.Add(this.labelMakeSubject);
            this.panelLogin.Controls.Add(this.panelDropdownList);
            this.panelLogin.Controls.Add(this.labelSelectSubject);
            this.panelLogin.Controls.Add(this.buttonLogin);
            this.panelLogin.Controls.Add(this.textboxUsername);
            this.panelLogin.Controls.Add(this.labelSignIn);
            this.panelLogin.Controls.Add(this.panelWelcomeText);
            this.panelLogin.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLogin.Location = new System.Drawing.Point(0, 0);
            this.panelLogin.Margin = new System.Windows.Forms.Padding(0);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.panelLogin.Size = new System.Drawing.Size(416, 555);
            this.panelLogin.TabIndex = 1;
            this.panelLogin.MouseMove += new System.Windows.Forms.MouseEventHandler(this.movablePanels_MouseMove);
            // 
            // textBoxSubject
            // 
            this.textBoxSubject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(245)))));
            this.textBoxSubject.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxSubject.Location = new System.Drawing.Point(50, 327);
            this.textBoxSubject.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxSubject.Name = "textBoxSubject";
            this.textBoxSubject.Padding = new System.Windows.Forms.Padding(5, 10, 0, 0);
            this.textBoxSubject.Size = new System.Drawing.Size(366, 66);
            this.textBoxSubject.TabIndex = 10;
            this.textBoxSubject.Load += new System.EventHandler(this.textBoxSubject_Load);
            // 
            // labelMakeSubject
            // 
            this.labelMakeSubject.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelMakeSubject.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMakeSubject.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(85)))), ((int)(((byte)(92)))));
            this.labelMakeSubject.Location = new System.Drawing.Point(50, 281);
            this.labelMakeSubject.Name = "labelMakeSubject";
            this.labelMakeSubject.Size = new System.Drawing.Size(366, 46);
            this.labelMakeSubject.TabIndex = 9;
            this.labelMakeSubject.Text = "Or make a new one";
            this.labelMakeSubject.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // panelDropdownList
            // 
            this.panelDropdownList.Controls.Add(this.dropdownListSubjects);
            this.panelDropdownList.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDropdownList.Location = new System.Drawing.Point(50, 243);
            this.panelDropdownList.Name = "panelDropdownList";
            this.panelDropdownList.Size = new System.Drawing.Size(366, 38);
            this.panelDropdownList.TabIndex = 8;
            // 
            // dropdownListSubjects
            // 
            this.dropdownListSubjects.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(247)))));
            this.dropdownListSubjects.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dropdownListSubjects.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dropdownListSubjects.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(166)))), ((int)(((byte)(243)))));
            this.dropdownListSubjects.FormattingEnabled = true;
            this.dropdownListSubjects.Items.AddRange(new object[] {
            "No subject is selected"});
            this.dropdownListSubjects.Location = new System.Drawing.Point(0, 6);
            this.dropdownListSubjects.MaxDropDownItems = 100;
            this.dropdownListSubjects.Name = "dropdownListSubjects";
            this.dropdownListSubjects.Size = new System.Drawing.Size(175, 28);
            this.dropdownListSubjects.TabIndex = 7;
            this.dropdownListSubjects.TabStop = false;
            this.dropdownListSubjects.Text = "No subject is selected";
            // 
            // labelSelectSubject
            // 
            this.labelSelectSubject.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelSelectSubject.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSelectSubject.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(85)))), ((int)(((byte)(92)))));
            this.labelSelectSubject.Location = new System.Drawing.Point(50, 197);
            this.labelSelectSubject.Name = "labelSelectSubject";
            this.labelSelectSubject.Size = new System.Drawing.Size(366, 46);
            this.labelSelectSubject.TabIndex = 6;
            this.labelSelectSubject.Text = "Select subject";
            this.labelSelectSubject.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(166)))), ((int)(((byte)(243)))));
            this.buttonLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLogin.FlatAppearance.BorderSize = 0;
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogin.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(247)))));
            this.buttonLogin.Location = new System.Drawing.Point(99, 445);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(218, 55);
            this.buttonLogin.TabIndex = 5;
            this.buttonLogin.TabStop = false;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // textboxUsername
            // 
            this.textboxUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(245)))));
            this.textboxUsername.Dock = System.Windows.Forms.DockStyle.Top;
            this.textboxUsername.Location = new System.Drawing.Point(50, 131);
            this.textboxUsername.Margin = new System.Windows.Forms.Padding(0);
            this.textboxUsername.Name = "textboxUsername";
            this.textboxUsername.Padding = new System.Windows.Forms.Padding(5, 10, 0, 0);
            this.textboxUsername.Size = new System.Drawing.Size(366, 66);
            this.textboxUsername.TabIndex = 3;
            this.textboxUsername.Load += new System.EventHandler(this.textboxName_Load);
            // 
            // labelSignIn
            // 
            this.labelSignIn.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelSignIn.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSignIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(85)))), ((int)(((byte)(92)))));
            this.labelSignIn.Location = new System.Drawing.Point(50, 85);
            this.labelSignIn.Name = "labelSignIn";
            this.labelSignIn.Size = new System.Drawing.Size(366, 46);
            this.labelSignIn.TabIndex = 2;
            this.labelSignIn.Text = "Sign in to continue";
            this.labelSignIn.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // panelWelcomeText
            // 
            this.panelWelcomeText.Controls.Add(this.labelOrganization);
            this.panelWelcomeText.Controls.Add(this.labelWelcome);
            this.panelWelcomeText.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelWelcomeText.Location = new System.Drawing.Point(50, 0);
            this.panelWelcomeText.Name = "panelWelcomeText";
            this.panelWelcomeText.Size = new System.Drawing.Size(366, 85);
            this.panelWelcomeText.TabIndex = 1;
            // 
            // labelOrganization
            // 
            this.labelOrganization.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelOrganization.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelOrganization.Font = new System.Drawing.Font("Matura MT Script Capitals", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOrganization.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(166)))), ((int)(((byte)(243)))));
            this.labelOrganization.Location = new System.Drawing.Point(0, 40);
            this.labelOrganization.Margin = new System.Windows.Forms.Padding(0);
            this.labelOrganization.Name = "labelOrganization";
            this.labelOrganization.Size = new System.Drawing.Size(366, 45);
            this.labelOrganization.TabIndex = 1;
            this.labelOrganization.Text = "ExamGenerator";
            this.labelOrganization.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelOrganization.MouseMove += new System.Windows.Forms.MouseEventHandler(this.movablePanels_MouseMove);
            // 
            // labelWelcome
            // 
            this.labelWelcome.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelWelcome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelWelcome.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWelcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(85)))), ((int)(((byte)(92)))));
            this.labelWelcome.Location = new System.Drawing.Point(0, 0);
            this.labelWelcome.Margin = new System.Windows.Forms.Padding(0);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.labelWelcome.Size = new System.Drawing.Size(366, 40);
            this.labelWelcome.TabIndex = 0;
            this.labelWelcome.Text = "Welcome to";
            this.labelWelcome.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.labelWelcome.MouseMove += new System.Windows.Forms.MouseEventHandler(this.movablePanels_MouseMove);
            // 
            // panelBankImage
            // 
            this.panelBankImage.BackgroundImage = global::ExamGenerator.Properties.Resources.bank;
            this.panelBankImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelBankImage.Controls.Add(this.buttonMinimize);
            this.panelBankImage.Controls.Add(this.buttonExit);
            this.panelBankImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBankImage.Location = new System.Drawing.Point(416, 0);
            this.panelBankImage.Margin = new System.Windows.Forms.Padding(0);
            this.panelBankImage.Name = "panelBankImage";
            this.panelBankImage.Size = new System.Drawing.Size(575, 555);
            this.panelBankImage.TabIndex = 2;
            this.panelBankImage.MouseMove += new System.Windows.Forms.MouseEventHandler(this.movablePanels_MouseMove);
            // 
            // buttonMinimize
            // 
            this.buttonMinimize.BackColor = System.Drawing.Color.Transparent;
            this.buttonMinimize.FlatAppearance.BorderSize = 0;
            this.buttonMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMinimize.Image = global::ExamGenerator.Properties.Resources.minus_20px;
            this.buttonMinimize.Location = new System.Drawing.Point(509, 0);
            this.buttonMinimize.Name = "buttonMinimize";
            this.buttonMinimize.Size = new System.Drawing.Size(30, 30);
            this.buttonMinimize.TabIndex = 1;
            this.buttonMinimize.UseVisualStyleBackColor = false;
            this.buttonMinimize.Click += new System.EventHandler(this.buttonMinimize_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.Transparent;
            this.buttonExit.FlatAppearance.BorderSize = 0;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Image = global::ExamGenerator.Properties.Resources.x_24px;
            this.buttonExit.Location = new System.Drawing.Point(545, 0);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(30, 30);
            this.buttonExit.TabIndex = 0;
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 555);
            this.Controls.Add(this.panelBankImage);
            this.Controls.Add(this.panelLogin);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.panelLogin.ResumeLayout(false);
            this.panelDropdownList.ResumeLayout(false);
            this.panelWelcomeText.ResumeLayout(false);
            this.panelBankImage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.Label labelSignIn;
        private System.Windows.Forms.Panel panelWelcomeText;
        private System.Windows.Forms.Label labelOrganization;
        private System.Windows.Forms.Label labelWelcome;
        private ModernTextbox textboxUsername;
        private System.Windows.Forms.Panel panelBankImage;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonMinimize;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Label labelSelectSubject;
        private System.Windows.Forms.ComboBox dropdownListSubjects;
        private ModernTextbox textBoxSubject;
        private System.Windows.Forms.Label labelMakeSubject;
        private System.Windows.Forms.Panel panelDropdownList;
    }
}

