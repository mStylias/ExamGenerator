
namespace ExamGenerator.MainFiles
{
    partial class FormManualGenerate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormManualGenerate));
            this.labelQuestion = new System.Windows.Forms.Label();
            this.panelBody = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelNumericUpDown = new System.Windows.Forms.Panel();
            this.LayoutNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.textboxExamName = new ExamGenerator.ModernTextbox();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.labelCorrectAnswerTitle = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.panelBody.SuspendLayout();
            this.panelNumericUpDown.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LayoutNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // labelQuestion
            // 
            this.labelQuestion.AutoEllipsis = true;
            this.labelQuestion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(215)))), ((int)(((byte)(249)))));
            this.labelQuestion.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelQuestion.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuestion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(28)))), ((int)(((byte)(32)))));
            this.labelQuestion.Location = new System.Drawing.Point(1, 1);
            this.labelQuestion.Name = "labelQuestion";
            this.labelQuestion.Size = new System.Drawing.Size(404, 50);
            this.labelQuestion.TabIndex = 4;
            this.labelQuestion.Text = "Generate exam manually";
            this.labelQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelQuestion.MouseMove += new System.Windows.Forms.MouseEventHandler(this.labelQuestion_MouseMove);
            // 
            // panelBody
            // 
            this.panelBody.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(233)))), ((int)(((byte)(242)))));
            this.panelBody.Controls.Add(this.label1);
            this.panelBody.Controls.Add(this.panelNumericUpDown);
            this.panelBody.Controls.Add(this.textboxExamName);
            this.panelBody.Controls.Add(this.buttonGenerate);
            this.panelBody.Controls.Add(this.labelCorrectAnswerTitle);
            this.panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBody.Location = new System.Drawing.Point(1, 51);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(404, 353);
            this.panelBody.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(233)))), ((int)(((byte)(242)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(28)))), ((int)(((byte)(32)))));
            this.label1.Location = new System.Drawing.Point(0, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(404, 52);
            this.label1.TabIndex = 14;
            this.label1.Text = "Type the name of the generated exam document";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelNumericUpDown
            // 
            this.panelNumericUpDown.Controls.Add(this.LayoutNumericUpDown);
            this.panelNumericUpDown.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelNumericUpDown.Location = new System.Drawing.Point(0, 86);
            this.panelNumericUpDown.Name = "panelNumericUpDown";
            this.panelNumericUpDown.Size = new System.Drawing.Size(404, 54);
            this.panelNumericUpDown.TabIndex = 13;
            // 
            // LayoutNumericUpDown
            // 
            this.LayoutNumericUpDown.BackColor = System.Drawing.Color.White;
            this.LayoutNumericUpDown.Font = new System.Drawing.Font("Century", 12F);
            this.LayoutNumericUpDown.Location = new System.Drawing.Point(145, 14);
            this.LayoutNumericUpDown.Margin = new System.Windows.Forms.Padding(2);
            this.LayoutNumericUpDown.Name = "LayoutNumericUpDown";
            this.LayoutNumericUpDown.Size = new System.Drawing.Size(115, 27);
            this.LayoutNumericUpDown.TabIndex = 10;
            this.LayoutNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // textboxExamName
            // 
            this.textboxExamName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(245)))));
            this.textboxExamName.Location = new System.Drawing.Point(35, 194);
            this.textboxExamName.Margin = new System.Windows.Forms.Padding(0);
            this.textboxExamName.Name = "textboxExamName";
            this.textboxExamName.Size = new System.Drawing.Size(336, 59);
            this.textboxExamName.TabIndex = 12;
            this.textboxExamName.Load += new System.EventHandler(this.textboxExamName_Load);
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonGenerate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(166)))), ((int)(((byte)(243)))));
            this.buttonGenerate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonGenerate.FlatAppearance.BorderSize = 0;
            this.buttonGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGenerate.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGenerate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(247)))));
            this.buttonGenerate.Location = new System.Drawing.Point(86, 282);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(232, 43);
            this.buttonGenerate.TabIndex = 11;
            this.buttonGenerate.TabStop = false;
            this.buttonGenerate.Text = "Generate";
            this.buttonGenerate.UseVisualStyleBackColor = false;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // labelCorrectAnswerTitle
            // 
            this.labelCorrectAnswerTitle.AutoEllipsis = true;
            this.labelCorrectAnswerTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(233)))), ((int)(((byte)(242)))));
            this.labelCorrectAnswerTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelCorrectAnswerTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelCorrectAnswerTitle.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCorrectAnswerTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(28)))), ((int)(((byte)(32)))));
            this.labelCorrectAnswerTitle.Location = new System.Drawing.Point(0, 0);
            this.labelCorrectAnswerTitle.Name = "labelCorrectAnswerTitle";
            this.labelCorrectAnswerTitle.Size = new System.Drawing.Size(404, 86);
            this.labelCorrectAnswerTitle.TabIndex = 9;
            this.labelCorrectAnswerTitle.Text = "Please, choose the number of\r\ndifferent layouts of the same test\r\n(same questions" +
    " and answers, but in different order):";
            this.labelCorrectAnswerTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(215)))), ((int)(((byte)(249)))));
            this.buttonExit.FlatAppearance.BorderSize = 0;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Image = global::ExamGenerator.Properties.Resources.delete_16px;
            this.buttonExit.Location = new System.Drawing.Point(377, 4);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(25, 25);
            this.buttonExit.TabIndex = 7;
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // FormManualGenerate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(406, 405);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.panelBody);
            this.Controls.Add(this.labelQuestion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormManualGenerate";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormManualGenerate";
            this.panelBody.ResumeLayout(false);
            this.panelNumericUpDown.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LayoutNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelQuestion;
        private System.Windows.Forms.Panel panelBody;
        private System.Windows.Forms.Label labelCorrectAnswerTitle;
        private System.Windows.Forms.NumericUpDown LayoutNumericUpDown;
        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelNumericUpDown;
        private ModernTextbox textboxExamName;
    }
}