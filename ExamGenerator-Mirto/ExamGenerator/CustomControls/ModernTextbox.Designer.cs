namespace ExamGenerator
{
    partial class ModernTextbox
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
            this.panelSideColor = new System.Windows.Forms.Panel();
            this.panelTextContainer = new System.Windows.Forms.Panel();
            this.textBox = new System.Windows.Forms.TextBox();
            this.labelFieldName = new System.Windows.Forms.Label();
            this.panelTextContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSideColor
            // 
            this.panelSideColor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelSideColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(245)))));
            this.panelSideColor.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideColor.Location = new System.Drawing.Point(0, 0);
            this.panelSideColor.Name = "panelSideColor";
            this.panelSideColor.Size = new System.Drawing.Size(5, 59);
            this.panelSideColor.TabIndex = 1;
            // 
            // panelTextContainer
            // 
            this.panelTextContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(245)))));
            this.panelTextContainer.Controls.Add(this.textBox);
            this.panelTextContainer.Controls.Add(this.labelFieldName);
            this.panelTextContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTextContainer.Location = new System.Drawing.Point(5, 0);
            this.panelTextContainer.Name = "panelTextContainer";
            this.panelTextContainer.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.panelTextContainer.Size = new System.Drawing.Size(331, 59);
            this.panelTextContainer.TabIndex = 2;
            // 
            // textBox
            // 
            this.textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(245)))));
            this.textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(166)))), ((int)(((byte)(243)))));
            this.textBox.Location = new System.Drawing.Point(15, 25);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(316, 34);
            this.textBox.TabIndex = 1;
            this.textBox.Text = "Sample text here";
            this.textBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.textBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyDown);
            // 
            // labelFieldName
            // 
            this.labelFieldName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(245)))));
            this.labelFieldName.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelFieldName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelFieldName.Font = new System.Drawing.Font("Imprint MT Shadow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFieldName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(85)))), ((int)(((byte)(92)))));
            this.labelFieldName.Location = new System.Drawing.Point(15, 0);
            this.labelFieldName.Name = "labelFieldName";
            this.labelFieldName.Size = new System.Drawing.Size(316, 25);
            this.labelFieldName.TabIndex = 0;
            this.labelFieldName.Text = "FieldInfo";
            this.labelFieldName.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // ModernTextbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(245)))));
            this.Controls.Add(this.panelTextContainer);
            this.Controls.Add(this.panelSideColor);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ModernTextbox";
            this.Size = new System.Drawing.Size(336, 59);
            this.Load += new System.EventHandler(this.ModernTextbox_Load);
            this.panelTextContainer.ResumeLayout(false);
            this.panelTextContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSideColor;
        private System.Windows.Forms.Panel panelTextContainer;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Label labelFieldName;
    }
}
